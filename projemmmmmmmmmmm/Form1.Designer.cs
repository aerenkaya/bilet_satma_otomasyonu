namespace projemmmmmmmmmmm
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rd_yonetici = new System.Windows.Forms.RadioButton();
            this.rd_user = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(279, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "kullanıcı adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(279, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "şifre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(284, 328);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 22);
            this.textBox2.TabIndex = 2;
            // 
            // rd_yonetici
            // 
            this.rd_yonetici.AutoSize = true;
            this.rd_yonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rd_yonetici.Location = new System.Drawing.Point(81, 71);
            this.rd_yonetici.Name = "rd_yonetici";
            this.rd_yonetici.Size = new System.Drawing.Size(181, 33);
            this.rd_yonetici.TabIndex = 4;
            this.rd_yonetici.TabStop = true;
            this.rd_yonetici.Text = "yönetici girişi";
            this.rd_yonetici.UseVisualStyleBackColor = true;
            // 
            // rd_user
            // 
            this.rd_user.AutoSize = true;
            this.rd_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rd_user.Location = new System.Drawing.Point(574, 71);
            this.rd_user.Name = "rd_user";
            this.rd_user.Size = new System.Drawing.Size(186, 33);
            this.rd_user.TabIndex = 5;
            this.rd_user.TabStop = true;
            this.rd_user.Text = "kullanıcı girişi";
            this.rd_user.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(299, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "giriş yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(299, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 59);
            this.button2.TabIndex = 7;
            this.button2.Text = "kaydol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 602);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rd_user);
            this.Controls.Add(this.rd_yonetici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rd_yonetici;
        private System.Windows.Forms.RadioButton rd_user;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

