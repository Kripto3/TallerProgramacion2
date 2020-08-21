namespace Practico1
{
    partial class Formulario1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.textMultilinea = new System.Windows.Forms.TextBox();
            this.BSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(44, 179);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(75, 23);
            this.BGuardar.TabIndex = 0;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(135, 179);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(75, 23);
            this.BEliminar.TabIndex = 1;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(41, 57);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(41, 97);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 3;
            this.LNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(91, 97);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // textMultilinea
            // 
            this.textMultilinea.Location = new System.Drawing.Point(262, 54);
            this.textMultilinea.Multiline = true;
            this.textMultilinea.Name = "textMultilinea";
            this.textMultilinea.Size = new System.Drawing.Size(196, 148);
            this.textMultilinea.TabIndex = 6;
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(330, 208);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(75, 23);
            this.BSalir.TabIndex = 7;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Visible = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.textMultilinea);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.KeyPreview = true;
            this.Name = "Formulario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Primer Forms";
            this.Load += new System.EventHandler(this.Formulario1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Formulario1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox textMultilinea;
        private System.Windows.Forms.Button BSalir;
    }
}

