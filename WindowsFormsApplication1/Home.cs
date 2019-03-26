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
    public partial class Home : Form
    {

        Boolean button5_clicked = false;

        public Home()
        {
            InitializeComponent();
        }


        int start = 12;
        Button b;
        private void button4_Click(object sender, EventArgs e)
        {

            Point newLoc = new Point(start, 200);
            b = new Button();

            b.Size = new Size(117, 53);
            b.Location = newLoc;
            Controls.Add(b);

            start += 117;

        }


      

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginscreen().Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5_clicked = true;

            Controls.Remove(b);
            start -= 117;



            if (start < 12)
            {
                start = 12;
            }



        }
    }
}