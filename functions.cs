using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    internal class functions
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=\\SQLEXPRESS;Initial Catalog=Hotel_Management_System;Integrated Security=True";// vt ekle 
            return con;
        }

        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da =new SqlDataAdapter(cmd);
            DataSet ds =new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query ,String message)// verileri göster 
        {
            SqlConnection con = getConnection();//sql bağlan 
            SqlCommand cmd = new SqlCommand();// komut
            cmd.Connection = con;
            con.Open(); 
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("'"+message+"'","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con= getConnection(); 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd=new SqlCommand(query,con);
            SqlDataReader sdr=cmd.ExecuteReader();
            return sdr;
        }



    }
}
