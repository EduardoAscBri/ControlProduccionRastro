namespace FYRASA.Forms
{
    partial class ControlUsuarios
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
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkArchivo = new System.Windows.Forms.CheckBox();
            this.chkBoletas = new System.Windows.Forms.CheckBox();
            this.chkPesos = new System.Windows.Forms.CheckBox();
            this.chkReportes = new System.Windows.Forms.CheckBox();
            this.txtNuevo = new System.Windows.Forms.Button();
            this.txtGuardar = new System.Windows.Forms.Button();
            this.bttSalir = new System.Windows.Forms.Button();
            this.chkOrdenesProduccion = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelWindows.SuspendLayout();
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
            this.panelWindows.Size = new System.Drawing.Size(738, 32);
            this.panelWindows.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Configuracion de usuarios";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::FYRASA.Properties.Resources.Minimize_to_Taskbar;
            this.button2.Location = new System.Drawing.Point(618, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 32);
            this.button2.TabIndex = 12;
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
            this.button1.Location = new System.Drawing.Point(658, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 32);
            this.button1.TabIndex = 13;
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
            this.bttCerrar.Location = new System.Drawing.Point(698, 0);
            this.bttCerrar.Name = "bttCerrar";
            this.bttCerrar.Size = new System.Drawing.Size(40, 32);
            this.bttCerrar.TabIndex = 14;
            this.bttCerrar.UseVisualStyleBackColor = true;
            this.bttCerrar.Click += new System.EventHandler(this.BttCerrar_Click);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUsuarios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(52, 94);
            this.cmbUsuarios.MaxDropDownItems = 5;
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(238, 33);
            this.cmbUsuarios.TabIndex = 0;
            this.cmbUsuarios.SelectionChangeCommitted += new System.EventHandler(this.CmbUsuarios_SelectionChangeCommitted);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(52, 181);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(238, 33);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtUsuario_KeyUp);
            this.txtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(52, 245);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(238, 33);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Leave += new System.EventHandler(this.TxtContraseña_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // chkArchivo
            // 
            this.chkArchivo.AutoSize = true;
            this.chkArchivo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkArchivo.Location = new System.Drawing.Point(495, 147);
            this.chkArchivo.Name = "chkArchivo";
            this.chkArchivo.Size = new System.Drawing.Size(97, 29);
            this.chkArchivo.TabIndex = 3;
            this.chkArchivo.Text = "Archivo";
            this.chkArchivo.UseVisualStyleBackColor = true;
            // 
            // chkBoletas
            // 
            this.chkBoletas.AutoSize = true;
            this.chkBoletas.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoletas.Location = new System.Drawing.Point(495, 183);
            this.chkBoletas.Name = "chkBoletas";
            this.chkBoletas.Size = new System.Drawing.Size(93, 29);
            this.chkBoletas.TabIndex = 4;
            this.chkBoletas.Text = "Boletas";
            this.chkBoletas.UseVisualStyleBackColor = true;
            // 
            // chkPesos
            // 
            this.chkPesos.AutoSize = true;
            this.chkPesos.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPesos.Location = new System.Drawing.Point(495, 217);
            this.chkPesos.Name = "chkPesos";
            this.chkPesos.Size = new System.Drawing.Size(78, 29);
            this.chkPesos.TabIndex = 5;
            this.chkPesos.Text = "Pesos";
            this.chkPesos.UseVisualStyleBackColor = true;
            // 
            // chkReportes
            // 
            this.chkReportes.AutoSize = true;
            this.chkReportes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReportes.Location = new System.Drawing.Point(495, 250);
            this.chkReportes.Name = "chkReportes";
            this.chkReportes.Size = new System.Drawing.Size(107, 29);
            this.chkReportes.TabIndex = 6;
            this.chkReportes.Text = "Reportes";
            this.chkReportes.UseVisualStyleBackColor = true;
            // 
            // txtNuevo
            // 
            this.txtNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtNuevo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevo.Location = new System.Drawing.Point(312, 384);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(120, 32);
            this.txtNuevo.TabIndex = 10;
            this.txtNuevo.Text = "Nuevo";
            this.txtNuevo.UseVisualStyleBackColor = true;
            this.txtNuevo.Click += new System.EventHandler(this.TxtNuevo_Click);
            // 
            // txtGuardar
            // 
            this.txtGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.txtGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtGuardar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardar.Location = new System.Drawing.Point(463, 384);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(120, 32);
            this.txtGuardar.TabIndex = 8;
            this.txtGuardar.Text = "Guardar";
            this.txtGuardar.UseVisualStyleBackColor = true;
            this.txtGuardar.Click += new System.EventHandler(this.TxtGuardar_Click);
            // 
            // bttSalir
            // 
            this.bttSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSalir.Location = new System.Drawing.Point(606, 384);
            this.bttSalir.Name = "bttSalir";
            this.bttSalir.Size = new System.Drawing.Size(120, 32);
            this.bttSalir.TabIndex = 9;
            this.bttSalir.Text = "Salir";
            this.bttSalir.UseVisualStyleBackColor = true;
            this.bttSalir.Click += new System.EventHandler(this.BttSalir_Click);
            // 
            // chkOrdenesProduccion
            // 
            this.chkOrdenesProduccion.AutoSize = true;
            this.chkOrdenesProduccion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOrdenesProduccion.Location = new System.Drawing.Point(495, 285);
            this.chkOrdenesProduccion.Name = "chkOrdenesProduccion";
            this.chkOrdenesProduccion.Size = new System.Drawing.Size(229, 29);
            this.chkOrdenesProduccion.TabIndex = 7;
            this.chkOrdenesProduccion.Text = "Ordenes de produccion";
            this.chkOrdenesProduccion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 100;
            this.label4.Text = "Permisos de acceso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 101;
            this.label5.Text = "Usuarios";
            // 
            // ControlUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(738, 428);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkOrdenesProduccion);
            this.Controls.Add(this.bttSalir);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.chkReportes);
            this.Controls.Add(this.chkPesos);
            this.Controls.Add(this.chkBoletas);
            this.Controls.Add(this.chkArchivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.panelWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlUsuarios";
            this.Load += new System.EventHandler(this.ControlUsuarios_Load);
            this.panelWindows.ResumeLayout(false);
            this.panelWindows.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWindows;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkArchivo;
        private System.Windows.Forms.CheckBox chkBoletas;
        private System.Windows.Forms.CheckBox chkPesos;
        private System.Windows.Forms.CheckBox chkReportes;
        private System.Windows.Forms.Button txtNuevo;
        private System.Windows.Forms.Button txtGuardar;
        private System.Windows.Forms.Button bttSalir;
        private System.Windows.Forms.CheckBox chkOrdenesProduccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}