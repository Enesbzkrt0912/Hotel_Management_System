namespace Hotel_Management_System.Tasarımlar
{
    partial class UC_MüsteriGirisi
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MüsteriEkleBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MAdSoyadTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.MÜlkeTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.MAdresTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.MTelefonTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.OdaFiyatTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.TCTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.OdaTipiCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.YatakTürüCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.OdaNumarasıCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.MCinsiyetCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MGirisTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.MDogumTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // MüsteriEkleBtn
            // 
            this.MüsteriEkleBtn.Animated = true;
            this.MüsteriEkleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MüsteriEkleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MüsteriEkleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MüsteriEkleBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MüsteriEkleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MüsteriEkleBtn.FillColor2 = System.Drawing.Color.White;
            this.MüsteriEkleBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MüsteriEkleBtn.ForeColor = System.Drawing.Color.Black;
            this.MüsteriEkleBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.MüsteriEkleBtn.Location = new System.Drawing.Point(1010, 421);
            this.MüsteriEkleBtn.Name = "MüsteriEkleBtn";
            this.MüsteriEkleBtn.Size = new System.Drawing.Size(180, 45);
            this.MüsteriEkleBtn.TabIndex = 0;
            this.MüsteriEkleBtn.Text = "Müşteri Ekle";
            this.MüsteriEkleBtn.Click += new System.EventHandler(this.MüsteriEkleBtn_Click);
            // 
            // MAdSoyadTb
            // 
            this.MAdSoyadTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MAdSoyadTb.DefaultText = "";
            this.MAdSoyadTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MAdSoyadTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MAdSoyadTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MAdSoyadTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MAdSoyadTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MAdSoyadTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MAdSoyadTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MAdSoyadTb.Location = new System.Drawing.Point(54, 162);
            this.MAdSoyadTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MAdSoyadTb.Name = "MAdSoyadTb";
            this.MAdSoyadTb.PasswordChar = '\0';
            this.MAdSoyadTb.PlaceholderText = "";
            this.MAdSoyadTb.SelectedText = "";
            this.MAdSoyadTb.Size = new System.Drawing.Size(239, 36);
            this.MAdSoyadTb.TabIndex = 1;
            // 
            // MÜlkeTb
            // 
            this.MÜlkeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MÜlkeTb.DefaultText = "";
            this.MÜlkeTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MÜlkeTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MÜlkeTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MÜlkeTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MÜlkeTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MÜlkeTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MÜlkeTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MÜlkeTb.Location = new System.Drawing.Point(393, 406);
            this.MÜlkeTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MÜlkeTb.Name = "MÜlkeTb";
            this.MÜlkeTb.PasswordChar = '\0';
            this.MÜlkeTb.PlaceholderText = "";
            this.MÜlkeTb.SelectedText = "";
            this.MÜlkeTb.Size = new System.Drawing.Size(239, 36);
            this.MÜlkeTb.TabIndex = 2;
            // 
            // MAdresTb
            // 
            this.MAdresTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MAdresTb.DefaultText = "";
            this.MAdresTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MAdresTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MAdresTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MAdresTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MAdresTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MAdresTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MAdresTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MAdresTb.Location = new System.Drawing.Point(393, 162);
            this.MAdresTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MAdresTb.Name = "MAdresTb";
            this.MAdresTb.PasswordChar = '\0';
            this.MAdresTb.PlaceholderText = "";
            this.MAdresTb.SelectedText = "";
            this.MAdresTb.Size = new System.Drawing.Size(239, 36);
            this.MAdresTb.TabIndex = 4;
            // 
            // MTelefonTb
            // 
            this.MTelefonTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MTelefonTb.DefaultText = "";
            this.MTelefonTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MTelefonTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MTelefonTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MTelefonTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MTelefonTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MTelefonTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MTelefonTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MTelefonTb.Location = new System.Drawing.Point(50, 281);
            this.MTelefonTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MTelefonTb.Name = "MTelefonTb";
            this.MTelefonTb.PasswordChar = '\0';
            this.MTelefonTb.PlaceholderText = "";
            this.MTelefonTb.SelectedText = "";
            this.MTelefonTb.Size = new System.Drawing.Size(239, 36);
            this.MTelefonTb.TabIndex = 3;
            // 
            // OdaFiyatTb
            // 
            this.OdaFiyatTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OdaFiyatTb.DefaultText = "";
            this.OdaFiyatTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OdaFiyatTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OdaFiyatTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OdaFiyatTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OdaFiyatTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OdaFiyatTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OdaFiyatTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OdaFiyatTb.Location = new System.Drawing.Point(315, 254);
            this.OdaFiyatTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OdaFiyatTb.Name = "OdaFiyatTb";
            this.OdaFiyatTb.PasswordChar = '\0';
            this.OdaFiyatTb.PlaceholderText = "";
            this.OdaFiyatTb.SelectedText = "";
            this.OdaFiyatTb.Size = new System.Drawing.Size(208, 36);
            this.OdaFiyatTb.TabIndex = 6;
            // 
            // TCTb
            // 
            this.TCTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCTb.DefaultText = "";
            this.TCTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TCTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TCTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TCTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TCTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TCTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCTb.Location = new System.Drawing.Point(54, 59);
            this.TCTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TCTb.Name = "TCTb";
            this.TCTb.PasswordChar = '\0';
            this.TCTb.PlaceholderText = "TC no gir";
            this.TCTb.SelectedText = "";
            this.TCTb.Size = new System.Drawing.Size(239, 36);
            this.TCTb.TabIndex = 5;
            // 
            // OdaTipiCb
            // 
            this.OdaTipiCb.BackColor = System.Drawing.Color.Transparent;
            this.OdaTipiCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OdaTipiCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OdaTipiCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OdaTipiCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OdaTipiCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OdaTipiCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.OdaTipiCb.ItemHeight = 30;
            this.OdaTipiCb.Items.AddRange(new object[] {
            "klimalı ",
            "klimasız "});
            this.OdaTipiCb.Location = new System.Drawing.Point(315, 59);
            this.OdaTipiCb.Name = "OdaTipiCb";
            this.OdaTipiCb.Size = new System.Drawing.Size(204, 36);
            this.OdaTipiCb.TabIndex = 7;
            this.OdaTipiCb.SelectedIndexChanged += new System.EventHandler(this.OdaTipiCb_SelectedIndexChanged);
            // 
            // YatakTürüCb
            // 
            this.YatakTürüCb.BackColor = System.Drawing.Color.Transparent;
            this.YatakTürüCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.YatakTürüCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YatakTürüCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YatakTürüCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YatakTürüCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.YatakTürüCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.YatakTürüCb.ItemHeight = 30;
            this.YatakTürüCb.Items.AddRange(new object[] {
            "tek kişilik ",
            "çift kişilik ",
            "tek+çift kişilik"});
            this.YatakTürüCb.Location = new System.Drawing.Point(34, 59);
            this.YatakTürüCb.Name = "YatakTürüCb";
            this.YatakTürüCb.Size = new System.Drawing.Size(204, 36);
            this.YatakTürüCb.TabIndex = 8;
            this.YatakTürüCb.SelectedIndexChanged += new System.EventHandler(this.YatakTürüCb_SelectedIndexChanged);
            // 
            // OdaNumarasıCb
            // 
            this.OdaNumarasıCb.BackColor = System.Drawing.Color.Transparent;
            this.OdaNumarasıCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OdaNumarasıCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OdaNumarasıCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OdaNumarasıCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OdaNumarasıCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OdaNumarasıCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.OdaNumarasıCb.ItemHeight = 30;
            this.OdaNumarasıCb.Location = new System.Drawing.Point(34, 254);
            this.OdaNumarasıCb.Name = "OdaNumarasıCb";
            this.OdaNumarasıCb.Size = new System.Drawing.Size(204, 36);
            this.OdaNumarasıCb.TabIndex = 9;
            this.OdaNumarasıCb.SelectedIndexChanged += new System.EventHandler(this.OdaNumarasıCb_SelectedIndexChanged);
            // 
            // MCinsiyetCb
            // 
            this.MCinsiyetCb.BackColor = System.Drawing.Color.Transparent;
            this.MCinsiyetCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MCinsiyetCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MCinsiyetCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MCinsiyetCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MCinsiyetCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MCinsiyetCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.MCinsiyetCb.ItemHeight = 30;
            this.MCinsiyetCb.Items.AddRange(new object[] {
            "Kadin",
            "Erkek"});
            this.MCinsiyetCb.Location = new System.Drawing.Point(54, 406);
            this.MCinsiyetCb.Name = "MCinsiyetCb";
            this.MCinsiyetCb.Size = new System.Drawing.Size(235, 36);
            this.MCinsiyetCb.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(83, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Müşteri Adı /Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(74, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Telefon Nummarası ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kimlik Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(464, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ülke";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(474, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(375, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Oda Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(90, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Yatak Türü";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(375, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Oda Tipi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(80, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Oda Numarası";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(122, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Cinsiyet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(458, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Giriş tarihi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(448, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "Doğum Tarihi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OdaFiyatTb);
            this.groupBox1.Controls.Add(this.OdaTipiCb);
            this.groupBox1.Controls.Add(this.YatakTürüCb);
            this.groupBox1.Controls.Add(this.OdaNumarasıCb);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(820, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 331);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oda Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MGirisTarihi);
            this.groupBox2.Controls.Add(this.MDogumTarihi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.MAdSoyadTb);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TCTb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.MÜlkeTb);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.MTelefonTb);
            this.groupBox2.Controls.Add(this.MAdresTb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.MCinsiyetCb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(19, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 504);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgileri";
            // 
            // MGirisTarihi
            // 
            this.MGirisTarihi.Checked = true;
            this.MGirisTarihi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.MGirisTarihi.Location = new System.Drawing.Point(393, 295);
            this.MGirisTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.MGirisTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.MGirisTarihi.Name = "MGirisTarihi";
            this.MGirisTarihi.Size = new System.Drawing.Size(242, 36);
            this.MGirisTarihi.TabIndex = 26;
            this.MGirisTarihi.Value = new System.DateTime(2023, 7, 15, 10, 53, 9, 534);
            // 
            // MDogumTarihi
            // 
            this.MDogumTarihi.Checked = true;
            this.MDogumTarihi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.MDogumTarihi.Location = new System.Drawing.Point(393, 63);
            this.MDogumTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.MDogumTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.MDogumTarihi.Name = "MDogumTarihi";
            this.MDogumTarihi.Size = new System.Drawing.Size(242, 36);
            this.MDogumTarihi.TabIndex = 25;
            this.MDogumTarihi.Value = new System.DateTime(2023, 7, 15, 10, 53, 9, 534);
            // 
            // UC_MüsteriGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MüsteriEkleBtn);
            this.Name = "UC_MüsteriGirisi";
            this.Size = new System.Drawing.Size(1442, 535);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox MCinsiyetCb;
        private Guna.UI2.WinForms.Guna2ComboBox OdaNumarasıCb;
        private Guna.UI2.WinForms.Guna2ComboBox YatakTürüCb;
        private Guna.UI2.WinForms.Guna2ComboBox OdaTipiCb;
        private Guna.UI2.WinForms.Guna2TextBox OdaFiyatTb;
        private Guna.UI2.WinForms.Guna2TextBox TCTb;
        private Guna.UI2.WinForms.Guna2TextBox MAdresTb;
        private Guna.UI2.WinForms.Guna2TextBox MTelefonTb;
        private Guna.UI2.WinForms.Guna2TextBox MÜlkeTb;
        private Guna.UI2.WinForms.Guna2TextBox MAdSoyadTb;
        private Guna.UI2.WinForms.Guna2GradientButton MüsteriEkleBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker MGirisTarihi;
        private Guna.UI2.WinForms.Guna2DateTimePicker MDogumTarihi;
    }
}
