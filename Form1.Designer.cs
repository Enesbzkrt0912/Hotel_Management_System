namespace Hotel_Management_System
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GirisBtn = new Guna.UI2.WinForms.Guna2Button();
            this.KullaniciAdiTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.SifreTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.GirişYazısıLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HatalıGirisLb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GirisBtn
            // 
            this.GirisBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GirisBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GirisBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GirisBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GirisBtn.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Bold);
            this.GirisBtn.ForeColor = System.Drawing.Color.White;
            this.GirisBtn.Location = new System.Drawing.Point(162, 382);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(199, 45);
            this.GirisBtn.TabIndex = 0;
            this.GirisBtn.Text = "Giriş Yap";
            this.GirisBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // KullaniciAdiTb
            // 
            this.KullaniciAdiTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KullaniciAdiTb.DefaultText = "";
            this.KullaniciAdiTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.KullaniciAdiTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.KullaniciAdiTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KullaniciAdiTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KullaniciAdiTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KullaniciAdiTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.KullaniciAdiTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KullaniciAdiTb.Location = new System.Drawing.Point(162, 141);
            this.KullaniciAdiTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KullaniciAdiTb.Name = "KullaniciAdiTb";
            this.KullaniciAdiTb.PasswordChar = '\0';
            this.KullaniciAdiTb.PlaceholderText = "";
            this.KullaniciAdiTb.SelectedText = "";
            this.KullaniciAdiTb.Size = new System.Drawing.Size(199, 39);
            this.KullaniciAdiTb.TabIndex = 1;
            // 
            // SifreTb
            // 
            this.SifreTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SifreTb.DefaultText = "";
            this.SifreTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SifreTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SifreTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SifreTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SifreTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SifreTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SifreTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SifreTb.Location = new System.Drawing.Point(162, 221);
            this.SifreTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SifreTb.Name = "SifreTb";
            this.SifreTb.PasswordChar = '\0';
            this.SifreTb.PlaceholderText = "";
            this.SifreTb.SelectedText = "";
            this.SifreTb.Size = new System.Drawing.Size(199, 39);
            this.SifreTb.TabIndex = 2;
            // 
            // GirişYazısıLb
            // 
            this.GirişYazısıLb.AutoSize = true;
            this.GirişYazısıLb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.GirişYazısıLb.Location = new System.Drawing.Point(12, 36);
            this.GirişYazısıLb.Name = "GirişYazısıLb";
            this.GirişYazısıLb.Size = new System.Drawing.Size(206, 21);
            this.GirişYazısıLb.TabIndex = 3;
            this.GirişYazısıLb.Text = "HOTEL-YÖNETİM-SİSTEMİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(45, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GirişYazısıLb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 100);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(436, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(516, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // HatalıGirisLb
            // 
            this.HatalıGirisLb.AutoSize = true;
            this.HatalıGirisLb.Location = new System.Drawing.Point(224, 310);
            this.HatalıGirisLb.Name = "HatalıGirisLb";
            this.HatalıGirisLb.Size = new System.Drawing.Size(71, 16);
            this.HatalıGirisLb.TabIndex = 9;
            this.HatalıGirisLb.Text = "giriş hatası";
            this.HatalıGirisLb.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(415, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Yeniden Deneyiniz\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HatalıGirisLb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SifreTb);
            this.Controls.Add(this.KullaniciAdiTb);
            this.Controls.Add(this.GirisBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button GirisBtn;
        private Guna.UI2.WinForms.Guna2TextBox KullaniciAdiTb;
        private Guna.UI2.WinForms.Guna2TextBox SifreTb;
        private System.Windows.Forms.Label GirişYazısıLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label HatalıGirisLb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

