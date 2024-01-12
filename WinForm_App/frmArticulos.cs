using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using helper;

namespace WinForm_App
{
    public partial class FrmArticulos : Form
    {
        private List<Articulo> listaArticulo;
        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(685, 545);
            cargarGrilla();
            cboxCampo.Items.Add("Nombre");
            cboxCampo.Items.Add("Marca");
            cboxCampo.Items.Add("Precio");
            cboxCampo.Items.Add("Categoria");
        }

        private void cargarGrilla()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                dgvArticulos.Columns[1].Width = 60;
                dgvArticulos.Columns[2].Width = 120;
                dgvArticulos.Columns[4].Width = 100;
                dgvArticulos.Columns[5].Width = 100;
                dgvArticulos.Columns[7].Width = 80;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
                lblDescNombre.Text = seleccionado.Nombre;
                lblDescMarca.Text = seleccionado.Marca.Descripcion;
                lblDescPrecio.Text = "$" + seleccionado.Precio.ToString("0.00");
            }
            else
            {
                lblDescNombre.Text = "Sin coincidencias";
                lblDescMarca.Text = "";
                lblDescPrecio.Text = "";
                pboxArticulo.Load("https://faculty.eng.ufl.edu/elliot-douglas/wp-content/uploads/sites/70/2015/11/img-placeholder.png");
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboxArticulo.Visible = true;
                pboxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pboxArticulo.Load("https://faculty.eng.ufl.edu/elliot-douglas/wp-content/uploads/sites/70/2015/11/img-placeholder.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCRUD_Articulos alta = new frmCRUD_Articulos();
            alta.ShowDialog();
            cargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow!=null && dgvArticulos.CurrentRow.DataBoundItem != null)
            {
                Articulo modificable = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmCRUD_Articulos editar = new frmCRUD_Articulos(modificable);
                editar.ShowDialog();
                cargarGrilla();
            }
            else
                MessageBox.Show("Ninguna fila seleccionada");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Chequeo que haya un item seleccionado:
            if (dgvArticulos.CurrentRow != null && dgvArticulos.CurrentRow.DataBoundItem != null)
            {
                Articulo seleccionado= (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ArticuloNegocio negocio = new ArticuloNegocio();
                //Pido confirmacion previo a eliminar:
                if (confirmarAccion(seleccionado.Codigo))
                {
                    try
                    {
                        negocio.eliminar(seleccionado.Id);
                        cargarGrilla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                
            }
            else
                MessageBox.Show("Ninguna fila seleccionada");
        }

        private bool confirmarAccion(string cod)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que quiere eliminar el registro con Código=" + cod + " de la BD?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(respuesta == DialogResult.Yes)
                return true;
            return false;
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            btnEditar.Enabled = true;
            btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            btnEliminar.Enabled = true;
            btnEliminar.BackColor = System.Drawing.Color.Black;

            try
            {
                if (!Validacion.validarFiltro(cboxCampo, cboxCriterio, txtboxFiltroAvanzado))
                    return;
                
                string campo = cboxCampo.SelectedItem.ToString();
                string criterio = cboxCriterio.SelectedItem.ToString();
                string filtro = txtboxFiltroAvanzado.Text;

                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

                dgvArticulos.Columns[1].Width = 60;
                dgvArticulos.Columns[2].Width = 120;
                dgvArticulos.Columns[4].Width = 100;
                dgvArticulos.Columns[5].Width = 100;
                dgvArticulos.Columns[7].Width = 80;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void txtboxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            //No inicializo el obj lista antes ya que la Lista se genera en el FindAll

            string filtro = txtboxFiltro.Text;
            if (filtro.Length >= 3)
                listaFiltrada = listaArticulo.FindAll(art => art.Nombre.ToUpper().Contains(filtro.ToUpper()) || art.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || art.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || art.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            else
                listaFiltrada = listaArticulo;

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;

            dgvArticulos.Columns[1].Width = 60;
            dgvArticulos.Columns[2].Width = 120;
            dgvArticulos.Columns[4].Width = 100;
            dgvArticulos.Columns[5].Width = 100;
            dgvArticulos.Columns[7].Width = 80;

            if (dgvArticulos.CurrentRow == null)
            {
                btnEliminar.Enabled = false;
                btnEliminar.BackColor = Color.Gray;
                btnEditar.Enabled = false;
                btnEditar.BackColor = Color.Gray;
            }
            else
            {
                btnEditar.Enabled = true;
                btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
                btnEliminar.Enabled = true;
                btnEliminar.BackColor = System.Drawing.Color.Black;
            }
            ocultarColumnas();


        }

        private void cboxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxCriterio.Items.Clear();
            if (cboxCampo.SelectedIndex != -1)
            {
                string campo = cboxCampo.SelectedItem.ToString();
                switch (campo)
                {
                    case "Precio":
                        cboxCriterio.Items.Add("Menor a");
                        cboxCriterio.Items.Add("Mayor a");
                        cboxCriterio.Items.Add("Igual a");
                        break;
                    default:
                        cboxCriterio.Items.Add("Comienza con");
                        cboxCriterio.Items.Add("Termina con");
                        cboxCriterio.Items.Add("Contiene");
                        break;
                }
            }
            else
                cboxCriterio.Items.Clear();
        }

    }
}
