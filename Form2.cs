using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            uC_OdaEkle1.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)// uygulama çıkış 
        {
            Application.Exit();
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)//önceki form 
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }



        private void guna2GradientButton1_Click(object sender, EventArgs e)//oda ekle 
        {
            uC_OdaEkle1.Visible = true;
            uC_OdaEkle1.BringToFront();
        }

       

        private void guna2GradientButton2_Click(object sender, EventArgs e)//müşteri giriş
        {
            uC_OdaEkle1.Visible = false;
            uC_MüsteriGirisi1.Visible = true;
            uC_MüsteriCikisi1.Visible = false;
            uC_MüsteriBilgileri1.Visible = false;
           

        }

       

        private void guna2GradientButton3_Click(object sender, EventArgs e)//müşteri çıkış 
        {
            uC_MüsteriCikisi1.Visible = true;   
            uC_MüsteriCikisi1.BringToFront();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            uC_MüsteriBilgileri1.Visible = true;
            uC_MüsteriBilgileri1.BringToFront();
        }
    }
}
