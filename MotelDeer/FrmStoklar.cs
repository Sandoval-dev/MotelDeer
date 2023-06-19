using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MotelDeer
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SD6K6FM\\SQLEXPRESS02;Initial Catalog=MotelDeer;Integrated Security=True");
        private void Datas()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand command = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem addItem = new ListViewItem();
                addItem.Text = reader["Gida"].ToString();
                addItem.SubItems.Add(reader["Icecek"].ToString());
                addItem.SubItems.Add(reader["Cerezler"].ToString());
                listView1.Items.Add(addItem);
            }
            baglanti.Close();

            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand command2 = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                ListViewItem addItem = new ListViewItem();
                addItem.Text = reader2["Elektrik"].ToString();
                addItem.SubItems.Add(reader2["Su"].ToString());
                addItem.SubItems.Add(reader2["Internet"].ToString());
                listView2.Items.Add(addItem);
            }
            baglanti.Close();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Stoklar (Gida,Icecek,Cerezler) values ('" + txtGida.Text + "','" + txtIcecek.Text + "','" + txtSnacks.Text +"')", baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
            Datas();

        
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            Datas();
        }

        private void btnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Faturalar (Elektrik,Su,Internet) values ('" + txtElektrik.Text + "','" + txtSu.Text + "','" + txtInternet.Text + "')", baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
            Datas();
        }
    }
}
