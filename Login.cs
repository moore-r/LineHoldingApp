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
    public partial class Login : Form
    {
        private account_head ActDB;
        private Event_Controller EvtDB;

        public Login(account_head Account_Database, Event_Controller Event_Database)
        {
            ActDB = Account_Database;
            EvtDB = Event_Database;
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string user = this.textBox1.Text;
            string pass = this.textBox2.Text;
            if (ActDB.check_info(user, pass) == true)
            {
                Home NewForm = new Home(ActDB, EvtDB, ActDB.get_info(user));
                NewForm.Show();
                NewForm.Left = this.Left;
                NewForm.Top = this.Top;
                NewForm.Size = this.Size;
                this.Hide();
            }
            else
                this.label1.Show();
        }

        private void Create_Account_Click(object sender, EventArgs e)
        {
            AccountCreation NewForm = new AccountCreation(ActDB, EvtDB);
            NewForm.Show();
            NewForm.Left = this.Left;
            NewForm.Top = this.Top;
            NewForm.Size = this.Size;
            this.Hide();
        }
    }
}
