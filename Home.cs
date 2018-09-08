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
    public partial class Home : Form
    {
        public Home(account_head Account_Database, Event_Controller Event_Database, account_info account)
        {
            ActDB = Account_Database;
            EvtDB = Event_Database;
            user = account;
            InitializeComponent();
        }
        private account_head ActDB;
        private Event_Controller EvtDB;
        private account_info user;

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
    }
}
