namespace arackiralamasistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.textBox_tc = new System.Windows.Forms.TextBox();
            this.textBox_no = new System.Windows.Forms.TextBox();
            this.button_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(43, 192);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(188, 20);
            this.textBox_ad.TabIndex = 0;
            // 
            // textBox_tc
            // 
            this.textBox_tc.Location = new System.Drawing.Point(43, 245);
            this.textBox_tc.MaxLength = 11;
            this.textBox_tc.Name = "textBox_tc";
            this.textBox_tc.Size = new System.Drawing.Size(188, 20);
            this.textBox_tc.TabIndex = 1;
            // 
            // textBox_no
            // 
            this.textBox_no.Location = new System.Drawing.Point(43, 291);
            this.textBox_no.MaxLength = 10;
            this.textBox_no.Name = "textBox_no";
            this.textBox_no.Size = new System.Drawing.Size(188, 20);
            this.textBox_no.TabIndex = 2;
            // 
            // button_giris
            // 
            this.button_giris.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_giris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_giris.ForeColor = System.Drawing.Color.White;
            this.button_giris.Location = new System.Drawing.Point(65, 336);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(143, 39);
            this.button_giris.TabIndex = 3;
            this.button_giris.Text = "Giriş Yap";
            this.button_giris.UseVisualStyleBackColor = false;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.textBox_no);
            this.Controls.Add(this.textBox_tc);
            this.Controls.Add(this.textBox_ad);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Araç Kiralama Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.TextBox textBox_tc;
        private System.Windows.Forms.TextBox textBox_no;
        private System.Windows.Forms.Button button_giris;
    }
}

