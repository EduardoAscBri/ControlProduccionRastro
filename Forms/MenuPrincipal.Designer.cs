namespace FYRASA.Forms
{
    partial class MenuPrincipal
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
            this.panelWindows = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bttCerrar = new System.Windows.Forms.Button();
            this.mnMenu = new System.Windows.Forms.MenuStrip();
            this.mnArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnControlUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnControlProduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnOrdenProduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBoletas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNuevaBoleta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPesos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPesoCaliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnPesoFrio = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnPesoCanastas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReporteProduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelWindows.SuspendLayout();
            this.mnMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWindows
            // 
            this.panelWindows.Controls.Add(this.label1);
            this.panelWindows.Controls.Add(this.button2);
            this.panelWindows.Controls.Add(this.button1);
            this.panelWindows.Controls.Add(this.bttCerrar);
            this.panelWindows.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindows.Location = new System.Drawing.Point(0, 0);
            this.panelWindows.Name = "panelWindows";
            this.panelWindows.Size = new System.Drawing.Size(800, 32);
            this.panelWindows.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistema de producción FYRASA";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::FYRASA.Properties.Resources.Minimize_to_Taskbar;
            this.button2.Location = new System.Drawing.Point(680, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 32);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::FYRASA.Properties.Resources.Minimize_Maximize;
            this.button1.Location = new System.Drawing.Point(720, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 32);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bttCerrar
            // 
            this.bttCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttCerrar.FlatAppearance.BorderSize = 0;
            this.bttCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bttCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCerrar.Image = global::FYRASA.Properties.Resources.Close;
            this.bttCerrar.Location = new System.Drawing.Point(760, 0);
            this.bttCerrar.Name = "bttCerrar";
            this.bttCerrar.Size = new System.Drawing.Size(40, 32);
            this.bttCerrar.TabIndex = 0;
            this.bttCerrar.UseVisualStyleBackColor = true;
            this.bttCerrar.Click += new System.EventHandler(this.BttCerrar_Click);
            // 
            // mnMenu
            // 
            this.mnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnArchivo,
            this.mnProduccion,
            this.mnBoletas,
            this.mnPesos,
            this.mnReportes});
            this.mnMenu.Location = new System.Drawing.Point(0, 0);
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.Size = new System.Drawing.Size(800, 40);
            this.mnMenu.TabIndex = 1;
            this.mnMenu.Text = "menuStrip1";
            this.mnMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MnMenu_ItemClicked);
            // 
            // mnArchivo
            // 
            this.mnArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnControlUsuarios,
            this.toolStripSeparator1,
            this.mnSalir});
            this.mnArchivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnArchivo.Name = "mnArchivo";
            this.mnArchivo.Size = new System.Drawing.Size(75, 36);
            this.mnArchivo.Text = "Archivo";
            // 
            // mnControlUsuarios
            // 
            this.mnControlUsuarios.Name = "mnControlUsuarios";
            this.mnControlUsuarios.Size = new System.Drawing.Size(216, 26);
            this.mnControlUsuarios.Text = "Control de usuarios";
            this.mnControlUsuarios.Click += new System.EventHandler(this.MnControlUsuarios_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // mnSalir
            // 
            this.mnSalir.Name = "mnSalir";
            this.mnSalir.Size = new System.Drawing.Size(216, 26);
            this.mnSalir.Text = "Salir";
            this.mnSalir.Click += new System.EventHandler(this.MnSalir_Click);
            // 
            // mnProduccion
            // 
            this.mnProduccion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnControlProduccion,
            this.toolStripSeparator4,
            this.mnOrdenProduccion});
            this.mnProduccion.Name = "mnProduccion";
            this.mnProduccion.Size = new System.Drawing.Size(100, 36);
            this.mnProduccion.Text = "Producción";
            // 
            // mnControlProduccion
            // 
            this.mnControlProduccion.Name = "mnControlProduccion";
            this.mnControlProduccion.Size = new System.Drawing.Size(242, 26);
            this.mnControlProduccion.Text = "Control de producción";
            this.mnControlProduccion.Click += new System.EventHandler(this.MnControlProduccion_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(239, 6);
            // 
            // mnOrdenProduccion
            // 
            this.mnOrdenProduccion.Name = "mnOrdenProduccion";
            this.mnOrdenProduccion.Size = new System.Drawing.Size(242, 26);
            this.mnOrdenProduccion.Text = "Ordenes de produccion";
            this.mnOrdenProduccion.Click += new System.EventHandler(this.MnOrdenProduccion_Click);
            // 
            // mnBoletas
            // 
            this.mnBoletas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnNuevaBoleta});
            this.mnBoletas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnBoletas.Name = "mnBoletas";
            this.mnBoletas.Size = new System.Drawing.Size(72, 36);
            this.mnBoletas.Text = "Boletas";
            // 
            // mnNuevaBoleta
            // 
            this.mnNuevaBoleta.Name = "mnNuevaBoleta";
            this.mnNuevaBoleta.Size = new System.Drawing.Size(172, 26);
            this.mnNuevaBoleta.Text = "Nueva boleta";
            this.mnNuevaBoleta.Click += new System.EventHandler(this.MnNuevaBoleta_Click);
            // 
            // mnPesos
            // 
            this.mnPesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPesoCaliente,
            this.toolStripSeparator2,
            this.mnPesoFrio,
            this.toolStripSeparator3,
            this.mnPesoCanastas});
            this.mnPesos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnPesos.Name = "mnPesos";
            this.mnPesos.Size = new System.Drawing.Size(61, 36);
            this.mnPesos.Text = "Pesos";
            // 
            // mnPesoCaliente
            // 
            this.mnPesoCaliente.Name = "mnPesoCaliente";
            this.mnPesoCaliente.Size = new System.Drawing.Size(196, 26);
            this.mnPesoCaliente.Text = "Peso caliente";
            this.mnPesoCaliente.Click += new System.EventHandler(this.MnPesoCaliente_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // mnPesoFrio
            // 
            this.mnPesoFrio.Name = "mnPesoFrio";
            this.mnPesoFrio.Size = new System.Drawing.Size(196, 26);
            this.mnPesoFrio.Text = "Peso frio";
            this.mnPesoFrio.Click += new System.EventHandler(this.MnPesoFrio_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // mnPesoCanastas
            // 
            this.mnPesoCanastas.Name = "mnPesoCanastas";
            this.mnPesoCanastas.Size = new System.Drawing.Size(196, 26);
            this.mnPesoCanastas.Text = "Peso en canastas";
            this.mnPesoCanastas.Click += new System.EventHandler(this.MnPesoCanastas_Click);
            // 
            // mnReportes
            // 
            this.mnReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnReporteProduccion});
            this.mnReportes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnReportes.Name = "mnReportes";
            this.mnReportes.Size = new System.Drawing.Size(84, 36);
            this.mnReportes.Text = "Reportes";
            // 
            // mnReporteProduccion
            // 
            this.mnReporteProduccion.Name = "mnReporteProduccion";
            this.mnReporteProduccion.Size = new System.Drawing.Size(238, 26);
            this.mnReporteProduccion.Text = "Reporte de producción";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 150);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::FYRASA.Properties.Resources.Floating_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(680, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelWindows.ResumeLayout(false);
            this.panelWindows.PerformLayout();
            this.mnMenu.ResumeLayout(false);
            this.mnMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWindows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttCerrar;
        private System.Windows.Forms.MenuStrip mnMenu;
        private System.Windows.Forms.ToolStripMenuItem mnArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnBoletas;
        private System.Windows.Forms.ToolStripMenuItem mnPesos;
        private System.Windows.Forms.ToolStripMenuItem mnReportes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem mnControlUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnSalir;
        private System.Windows.Forms.ToolStripMenuItem mnNuevaBoleta;
        private System.Windows.Forms.ToolStripMenuItem mnPesoCaliente;
        private System.Windows.Forms.ToolStripMenuItem mnPesoFrio;
        private System.Windows.Forms.ToolStripMenuItem mnReporteProduccion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnPesoCanastas;
        private System.Windows.Forms.ToolStripMenuItem mnProduccion;
        private System.Windows.Forms.ToolStripMenuItem mnControlProduccion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnOrdenProduccion;
    }
}