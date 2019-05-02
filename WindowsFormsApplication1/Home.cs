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
        private ListViewColumnSorter lvwColumnSorter;
        private List<TeacherModel> teacher;
        private List<ClassModel> classes;
        private string CRN;
        private string username;

        public Home(string username)
        {
            InitializeComponent();
            this.teacher = SqliteDataAccess.LoadTeacher(username);
            this.classes = SqliteDataAccess.LoadClass(teacher[0].techer_ID);
            this.username = username;

            label1.Text = teacher[0].firstName + " " + teacher[0].lastName;

            lvwColumnSorter = new ListViewColumnSorter();
            this.ClassesView.ListViewItemSorter = lvwColumnSorter;

            ClassesView.View = View.Details;
            ClassesView.FullRowSelect = true;

            ClassesView.Columns.Add("CRN", 73);
            ClassesView.Columns.Add("Class Name", 248);
            ClassesView.Columns.Add("Semester", 80);
            ClassesView.Columns.Add("Year", 43);

            foreach (ClassModel course in classes)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = course.CRN;
                lvi.SubItems.Add(course.className);
                lvi.SubItems.Add(course.semester);
                lvi.SubItems.Add(course.year);

                ClassesView.Items.Add(lvi);
            }

        }


        private void addClass(String crn, String className, String semester, string year)
        {

            String[] rowClass = { crn, className, semester, year };
            ListViewItem course = new ListViewItem(rowClass);
            ClassModel item = new ClassModel();

            item.CRN = crn;
            item.className = className;
            item.semester = semester;
            item.year = year;
            item.comments = "";
            item.teacher_ID = teacher[0].techer_ID;
            SqliteDataAccess.SaveClass(item);
            classes = SqliteDataAccess.LoadClass(teacher[0].techer_ID);

            ClassesView.Items.Add(course);
        }

        private void removeClass()
        {

            if (MessageBox.Show("Are You Sure?", "REMOVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ListViewItem item = ClassesView.SelectedItems[0];
                SqliteDataAccess.DeleteAssessment(item.Text);
                SqliteDataAccess.DeleteLearningOutcome(item.Text);
                SqliteDataAccess.DeleteMissionObjective(item.Text);
                SqliteDataAccess.DeleteClass(item.Text);
                classes = SqliteDataAccess.LoadClass(teacher[0].techer_ID);

                ClassesView.Items.RemoveAt(ClassesView.SelectedIndices[0]);
            }

            ClassText.Text = "";
            CRNText.Text = "";
            SemesterText.Text = "";
            yearText.Text = "";

        }


        private void Add_Button_Click(object sender, EventArgs e)
        {
            addClass(CRNText.Text, ClassText.Text, SemesterText.Text, yearText.Text);

            ClassText.Text = "";
            CRNText.Text = "";
            SemesterText.Text = "";
            yearText.Text = "";
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            removeClass();
        }

        private void ClassesView_MouseClick(object sender, MouseEventArgs e)
        {
            CRNText.Text = ClassesView.SelectedItems[0].SubItems[0].Text;
            ClassText.Text = ClassesView.SelectedItems[0].SubItems[1].Text;
            SemesterText.Text = ClassesView.SelectedItems[0].SubItems[2].Text;
            yearText.Text = ClassesView.SelectedItems[0].SubItems[3].Text;

        }

        

        private void ClassesView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CRN = ClassesView.SelectedItems[0].Text;
            this.Hide();
            new Class(CRN, username).Show();

            //CRNText.Text = ClassesView.SelectedItems[0].SubItems[0].Text;
            //ClassText.Text = ClassesView.SelectedItems[0].SubItems[1].Text;
            //SemesterYearText.Text = ClassesView.SelectedItems[0].SubItems[2].Text;
        }

        private void ClassesView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {

                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            this.ClassesView.Sort();
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new loginscreen().Show();
        }

        private void Sync_Button_Click(object sender, EventArgs e)
        {
           // var sync = new DatabaseSync.Desktop.Sync();

           // sync.Show();
        }
    }
}