using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class loginscreen : Form
    {

        public loginscreen()
        {
            InitializeComponent();

            //Strings to allow user to change all colors of something at once. More efficient than Visual Studio's way of doing it individually
            string hexColorBack = "#57A0BC";
            string hexColorText = "#FFFFFF";// #D9AC84 or #002121 or 87714D or FFDC8C
            string hexColorTextBox = "#FFFFFF";//D9D9D9 or A3AAAE

            //Convert given strings to Color
            Color colorBack = System.Drawing.ColorTranslator.FromHtml(hexColorBack);
            Color colorText = System.Drawing.ColorTranslator.FromHtml(hexColorText);
            Color colorTextBox = System.Drawing.ColorTranslator.FromHtml(hexColorTextBox);

            //change background color for form
            this.BackColor = colorBack;

            //Array of labels to change all text color at once
            Label[] labels = {  username, password};
            for (int i = 0; i < labels.Count(); i++)
            {
                labels[i].ForeColor = colorText;
            }

            //Array of textboxes to change color of all text boxes at once
            TextBox[] boxes = { usernameTxt, passTxt };
            for (int i = 0; i < boxes.Count(); i++)
            {
                boxes[i].BackColor = colorTextBox;
            }
        }

        //User Login
        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                List<LoginModel> login = SqliteDataAccess.passwordFetch(usernameTxt.Text);
                string teacher = login[0].user_ID;
                string storedp = login[0].password;
                string salt = login[0].salt;
                string password = passTxt.Text;

                if (compareHash(password, storedp, salt))
                {
                    this.Hide();
                    new Home(teacher).Show();
                }
                else
                {
                    MessageBox.Show("Incomplete Login Information.");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Incomplete Login Information");
            }
        }
        private void passTxt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && passTxt.Text != null && usernameTxt.Text != null)
                {
                    List<LoginModel> login = SqliteDataAccess.passwordFetch(usernameTxt.Text);
                    string teacher = login[0].user_ID;
                    string storedp = login[0].password;
                    string salt = login[0].salt;
                    string password = passTxt.Text;

                    if (compareHash(password, storedp, salt))
                    {
                        this.Hide();
                        new Home(teacher).Show();
                    }
                    else
                    {
                        MessageBox.Show("Incomplete Login Information.");
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Incomplete Login Information");
            }
        }
        private void usernameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && passTxt.Text != null && usernameTxt.Text != null)
                {
                    List<LoginModel> login = SqliteDataAccess.passwordFetch(usernameTxt.Text);
                    string teacher = login[0].user_ID;
                    string storedp = login[0].password;
                    string salt = login[0].salt;
                    string password = passTxt.Text;

                    if (compareHash(password, storedp, salt))
                    {
                        this.Hide();
                        new Home(teacher).Show();
                    }
                    else
                    {
                        MessageBox.Show("Login inforamtion is incorrect.");
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Login information is incorrect");
            }
        }
        //Gets the hash of the attemped password with stored salt.
        public static byte[] getHash(string password, string salt)
        {
            byte[] unhashed = Encoding.Unicode.GetBytes(String.Concat(password, salt));

            SHA256Managed sha256 = new SHA256Managed();
            byte[] hashed = sha256.ComputeHash(unhashed);

            return hashed;
        }

        //Compares the stored passwored to the attempted password.
        public static bool compareHash(string password, string hash, string salt)
        {
            string base64Pass = Convert.ToBase64String(getHash(password, salt));
            return string.Equals(hash, base64Pass);
        }


        //Show form for the "About Project" form
        private void abtButton_Click(object sender, EventArgs e)
        {
            new About().Show();
        }
    }
}
