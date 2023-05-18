namespace Inventario.GUI
{
    partial class Adminstracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminstracion));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnTablero = new System.Windows.Forms.Button();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkBlue;
            this.panelMenu.Controls.Add(this.btnDocumentos);
            this.panelMenu.Controls.Add(this.btnStock);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.btnTablero);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(236, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 41);
            this.panel1.TabIndex = 1;
            // 
            // btnStock
            // 
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.ForeColor = System.Drawing.SystemColors.Info;
            this.btnStock.Image = global::Inventario.Properties.Resources.en_stock1;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 181);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(236, 70);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "   Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.SystemColors.Info;
            this.btnProductos.Image = global::Inventario.Properties.Resources.caja;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 111);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(236, 70);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "   Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnTablero
            // 
            this.btnTablero.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTablero.FlatAppearance.BorderSize = 0;
            this.btnTablero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablero.ForeColor = System.Drawing.SystemColors.Info;
            this.btnTablero.Image = ((System.Drawing.Image)(resources.GetObject("btnTablero.Image")));
            this.btnTablero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTablero.Location = new System.Drawing.Point(0, 41);
            this.btnTablero.Name = "btnTablero";
            this.btnTablero.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTablero.Size = new System.Drawing.Size(236, 70);
            this.btnTablero.TabIndex = 1;
            this.btnTablero.Text = "   Tablero";
            this.btnTablero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTablero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTablero.UseVisualStyleBackColor = true;
            this.btnTablero.Click += new System.EventHandler(this.btnTablero_Click);
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocumentos.FlatAppearance.BorderSize = 0;
            this.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentos.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDocumentos.Image = global::Inventario.Properties.Resources.dinero_digital;
            this.btnDocumentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentos.Location = new System.Drawing.Point(0, 251);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDocumentos.Size = new System.Drawing.Size(236, 70);
            this.btnDocumentos.TabIndex = 5;
            this.btnDocumentos.Text = "   Documentos";
            this.btnDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocumentos.UseVisualStyleBackColor = true;
            this.btnDocumentos.Click += new System.EventHandler(this.btnDocumentos_Click);
            // 
            // Adminstracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenu);
            this.Name = "Adminstracion";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTablero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnDocumentos;
    }
}