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
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SD6K6FM\\SQLEXPRESS02;Initial Catalog=MotelDeer;Integrated Security=True");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "select * from AdminLogin where Kullanici=@KullaniciAdi AND Sifre=@Sifresi";
            SqlParameter parameter1 = new SqlParameter("Kullaniciadi", txtUserName.Text.Trim());
            SqlParameter parameter2 = new SqlParameter("Sifresi", txtPassword.Text.Trim());
            SqlCommand command = new SqlCommand(sql, baglanti);
            command.Parameters.Add(parameter1);
            command.Parameters.Add(parameter2);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                FrmMainForm frmMainForm = new FrmMainForm();
                frmMainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                baglanti.Close();
            }




        }
    }
}
