namespace FYRASA.Forms
{
    partial class VisorDeReportes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bttCerrar = new System.Windows.Forms.Button();
            this.rvVisorReportes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelWindows.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWindows
            // 
            this.panelWindows.Controls.Add(this.lblTitulo);
            this.panelWindows.Controls.Add(this.button2);
            this.panelWindows.Controls.Add(this.button1);
            this.panelWindows.Controls.Add(this.bttCerrar);
            this.panelWindows.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindows.Location = new System.Drawing.Point(0, 0);
            this.panelWindows.Name = "panelWindows";
            this.panelWindows.Size = new System.Drawing.Size(800, 32);
            this.panelWindows.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(85, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Reportes";
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.bttCerrar.Click += new System.EventHandler(this.bttCerrar_Click);
            // 
            // rvVisorReportes
            // 
            this.rvVisorReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvVisorReportes.Location = new System.Drawing.Point(0, 32);
            this.rvVisorReportes.Name = "rvVisorReportes";
            this.rvVisorReportes.ServerReport.BearerToken = null;
            this.rvVisorReportes.Size = new System.Drawing.Size(800, 418);
            this.rvVisorReportes.TabIndex = 3;
            this.rvVisorReportes.Load += new System.EventHandler(this.rvVisorReportes_Load);
            // 
            // VisorDeReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvVisorReportes);
            this.Controls.Add(this.panelWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisorDeReportes";
            this.Text = "VisorDeReportes";
            this.Load += new System.EventHandler(this.VisorDeReportes_Load);
            this.panelWindows.ResumeLayout(false);
            this.panelWindows.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWindows;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer rvVisorReportes;
    }
}