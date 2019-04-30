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
    public partial class Class : Form
    {
        private string username;
        private string CRN;
        List<ClassModel> classes;
        List<LearningOutcomeModel> outcomes;
        List<MissionObjectiveModel> objectives;
        List<AssessmentModel> assessments;
        List<ABETModel> abet = SqliteDataAccess.LoadABET();

        public Class(string CRN, string username)
        { 
            InitializeComponent();
            this.username = username;
            this.CRN = CRN;
            this.classes = SqliteDataAccess.LoadClassViaCRN(CRN);
            label2.Text = this.classes[0].className + " Dashboard";
            
            //Strings to allow user to change all colors of something at once. More efficient than Visual Studio's way of doing it individually
            string hexColorBack = "#FFFFFF"; 
            string hexColorSplitContainerHalves = "#57A0BC";
            string hexColorText = "#FFFFFF";// #D9AC84 or #002121 or 87714D or FFDC8C
            string hexColorTextBox = "#FFFFFF";

            //Convert given strings to Color
            Color colorBack = System.Drawing.ColorTranslator.FromHtml(hexColorBack);
            Color colorSplitHalves = System.Drawing.ColorTranslator.FromHtml(hexColorSplitContainerHalves);
            Color colorText = System.Drawing.ColorTranslator.FromHtml(hexColorText);
            Color colorTextBox = System.Drawing.ColorTranslator.FromHtml(hexColorTextBox);

            //Edit splitContainer halves as well as background bar in the middle splitting the two panels
            splitContainer1.BackColor = colorBack;
            splitContainer1.Panel1.BackColor = colorSplitHalves;
            splitContainer1.Panel2.BackColor = colorSplitHalves;

            //Array of labels to change all text color at once
            Label[] labels = { label1, label2, label3, label4, label5, label8, label9 };
            for (int i = 0; i < labels.Count(); i++)
            {
                labels[i].ForeColor = colorText;
            }

            //Array of textboxes to change color of all text boxes at once
            TextBox[] boxes = { OutcomeDesc_txt, ObjDesc_txt, ABETLearningObjDesc_txt, textBox2 };
            for (int i = 0; i < boxes.Count(); i++)
            {
                boxes[i].BackColor = colorTextBox;
            }

            //Initialize the Lists
            outcomes = SqliteDataAccess.LoadLearningOutcome(CRN);
            objectives = SqliteDataAccess.LoadMissionObjective(CRN);
            assessments = SqliteDataAccess.LoadAssessment(CRN);

            //Fill the DataGrids with any information pertaining to the class.
            foreach (LearningOutcomeModel model in outcomes)
            {
                dataGridViewLO.Rows.Add(model.outcome_ID, model.description_LO);
            }

            foreach(MissionObjectiveModel model in objectives)
            {
                dataGridViewMissionObj.Rows.Add(model.objective_ID, model.description_MO);
            }

            foreach (AssessmentModel model in assessments)
            {
                dataGridView1.Rows.Add(model.title, model.high, model.mid, model.low, model.average, model.standardDeviation);
            }

            foreach(ABETModel model in abet)
            {
                dataGridViewABET.Rows.Add(model.abet_ID, model.description_ABET);
            }

            textBox2.Text = classes[0].comments;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Work in Progress!!!!!
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }

        //Logs user out
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginscreen().Show();
        }

        //Goes to Home Page
        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home(username).Show();
        }

        //Displays content of Learning Objective selected in text box
        private void dataGridViewLO_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewLO.Rows[e.RowIndex];
                OutcomeDesc_txt.Text = row.Cells["OutcomeDesc"].Value.ToString();
            }
        }

        //Displays content of Mission Objective selected in text box
        private void dataGridViewMissionObj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewMissionObj.Rows[e.RowIndex];
                ObjDesc_txt.Text = row.Cells["objDesc"].Value.ToString();
            }
        }

        //Displays content of ABET Learning Objective selected in text box
        private void dataGridViewABET_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewABET.Rows[e.RowIndex];
                ABETLearningObjDesc_txt.Text = row.Cells["abetLearningObj"].Value.ToString();
            }
        }

        //Push user written/edited Outcome Description to DataGridView's current cell
        private void pushOutcomeDesc_Click(object sender, EventArgs e)
        {
            dataGridViewLO.CurrentRow.Cells[1].Value = OutcomeDesc_txt.Text;
        }

        //Push user written/edited Objective Description to DataGridView's current cell
        private void pushObjDesc_Click(object sender, EventArgs e)
        {
            dataGridViewMissionObj.CurrentRow.Cells[1].Value = ObjDesc_txt.Text;
        }

        private void ButtonOutcomeUpdate_Click(object sender, EventArgs e)
        {
            outcomes.Clear();
            foreach(DataGridViewRow row in dataGridViewLO.Rows)
            {
                if(row.Cells[0].Value != null)
                {
                    LearningOutcomeModel model = new LearningOutcomeModel();
                    model.outcome_ID = row.Cells[0].Value.ToString();
                    model.description_LO = row.Cells[1].Value.ToString();
                    model.CRN = this.CRN;
                    outcomes.Add(model);
                }
            }

            SqliteDataAccess.DeleteLearningOutcome(CRN);
            foreach(LearningOutcomeModel model in outcomes)
            {
                SqliteDataAccess.SaveLearningOutcome(model);
            }
        }

        private void ButtonObjectiveUpdate_Click(object sender, EventArgs e)
        {
            objectives.Clear();
            foreach (DataGridViewRow row in dataGridViewMissionObj.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    MissionObjectiveModel model = new MissionObjectiveModel();
                    model.objective_ID = row.Cells[0].Value.ToString();
                    model.description_MO = row.Cells[1].Value.ToString();
                    model.CRN = this.CRN;
                    objectives.Add(model);
                }
            }

            SqliteDataAccess.DeleteMissionObjective(CRN);
            foreach (MissionObjectiveModel model in objectives)
            {
                SqliteDataAccess.SaveMissionObjective(model);
            }
        }

        private void ButtonAssessmentUpdate_Click(object sender, EventArgs e)
        {
            assessments.Clear();
            int i = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[0].Value.ToString() != "")
                {
                    AssessmentModel model = new AssessmentModel();
                    model.assessment_ID = i.ToString();
                    model.title = row.Cells[0].Value.ToString();
                    model.high = row.Cells[1].Value.ToString();
                    model.mid = row.Cells[2].Value.ToString();
                    model.low = row.Cells[3].Value.ToString();
                    model.average = row.Cells[4].Value.ToString();
                    model.standardDeviation = row.Cells[5].Value.ToString();
                    model.CRN = this.CRN;
                    assessments.Add(model);
                }
            }

            SqliteDataAccess.DeleteAssessment(CRN);
            foreach (AssessmentModel model in assessments)
            {
                SqliteDataAccess.SaveAssessment(model);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.updateComments(CRN, textBox2.Text);
        }
    }
}
//dataGridViewLO.Columns.Add("OutcomeDesc", OutcomeDesc_txt.Text); adds a new column altogether. could be useful later