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
        int count = 0;

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
            int counter = 1;
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
                        worksheet.Cells[1, i].EntireRow.Font.Bold = true;
                        worksheet.Cells[1, i].EntireRow.Style.WrapText = false;

                        break;
                    case 2:
                        worksheet.Cells[1, i] = "Misssion Objective(s)";
                        worksheet.Cells[1, i].EntireRow.Font.Bold = true;
                        break;
                    case 3:
                        worksheet.Cells[1, i] = "ABET learning Outcomes";
                        worksheet.Cells[1, i].EntireRow.Font.Bold = true;
                        break;
                    case 4:
                        worksheet.Cells[1, i] = "Evaluation Instrument";
                        worksheet.Cells[1, i].EntireRow.Font.Bold = true;
                        break;
                    case 5:
                        worksheet.Cells[1, i] = "Avg (%)";
                        worksheet.Cells[1, i].EntireRow.Font.Bold = true;
                        break;
                    case 6:
                        worksheet.Cells[1, i] = "Program Outcome";
                        worksheet.Cells[1, i].EntireRow.Font.Bold = true;
                        break;
                    case 7:
                        worksheet.Cells[1, i] = "Avg";
                        worksheet.Cells[1, i].EntireRow.Font.Bold = true;
                        break;
                    default:
                        worksheet.Cells[1, i] = "Opps!";
                        break;
                }
            }
            for (int i = 0; i <= 2; i++)
            {
                switch (i)
                {
                    case 0:
                        worksheet.Cells[i + 17, 1] = "Mission Objectives";
                        worksheet.Cells[i + 17, 1].EntireRow.Font.Bold = true;
                        break;
                    case 1:
                        worksheet.Cells[i + 24, 1] = "ABET Learning Outcomes";
                        worksheet.Cells[i + 24, 1].EntireRow.Font.Bold = true;
                        worksheet.Cells[i + 25, 1] = "The program enables students to achieve, by the time of graduation:";
                        break;
                    case 2:
                        worksheet.Cells[i + 27, 1] = "1. General:";
                        worksheet.Cells[i + 27, 1].EntireRow.Font.Bold = true;
                        worksheet.Cells[i + 28, 1] = "(a) An ability to apply knowledge of computing and mathematics appropriate to the discipline";
                        worksheet.Cells[i + 29, 1] = "(b) An ability to analyze a problem, and identify and define the computing requirements appropriate to its solution;";
                        worksheet.Cells[i + 30, 1] = "(c) An ability to design, implement and evaluate a computer-based system, process, component, or program to meet desired needs;";
                        worksheet.Cells[i + 31, 1] = "(d) An ability to function effectively on teams to accomplish a common goal;";
                        worksheet.Cells[i + 32, 1] = "(e) An understanding of professional, ethical, legal, security, and social issues and responsibilities;";
                        worksheet.Cells[i + 33, 1] = "(f) An ability to communicate effectively with a range of audiences;";
                        worksheet.Cells[i + 34, 1] = "(g) An ability to analyze the local and global impact of computing on individuals, organizations and society, including ethical, legal, security and global policy issues;";
                        worksheet.Cells[i + 35, 1] = "(h) Recognition of the need for, and an ability to engage in, continuing professional development;";
                        worksheet.Cells[i + 36, 1] = "(i) An ability to use current techniques, skills, and tools necessary for computing practice.";
                        worksheet.Cells[i + 38, 1] = "2. CS Specific:";
                        worksheet.Cells[i + 38, 1].EntireRow.Font.Bold = true;
                        worksheet.Cells[i + 39, 1] = "(a) An ability to apply mathematical foundations, algorithmic principles, and computer science theory in the modeling and design of computer-based systems in a way that demonstrates comprehension of the tradeoffs involved in design choices;";
                        worksheet.Cells[i + 40, 1] = "(b) An ability to apply design and development principles in the construction of software systems of varying complexity.";
                        break;
                    default:
                        worksheet.Cells[1 + 37, 1] = "Opps!";
                        break;

                }

            }

            for (int i = 2; i <= 7; i++)
            {
                worksheet.Cells[1, i].WrapText = true;
            }
            worksheet.Cells[1, 1].ColumnWidth = 84.14;
            worksheet.Cells[1, 1].RowHeight = 26.25;
            // storing Each row and column value in Mission Objectives
            for (int i = 0; i <= objective.Count - 1; i++)
            {
                worksheet.Cells[i + 18, 1] = objective[i].missionObjectiveID.ToString() + ". " + objective[i].missionObjective.ToString();
            }
            for (int i = 0; i <= outcome.Count - 1; i++)
            {
                worksheet.Cells[i + 2, 1] = outcome[i].outcome.ToString();
            }
            this.Hide();
            new LearningOutcome().Show();
        }
            //
            // save the application  
            // workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            
           /* for (int i = 0; i <= 20; i++)
            {
                worksheet.Cells[counter + 2, 1] = outcome[counter].outcome.ToString();
                counter++;
                if (outcome[counter].outcome == null)
                {
                    worksheet.Cells[counter + 2, 1] = " ";
                    worksheet.Cells[counter + 3, 1] = "Mission Objectives";
                    worksheet.Cells[counter + 4, 1] = " ";
                    for (int j = 0; j <= 20; j++)
                    {
                        worksheet.Cells[counter + 5, 1] = objective[counter].missionObjectiveID.ToString() + ". " + objective[counter].missionObjective.ToString();
                        counter++;
                        if (objective[counter].missionObjective == null)
                        {
                            worksheet.Cells[counter + 6, 1] = " ";
                            worksheet.Cells[counter + 7, 1] = "ABET Learning Outcomes";
                            worksheet.Cells[counter + 8, 1] = " ";

                        }
                    }
                }
            }
        }
        */
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}