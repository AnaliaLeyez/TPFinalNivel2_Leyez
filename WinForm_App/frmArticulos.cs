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
            this.ClientSize = new System.Drawing.Size(805, 545);
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
            validarCeldaSelec();
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
            opcEliminar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            opcEliminar(true);
        }

        private void opcEliminar(bool logico=false)
        {
            //Chequeo que haya un item seleccionado:

            if (dgvArticulos.CurrentRow != null && dgvArticulos.CurrentRow.DataBoundItem != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ArticuloNegocio negocio = new ArticuloNegocio();
                //Pido confirmacion previo a eliminar:
                if (confirmarAccion(seleccionado.Codigo, logico))
                {
                    try
                    {
                        if (logico)
                            negocio.activar_desactivar(seleccionado.Id);
                        else
                            negocio.elimFisico(seleccionado.Id);
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

        private bool confirmarAccion(string cod, bool logico)
        {
            DialogResult respuesta;
            if (logico)
                respuesta = MessageBox.Show("¿Seguro que quiere dar de baja el registro con Código=" + cod + " de la BD?", "Desactivando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            else
                respuesta = MessageBox.Show("¿Seguro que quiere eliminar el registro con Código=" + cod + " de la BD?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtroAv();
        }

        private void txtboxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            //No inicializo el obj lista antes ya que la Lista se genera en el FindAll

            string filtro = txtboxFiltro.Text;
            if (filtro.Length >= 2)
                listaFiltrada = listaArticulo.FindAll(art => art.Nombre.ToUpper().Contains(filtro.ToUpper()) || art.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || art.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || art.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            else
                listaFiltrada = listaArticulo;

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;

            validarCeldaSelec();
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

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            FrmReactivarArt activacion = new FrmReactivarArt();
            activacion.ShowDialog();
            cargarGrilla();
        }

        private void TsMenuAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmCRUD_Articulos alta = new frmCRUD_Articulos();
            alta.ShowDialog();
            cargarGrilla();
        }

        private void TsMenuCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void validarCeldaSelec()
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
                lblDescNombre.Text = seleccionado.Nombre;
                lblDescMarca.Text = seleccionado.Marca.Descripcion;
                lblDescPrecio.Text = "$" + seleccionado.Precio.ToString("0.00");

                btnEliminar.Enabled = true;
                btnEliminar.BackColor = System.Drawing.Color.Black;
                btnBaja.Enabled = true;
                btnBaja.BackColor = System.Drawing.Color.Black;
                btnEditar.Enabled = true;
                btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            }
            else
            {
                lblDescNombre.Text = "Sin coincidencias";
                lblDescMarca.Text = "";
                lblDescPrecio.Text = "";
                pboxArticulo.Load("https://faculty.eng.ufl.edu/elliot-douglas/wp-content/uploads/sites/70/2015/11/img-placeholder.png");

                btnEliminar.Enabled = false;
                btnEliminar.BackColor = Color.Gray;
                btnBaja.Enabled = false;
                btnBaja.BackColor = Color.Gray;
                btnEditar.Enabled = false;
                btnEditar.BackColor = Color.Gray;
            }
        }

        private void TsMenuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cargarGrilla();
            txtboxFiltroAvanzado.Text = "";
        }



        private void filtroAv()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (!Validacion.validarFiltro(cboxCampo, cboxCriterio, txtboxFiltroAvanzado))
                    return;

                string campo = cboxCampo.SelectedItem.ToString();
                string criterio = cboxCriterio.SelectedItem.ToString();
                string filtro = txtboxFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

                validarCeldaSelec();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtboxFiltroAvanzado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                filtroAv();
                e.Handled = true; // evita que se genere el sonido de la tecla Enter
            }
        }

        private void TsMenuAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarCategMarca nuevaMarca = new frmAgregarCategMarca(true);
            nuevaMarca.ShowDialog();
        }

        private void TsMenuAgregarCat_Click(object sender, EventArgs e)
        {
            frmAgregarCategMarca nuevaCateg = new frmAgregarCategMarca();
            nuevaCateg.ShowDialog();
        }
    }
}
