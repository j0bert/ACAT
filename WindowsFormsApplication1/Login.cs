using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            this.Hide();
            new Home().Show();
        }

        //ERASE LATER: TESTING PURPOSES ONLY
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Class().Show();
        }

        //Show form for the "About Project" form
        private void abtButton_Click(object sender, EventArgs e)
        {
            new About().Show();
        }
    }
}
