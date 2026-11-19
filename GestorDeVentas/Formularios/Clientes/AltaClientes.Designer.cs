namespace GestorDeVentas.Formularios.Clientes
{
    partial class AltaClientes
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lablblApellidoel2 = new System.Windows.Forms.Label();
            this.lblCUIL = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCUIL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnGrabar.Location = new System.Drawing.Point(106, 289);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(102, 35);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpNacimiento.Location = new System.Drawing.Point(15, 250);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(284, 26);
            this.dtpNacimiento.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNombre.Location = new System.Drawing.Point(15, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lablblApellidoel2
            // 
            this.lablblApellidoel2.AutoSize = true;
            this.lablblApellidoel2.Font = new System.Drawing.Font("Arial", 12F);
            this.lablblApellidoel2.Location = new System.Drawing.Point(15, 79);
            this.lablblApellidoel2.Name = "lablblApellidoel2";
            this.lablblApellidoel2.Size = new System.Drawing.Size(65, 18);
            this.lablblApellidoel2.TabIndex = 3;
            this.lablblApellidoel2.Text = "Apellido";
            // 
            // lblCUIL
            // 
            this.lblCUIL.AutoSize = true;
            this.lblCUIL.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCUIL.Location = new System.Drawing.Point(15, 149);
            this.lblCUIL.Name = "lblCUIL";
            this.lblCUIL.Size = new System.Drawing.Size(43, 18);
            this.lblCUIL.TabIndex = 4;
            this.lblCUIL.Text = "CUIL";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNacimiento.Location = new System.Drawing.Point(15, 219);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(157, 18);
            this.lblNacimiento.TabIndex = 5;
            this.lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNombre.Location = new System.Drawing.Point(15, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(284, 26);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Arial", 12F);
            this.txtApellido.Location = new System.Drawing.Point(15, 110);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(222, 26);
            this.txtApellido.TabIndex = 8;
            // 
            // txtCUIL
            // 
            this.txtCUIL.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCUIL.Location = new System.Drawing.Point(15, 180);
            this.txtCUIL.Name = "txtCUIL";
            this.txtCUIL.Size = new System.Drawing.Size(165, 26);
            this.txtCUIL.TabIndex = 10;
            // 
            // AltaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 350);
            this.Controls.Add(this.txtCUIL);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblCUIL);
            this.Controls.Add(this.lablblApellidoel2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.btnGrabar);
            this.Name = "AltaClientes";
            this.Text = "AltaClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lablblApellidoel2;
        private System.Windows.Forms.Label lblCUIL;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCUIL;
    }
}