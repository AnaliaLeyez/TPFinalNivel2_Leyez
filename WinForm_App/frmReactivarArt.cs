using dominio;
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
    public partial class FrmReactivarArt : Form
    {
        
        private List<Articulo> listaDesactivados;
        public FrmReactivarArt()
        {
            InitializeComponent();
        }

        private void FrmReactivarArt_Load(object sender, EventArgs e)
        {
            //    this.ClientSize = new System.Drawing.Size(685, 545);
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaDesactivados = negocio.listar(true);
                dgvDesactivados.DataSource = listaDesactivados;
                ocultarColumnas();
                dgvDesactivados.Columns[1].Width = 60;
                dgvDesactivados.Columns[2].Width = 120;
                dgvDesactivados.Columns[4].Width = 100;
                dgvDesactivados.Columns[5].Width = 100;
                dgvDesactivados.Columns[7].Width = 80;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvDesactivados.Columns["Id"].Visible = false;
            dgvDesactivados.Columns["Imagen"].Visible = false;
            dgvDesactivados.Columns["Descripcion"].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            if (dgvDesactivados.CurrentRow != null && dgvDesactivados.CurrentRow.DataBoundItem != null)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo desactivado = (Articulo)dgvDesactivados.CurrentRow.DataBoundItem;
                negocio.activar_desactivar(desactivado.Id);
                cargarGrilla();
            }
            else
                MessageBox.Show("Ninguna fila seleccionada");
        }
    }
}
