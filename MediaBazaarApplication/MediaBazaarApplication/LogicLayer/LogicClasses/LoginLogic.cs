using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace MediaBazaarApplication
{
    public class LoginLogic
    {
        Employee user;
        DBLogin loginDB = new DBLogin();


        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        public bool LogIn(string _email, string _password)
        {
            //string password = Encrypt(_password); 
           
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(_email);
            if (match.Success)
            {

                string dbPassword = loginDB.GetPassword(_email);
                bool doesPasswordMatch = Hashing.ValidatePassword(_password, dbPassword);
                if (doesPasswordMatch == true)
                {
                    try
                    {
                        loginDB.GetUser(_email);
                        user = loginDB.GetUser(_email);
                        if (user != null)
                        {
                            if (user.GetRole() == "Manager" || user.GetRole() == "Admin")
                            {
                                MainForm form = new MainForm(user);
                                try
                                {
                                    form.Show();
                                }
                                catch (InvalidOperationException)
                                {
                                    form.Show();
                                }
                            }
                            else if (user.GetRole() == "Employee")
                            {
                                EmployeeView form = new EmployeeView(user);
                                try
                                {
                                    form.Show();
                                }
                                catch (InvalidOperationException)
                                {
                                    form.Show();
                                }
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }

                    return true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Incorrect email or password!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Incorrect email format!", "Email", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        public bool SetPassword(string _email, string _newPassword, string _oldPassword)
        {
            string correctOldPassword = loginDB.GetPassword(_email);
            bool doesPasswordMatch = Hashing.ValidatePassword(_oldPassword, correctOldPassword);
            string email = _email;
            string newPassword = Hashing.HashPassword(_newPassword);
            string oldPassword = _oldPassword;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(_email);
            if (match.Success)
            {
                
                if (doesPasswordMatch == true)
                {
                    loginDB.SetPassword(_email, newPassword);
                    return true;
                }
                return false;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Incorrect email format!");
                return false;
            }
        }


    }
}
