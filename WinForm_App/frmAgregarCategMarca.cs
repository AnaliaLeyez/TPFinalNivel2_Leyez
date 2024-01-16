using dominio;
using helper;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_App
{
    public partial class frmAgregarCategMarca : Form
    {
        public frmAgregarCategMarca(bool marca = false)
        {
            InitializeComponent();
            if (marca)
            {
                Text = "Agregar Marca";
                lblCabecera.Text = "Nueva Marca";
            }

            else
            {
                Text = "Agregar Categoría";
                lblCabecera.Text = "Nueva Categoría";
            }
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            agregarCat();
        }

        private void tboxNuevaCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                agregarCat();
                e.Handled = true; // evita que se genere el sonido de la tecla Enter
            }
        }

        private void agregarCat()
        {
            try
            {
                if (!Validacion.validarTbox(tboxNuevaCat.Text))
                    return;

                if (lblCabecera.Text == "Nueva Marca")
                {
                    MarcaNegocio negocio = new MarcaNegocio();
                    Marca nuevo = new Marca();
                    nuevo.Descripcion = tboxNuevaCat.Text;
                    negocio.agregar(nuevo);
                }
                else
                {
                    CategoriaNegocio negocio = new CategoriaNegocio();
                    Categoria nuevo = new Categoria();
                    nuevo.Descripcion = tboxNuevaCat.Text;
                    negocio.agregar(nuevo);
                }
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
