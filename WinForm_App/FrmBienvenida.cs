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
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void pboxHome_Click(object sender, EventArgs e)
        {
            FrmArticulos administrador = new FrmArticulos();
            administrador.ShowDialog();
        }
    }
}
