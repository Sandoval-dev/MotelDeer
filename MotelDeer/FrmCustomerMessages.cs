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
    public partial class FrmCustomerMessages : Form
    {
        public FrmCustomerMessages()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SD6K6FM\\SQLEXPRESS02;Initial Catalog=MotelDeer;Integrated Security=True");


        private void FrmCustomerMessages_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Messages", baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = reader["MesajId"].ToString();
                add.SubItems.Add(reader["AdSoyad"].ToString());
                add.SubItems.Add(reader["Mesaj"].ToString());   
                listView1.Items.Add(add);

            }

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Messages(AdSoyad,Mesaj) values('"+textBox1.Text  +"','" + richTextBox1.Text + "')", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            baglanti.Close();
            ShowData();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
