using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    // right-click WindowsFormsApplication1
    // click Add --> Reference
    // search Microsoft.VisualBasic
    // using Microsoft.VisualBasic;
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        int start = 12;
        int index = 0;
        Button[] classArray;
        Boolean click;

        private void button4_Click(object sender, EventArgs e)
        {



            classArray = new Button[100];



            classArray[index] = new Button();
            classArray[index].Size = new Size(117, 53);
            classArray[index].Location = new Point(start, 200);
            classArray[index].Text = Interaction.InputBox("Enter Name of Class", "Class", "Class Name", -1, -1);

            if (classArray[index].Text != null)
            {
                Controls.Add(classArray[index]);
            }


            if (classArray[index].Text == "")
            {
                Controls.Remove(classArray[index]);
                start -= 117;
                index--;
            }

            index++;
            start += 117;



        }


        private void button5_Click_1(object sender, EventArgs e)
        {

            // String removeClass = Interaction.InputBox("Enter Class You Want to Remove", "Class", "Class Name", -1, -1);

            //  if (classArray[index].Text ==  remove)
            //  {
            // Controls.Remove(classArray[index]);
            // }




        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginscreen().Show();
        }



    }
}