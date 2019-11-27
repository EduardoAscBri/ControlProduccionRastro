namespace FYRASA.Forms
{
    partial class Reportes
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
            this.bttBoletasHistorico = new System.Windows.Forms.Button();
            this.bttOrdenesHistorico = new System.Windows.Forms.Button();
            this.bttLotesLista = new System.Windows.Forms.Button();
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
            this.panelWindows.Size = new System.Drawing.Size(492, 32);
            this.panelWindows.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reportes";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::FYRASA.Properties.Resources.Minimize_to_Taskbar;
            this.button2.Location = new System.Drawing.Point(372, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 32);
            this.button2.TabIndex = 12;
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
            this.button1.Location = new System.Drawing.Point(412, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 32);
            this.button1.TabIndex = 13;
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
            this.bttCerrar.Location = new System.Drawing.Point(452, 0);
            this.bttCerrar.Name = "bttCerrar";
            this.bttCerrar.Size = new System.Drawing.Size(40, 32);
            this.bttCerrar.TabIndex = 14;
            this.bttCerrar.UseVisualStyleBackColor = true;
            this.bttCerrar.Click += new System.EventHandler(this.bttCerrar_Click);
            // 
            // bttBoletasHistorico
            // 
            this.bttBoletasHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bttBoletasHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttBoletasHistorico.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttBoletasHistorico.Location = new System.Drawing.Point(17, 50);
            this.bttBoletasHistorico.Name = "bttBoletasHistorico";
            this.bttBoletasHistorico.Size = new System.Drawing.Size(463, 32);
            this.bttBoletasHistorico.TabIndex = 101;
            this.bttBoletasHistorico.Text = "Boletas de entrada - Historico";
            this.bttBoletasHistorico.UseVisualStyleBackColor = true;
            this.bttBoletasHistorico.Click += new System.EventHandler(this.bttBoletasHistorico_Click);
            // 
            // bttOrdenesHistorico
            // 
            this.bttOrdenesHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bttOrdenesHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttOrdenesHistorico.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttOrdenesHistorico.Location = new System.Drawing.Point(17, 98);
            this.bttOrdenesHistorico.Name = "bttOrdenesHistorico";
            this.bttOrdenesHistorico.Size = new System.Drawing.Size(463, 32);
            this.bttOrdenesHistorico.TabIndex = 102;
            this.bttOrdenesHistorico.Text = "Ordenes de produccion - Historico";
            this.bttOrdenesHistorico.UseVisualStyleBackColor = true;
            this.bttOrdenesHistorico.Click += new System.EventHandler(this.bttOrdenesHistorico_Click);
            // 
            // bttLotesLista
            // 
            this.bttLotesLista.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bttLotesLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttLotesLista.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLotesLista.Location = new System.Drawing.Point(17, 145);
            this.bttLotesLista.Name = "bttLotesLista";
            this.bttLotesLista.Size = new System.Drawing.Size(463, 32);
            this.bttLotesLista.TabIndex = 103;
            this.bttLotesLista.Text = "Lista de lotes de produccion";
            this.bttLotesLista.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 270);
            this.Controls.Add(this.bttLotesLista);
            this.Controls.Add(this.bttOrdenesHistorico);
            this.Controls.Add(this.bttBoletasHistorico);
            this.Controls.Add(this.panelWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.panelWindows.ResumeLayout(false);
            this.panelWindows.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWindows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttCerrar;
        private System.Windows.Forms.Button bttBoletasHistorico;
        private System.Windows.Forms.Button bttOrdenesHistorico;
        private System.Windows.Forms.Button bttLotesLista;
    }
}