namespace Practico2
{
    partial class Form1
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
            this.LNya = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(34, 29);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(92, 13);
            this.LNya.TabIndex = 0;
            this.LNya.Text = "Nombre y Apellido";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(34, 77);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 1;
            this.LDni.Text = "DNI";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(34, 117);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(34, 155);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 3;
            this.LNombre.Text = "Nombre";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(144, 29);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(49, 13);
            this.LModificar.TabIndex = 4;
            this.LModificar.Text = "modificar";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(101, 74);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(92, 20);
            this.TDni.TabIndex = 5;
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(101, 110);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(92, 20);
            this.TApellido.TabIndex = 6;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(101, 148);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(92, 20);
            this.TNombre.TabIndex = 7;
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(37, 203);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(75, 23);
            this.BGuardar.TabIndex = 8;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            // 
            // BModificar
            // 
            this.BModificar.Location = new System.Drawing.Point(118, 203);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(75, 23);
            this.BModificar.TabIndex = 9;
            this.BModificar.Text = "Modificar";
            this.BModificar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 258);
            this.Controls.Add(this.BModificar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.LModificar);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LNya);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BModificar;
    }
}

