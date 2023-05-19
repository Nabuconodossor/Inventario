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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnTablero = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkBlue;
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnDocumentos);
            this.panelMenu.Controls.Add(this.btnStock);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.btnTablero);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(236, 487);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(236, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Image = global::Inventario.Properties.Resources.boton;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 360);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(236, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "   Cerrar Sesion";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocumentos.FlatAppearance.BorderSize = 0;
            this.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentos.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDocumentos.Image = global::Inventario.Properties.Resources.dinero_digital;
            this.btnDocumentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentos.Location = new System.Drawing.Point(0, 290);
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
            // btnStock
            // 
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.ForeColor = System.Drawing.SystemColors.Info;
            this.btnStock.Image = global::Inventario.Properties.Resources.en_stock1;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 220);
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
            this.btnProductos.Location = new System.Drawing.Point(0, 150);
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
            this.btnTablero.Location = new System.Drawing.Point(0, 80);
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
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(236, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(866, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(333, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Marca";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(236, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(866, 407);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // Adminstracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1102, 487);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Adminstracion";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTablero;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnDocumentos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}