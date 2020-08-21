using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {
           
        }

        #region Eventos
        private void BGuardar_Click(object sender, EventArgs e)
        {
            var result = Concatenar(this.txtNombre.Text, this.txtApellido.Text);
            this.textMultilinea.Text = result;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Realiza una accion al presionar una(as) tecla(as)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">obtejo de tipo KeyEventArgs</param>
        private void Formulario1_KeyDown(object sender, KeyEventArgs e)
        {
            //KeyData : obtejo de tipo enun que posee todas las teclas.
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                this.BSalir.Visible = true; 
                this.BSalir.Focus();
                
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        #endregion

        #region Metodos Privados

        private string Concatenar(string nombre, string apellido)
        {
            var result = $"{nombre} {apellido}";
            return result;
        }

        private void Limpiar()
        {
            this.textMultilinea.Clear();
        }

        private void Salir()
        {
            //TODO: Idem a VB -> End
            this.Close();
        }

        #endregion


    }
}
