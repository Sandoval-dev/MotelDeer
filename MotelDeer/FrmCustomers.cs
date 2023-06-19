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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SD6K6FM\\SQLEXPRESS02;Initial Catalog=MotelDeer;Integrated Security=True");

        private void ShowData()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AddCustomer", baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = reader["MusteriID"].ToString();
                add.SubItems.Add(reader["Adi"].ToString());
                add.SubItems.Add(reader["Soyadi"].ToString());
                add.SubItems.Add(reader["Cinsiyet"].ToString());
                add.SubItems.Add(reader["Telefon"].ToString());
                add.SubItems.Add(reader["Mail"].ToString());
                add.SubItems.Add(reader["TC"].ToString());
                add.SubItems.Add(reader["OdaNo"].ToString());
                add.SubItems.Add(reader["Ucret"].ToString());
                add.SubItems.Add(reader["GirisTarihi"].ToString());
                add.SubItems.Add(reader["CikisTarihi"].ToString());

                listView1.Items.Add(add);

            }

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int id = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSurname.Text = listView1.SelectedItems[0].SubItems[2].Text;
           comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtPhoneNumber.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtRoomNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtPrice.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpGiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpOut.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (TxtRoomNo.Text=="109")
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("delete from Room109", baglanti);
                command.ExecuteNonQuery();
                baglanti.Close();
                ShowData();
            }
            if (TxtRoomNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("delete from Room101", baglanti);
                command.ExecuteNonQuery();
                baglanti.Close();
                ShowData();
            }
            if (TxtRoomNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("delete from Room107", baglanti);
                command.ExecuteNonQuery();
                baglanti.Close();
                ShowData();
            }
            if (TxtRoomNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("delete from Room104", baglanti);
                command.ExecuteNonQuery();
                baglanti.Close();
                ShowData();
            }
            if (TxtRoomNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("delete from Room103", baglanti);
                command.ExecuteNonQuery();
                baglanti.Close();
                ShowData();
            }
            if (TxtRoomNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("delete from Room102", baglanti);
                command.ExecuteNonQuery();
                baglanti.Close();
                ShowData();
            }

            if (TxtRoomNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("delete from Room109", baglanti);
                command.ExecuteNonQuery();
                baglanti.Close();
                ShowData();
            }
            if (TxtRoomNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("delete from Room109", baglanti);
                command.ExecuteNonQuery();
                baglanti.Close();
                ShowData();
            }
            if (TxtRoomNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("delete from Room109", baglanti);
                command.ExecuteNonQuery();
                baglanti.Close();
                ShowData();
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSurname.Clear();
            comboBox1.Text = "";
            txtPhoneNumber.Clear();
            txtMail.Clear();
            txtTc.Clear();
            TxtRoomNo.Clear();
            txtPrice.Clear();
            dtpGiris.Text = "";
            dtpOut.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("update AddCustomer set Adi='" + txtName.Text + "',Soyadi='" + txtSurname.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + txtPhoneNumber.Text + "',Mail='" + txtMail.Text + "',TC='" + txtTc.Text + "',OdaNo='" + TxtRoomNo.Text + "',Ucret='" + txtPrice.Text + "',GirisTarihi='" + dtpGiris.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + dtpOut.Value.ToString("yyyy-MM-dd") + "'where MusteriID=" + id + "", baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
            ShowData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AddCustomer where Adi like '%"+textBox1.Text+ "%'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = reader["MusteriID"].ToString();
                add.SubItems.Add(reader["Adi"].ToString());
                add.SubItems.Add(reader["Soyadi"].ToString());
                add.SubItems.Add(reader["Cinsiyet"].ToString());
                add.SubItems.Add(reader["Telefon"].ToString());
                add.SubItems.Add(reader["Mail"].ToString());
                add.SubItems.Add(reader["TC"].ToString());
                add.SubItems.Add(reader["OdaNo"].ToString());
                add.SubItems.Add(reader["Ucret"].ToString());
                add.SubItems.Add(reader["GirisTarihi"].ToString());
                add.SubItems.Add(reader["CikisTarihi"].ToString());

                listView1.Items.Add(add);

            }

            baglanti.Close();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {

        }
    }

    //SqlCommand command = new SqlCommand("delete from AddCustomer where MusteriID=(" + id + ")", baglanti);

}
