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
