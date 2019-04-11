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

            ClassesView.View = View.Details;
            ClassesView.FullRowSelect = true;

            ClassesView.Columns.Add("ID",30);
            ClassesView.Columns.Add("Class Name", 150);
            ClassesView.Columns.Add("Semester", 75);
            ClassesView.Columns.Add("Year", 75);

           
        }

        int id = 0;

        private void addClass( String className, String semester, String year)
        {
           
            id++;
            String[] rowClass = {id.ToString(), className, semester, year };
            ListViewItem course = new ListViewItem(rowClass);
            ClassesView.Items.Add(course);

        }

        private void removeClass()
        {
           
            if (MessageBox.Show("Are You Sure?", "REMOVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ClassesView.Items.RemoveAt(ClassesView.SelectedIndices[0]);
            }

            ClassText.Text = "";
            SemesterText.Text = "";
            YearText.Text = "";

        }


        private void Add_Button_Click(object sender, EventArgs e)
        {
            addClass(ClassText.Text,SemesterText.Text,YearText.Text);

            ClassText.Text = "";
            SemesterText.Text = "";
            YearText.Text = "";
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            removeClass();
        }

        private void ClassesView_MouseClick(object sender, MouseEventArgs e)
        {
            ClassText.Text = ClassesView.SelectedItems[0].SubItems[0].Text;
            SemesterText.Text = ClassesView.SelectedItems[0].SubItems[1].Text;
            YearText.Text = ClassesView.SelectedItems[0].SubItems[2].Text;

        }
    
        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginscreen().Show();
        }

        private void ClassesView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new Class().Show();
        }
    }
}