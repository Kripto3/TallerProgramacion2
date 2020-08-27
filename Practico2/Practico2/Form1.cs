using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.male_img;
        }

        

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = EsUnNumero(e);
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = EsUnaCadena(e);
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = EsUnaCadena(e);
        }


        private void BGuardar_Click(object sender, EventArgs e)
        {
            DialogResult ask; // equivalente a MsgBoxResult de VB
            var formularioValido = ValidarFormulario();

            if (!formularioValido)
            {
                MessageBox.Show("Debe completar todos los campos.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente ?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if ((int)ask == 6)
                {
                    var nombreCompleto = $"{this.TNombre.Text} {this.TApellido.Text}";
                    this.LModificar.Text = nombreCompleto;
                    MessageBox.Show($"El Cliente: {nombreCompleto} se insertó correctamente.","Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
               
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            var cliente = $"{this.LModificar.Text}";
            if (!string.IsNullOrEmpty(cliente))
            {
                DialogResult ask;

                ask = MessageBox.Show($"Esta apunto de eliminar el Cliente: {cliente}", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if ((int)ask == 6)
                {
                    MessageBox.Show($"El Cliente: {cliente} se eliminó correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
            }
            else
            {
                MessageBox.Show("No posee Clientes cargados.", "Eliminar",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.male_img;

        }
        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.female_img;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Metodos privados
        private bool ValidarFormulario()
        {
            if (String.IsNullOrEmpty(this.TNombre.Text.Trim()) ||
                String.IsNullOrEmpty(this.TApellido.Text.Trim()) ||
                String.IsNullOrEmpty(this.TNombre.Text.Trim())
                )
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// Indica si la tecla presionada es una cadena retornando un valor bool
        /// </summary>
        /// <param name="e">evento obtenido al presionar una tecla</param>
        /// <returns>Verdadero/falso segun la condicion</returns>
        private bool EsUnaCadena(KeyPressEventArgs e)
        {
            bool esCadena;

            if (Char.IsLetter(e.KeyChar)
                || Char.IsControl(e.KeyChar)
                || Char.IsControl(e.KeyChar)
                || Char.IsControl(e.KeyChar)
                || Char.IsSeparator(e.KeyChar)
               )
            {
                esCadena = false;
            }
            else
            {
                esCadena = true;
            }
            return esCadena;
        }
        private bool EsUnNumero(KeyPressEventArgs e)
        {
            bool esNumero;


            if (Char.IsDigit(e.KeyChar)
                || Char.IsControl(e.KeyChar)
                || Char.IsControl(e.KeyChar)
                || Char.IsControl(e.KeyChar)
                || Char.IsSeparator(e.KeyChar)
               )
            {
                esNumero = false;
            }
            else
            {
                esNumero = true;
            }
            return esNumero;
        }
        /// <summary>
        /// Limpia todos los campos del formulario
        /// </summary>
        private void LimpiarFormulario()
        {
            TDni.Text = string.Empty;
            TNombre.Text = string.Empty;
            TApellido.Text = string.Empty;
            LModificar.Text = string.Empty;
        }


        #endregion
    }
}
