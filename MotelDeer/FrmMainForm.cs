using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotelDeer
{
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            FrmAdminLogin frmAdminLogin = new FrmAdminLogin();
            frmAdminLogin.Show();
            this.Hide();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            FrmNewCustomer frmNewCustomer = new FrmNewCustomer();
            frmNewCustomer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRooms frmRooms = new FrmRooms();
            frmRooms.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomers frmCustomers = new FrmCustomers();
            frmCustomers.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Motel Deer Kayıt Uygulaması - 2023", "Osman Erdem Kılıç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmNewsPaper frmNewsPaper = new FrmNewsPaper();
            frmNewsPaper.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGelirGider frmGelirGider = new FrmGelirGider();
            frmGelirGider.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmStoklar frmStoklar = new FrmStoklar();
            frmStoklar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmRadio frmRadio = new FrmRadio();
            frmRadio.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle frmSifreGuncelle = new FrmSifreGuncelle();
            frmSifreGuncelle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCustomerMessages frmCustomerMessages = new FrmCustomerMessages();
            frmCustomerMessages.Show();
        }
    }
}
