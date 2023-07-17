using Hotel_Management_System.Tasarımlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hotel_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dönüs=0;
        void animasyon()
        {
            if (dönüs==0)
            {
                GirişYazısıLb.Location = new System.Drawing.Point(12, 36);
                dönüs++;
            }
            else if (dönüs==1)
            {
                GirişYazısıLb.Location = new System.Drawing.Point(150, 36);
                dönüs++;
            }
            else if (dönüs==2)
            {
                GirişYazısıLb.Location = new System.Drawing.Point(300, 36);
                dönüs=0;
            }
        }               

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            animasyon();
            label4.Text = DateTime.Now.ToLongDateString();
            label5.Text = DateTime.Now.ToLongTimeString();
        }
        int num = 0;

        SqlConnection baglanti=new SqlConnection("Data Source=BATCOMPUTER\\SQLEXPRESS;Initial Catalog=Hotel_Management_System;Integrated Security=True");
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from user_login where KullaniciAdi=@kullanici and Sifre=@sifre";//verileri parametre aktardım 
                SqlParameter prm1= new SqlParameter("kullanici",KullaniciAdiTb.Text.Trim());//texbox verilerini parametre aktardım 
                SqlParameter prm2= new SqlParameter("sifre",SifreTb.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                HatalıGirisLb.Visible= true;
                button1.Visible= true;
                GirisBtn.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
