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
        List<int> AssAverage = new List<int>();
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
        List<int> Assave = new List<int>();
        ArrayList Assave2 = new ArrayList(20);
        List<int> avareage = new List<int>();
        List<int> finalavareage = new List<int>();
        List<double> squareroot = new List<double>();
        int outcomecount = 0;
        int[] averageArray;
        int pagelength;

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
            dataGridViewLO.Rows[outcomecount].Selected = true;

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
        private void MissionUncheckAllItems()
        {
            while (MissionOBBox.CheckedIndices.Count > 0)
                MissionOBBox.SetItemChecked(MissionOBBox.CheckedIndices[0], false);
        }
        private void ABETUncheckAllItems()
        {
            while (ABETLearningBox.CheckedIndices.Count > 0)
                ABETLearningBox.SetItemChecked(ABETLearningBox.CheckedIndices[0], false);
        }
        private void AssUncheckAllItems()
        {
            while (AssessmentBox.CheckedIndices.Count > 0)
                AssessmentBox.SetItemChecked(AssessmentBox.CheckedIndices[0], false);
        }
        private void MissioncheckAllItems()
        {
            for (int i = 0; i < MissionOBBox.Items.Count; i++)
            {
                MissionOBBox.SetItemChecked(i, true);
            }
        }
        private void ABETcheckAllItems()
        {

            for (int i = 0; i < ABETLearningBox.Items.Count; i++)
            {
                ABETLearningBox.SetItemChecked(i, true);
            }
        }
        private void AsscheckAllItems()
        {
            for (int i = 0; i < AssessmentBox.Items.Count; i++)
            {
                AssessmentBox.SetItemChecked(i, true);
            }
        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                int index = 1;
                int num = 0;
                int sum = 0;
                int score = 0;
                double sqrtroot = 0;
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
                for (int i = 0; i < AssessmentBox.CheckedIndices.Count; i++)
                {
                    //gets indices from assessmentbox
                    AssAverage.Add(AssessmentBox.CheckedIndices[i]);
                }

                for (int i = 0; i < AssAverage.Count; i++)
                {


                    index = AssAverage[i];
                    Int32.TryParse(assessments[index].average.ToString(), out x);
                    Assave.Add(x);

                }
                for (int i = 0; i < Assave.Count; i++)
                {

                    score = Assave[i];
                    sum += score;
                    num++;
                }
               

                string MOresult = string.Join(",", MOmap.ToArray());
                string ABTresult = string.Join(",", ABTmap.ToArray());
                string Assmresult = string.Join(",", Assmap.ToArray());
                string Assmav = string.Join(",", Assave.ToArray());
                MOarray.Add(MOresult);
                ABarray.Add(ABTresult);
                Assarray.Add(Assmresult);
                Assave2.Add(Assmav);
                avareage.Add(sum / num);
                MOmap.Clear();
                ABTmap.Clear();
                Assmap.Clear();
                Assave.Clear();
                AssAverage.Clear();
                outcomecount++;
                dataGridViewLO.Rows[outcomecount].Selected = true;
                MissionUncheckAllItems();
                ABETUncheckAllItems();
                AssUncheckAllItems();
                for (int i = 0; i < avareage.Count; i++)
                {
                    sqrtroot = Math.Sqrt(avareage[i]);
                }
                squareroot.Add(sqrtroot);

                if (outcomes.Count - 1 == outcomecount)
                {
                    NextButton.Text = "Final Change";
                }
                if (outcomes.Count == outcomecount)
                {
                    NextButton.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("All fields must be entered ");
            }
            }
            
        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (outcomecount != outcomes.Count)
            {
                MessageBox.Show("You must input all of the fields before exporting", " Warning",
    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
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
                for (int j = 1; j <= 10; j++)
                {
                    switch (j)
                    {
                        case 1:
                            worksheet.Cells[1, j] = CRN + " " + "Learning Outcomes";
                            worksheet.Cells[1, j].Font.Bold = true;
                            worksheet.Cells[1, j].EntireRow.Style.WrapText = false;

                            break;
                        case 2:
                            worksheet.Cells[1, j] = "Misssion Objective(s)";
                            worksheet.Cells[1, j].Font.Bold = true;
                            break;
                        case 3:
                            worksheet.Cells[1, j] = "ABET learning Outcomes";
                            worksheet.Cells[1, j].Font.Bold = true;
                            break;
                        case 4:
                            worksheet.Cells[1, j] = "Evaluation Instrument";
                            worksheet.Cells[1, j].Font.Bold = true;
                            break;
                        case 5:
                            worksheet.Cells[1, j] = "Avg (%)";
                            worksheet.Cells[1, j].Font.Bold = true;
                            break;
                        case 6:
                            worksheet.Cells[1, j] = "Standard Deviation";
                            worksheet.Cells[1, j].Font.Bold = true;
                            break;
                        case 7:
                            worksheet.Cells[1, j] = " ";
                            worksheet.Cells[1, j].Font.Bold = true;
                            break;
                        case 8:
                            worksheet.Cells[1, j] = "Program Outcome";
                            worksheet.Cells[1, j].Font.Bold = true;
                            break;
                        case 9:
                            worksheet.Cells[1, j] = "Avg";
                            worksheet.Cells[1, j].Font.Bold = true;
                            break;
                        case 10:
                            worksheet.Cells[1, j] = "Standard Deviation";
                            worksheet.Cells[1, j].Font.Bold = true;
                            break;
                        default:
                            worksheet.Cells[1, j] = "Opps!";
                            break;
                    }
                }
                /*
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

    */

                for (int j = 2; j <= 7; j++)
                {
                    worksheet.Cells[1, j].WrapText = true;
                }
                worksheet.Cells[1, 1].ColumnWidth = 84.14;
                worksheet.Cells[1, 1].RowHeight = 26.25;
                // storing Each row and column value in Mission Objectives
                for (int j = 0; j <= objectives.Count - 1; j++)
                {
                   // worksheet.Cells[j + 18, 1] = objectives[j].objective_ID.ToString() + ". " + objectives[j].description_MO.ToString();

                }

                for (int j = 0; j <= outcomes.Count - 1; j++)
                {
                  //  worksheet.Cells[j + 2, 1] = outcomes[j].description_LO.ToString();
                    worksheet.Cells[j + 2, 2] = MOarray[j].ToString();
                    worksheet.Cells[j + 2, 3] = ABarray[j].ToString();
                    worksheet.Cells[j + 2, 3].ColumnWidth = 8.43;
                    worksheet.Cells[j + 2, 3].RowHeight = 15;
                    worksheet.Cells[j + 2, 3].EntireRow.Style.WrapText = false;
                    worksheet.Cells[j + 2, 4] = Assarray[j].ToString();
                    worksheet.Cells[j + 2, 5] = avareage[j].ToString() + "%";
                    worksheet.Cells[j + 2, 6] = squareroot[j].ToString();



                }
                for (int j = 0; j <= abet.Count - 1; j++)
                {
                 //   worksheet.Cells[j + 30, 1] = "(" + abet[j].abet_ID.ToString() + ") " + abet[j].description_ABET.ToString();
                    worksheet.Cells[j + 2, 8] = abet[j].abet_ID.ToString();
                }
                
                for (int j = 0; j <= outcomes.Count - 1; j++)
                {
                    worksheet.Cells[j + 2, 1] = outcomes[j].description_LO.ToString();
                    if (j == outcomes.Count - 1)
                    {
                        worksheet.Cells[j + 3, 1] = " ";
                        worksheet.Cells[j + 4, 1] = "Mission Objectives";
                        worksheet.Cells[j + 4, 1].Font.Bold = true;
                        for (int k = 0; k <= objectives.Count - 1; k++)
                        {
                            worksheet.Cells[j + k + 5, 1] = objectives[k].objective_ID.ToString() + ". " + objectives[k].description_MO.ToString();
                            if (k == objectives.Count - 1)
                            {
                                worksheet.Cells[j + k + 6, 1] = " ";
                                worksheet.Cells[j + k + 7, 1] = "ABET Learning Outcomes";
                                worksheet.Cells[j + k + 7, 1].Font.Bold = true;
                                worksheet.Cells[j + k + 8, 1] = "The program enables students to achieve, by the time of graduation:";
                                worksheet.Cells[j + k + 9, 1] = " ";
                                worksheet.Cells[j + k + 10, 1] = "1. General:";
                                worksheet.Cells[j + k + 10, 1].Font.Bold = true;
                                worksheet.Cells[j + k + 11, 1] = " ";
                                for (int l = 0; l <= abet.Count - 1; l++)
                                {
                                    worksheet.Cells[j + k + l + 12, 1] = "(" + abet[l].abet_ID.ToString() + ") " + abet[l].description_ABET.ToString();
                                    if (l == abet.Count - 1)
                                    {
                                        worksheet.Cells[j + k + l + 13, 1] = " ";
                                        worksheet.Cells[j + k + l + 14, 1] =  " ";
                                        worksheet.Cells[j + k + l + 15, 1] = "2. CS Specific:";
                                        worksheet.Cells[j + k + l + 15, 1].Font.Bold = true;
                                        worksheet.Cells[j + k + l + 16, 1] = "(a) An ability to apply mathematical foundations, algorithmic principles, and computer science theory in the modeling and design of computer-based systems in a way that demonstrates comprehension of the tradeoffs involved in design choices;";
                                        worksheet.Cells[j + k + l + 17, 1] = "(b) An ability to apply design and development principles in the construction of software systems of varying complexity.";
                                    }
                                }
                            }




                        }

                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MissionUncheckAllItems();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MissioncheckAllItems();
        }

        private void AbetSelect_Click(object sender, EventArgs e)
        {
            ABETcheckAllItems();
        }

        private void AssSelect_Click(object sender, EventArgs e)
        {
            AsscheckAllItems();
        }

        private void ABETDeselect_Click(object sender, EventArgs e)
        {
            ABETUncheckAllItems();
        }

        private void AssDeselect_Click(object sender, EventArgs e)
        {
            AssUncheckAllItems();
        }
    }
}
