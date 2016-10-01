using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Pragati_Judge
{
    public partial class Login : Form
    {
        public Login()
        {           
            InitializeComponent();
        }

        private void cmdLoginExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            validateUser(txtLoginName.Text, txtLoginPass.Text);
        }

        private void validateUser(string loginName, string password)
        {
            DbaseHandler obj = new DbaseHandler();
            bool valid = false;
            try
            {
                valid = (obj.userValid(loginName, password));
            }
            catch (Exception) { MessageBox.Show(" Database connection failure, contact pragati co ordinators"); Application.Exit(); }
            if (valid)
            {
                Team temp;
                temp = obj.getTeamUsingName(loginName);
                this.Hide();
                (new HomeApp(loginName,temp.Score,temp.ID)).ShowDialog();
                if(this!=null)
                    this.Show();
            }
            else
                wrongInfoEntered();
        }

        private void wrongInfoEntered()
        {
            MessageBox.Show(" Invalid login information ");
            clearLoginForm();
        }

        private void clearLoginForm()
        {
            // Clear All fields of Login form
            txtLoginName.Text = "";
            txtLoginPass.Text = "";
        }

    }
}