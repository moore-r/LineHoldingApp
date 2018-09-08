using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hold_It_App
{
    public partial class Account : Form
    {
        public Account(account_head Account_Database, Event_Controller Event_Database, account_info account)
        {
            ActDB = Account_Database;
            EvtDB = Event_Database;
            user = account;
            InitializeComponent();
        }
        private account_head ActDB;
        private Event_Controller EvtDB;
        private account_info user;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = user.get_email();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.user.check_status() == true)
                this.label6.Text = "Holdee";
            else
                this.label6.Text = "Customer";
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home NewForm = new Home(ActDB, EvtDB, user);
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search NewForm = new Search(ActDB, EvtDB, user);
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            this.Hide();
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            Post NewForm = new Post(ActDB, EvtDB, user);
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            this.Hide();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            Account NewForm = new Account(ActDB, EvtDB, user);
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            NewForm.label2.Text = user.get_email();
            if (user.check_status() == true)
            {
                NewForm.label6.Text = "Holdee";
                NewForm.button2.Hide();
                NewForm.button1.Show();
            }
            else
            { 
                NewForm.label6.Text = "Customer";
                NewForm.button1.Hide();
                NewForm.button2.Show();
            }
            if (EvtDB.check_cust_spot(user.get_email()) == true)
                NewForm.button3.Show();
            else
                NewForm.label8.Show();

            this.Hide();
        }

        private void HoldeeButton_Click(object sender, EventArgs e)
        {
            AccountHoldee NewForm = new AccountHoldee(ActDB, EvtDB, user);
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            NewForm.label2.Text = user.get_email();
            if (EvtDB.check_spot(user.get_email()) == false)
                NewForm.label8.Show();
            else
                NewForm.button3.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login NewForm = new Login(ActDB, EvtDB);
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            this.Hide();
        }

        private void Become_Holdee_Click(object sender, EventArgs e)
        {
            this.button2.Hide();
            this.button1.Show();
            user.set_status(true);
            this.label6.Text = "Holdee";
        }

        private void Spot_Button_Click(object sender, EventArgs e)
        {
            Spot current = EvtDB.get_cust_spot(user.get_email());
            Spotd NewForm = new Spotd(ActDB, EvtDB, user, current);
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            NewForm.label6.Text = current.holdeeID;
            NewForm.label7.Text = current.get_cost().ToString();
            NewForm.textBox3.Text = current.get_spotdesc();
            this.Hide();
        }
    }
}
