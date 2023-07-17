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

namespace Hotel_Management_System.Tasarımlar
{
    public partial class UC_MüsteriGirisi : UserControl
    {
        functions fn=new functions();
        String query;

        public UC_MüsteriGirisi()
        {
            InitializeComponent();
        }

        public void setComboBox(String query , ComboBox combo )
        {
            SqlDataReader sdr=fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void OdaTipiCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select  roomNo from rooms where bed='" + YatakTürüCb.Text + "' and roomType='"+OdaTipiCb.Text+"' and booked='NO' ";
            setComboBox(query, OdaNumarasıCb);
        }

        private void YatakTürüCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdaTipiCb.SelectedIndex = -1;
            OdaNumarasıCb.Items.Clear();
        }

        int rid;
        private void OdaNumarasıCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            query="select price,roomid from rooms where roomNo='"+OdaNumarasıCb.Text+"'";
            DataSet ds =fn.getData(query);
            OdaFiyatTb.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse (ds.Tables[0].Rows[0][1].ToString());
        }

        private void MüsteriEkleBtn_Click(object sender, EventArgs e)
        {
            if (TCTb.Text!="" && MAdSoyadTb.Text!="" && MTelefonTb.Text!="" && MCinsiyetCb.Text!="" && MDogumTarihi.Text!="" && MAdresTb.Text!="" && MGirisTarihi.Text!="" && MÜlkeTb.Text!="")
            {
                String name = MAdSoyadTb.Text;
                Int64 mobile =Int64.Parse(MTelefonTb.Text);
                String national = MÜlkeTb.Text;
                String gender = MCinsiyetCb.Text;
                String dob = MDogumTarihi.Text;
                String idproof = TCTb.Text;
                String adress = MAdresTb.Text;
                String checkin = MGirisTarihi.Text;

                query = "insert into customer (cname,mobile,nationality,gender,dob,idproof,addres,checkin,roomid) values ('"+ name +"' , '"+mobile+"' , '"+national+"' , '"+gender+"' , '"+dob+"' , '"+ idproof+"' , '"+ adress+ "' , '"+ checkin+ "', "+rid+") update rooms set booked= 'YES' where roomNo='"+OdaNumarasıCb.Text+"'";
                fn.setData(query, "Oda Numarası" + OdaNumarasıCb.Text + "Ekleme Başarılı ");
            }
            else
            {
                MessageBox.Show("Bütün Alanları Doldurun", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            

        }
       
    }
}
