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
    public partial class EventHoldee : Form
    {
        public EventHoldee(account_head Account_Database, Event_Controller Event_Database, account_info account, Event eve)
        {
            ActDB = Account_Database;
            EvtDB = Event_Database;
            user = account;
            Evt = eve;
            InitializeComponent();
        }
        private account_head ActDB;
        private Event_Controller EvtDB;
        private account_info user;
        private Event Evt;

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
            this.Hide();
            if (EvtDB.check_spot(user.get_email()) == false)
                NewForm.label8.Show();
            else
                NewForm.button3.Show();
        }

        private void Combobox_Button_Click(object sender, EventArgs e)
        {
            this.label5.Show();
            this.label6.Show();
            this.label8.Show();
            this.textBox3.Show();
            Spot view = EvtDB.get_holdee_spot(this.comboBox1.Text);
            this.label5.Text = view.get_cost().ToString();
            this.textBox3.Text = view.get_spotdesc();
        }

        private void EventHoldee_Load(object sender, EventArgs e)
        {

        }
    }
}
