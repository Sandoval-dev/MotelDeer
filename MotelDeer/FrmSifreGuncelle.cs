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
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SD6K6FM\\SQLEXPRESS02;Initial Catalog=MotelDeer;Integrated Security=True");


        private void FrmSifreGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("update AdminLogin set Kullanici='" + txtUserName.Text + "',Sifre='" + txtPassword.Text + "'", baglanti);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Şifre güncellendi.", "Şifre Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
