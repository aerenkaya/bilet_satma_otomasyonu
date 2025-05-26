namespace projemmmmmmmmmmm
{
    partial class Hasilat
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
            this.labelGelir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGelir
            // 
            this.labelGelir.AutoSize = true;
            this.labelGelir.BackColor = System.Drawing.Color.Transparent;
            this.labelGelir.Font = new System.Drawing.Font("Segoe UI Variable Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGelir.ForeColor = System.Drawing.Color.White;
            this.labelGelir.Location = new System.Drawing.Point(259, 211);
            this.labelGelir.Name = "labelGelir";
            this.labelGelir.Size = new System.Drawing.Size(92, 37);
            this.labelGelir.TabIndex = 0;
            this.labelGelir.Text = "sddsd";
            this.labelGelir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGelir.Click += new System.EventHandler(this.labelGelir_Click);
            // 
            // Hasilat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projemmmmmmmmmmm.Properties.Resources.Siyah_ve_Beyaz__Profesyonel_ve_Havalı__Sanatsal_Masaüstü_Duvar_Kağıdı__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGelir);
            this.Name = "Hasilat";
            this.Text = "Hasilat";
            this.Load += new System.EventHandler(this.Hasilat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGelir;
    }
}