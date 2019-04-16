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
        List<LearningOutcomeModel> outcome = new List<LearningOutcomeModel>();
        List<MissionObjectiveModel> objective = new List<MissionObjectiveModel>();
        List<AssessmentModel> assessment = new List<AssessmentModel>();
        List<ABETModel> Abet = new List<ABETModel>();

        public Class()
        {
            InitializeComponent();
            LoadLearningOutcomesList();
            LoadMissionObjectivesList();
            LoadAssessmentList();
        }

        //Methods to load the information from the database into a form that can be shown and changed by the app.
        private void LoadLearningOutcomesList()
        {
            outcome = SqliteDataAccess.LoadLearningOutcome();
            for(int i = 0; i < outcome.Count; i++)
            {
                dataGridViewLO.Rows.Add(outcome[i].OutcomeID, outcome[i].outcome);
            }
        }
        private void LoadMissionObjectivesList()
        {
            objective = SqliteDataAccess.LoadMissionObjective();
            Abet = SqliteDataAccess.LoadABET();
            for(int i = 0; i < objective.Count; i++)
            {
                dataGridViewMissionObj.Rows.Add(objective[i].missionObjectiveID, objective[i].missionObjective);
            }
        }
        private void LoadAssessmentList()
        {
            assessment = SqliteDataAccess.LoadAssessment();
            for (int i = 0; i < assessment.Count; i++)
            {
                dataGridView1.Rows.Add(assessment[i].AssessmentID, assessment[i].assessmentName, "", "", assessment[i].average, assessment[i].standardDeviation);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

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
            for (int i = 1; i <= 7; i++)
            {
                switch (i)
                {
                    case 1:
                        worksheet.Cells[1, i] = "Learning Outcomes";
                        break;
                    case 2:
                        worksheet.Cells[1, i] = "Misssion Objective(s)";
                        break;
                    case 3:
                        worksheet.Cells[1, i] = "ABET learning Outcomes";
                        break;
                    case 4:
                        worksheet.Cells[1, i] = "Evaluation Instrument";
                        break;
                    case 5:
                        worksheet.Cells[1, i] = "Avg (%)";
                        break;
                    case 6:
                        worksheet.Cells[1, i] = "Program Outcome";
                        break;
                    case 7:
                        worksheet.Cells[1, i] = "Avg";
                        break;
                    default:
                        worksheet.Cells[1, i] = "Opps!";
                        break;
                }
            }
            for (int i = 1; i <= 4; i++)
            {
                switch (i)
                {
                    case 1:
                        worksheet.Cells[i + 17, 1] = "Mission Objectives";
                        break;
                    case 2:
                        worksheet.Cells[i + 24, 1] = "ABET Learning Outcomes";
                        worksheet.Cells[i + 25, 1] = "The program enables students to achieve, by the time of graduation:";
                        break;
                    case 3:
                        worksheet.Cells[i + 26, 1] = "1. General:";
                        break;
                    case 4:
                        worksheet.Cells[i + 37, 1] = "2. CS Specific:";
                        break;
                    default:
                        worksheet.Cells[1 + 50, 1] = "Opps!";
                        break;
                }
            }
            //i is x axis j is y axis
            // storing Each row and column value in Mission Objectives
            for (int i = 0; i < dataGridViewMissionObj.Rows.Count - 1; i++)
            {
                for (int j = 1; j < dataGridViewMissionObj.Columns.Count - 1; j++)
                {
                    worksheet.Cells[i + 20, j] = objective[i].missionObjectiveID.ToString()+ ". " + objective[i].missionObjective.ToString();


                }
            }
            for (int i = 0; i < dataGridViewLO.Rows.Count - 1; i++)
            {
                for (int j = 1; j < dataGridViewLO.Columns.Count - 1; j++)
                {
                    worksheet.Cells[i + 15, j] = i + 1 + ". " + dataGridViewLO.Rows[i].Cells[j].Value.ToString();


                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginscreen().Show();
        }

        private void addAssesment_Click(object sender, EventArgs e)
        {

        }

        private void AssesmentName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewLO_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewLO.Rows[e.RowIndex];
                OutcomeDesc_txt.Text = row.Cells["OutcomeDesc"].Value.ToString();
            }
        }

        private void dataGridViewMissionObj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewMissionObj.Rows[e.RowIndex];
                ObjDesc_txt.Text = row.Cells["objDesc"].Value.ToString();
                ABETLearningObjDesc_txt.Text = row.Cells["abetLearningObj"].Value.ToString();
            }
        }
    }
}