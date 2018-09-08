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
    public partial class AccountCreation : Form
    {
        public AccountCreation(account_head Account_Database, Event_Controller Event_Database)
        {
            ActDB = Account_Database;
            EvtDB = Event_Database;
            InitializeComponent();
        }
        private account_head ActDB;
        private Event_Controller EvtDB;

        private void Create_Account_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text == this.textBox3.Text)
                this.label3.Hide();

            if (ActDB.search_list(this.textBox1.Text) == true)
                this.label2.Show();
            else if (this.textBox2.Text != this.textBox3.Text)
            {
                this.label2.Hide();
                this.label3.Show();
            }
            else
            {
                ActDB.create_account(this.textBox1.Text, this.textBox2.Text);
                Home NewForm = new Home(ActDB, EvtDB, ActDB.get_info(this.textBox1.Text));
                NewForm.Show();
                NewForm.Left = this.Left;
                NewForm.Top = this.Top;
                NewForm.Size = this.Size;
                this.Hide();
            }//end else
        }//end Create account click
    }
}
