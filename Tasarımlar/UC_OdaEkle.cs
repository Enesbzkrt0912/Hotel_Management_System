using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.Tasarımlar
{
    public partial class UC_OdaEkle : UserControl
    {

        functions fn = new functions();
        String query;
        public UC_OdaEkle()
        {
            InitializeComponent();
        }

        private void UC_OdaEkle_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds =fn.getData(query);
            DataGridView1.DataSource= ds.Tables[0];
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            if (OdaNumarasıTb.Text!=""&&OdaFiyatıTb.Text!="")
            {
                String roomno = OdaNumarasıTb.Text;
                String type = OdaTipiCb.Text;
                String bed = YatakTipiCb.Text;
                Int64 price = Int64.Parse(OdaFiyatıTb.Text);

                query = "insert into rooms (roomNo,roomType,bed,price) values ('" + roomno + "','" + type + "','" + bed + "','" + price + "')";
                fn.setData(query,"Oda eklendi");

                UC_OdaEkle_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurunuz ","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
            public void ClearAll()
            {
                OdaTipiCb.SelectedIndex = -1;
                YatakTipiCb.SelectedIndex = -1;
                OdaNumarasıTb.Text = "";
                OdaFiyatıTb.Text = "";
            }
        
    }
}
