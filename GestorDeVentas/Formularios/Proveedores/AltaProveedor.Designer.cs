namespace GestorDeVentas.Formularios.Proveedores
{
    partial class AltaProveedor
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
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Arial", 12F);
            this.lblRazonSocial.Location = new System.Drawing.Point(12, 21);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(100, 18);
            this.lblRazonSocial.TabIndex = 0;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Arial", 12F);
            this.txtRazonSocial.Location = new System.Drawing.Point(12, 48);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(248, 26);
            this.txtRazonSocial.TabIndex = 1;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtRazonSocial_TextChanged);
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCUIT.Location = new System.Drawing.Point(12, 83);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(43, 18);
            this.lblCUIT.TabIndex = 0;
            this.lblCUIT.Text = "CUIT";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCUIT.Location = new System.Drawing.Point(12, 110);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(152, 26);
            this.txtCUIT.TabIndex = 1;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnGrabar.Location = new System.Drawing.Point(83, 177);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(81, 28);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // AltaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 245);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.lblRazonSocial);
            this.Name = "AltaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AltaProveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Button btnGrabar;
    }
}