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
        public Home()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Point newLoc = new Point(12, 200); // Set whatever you want for initial location

                Button b = new Button();
                b.Size = new Size(50, 50);
                b.Location = newLoc;
                Controls.Add(b);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginscreen().Show();
        }
    }
}
