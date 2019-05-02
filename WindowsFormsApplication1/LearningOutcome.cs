using Microsoft.Office.Interop.Excel;
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
        private string username;
        private string CRN;
        ArrayList ObjectiveNames = new ArrayList(50);
        ArrayList ABETnames = new ArrayList(50);
        ArrayList Assessments = new ArrayList(50);
        List<string> MOmap = new List<string>();
        List<string> ABTmap = new List<string>();
        List<string> Assmap = new List<string>();
        ArrayList MOmap2 = new ArrayList(50);
        ArrayList ABTmap2 = new ArrayList(50);
        ArrayList Assmap2 = new ArrayList(50);
        List<ClassModel> classes;
        List<LearningOutcomeModel> outcomes;
        List<MissionObjectiveModel> objectives;
        List<AssessmentModel> assessments;
        List<ABETModel> abet = SqliteDataAccess.LoadABET();
        ArrayList MOarray = new ArrayList(20);
        ArrayList ABarray = new ArrayList(20);
        ArrayList Assarray = new ArrayList(20);
        int outcomecount = 0;

        public LearningOutcome(string CRN, string username)
        {
            InitializeComponent();
            this.username = username;
            this.CRN = CRN;
            this.classes = SqliteDataAccess.LoadClassViaCRN(CRN);
            outcomes = SqliteDataAccess.LoadLearningOutcome(CRN);
            objectives = SqliteDataAccess.LoadMissionObjective(CRN);
            assessments = SqliteDataAccess.LoadAssessment(CRN);
            


            foreach (LearningOutcomeModel model in outcomes)
            {
                dataGridViewLO.Rows.Add(model.outcome_ID, model.description_LO);
            }
            LoadMissionObjectivesList();
            LoadAssessmentList();
            LoadAbetList();
           
        }
        private void LoadAbetList()
        {
     
            for (int i = 0; i < abet.Count; i++)
            {
                ABETnames.Add(abet[i].abet_ID.ToString());
                ABETLearningBox.Items.Add(ABETnames[i]);
            }
        }
        private void LoadMissionObjectivesList()
        {
            objectives = SqliteDataAccess.LoadMissionObjective(CRN);
            for (int i = 0; i < objectives.Count; i++)
            {
                ObjectiveNames.Add(objectives[i].description_MO.ToString());
                MissionOBBox.Items.Add(ObjectiveNames[i]);
            }

        }
        private void LoadAssessmentList()
        {
            assessments = SqliteDataAccess.LoadAssessment(CRN);
            for (int i = 0; i < assessments.Count; i++)
            {
                Assessments.Add(assessments[i].title.ToString());
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
                DataGridViewRow row = this.dataGridViewLO.Rows[e.RowIndex];

            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
           


            for (int i = 0; i < MissionOBBox.CheckedIndices.Count; i++)
                {
                    MOmap.Add(MissionOBBox.CheckedIndices[i] + 1 + " ");
                }
                foreach (string s in ABETLearningBox.CheckedItems)
                {
                    ABTmap.Add(s);
                }
                foreach (string s in AssessmentBox.CheckedItems)
                {
                    Assmap.Add(s);
                }
                
                    string MOresult = string.Join(",", MOmap.ToArray());
                    string ABTresult = string.Join(",", ABTmap.ToArray());
                    string Assmresult = string.Join(",", Assmap.ToArray());

                    MOarray.Add(MOresult);
                    ABarray.Add(ABTresult);
                    Assarray.Add(Assmresult);
                    MOmap.Clear();
                    ABTmap.Clear();
                    Assmap.Clear();

            outcomecount++;
            dataGridViewLO.Rows[outcomecount -1].Selected = true;
            if (outcomes.Count == outcomecount)
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
                    for (int j = 0; j <= objectives.Count - 1; j++)
                    {
                        worksheet.Cells[j + 18, 1] = objectives[j].objective_ID.ToString() + ". " + objectives[j].description_MO.ToString();
                    }
                    for (int j = 0; j <= outcomes.Count - 1; j++)
                    {
                        worksheet.Cells[j + 2, 1] = outcomes[j].description_LO.ToString();
                        worksheet.Cells[j + 2, 2] = MOarray[j].ToString();
                        worksheet.Cells[j + 2, 3] = ABarray[j].ToString();
                        worksheet.Cells[j + 2, 4] = Assarray[j].ToString();
                    }
                    for (int j = 0; j <= abet.Count - 1; j++)
                    {
                        worksheet.Cells[j + 30, 1] = "(" + abet[j].abet_ID.ToString() + ") " + abet[j].description_ABET.ToString();
                    }
                }
            
            }

        }
    }
