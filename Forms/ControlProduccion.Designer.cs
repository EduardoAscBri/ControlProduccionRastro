namespace FYRASA.Forms
{
    partial class ControlProduccion
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFolioOrden = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSerieOrden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGranjaOrden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCerdosOrden = new System.Windows.Forms.TextBox();
            this.bttSalir = new System.Windows.Forms.Button();
            this.bttConcluir = new System.Windows.Forms.Button();
            this.bttIniciar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCanalizacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
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
            this.panelWindows.Size = new System.Drawing.Size(900, 32);
            this.panelWindows.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Control de producción";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::FYRASA.Properties.Resources.Minimize_to_Taskbar;
            this.button2.Location = new System.Drawing.Point(780, 0);
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
            this.button1.Location = new System.Drawing.Point(820, 0);
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
            this.bttCerrar.Location = new System.Drawing.Point(860, 0);
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
            this.dgvOrdenesProduccion.Location = new System.Drawing.Point(12, 182);
            this.dgvOrdenesProduccion.Name = "dgvOrdenesProduccion";
            this.dgvOrdenesProduccion.ReadOnly = true;
            this.dgvOrdenesProduccion.Size = new System.Drawing.Size(876, 248);
            this.dgvOrdenesProduccion.TabIndex = 3;
            this.dgvOrdenesProduccion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvOrdenesProduccion_MouseDoubleClick);
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
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Checked = false;
            this.dtpFecha.CustomFormat = "MM-dd-yyyy HH:mm:ss";
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(708, 73);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(185, 29);
            this.dtpFecha.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(809, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 48;
            this.label6.Text = "Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(753, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 47;
            this.label7.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 21);
            this.label8.TabIndex = 46;
            this.label8.Text = "Folio";
            // 
            // txtFolioOrden
            // 
            this.txtFolioOrden.Enabled = false;
            this.txtFolioOrden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolioOrden.Location = new System.Drawing.Point(87, 73);
            this.txtFolioOrden.Name = "txtFolioOrden";
            this.txtFolioOrden.Size = new System.Drawing.Size(64, 29);
            this.txtFolioOrden.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 21);
            this.label9.TabIndex = 44;
            this.label9.Text = "Serie";
            // 
            // txtSerieOrden
            // 
            this.txtSerieOrden.Enabled = false;
            this.txtSerieOrden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerieOrden.Location = new System.Drawing.Point(17, 73);
            this.txtSerieOrden.Name = "txtSerieOrden";
            this.txtSerieOrden.Size = new System.Drawing.Size(64, 29);
            this.txtSerieOrden.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Granja";
            // 
            // txtGranjaOrden
            // 
            this.txtGranjaOrden.Enabled = false;
            this.txtGranjaOrden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGranjaOrden.Location = new System.Drawing.Point(157, 73);
            this.txtGranjaOrden.Name = "txtGranjaOrden";
            this.txtGranjaOrden.Size = new System.Drawing.Size(362, 29);
            this.txtGranjaOrden.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 53;
            this.label3.Text = "Cantidad de cerdos";
            // 
            // txtCerdosOrden
            // 
            this.txtCerdosOrden.Enabled = false;
            this.txtCerdosOrden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCerdosOrden.Location = new System.Drawing.Point(582, 73);
            this.txtCerdosOrden.Name = "txtCerdosOrden";
            this.txtCerdosOrden.Size = new System.Drawing.Size(64, 29);
            this.txtCerdosOrden.TabIndex = 52;
            // 
            // bttSalir
            // 
            this.bttSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSalir.Location = new System.Drawing.Point(768, 451);
            this.bttSalir.Name = "bttSalir";
            this.bttSalir.Size = new System.Drawing.Size(120, 32);
            this.bttSalir.TabIndex = 56;
            this.bttSalir.Text = "Salir";
            this.bttSalir.UseVisualStyleBackColor = true;
            this.bttSalir.Click += new System.EventHandler(this.BttSalir_Click);
            // 
            // bttConcluir
            // 
            this.bttConcluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bttConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttConcluir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttConcluir.Location = new System.Drawing.Point(625, 451);
            this.bttConcluir.Name = "bttConcluir";
            this.bttConcluir.Size = new System.Drawing.Size(120, 32);
            this.bttConcluir.TabIndex = 55;
            this.bttConcluir.Text = "Concluir";
            this.bttConcluir.UseVisualStyleBackColor = true;
            this.bttConcluir.Click += new System.EventHandler(this.BttConcluir_Click);
            // 
            // bttIniciar
            // 
            this.bttIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bttIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttIniciar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttIniciar.Location = new System.Drawing.Point(474, 451);
            this.bttIniciar.Name = "bttIniciar";
            this.bttIniciar.Size = new System.Drawing.Size(120, 32);
            this.bttIniciar.TabIndex = 54;
            this.bttIniciar.Text = "Iniciar";
            this.bttIniciar.UseVisualStyleBackColor = true;
            this.bttIniciar.Click += new System.EventHandler(this.BttNuevo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 58;
            this.label4.Text = "Canalizacion";
            // 
            // txtCanalizacion
            // 
            this.txtCanalizacion.Enabled = false;
            this.txtCanalizacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanalizacion.Location = new System.Drawing.Point(18, 130);
            this.txtCanalizacion.Name = "txtCanalizacion";
            this.txtCanalizacion.Size = new System.Drawing.Size(272, 29);
            this.txtCanalizacion.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 60;
            this.label5.Text = "Lote";
            // 
            // txtLote
            // 
            this.txtLote.Enabled = false;
            this.txtLote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Location = new System.Drawing.Point(345, 130);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(174, 29);
            this.txtLote.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(590, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 21);
            this.label10.TabIndex = 62;
            this.label10.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(582, 130);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(174, 29);
            this.txtStatus.TabIndex = 61;
            // 
            // ControlProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCanalizacion);
            this.Controls.Add(this.bttSalir);
            this.Controls.Add(this.bttConcluir);
            this.Controls.Add(this.bttIniciar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCerdosOrden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGranjaOrden);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFolioOrden);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSerieOrden);
            this.Controls.Add(this.dgvOrdenesProduccion);
            this.Controls.Add(this.panelWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlProduccion";
            this.Text = "ControlProduccion";
            this.Load += new System.EventHandler(this.ControlProduccion_Load);
            this.panelWindows.ResumeLayout(false);
            this.panelWindows.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesProduccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWindows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttCerrar;
        private System.Windows.Forms.DataGridView dgvOrdenesProduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Granja;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCerdos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFolioOrden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSerieOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGranjaOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCerdosOrden;
        private System.Windows.Forms.Button bttSalir;
        private System.Windows.Forms.Button bttConcluir;
        private System.Windows.Forms.Button bttIniciar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCanalizacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStatus;
    }
}