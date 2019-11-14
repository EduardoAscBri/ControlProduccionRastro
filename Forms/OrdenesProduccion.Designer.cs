namespace FYRASA.Forms
{
    partial class OrdenesProduccion
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
            this.dgvOrdenesProduccion = new System.Windows.Forms.DataGridView();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Granja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCerdos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttSalir = new System.Windows.Forms.Button();
            this.txtNuevo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelWindows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesProduccion)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ordenes de produccion";
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
            // dgvOrdenesProduccion
            // 
            this.dgvOrdenesProduccion.AllowUserToAddRows = false;
            this.dgvOrdenesProduccion.AllowUserToDeleteRows = false;
            this.dgvOrdenesProduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdenesProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenesProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serie,
            this.Folio,
            this.Fecha,
            this.Granja,
            this.CantidadCerdos,
            this.Status});
            this.dgvOrdenesProduccion.Location = new System.Drawing.Point(12, 96);
            this.dgvOrdenesProduccion.Name = "dgvOrdenesProduccion";
            this.dgvOrdenesProduccion.ReadOnly = true;
            this.dgvOrdenesProduccion.Size = new System.Drawing.Size(776, 276);
            this.dgvOrdenesProduccion.TabIndex = 0;
            this.dgvOrdenesProduccion.DoubleClick += new System.EventHandler(this.DgvOrdenesProduccion_DoubleClick);
            // 
            // Serie
            // 
            this.Serie.DataPropertyName = "Serie";
            this.Serie.HeaderText = "Serie";
            this.Serie.Name = "Serie";
            this.Serie.ReadOnly = true;
            this.Serie.Width = 56;
            // 
            // Folio
            // 
            this.Folio.DataPropertyName = "Folio";
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            this.Folio.Width = 54;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 62;
            // 
            // Granja
            // 
            this.Granja.DataPropertyName = "Granja";
            this.Granja.HeaderText = "Granja";
            this.Granja.Name = "Granja";
            this.Granja.ReadOnly = true;
            this.Granja.Width = 63;
            // 
            // CantidadCerdos
            // 
            this.CantidadCerdos.DataPropertyName = "CantidadCerdos";
            this.CantidadCerdos.HeaderText = "Cantidad de cerdos";
            this.CantidadCerdos.Name = "CantidadCerdos";
            this.CantidadCerdos.ReadOnly = true;
            this.CantidadCerdos.Width = 85;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 62;
            // 
            // bttSalir
            // 
            this.bttSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSalir.Location = new System.Drawing.Point(668, 394);
            this.bttSalir.Name = "bttSalir";
            this.bttSalir.Size = new System.Drawing.Size(120, 32);
            this.bttSalir.TabIndex = 3;
            this.bttSalir.Text = "Salir";
            this.bttSalir.UseVisualStyleBackColor = true;
            this.bttSalir.Click += new System.EventHandler(this.BttSalir_Click);
            // 
            // txtNuevo
            // 
            this.txtNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtNuevo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevo.Location = new System.Drawing.Point(513, 394);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(120, 32);
            this.txtNuevo.TabIndex = 1;
            this.txtNuevo.Text = "Nuevo";
            this.txtNuevo.UseVisualStyleBackColor = true;
            this.txtNuevo.Click += new System.EventHandler(this.TxtNuevo_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(359, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // OrdenesProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bttSalir);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.dgvOrdenesProduccion);
            this.Controls.Add(this.panelWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdenesProduccion";
            this.Text = "OrdenesProduccion";
            this.Load += new System.EventHandler(this.OrdenesProduccion_Load);
            this.panelWindows.ResumeLayout(false);
            this.panelWindows.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesProduccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWindows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttCerrar;
        private System.Windows.Forms.DataGridView dgvOrdenesProduccion;
        private System.Windows.Forms.Button bttSalir;
        private System.Windows.Forms.Button txtNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Granja;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCerdos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button button3;
    }
}