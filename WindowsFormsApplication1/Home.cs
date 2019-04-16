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

            ClassesView.Columns.Add("CRN",73);
            ClassesView.Columns.Add("Class Name", 248);
            ClassesView.Columns.Add("Semester/Year", 123);
            

           
        }


        private void addClass( String crn, String className, String semesterYear)
        {
           
            
            String[] rowClass = {crn, className, semesterYear };
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
            CRNText.Text = "";
            SemesterYearText.Text = "";

        }


        private void Add_Button_Click(object sender, EventArgs e)
        {
            addClass(CRNText.Text, ClassText.Text,SemesterYearText.Text);

            ClassText.Text = "";
            CRNText.Text = "";
            SemesterYearText.Text = "";
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            removeClass();
        }

        private void ClassesView_MouseClick(object sender, MouseEventArgs e)
        {
            CRNText.Text = ClassesView.SelectedItems[0].SubItems[0].Text;
            ClassText.Text = ClassesView.SelectedItems[0].SubItems[1].Text;
            SemesterYearText.Text = ClassesView.SelectedItems[0].SubItems[2].Text;

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

            //CRNText.Text = ClassesView.SelectedItems[0].SubItems[0].Text;
            //ClassText.Text = ClassesView.SelectedItems[0].SubItems[1].Text;
            //SemesterYearText.Text = ClassesView.SelectedItems[0].SubItems[2].Text;
        }

        private void ClassesView_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }
    }
}