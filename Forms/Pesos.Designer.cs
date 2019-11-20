namespace FYRASA.Forms
{
    partial class Pesos
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bttCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblNumeroCanal = new System.Windows.Forms.Label();
            this.lblCanalizacion = new System.Windows.Forms.Label();
            this.bttSalir = new System.Windows.Forms.Button();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.panelWindows.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWindows
            // 
            this.panelWindows.Controls.Add(this.lblTitle);
            this.panelWindows.Controls.Add(this.button2);
            this.panelWindows.Controls.Add(this.button1);
            this.panelWindows.Controls.Add(this.bttCerrar);
            this.panelWindows.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindows.Location = new System.Drawing.Point(0, 0);
            this.panelWindows.Name = "panelWindows";
            this.panelWindows.Size = new System.Drawing.Size(652, 32);
            this.panelWindows.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(63, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Peso...";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::FYRASA.Properties.Resources.Minimize_to_Taskbar;
            this.button2.Location = new System.Drawing.Point(532, 0);
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
            this.button1.Location = new System.Drawing.Point(572, 0);
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
            this.bttCerrar.Location = new System.Drawing.Point(612, 0);
            this.bttCerrar.Name = "bttCerrar";
            this.bttCerrar.Size = new System.Drawing.Size(40, 32);
            this.bttCerrar.TabIndex = 0;
            this.bttCerrar.UseVisualStyleBackColor = true;
            this.bttCerrar.Click += new System.EventHandler(this.BttCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lote:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero de canal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Canalización:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(312, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            this.panel1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "KG";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(45, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 33);
            this.textBox1.TabIndex = 10;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(81, 62);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(19, 21);
            this.lblLote.TabIndex = 6;
            this.lblLote.Text = "...";
            // 
            // lblNumeroCanal
            // 
            this.lblNumeroCanal.AutoSize = true;
            this.lblNumeroCanal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCanal.Location = new System.Drawing.Point(170, 103);
            this.lblNumeroCanal.Name = "lblNumeroCanal";
            this.lblNumeroCanal.Size = new System.Drawing.Size(19, 21);
            this.lblNumeroCanal.TabIndex = 7;
            this.lblNumeroCanal.Text = "...";
            // 
            // lblCanalizacion
            // 
            this.lblCanalizacion.AutoSize = true;
            this.lblCanalizacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanalizacion.Location = new System.Drawing.Point(138, 144);
            this.lblCanalizacion.Name = "lblCanalizacion";
            this.lblCanalizacion.Size = new System.Drawing.Size(19, 21);
            this.lblCanalizacion.TabIndex = 8;
            this.lblCanalizacion.Text = "...";
            // 
            // bttSalir
            // 
            this.bttSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSalir.Location = new System.Drawing.Point(492, 201);
            this.bttSalir.Name = "bttSalir";
            this.bttSalir.Size = new System.Drawing.Size(120, 32);
            this.bttSalir.TabIndex = 14;
            this.bttSalir.Text = "Salir";
            this.bttSalir.UseVisualStyleBackColor = true;
            this.bttSalir.Click += new System.EventHandler(this.bttSalir_Click);
            // 
            // bttGuardar
            // 
            this.bttGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bttGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGuardar.Location = new System.Drawing.Point(337, 201);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(120, 32);
            this.bttGuardar.TabIndex = 13;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            // 
            // Pesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 256);
            this.Controls.Add(this.bttSalir);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.lblCanalizacion);
            this.Controls.Add(this.lblNumeroCanal);
            this.Controls.Add(this.lblLote);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pesos";
            this.Text = "Pesos";
            this.Load += new System.EventHandler(this.Pesos_Load);
            this.panelWindows.ResumeLayout(false);
            this.panelWindows.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWindows;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblNumeroCanal;
        private System.Windows.Forms.Label lblCanalizacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button bttSalir;
        public System.Windows.Forms.Button bttGuardar;
        public System.Windows.Forms.Label lblTitle;
    }
}