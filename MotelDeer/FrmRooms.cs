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
    public partial class FrmRooms : Form
    {
        public FrmRooms()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SD6K6FM\\SQLEXPRESS02;Initial Catalog=MotelDeer;Integrated Security=True");


        private void btnRoom109_Click(object sender, EventArgs e)
        {

        }

        private void FrmRooms_Load(object sender, EventArgs e)
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
            }

            baglanti.Open();
            SqlCommand command = new SqlCommand("select * from Room107",baglanti);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               btnRoom107.Text = reader["Adi"].ToString() +" " + reader["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnRoom107.Text!="107")
            {
                btnRoom107.BackColor = Color.Red;
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
            }
        }
    }
}
