using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hold_It_App
{
    // account_node contains all of the information needed for a node in the LLL of accounts
    public class account_node
    {
        private account_info current_account; // the instance of account info that is stored in the node
        private account_node next; // the next node in the LLL
        private account_node previous; // the previous node in the LLL

        public account_node(account_info new_account)
        {
            current_account = new_account;
            next = null;
            previous = null;
        }

        // changes the current_account in the node to the new_accound passed into the method
        public bool set_current_account(account_info new_account)
        {
            current_account = new_account;
            return true;
        }

        // returns the account_info stored in the current node
        public account_info get_current_account()
        {
            return current_account;
        }

        // sets the next node to the set_next node passed into the method
        public bool set_an_next(account_node set_next)
        {
            next = set_next;
            return true;
        }

        // sets the previous node to the set_previous node passed into the method
        public bool set_an_previous(account_node set_previous)
        {
            previous = set_previous;
            return true;
        }

        // returns the next node in the LLL
        public account_node go_next()
        {
            return next;
        }

        // returns the previous node in the LLL
        public account_node go_previous()
        {
            return previous;
        }
    }

    // the front of the LLL of accounts, manages accounts
    public class account_head
    {
        private account_node next;
        private int node_count;
        private account_node found_account;

        // searches the LLL of accounts to see if the name_attempt already exists
        public bool search_list(string name_attempt)
        {
            if (node_count < 1) // no nodes in the list
                return false;

            account_info temp;
            account_node temp_node = next;
            for(int i = 0;  i < node_count; ++i) // loop to check each node in the list
            {
                temp = temp_node.get_current_account();
                if (temp.check_email(name_attempt))
                {
                    found_account = temp_node;
                    return true;
                }
                temp_node = temp_node.go_next();
            }
            return false; 
        }

        // adds a new node to the LLL with the account_info passed into the method
        public bool add_node(account_info new_account)
        {
            if (node_count < 1) // if there are no nodes in the LLL
            {
                next = new account_node(new_account);
                node_count += 1;
                return true;
            }

            // if there are nodes in the LLL
            account_node temp = next;
            next = new account_node(new_account);
            next.set_an_next(temp);
            node_count += 1;
            return true;
        }

        // creates a new account_info object with the email address and password passed into the method
        public bool create_account(string new_email, string password)
        {
            if (search_list(new_email)) // checks to see if email already exists
                return false;
            account_info temp = new account_info(new_email, password);
            return add_node(temp); // adds account to the LLL
        }

        // looks through the LLL to see if the email and password passed into the method exist in the list
        public bool check_info(string email, string password)
        {
            if (!search_list(email)) // checks to see if the email exists in the LLL
                return false;

            account_info temp = found_account.get_current_account();
            return temp.check_password(password); // checks to see if the password matches the account
        }

        // returns the account_info for the email passed in to the method, only call method if you know the email exists
        public account_info get_info(string email)
        {
            search_list(email);
            return found_account.get_current_account();
        }
    }
}
