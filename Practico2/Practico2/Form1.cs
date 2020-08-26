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


        private bool EsUnaCadena(KeyPressEventArgs e)
        {
            bool esCadena;

            if (   Char.IsLetter(e.KeyChar)
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


            if (   Char.IsDigit(e.KeyChar) 
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

        private void BGuardar_Click(object sender, EventArgs e)
        {
            var nombreCompleto = $"{this.TNombre.Text} {this.TApellido.Text}";
            this.LModificar.Text = nombreCompleto;
        }
    }
}
