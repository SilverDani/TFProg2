namespace GestorDeVentas
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaCleintesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCleinteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.realizarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlMenu.Controls.Add(this.menuStrip1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(800, 30);
            this.pnlMenu.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionClientesToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.articulosToolStripMenuItem,
            this.ventaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionClientesToolStripMenuItem
            // 
            this.gestionClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaCleintesToolStripMenuItem,
            this.modificarCleinteToolStripMenuItem,
            this.bajaClienteToolStripMenuItem});
            this.gestionClientesToolStripMenuItem.Name = "gestionClientesToolStripMenuItem";
            this.gestionClientesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.gestionClientesToolStripMenuItem.Text = "Gestion Clientes";
            // 
            // altaCleintesToolStripMenuItem
            // 
            this.altaCleintesToolStripMenuItem.Name = "altaCleintesToolStripMenuItem";
            this.altaCleintesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaCleintesToolStripMenuItem.Text = "Alta Cleintes";
            this.altaCleintesToolStripMenuItem.Click += new System.EventHandler(this.altaCleintesToolStripMenuItem_Click);
            // 
            // modificarCleinteToolStripMenuItem
            // 
            this.modificarCleinteToolStripMenuItem.Name = "modificarCleinteToolStripMenuItem";
            this.modificarCleinteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarCleinteToolStripMenuItem.Text = "Modificar Cleinte";
            this.modificarCleinteToolStripMenuItem.Click += new System.EventHandler(this.modificarCleinteToolStripMenuItem_Click);
            // 
            // bajaClienteToolStripMenuItem
            // 
            this.bajaClienteToolStripMenuItem.Name = "bajaClienteToolStripMenuItem";
            this.bajaClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bajaClienteToolStripMenuItem.Text = "Baja Cliente";
            this.bajaClienteToolStripMenuItem.Click += new System.EventHandler(this.bajaClienteToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaProveedorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.bajaProveedorToolStripMenuItem});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.proveedorToolStripMenuItem.Text = "Gestion Proveedores";
            // 
            // altaProveedorToolStripMenuItem
            // 
            this.altaProveedorToolStripMenuItem.Name = "altaProveedorToolStripMenuItem";
            this.altaProveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaProveedorToolStripMenuItem.Text = "Alta Proveedor";
            this.altaProveedorToolStripMenuItem.Click += new System.EventHandler(this.altaProveedorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Modifar Proveedor";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // bajaProveedorToolStripMenuItem
            // 
            this.bajaProveedorToolStripMenuItem.Name = "bajaProveedorToolStripMenuItem";
            this.bajaProveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bajaProveedorToolStripMenuItem.Text = "Baja Proveedor";
            this.bajaProveedorToolStripMenuItem.Click += new System.EventHandler(this.bajaProveedorToolStripMenuItem_Click);
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaArticuloToolStripMenuItem,
            this.modificarArticuloToolStripMenuItem,
            this.bajaArticuloToolStripMenuItem});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.articulosToolStripMenuItem.Text = "Gestion Articulos";
            // 
            // altaArticuloToolStripMenuItem
            // 
            this.altaArticuloToolStripMenuItem.Name = "altaArticuloToolStripMenuItem";
            this.altaArticuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaArticuloToolStripMenuItem.Text = "Alta Articulo";
            this.altaArticuloToolStripMenuItem.Click += new System.EventHandler(this.altaArticuloToolStripMenuItem_Click);
            // 
            // modificarArticuloToolStripMenuItem
            // 
            this.modificarArticuloToolStripMenuItem.Name = "modificarArticuloToolStripMenuItem";
            this.modificarArticuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarArticuloToolStripMenuItem.Text = "Modificar Articulo";
            this.modificarArticuloToolStripMenuItem.Click += new System.EventHandler(this.modificarArticuloToolStripMenuItem_Click);
            // 
            // bajaArticuloToolStripMenuItem
            // 
            this.bajaArticuloToolStripMenuItem.Name = "bajaArticuloToolStripMenuItem";
            this.bajaArticuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bajaArticuloToolStripMenuItem.Text = "Baja Articulo";
            this.bajaArticuloToolStripMenuItem.Click += new System.EventHandler(this.bajaArticuloToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarVentaToolStripMenuItem});
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ventaToolStripMenuItem.Text = "Venta";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.BlueViolet;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 30);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 420);
            this.pnlContenedor.TabIndex = 2;
            // 
            // realizarVentaToolStripMenuItem
            // 
            this.realizarVentaToolStripMenuItem.Name = "realizarVentaToolStripMenuItem";
            this.realizarVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.realizarVentaToolStripMenuItem.Text = "Realizar Venta";
            this.realizarVentaToolStripMenuItem.Click += new System.EventHandler(this.realizarVentaToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Articulos y Ventas";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaCleintesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCleinteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bajaProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.ToolStripMenuItem realizarVentaToolStripMenuItem;
    }
}

