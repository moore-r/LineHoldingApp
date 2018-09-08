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
    public partial class SearchHoldee : Form
    {
        public SearchHoldee(account_head Account_Database, Event_Controller Event_Database, account_info account)
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

        private void Search_Address_Button_Click(object sender, EventArgs e)
        {
            SearchHoldee NewForm = new SearchHoldee(ActDB, EvtDB, user);
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            if (EvtDB.checkaddress(this.textBox1.Text) == false)
                NewForm.label8.Show();
            else
            {
                Event eve = EvtDB.Edatabase.findaddress(this.textBox1.Text);
                NewForm.label3.Text = this.textBox1.Text;
                NewForm.label6.Text = eve.get_non_hidden_spots().ToString();
                NewForm.button1.Show();
                NewForm.label2.Show();
                NewForm.label5.Show();
                NewForm.label7.Show();
                NewForm.label6.Show();
                NewForm.label4.Show();
                NewForm.label3.Show();
            }
            this.Hide();
        }

        private void Event_Button_Click(object sender, EventArgs e)
        {
            Event Evt = EvtDB.Edatabase.findaddress(this.label3.Text);
            EventHoldee NewForm = new EventHoldee(ActDB, EvtDB, user, Evt);
            NewForm.Show();
            NewForm.label3.Text = Evt.get_address();
            for (int index = 0; index < Evt.get_non_hidden_spots(); index++)
                NewForm.comboBox1.Items.Add(Evt.transverse(index).get_holdeeid());
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            this.Hide();
        }
    }
}
