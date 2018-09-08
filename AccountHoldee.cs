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
    public partial class AccountHoldee : Form
    {
        public AccountHoldee(account_head Account_Database, Event_Controller Event_Database, account_info account)
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

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeHoldee NewForm = new HomeHoldee(ActDB, EvtDB, user);
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchHoldee NewForm = new SearchHoldee(ActDB, EvtDB, user);
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            this.Hide();
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            PostHoldee NewForm = new PostHoldee(ActDB, EvtDB, user);
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            this.Hide();
        }

        private void AccountButton_Click(object sender, EventArgs e)
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

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            Account NewForm = new Account(ActDB, EvtDB, user);
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            NewForm.label2.Text = user.get_email();
            NewForm.button2.Hide();
            NewForm.label6.Text = "Holdee";
            if (EvtDB.check_cust_spot(user.get_email()) == true)
                NewForm.button3.Show();
            else
                NewForm.label8.Show();
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

        private void Spot_Button_Click(object sender, EventArgs e)
        {
            Spot current = EvtDB.get_holdee_spot(user.get_email());
            SpotHoldee NewForm = new SpotHoldee(ActDB, EvtDB, user, current);
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            NewForm.label6.Text = current.get_customerid();
            NewForm.label7.Text = current.get_cost().ToString();
            NewForm.textBox3.Text = current.get_spotdesc();
            this.Hide();
        }
    }
}
