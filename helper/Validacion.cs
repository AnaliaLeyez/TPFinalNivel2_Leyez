using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helper
{
    public class Validacion
    {
        public static bool validarFiltro(ComboBox cboxCampo, ComboBox cboxCriterio, TextBox txtboxFiltroAvanzado)
        {
            if (cboxCampo.SelectedIndex == -1 || cboxCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar Campo y Criterio para filtrar");
                return false;
            }
            if (cboxCampo.SelectedItem.ToString() == "Precio")
            {
                Validacion validacion = new Validacion();
                if (string.IsNullOrEmpty(txtboxFiltroAvanzado.Text))
                {
                    MessageBox.Show("Por favor, seleccione un valor para filtrar");
                    return false;
                }
                else if (!(Validacion.soloNumeros(txtboxFiltroAvanzado.Text)))
                {
                    MessageBox.Show("solo nros enteros para filtrar numericamente");
                    return false;
                }
            }

            return true;
        }
        public static bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        
        public static bool camposObligatorios(TextBox tbxCodigo, TextBox tbxNombre, TextBox tbxPrecio)
        {
            bool vacio = false;
            if (string.IsNullOrWhiteSpace(tbxCodigo.Text))
            {
                tbxCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                vacio = true;
            }
            if (string.IsNullOrWhiteSpace(tbxNombre.Text))
            {
                tbxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                vacio = true;
            }
            if (string.IsNullOrWhiteSpace(tbxPrecio.Text))
            {
                tbxPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                vacio = true;
            }
            if (vacio == true)
                return false;
            return true;
        }
    }

    

}
