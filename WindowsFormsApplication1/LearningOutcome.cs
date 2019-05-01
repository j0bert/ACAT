using System;
using System.Collections;
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
    public partial class LearningOutcome : Form
    {
        List<LearningOutcomeModel> outcome = new List<LearningOutcomeModel>();
        List<MissionObjectiveModel> objective = new List<MissionObjectiveModel>();
        List<AssessmentModel> assessment = new List<AssessmentModel>();
        List<ABETModel> Abet = new List<ABETModel>();
        ArrayList ObjectiveNames = new ArrayList(50);
        ArrayList ABETnames = new ArrayList(50);
        ArrayList Assessments = new ArrayList(50);
        ArrayList MOmap = new ArrayList(50);
        ArrayList ABTmap = new ArrayList(50);
        ArrayList Assmap = new ArrayList(50);



        public LearningOutcome()
        {
            InitializeComponent();
            LoadLearningOutcomesList();
            LoadMissionObjectivesList();
            LoadAssessmentList();
            LoadAbetList();
        }
        private void LoadAbetList()
        {
            Abet = SqliteDataAccess.LoadABET();
            for (int i = 0; i < Abet.Count; i++)
            {
                ABETnames.Add(Abet[i].abetLearningOutcomes.ToString());
                ABETLearningBox.Items.Add(ABETnames[i]);
            }
        }
        private void LoadLearningOutcomesList()
        {
            outcome = SqliteDataAccess.LoadLearningOutcome();
            int i = 0;
                LearningOutcomeGrid.Rows.Add(outcome[i].OutcomeID, outcome[i].outcome);
       


        }
        private void LoadMissionObjectivesList()
        {
            objective = SqliteDataAccess.LoadMissionObjective();
            for (int i = 0; i < objective.Count; i++)
            {
                ObjectiveNames.Add(objective[i].missionObjective.ToString());
                MissionOBBox.Items.Add(ObjectiveNames[i]);
            }
            
        }
        private void LoadAssessmentList()
        {
            assessment = SqliteDataAccess.LoadAssessment();
            for (int i = 0; i < assessment.Count; i++)
            {
                Assessments.Add(assessment[i].assessmentName.ToString());
                AssessmentBox.Items.Add(Assessments[i]);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.LearningOutcomeGrid.Rows[e.RowIndex];
   
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            int sizeOfList;
            int i = 0;
            foreach (string s in MissionOBBox.CheckedItems)
            {
                MOmap.Add(s);
            }
            i++;
            sizeOfList = outcome.Count;

            if (outcome[i - 1] == outcome[sizeOfList - 1])
            {

                


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            for (int j = 1; j <= 9; j++)
            {
                switch (j)
                {
                    case 1:
                        worksheet.Cells[1, j] = "Learning Outcomes";
                        worksheet.Cells[1, j].EntireRow.Font.Bold = true;
                        worksheet.Cells[1, j].EntireRow.Style.WrapText = false;

                        break;
                    case 2:
                        worksheet.Cells[1, j] = "Misssion Objective(s)";
                        worksheet.Cells[1, j].EntireRow.Font.Bold = true;
                        break;
                    case 3:
                        worksheet.Cells[1, j] = "ABET learning Outcomes";
                        worksheet.Cells[1, j].EntireRow.Font.Bold = true;
                        break;
                    case 4:
                        worksheet.Cells[1, j] = "Evaluation Instrument";
                        worksheet.Cells[1, j].EntireRow.Font.Bold = true;
                        break;
                    case 5:
                        worksheet.Cells[1, j] = "Avg (%)";
                        worksheet.Cells[1, j].EntireRow.Font.Bold = true;
                        break;
                    case 6:
                        worksheet.Cells[1, j] = "Standard Deviation";
                        worksheet.Cells[1, j].EntireRow.Font.Bold = true;
                        break;
                    case 7:
                        worksheet.Cells[1, j] = "Program Outcome";
                        worksheet.Cells[1, j].EntireRow.Font.Bold = true;
                        break;
                    case 8:
                        worksheet.Cells[1, j] = "Avg";
                        worksheet.Cells[1, j].EntireRow.Font.Bold = true;
                        break;
                    case 9:
                        worksheet.Cells[1, j] = "Standard Deviation";
                        worksheet.Cells[1, j].EntireRow.Font.Bold = true;
                        break;
                    default:
                        worksheet.Cells[1, j] = "Opps!";
                        break;
                }
            }
            for (int j = 0; j <= 2; j++)
            {
                switch (j)
                {
                    case 0:
                        worksheet.Cells[j + 17, 1] = "Mission Objectives";
                        worksheet.Cells[j + 17, 1].EntireRow.Font.Bold = true;
                        break;
                    case 1:
                        worksheet.Cells[j + 24, 1] = "ABET Learning Outcomes";
                        worksheet.Cells[j + 24, 1].EntireRow.Font.Bold = true;
                        worksheet.Cells[j + 25, 1] = "The program enables students to achieve, by the time of graduation:";
                        break;
                    case 2:
                        worksheet.Cells[j + 27, 1] = "1. General:";
                        worksheet.Cells[j + 27, 1].EntireRow.Font.Bold = true;
                        worksheet.Cells[j + 28, 1] = "(a) An ability to apply knowledge of computing and mathematics appropriate to the discipline";
                        worksheet.Cells[j + 29, 1] = "(b) An ability to analyze a problem, and identify and define the computing requirements appropriate to its solution;";
                        worksheet.Cells[j + 30, 1] = "(c) An ability to design, implement and evaluate a computer-based system, process, component, or program to meet desired needs;";
                        worksheet.Cells[j + 31, 1] = "(d) An ability to function effectively on teams to accomplish a common goal;";
                        worksheet.Cells[j + 32, 1] = "(e) An understanding of professional, ethical, legal, security, and social issues and responsibilities;";
                        worksheet.Cells[j + 33, 1] = "(f) An ability to communicate effectively with a range of audiences;";
                        worksheet.Cells[j + 34, 1] = "(g) An ability to analyze the local and global impact of computing on individuals, organizations and society, including ethical, legal, security and global policy issues;";
                        worksheet.Cells[j + 35, 1] = "(h) Recognition of the need for, and an ability to engage in, continuing professional development;";
                        worksheet.Cells[j + 36, 1] = "(i) An ability to use current techniques, skills, and tools necessary for computing practice.";
                        worksheet.Cells[j + 38, 1] = "2. CS Specific:";
                        worksheet.Cells[j + 38, 1].EntireRow.Font.Bold = true;
                        worksheet.Cells[j + 39, 1] = "(a) An ability to apply mathematical foundations, algorithmic principles, and computer science theory in the modeling and design of computer-based systems in a way that demonstrates comprehension of the tradeoffs involved in design choices;";
                        worksheet.Cells[j + 40, 1] = "(b) An ability to apply design and development principles in the construction of software systems of varying complexity.";
                        break;
                    default:
                        worksheet.Cells[1 + 37, 1] = "Opps!";
                        break;

                }

            }

            for (int j = 2; j <= 7; j++)
            {
                worksheet.Cells[1, j].WrapText = true;
            }
            worksheet.Cells[1, 1].ColumnWidth = 84.14;
            worksheet.Cells[1, 1].RowHeight = 26.25;
            // storing Each row and column value in Mission Objectives
            for (int j = 0; j <= objective.Count - 1; j++)
            {
                worksheet.Cells[j + 18, 1] = objective[j].missionObjectiveID.ToString() + ". " + objective[j].missionObjective.ToString();
            }
            for (int j = 0; j <= outcome.Count - 1; j++)
            {
                worksheet.Cells[j + 2, 1] = outcome[j].outcome.ToString();
            }
           
        }
    }
}
