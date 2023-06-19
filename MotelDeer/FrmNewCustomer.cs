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
    public partial class FrmNewCustomer : Form
    {
        public FrmNewCustomer()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SD6K6FM\\SQLEXPRESS02;Initial Catalog=MotelDeer;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRoom101_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "101";
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Room101 (Adi,Soyadi) values ('" + txtName.Text + "','" + txtSurname.Text + "')", baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
        }

     
        private void btnRoom102_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "102";
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Room102 (Adi,Soyadi) values ('" + txtName.Text + "','" + txtSurname.Text + "')", baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnRoom103_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "103";
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Room103 (Adi,Soyadi) values ('" + txtName.Text + "','" + txtSurname.Text + "')", baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnRoom104_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "104";
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Room104 (Adi,Soyadi) values ('" + txtName.Text + "','" + txtSurname.Text + "')", baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnRoom105_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "105";
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Room105 (Adi,Soyadi) values ('" + txtName.Text + "','" + txtSurname.Text + "')", baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnRoom106_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "106";
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Room106 (Adi,Soyadi) values ('" + txtName.Text + "','" + txtSurname.Text + "')", baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnRoom107_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "107";
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Room107 (Adi,Soyadi) values ('" + txtName.Text + "','" + txtSurname.Text + "')", baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnRoom108_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "108";
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Room108 (Adi,Soyadi) values ('" + txtName.Text + "','" + txtSurname.Text + "')", baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnRoom109_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "109";
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Room109 (Adi,Soyadi) values ('" + txtName.Text + "','" + txtSurname.Text + "')", baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnFullRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir.","Oda Bilgisi");
        }

        private void btnEmptyRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renki butonlar boş odaları gösterir.", "Oda Bilgisi");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into AddCustomer (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values ('" + txtName.Text + "','" + txtSurname.Text + "', '" + comboBox1.Text + "' , '" + txtPhoneNumber.Text + "','" + txtMail.Text + "','" + txtTc.Text + "','" + TxtRoomNo.Text +  "','" + txtPrice.Text + "','" + dtpGiris.Value.ToString("yyyy-MM-dd") + "','" + dtpOut.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dtpOut_ValueChanged(object sender, EventArgs e)
        {
            int ucret=300;
            DateTime kucukTarih = Convert.ToDateTime(dtpGiris.Text);
            DateTime buyukTarih = Convert.ToDateTime(dtpOut.Text);

            TimeSpan Sonuc = buyukTarih - kucukTarih;

            ucret *= Convert.ToInt32(Sonuc.TotalDays.ToString());
            txtPrice.Text = ucret.ToString();


            
        }

        private void FrmNewCustomer_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command9 = new SqlCommand("select * from Room101", baglanti);
            SqlDataReader reader9 = command9.ExecuteReader();
            while (reader9.Read())
            {
                btnRoom101.Text = reader9["Adi"].ToString() + " " + reader9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnRoom101.Text != "101")
            {
                btnRoom101.BackColor = Color.Red;
                btnRoom101.Enabled = false;
            }


            baglanti.Open();
            SqlCommand command8 = new SqlCommand("select * from Room102", baglanti);
            SqlDataReader reader8 = command8.ExecuteReader();
            while (reader8.Read())
            {
                btnRoom102.Text = reader8["Adi"].ToString() + " " + reader8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnRoom102.Text != "102")
            {
                btnRoom102.BackColor = Color.Red;
                btnRoom102.Enabled = false;
            }

            baglanti.Open();
            SqlCommand command7 = new SqlCommand("select * from Room103", baglanti);
            SqlDataReader reader7 = command7.ExecuteReader();
            while (reader7.Read())
            {
                btnRoom103.Text = reader7["Adi"].ToString() + " " + reader7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnRoom103.Text != "103")
            {
                btnRoom103.BackColor = Color.Red;
                btnRoom103.Enabled = false;
            }


            baglanti.Open();
            SqlCommand command6 = new SqlCommand("select * from Room104", baglanti);
            SqlDataReader reader6 = command6.ExecuteReader();
            while (reader6.Read())
            {
                btnRoom104.Text = reader6["Adi"].ToString() + " " + reader6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnRoom104.Text != "104")
            {
                btnRoom104.BackColor = Color.Red;
                btnRoom104.Enabled = false;
            }

            baglanti.Open();
            SqlCommand command5 = new SqlCommand("select * from Room105", baglanti);
            SqlDataReader reader5 = command5.ExecuteReader();
            while (reader5.Read())
            {
                btnRoom105.Text = reader5["Adi"].ToString() + " " + reader5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnRoom105.Text != "105")
            {
                btnRoom105.BackColor = Color.Red;
                btnRoom105.Enabled = false;
            }

            baglanti.Open();
            SqlCommand command4 = new SqlCommand("select * from Room106", baglanti);
            SqlDataReader reader4 = command4.ExecuteReader();
            while (reader4.Read())
            {
                btnRoom106.Text = reader4["Adi"].ToString() + " " + reader4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnRoom106.Text != "106")
            {
                btnRoom106.BackColor = Color.Red;
                btnRoom106.Enabled = false;
            }

            baglanti.Open();
            SqlCommand command = new SqlCommand("select * from Room107", baglanti);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                btnRoom107.Text = reader["Adi"].ToString() + " " + reader["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnRoom107.Text != "107")
            {
                btnRoom107.BackColor = Color.Red;
                btnRoom107.Enabled = false;
            }

            baglanti.Open();
            SqlCommand command3 = new SqlCommand("select * from Room108", baglanti);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                btnRoom107.Text = reader3["Adi"].ToString() + " " + reader3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnRoom108.Text != "108")
            {
                btnRoom108.BackColor = Color.Red;
                btnRoom108.Enabled = false;
            }

            baglanti.Open();
            SqlCommand command2 = new SqlCommand("select * from Room109", baglanti);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                btnRoom109.Text = reader2["Adi"].ToString() + " " + reader2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnRoom109.Text != "109")
            {
                btnRoom109.BackColor = Color.Red;
                btnRoom109.Enabled = false;
            }
        }

        //Data Source=DESKTOP-SD6K6FM\SQLEXPRESS02;Initial Catalog=MotelDeer;Integrated Security=True
    }
}
