namespace FYRASA.Forms
{
    partial class PesosCanastas
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbCortes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttSalir
            // 
            this.bttSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bttSalir.Location = new System.Drawing.Point(492, 406);
            this.bttSalir.Click += new System.EventHandler(this.bttSalir_Click);
            // 
            // bttGuardar
            // 
            this.bttGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bttGuardar.Location = new System.Drawing.Point(337, 406);
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FYRASA.Properties.Resources.CortesPorcino;
            this.pictureBox1.Location = new System.Drawing.Point(12, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // cmbCortes
            // 
            this.cmbCortes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCortes.FormattingEnabled = true;
            this.cmbCortes.Location = new System.Drawing.Point(359, 185);
            this.cmbCortes.Name = "cmbCortes";
            this.cmbCortes.Size = new System.Drawing.Size(253, 29);
            this.cmbCortes.TabIndex = 16;
            // 
            // PesosCanastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.cmbCortes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PesosCanastas";
            this.Text = "PesosCanastas";
            this.Load += new System.EventHandler(this.PesosCanastas_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblNumeroCanal, 0);
            this.Controls.SetChildIndex(this.txtNumeroCanal, 0);
            this.Controls.SetChildIndex(this.bttGuardar, 0);
            this.Controls.SetChildIndex(this.bttSalir, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.cmbCortes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbCortes;
    }
}