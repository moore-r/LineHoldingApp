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
    public partial class SpotHoldee : Form
    {
        public SpotHoldee(account_head Account_Database, Event_Controller Event_Database, account_info account, Spot view)
        {
            ActDB = Account_Database;
            EvtDB = Event_Database;
            user = account;
            current = view;
            InitializeComponent();
        }
        private account_head ActDB;
        private Event_Controller EvtDB;
        private account_info user;
        private Spot current;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(current.get_taken() == true)
                this.label6.Text = current.get_customerid();
            this.label7.Text = current.get_cost().ToString();
            this.textBox3.Text = current.get_spotdesc();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            AccountHoldee NewForm = new AccountHoldee(ActDB, EvtDB, user);
            EvtDB.delete_spot(user.get_email());
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            NewForm.label2.Text = user.get_email();
            this.Hide();
            if (EvtDB.check_spot(user.get_email()) == false)
                NewForm.label8.Show();
            else
                NewForm.button3.Show();
        }
    }
}
