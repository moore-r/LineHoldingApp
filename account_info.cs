using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hold_It_App
{
    //the account_info class contains all of the information contained in someones account
    public class account_info
    {
        private string email_address;
        private string password;
        private bool is_holdee; // true if user is a holdee, false if they are a customer

        public account_info(string new_email, string new_password)
        {
            email_address = new_email;
            password = new_password;
            is_holdee = false;
        }

        // get_email returns the email address on file for the account
        public string get_email()
        {
            return email_address;
        }

        // set_email sets the email address of the account to the new_email passed into the function
        public bool set_email(string new_email)
        {
            email_address = new_email;
            return true;
        }

        // check_email returns true if the test_email passed in is the same as the email address in the account. If not returns false
        public bool check_email(string test_email)
        {
            if (email_address == test_email)
                return true;
            return false;
        }

        // check_password returns true if the password passed in matched the password for the account 
        public bool check_password(string attempt)
        {
            if (password == attempt)
                return true;
            return false;
        }

        // set_password changes the password stored for the account to the new_pw that was passed in
        public bool set_password(string new_pw)
        {
            password = new_pw;
            return true;
        }

        // check_status returns true if the is_holdee bool is true, otherwise returns false
        public bool check_status()
        {
            if (is_holdee == true)
                return true;
            return false;
        }

        // set_status changes the is_holdee bool to the new_status passed into the funtion
        public bool set_status(bool new_status)
        {
            is_holdee = new_status;
            return true;
        }
    }
}
