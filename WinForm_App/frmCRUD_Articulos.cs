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
using System.Configuration;
using System.IO;

namespace WinForm_App
{
    public partial class frmCRUD_Articulos : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;  
        public frmCRUD_Articulos()
        {
            InitializeComponent();
            Text = "Agregar un nuevo artículo";
        }

        public frmCRUD_Articulos(Articulo art)
        {
            InitializeComponent();
            this.articulo = art;
            Text = "Modificar Pokemon";
        }

        private void frmCRUD_Articulos_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocioCateg = new CategoriaNegocio();
            MarcaNegocio negocioMarca = new MarcaNegocio();
            try
            {
                cboxMarca.DataSource = negocioMarca.listar();
                cboxMarca.ValueMember = "Id";
                cboxMarca.DisplayMember = "Descripcion";
                cboxCategoria.DataSource = negocioCateg.listar();
                cboxCategoria.ValueMember = "Id";
                cboxCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    tbxCodigo.Text = articulo.Codigo;
                    tbxNombre.Text = articulo.Nombre;
                    tbxDescripcion.Text = articulo.Descripcion;
                    tbxUrlImg.Text = articulo.Imagen;
                    cboxMarca.SelectedValue = articulo.Marca.Id;
                    cboxCategoria.SelectedValue = articulo.Categoria.Id;
                    tbxPrecio.Text = articulo.Precio.ToString("0.00");
                    cargarImagen(articulo.Imagen);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            resetearColores();
            
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = tbxCodigo.Text;
                articulo.Nombre = tbxNombre.Text;
                articulo.Descripcion = tbxDescripcion.Text;
                articulo.Imagen = tbxUrlImg.Text;
                articulo.Marca = (Marca)cboxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboxCategoria.SelectedItem;
                if (!Validacion.camposObligatorios(tbxCodigo, tbxNombre, tbxPrecio))
                    return;
                
                if (Validacion.soloNumDecimal(tbxPrecio.Text))
                {
                    tbxPrecio.Text = tbxPrecio.Text.Replace('.', ',');
                    articulo.Precio = decimal.Parse(tbxPrecio.Text);
                    if (articulo.Precio == 0)
                    {
                        MessageBox.Show("No se admite precio igual a 0");
                        return;
                    }
                    
                }
                else
                {
                    MessageBox.Show("el precio solo admite ingreso numérico (valores decimales positivos)");
                    return;
                }


                //Guargo la img solo si es que levanté img localmente:
                if (archivo != null && !(tbxUrlImg.Text.ToLower().Contains("http")))
                {
                    // Obtener la fecha y hora actual como parte del nombre del archivo
                    string nombreArchivo = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + archivo.SafeFileName;

                    // Copiar el archivo al nuevo nombre de archivo y ruta
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["img-folder"] + nombreArchivo);
                }


                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
        }

        private void resetearColores()
        {
            tbxCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            tbxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            tbxPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboxImg.Load(imagen);
            }
            catch (Exception ex)
            {
                pboxImg.Load("https://faculty.eng.ufl.edu/elliot-douglas/wp-content/uploads/sites/70/2015/11/img-placeholder.png");
            }
        }

        private void tbxUrlImg_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxUrlImg.Text);
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                tbxUrlImg.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }

        private void tbxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && ((e.KeyChar != ',' && e.KeyChar != '.')))
                    e.Handled = true;

                if ((e.KeyChar == ',' || e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1 || (sender as TextBox).Text.IndexOf('.') > -1))
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    
    }
}
