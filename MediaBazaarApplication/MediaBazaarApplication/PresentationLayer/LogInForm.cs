using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace MediaBazaarApplication
{
    public partial class LogInForm : Form
    {
        private LoginLogic loginLogic;
        public LogInForm()
        {
            InitializeComponent();
            loginLogic = new LoginLogic();
        }        

        private void btnWin2_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = true;
            pnlLogIn.Visible = false;
        }

        private void btnWin1_Click(object sender, EventArgs e)
        {
            pnlLogIn.Visible = true;
            pnlRegister.Visible = false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(loginLogic.LogIn(tbEmail.Text, tbPassword.Text))
            {
                this.Close();
            }
        }

        private void btnSetPass_Click(object sender, EventArgs e)
        {
            if (loginLogic.SetPassword(tbEmail2.Text,tbNewPassword.Text, tbOldPassword.Text))
            {
                pnlLogIn.Visible = true;
                pnlRegister.Visible = false;
            }

        }

        private void LogInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
                
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        #region Press "Enter" event 
        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn_Click(this, new EventArgs());
            }
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn_Click(this, new EventArgs());
            }
        }

        private void tbEmail2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSetPass_Click(this, new EventArgs());
            }
        }

        private void tbOldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSetPass_Click(this, new EventArgs());
            }
        }

        private void tbNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSetPass_Click(this, new EventArgs());
            }
        }
        #endregion

        #region Show/Hide Password button functionality

        private void btnViewPassword_MouseHover(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
        }

        private void btnViewPassword_MouseLeave(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnShowOldPassword_MouseHover(object sender, EventArgs e)
        {
            tbOldPassword.UseSystemPasswordChar = false;
        }

        private void btnShowOldPassword_MouseLeave(object sender, EventArgs e)
        {
            tbOldPassword.UseSystemPasswordChar = true;
        }

        private void btnShowNewPassword_MouseHover(object sender, EventArgs e)
        {
            tbNewPassword.UseSystemPasswordChar = false;
        }

        private void btnShowNewPassword_MouseLeave(object sender, EventArgs e)
        {
            tbNewPassword.UseSystemPasswordChar = true;
        }
        #endregion
    }

}
