using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.Tasarımlar
{
    public partial class UC_MüsteriCikisi : UserControl
    {
        functions fn=new functions();
        String query;
        public UC_MüsteriCikisi()
        {
            InitializeComponent();
        }

        private void UC_MüsteriCikisi_Load(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where chekout='NO'";
             DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0]; 

        }

        private void AdTb_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where cname like'" + AdTb.Text + "%' and chekout='NO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                MAdıTb.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                OdaNumarasıTb.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void MCıkısBtn_Click(object sender, EventArgs e)
        {
            if (MAdıTb.Text!="")
            {
                if (MessageBox.Show("Emin misiniz","Onayama",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    String cdate = MCıkısDtp.Text;
                    query="update customer set chekout='YES',checkout='"+cdate+"'where cid="+id+"update rooms set booked ='NO' where roomNo='"+OdaNumarasıTb.Text+"'";
                    fn.setData(query,"Çıkış Başarılı ");
                    UC_MüsteriCikisi_Load(this, null);
                    clearAll();

                }

            }
            else
            {
                MessageBox.Show("Lütfen Müşeri Seçiniz","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void  clearAll()
        {
            AdTb.Clear();   
            MAdıTb.Clear();
            OdaNumarasıTb.Clear();
            MCıkısDtp.ResetText();
        }
        private void UC_MüsteriCikisi_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
