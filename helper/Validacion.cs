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
                else if (!(Validacion.soloNumDecimal(txtboxFiltroAvanzado.Text)))
                {
                    MessageBox.Show("solo nros para filtrar numericamente");
                    return false;
                }
            }

            return true;
        }
        public static bool soloNumDecimal(string cadena)
        {
            int contadorComa = 0;
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    if (caracter == '.' || caracter == ',')
                        contadorComa++;
                    else
                        return false;
                if (contadorComa > 1)
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

        public static bool validarTbox(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                MessageBox.Show("No cargó información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cadena.Length < 2 || cadena.Length > 50)
            {
                MessageBox.Show("Mínimo 3 caractéres y máximo 50");
                return false;
            }

            //validar que no haya caracteres especiales, solo letras y numeros
            // que los MessageBox sean de tipo "Alerta"
            foreach (char caracter in cadena)
            {
                if (!char.IsLetterOrDigit(caracter))
                {
                    MessageBox.Show("Solo se admiten letras y números");
                    return false;
                }
            }
            return true;
        }
    }   
}
