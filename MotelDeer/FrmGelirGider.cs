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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SD6K6FM\\SQLEXPRESS02;Initial Catalog=MotelDeer;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            int personel = Convert.ToInt32(textBox1.Text);
            lblPersonel.Text = (personel * 2000).ToString();

            int sonuc;
            sonuc=(Convert.ToInt32(lblKasaToplam.Text)) - (Convert.ToInt32(txtIcecek.Text) + Convert.ToInt32(txtGida.Text) + Convert.ToInt32(txtElektrik.Text) + Convert.ToInt32(txtInternet.Text) + Convert.ToInt32(txtSu.Text) + Convert.ToInt32(txtSnacks.Text) + Convert.ToInt32(lblPersonel.Text));
            lblSonuc.Text = sonuc.ToString();

        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("select SUM(Ucret) as toplam from AddCustomer", baglanti);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblKasaToplam.Text = reader["toplam"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand command2 = new SqlCommand("select SUM(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                txtGida.Text = reader2["toplam1"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand command3 = new SqlCommand("select SUM(Icecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                txtIcecek.Text = reader3["toplam2"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand command4 = new SqlCommand("select SUM(Cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader reader4 = command4.ExecuteReader();
            while (reader4.Read())
            {
                txtSnacks.Text = reader4["toplam3"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand command5 = new SqlCommand("select SUM(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader reader5 = command5.ExecuteReader();
            while (reader5.Read())
            {
                txtElektrik.Text = reader5["toplam4"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand command6 = new SqlCommand("select SUM(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader reader6 = command6.ExecuteReader();
            while (reader6.Read())
            {
                txtSu.Text = reader6["toplam5"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand command7 = new SqlCommand("select SUM(Internet) as toplam6 from Faturalar", baglanti);
            SqlDataReader reader7 = command7.ExecuteReader();
            while (reader7.Read())
            {
                txtInternet.Text = reader7["toplam6"].ToString();
            }
            baglanti.Close();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblKasaToplam_Click(object sender, EventArgs e)
        {

        }
    }
}
