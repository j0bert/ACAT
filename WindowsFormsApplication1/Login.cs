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

            string hexColorBack = "#011E41";
            string hexColorText = "#FFDC8C";// #D9AC84 or #002121 or 87714D or FFDC8C
            string hexColorTextBox = "#D9D9D9";//D9D9D9 or A3AAAE

            Color colorBack = System.Drawing.ColorTranslator.FromHtml(hexColorBack);
            Color colorText = System.Drawing.ColorTranslator.FromHtml(hexColorText);
            Color colorTextBox = System.Drawing.ColorTranslator.FromHtml(hexColorTextBox);

            this.BackColor = colorBack;

            Label[] labels = {  username, password};
            for (int i = 0; i < labels.Count(); i++)
            {
                labels[i].ForeColor = colorText;
            }

            TextBox[] boxes = { usernameTxt, passTxt };
            for (int i = 0; i < boxes.Count(); i++)
            {
                boxes[i].BackColor = colorTextBox;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Class().Show();
        }
    }
}
