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
        Dictionary<int, string> MOmap = new Dictionary<int, string>();
        Dictionary<int, string> ABTmap = new Dictionary<int, string>();
        Dictionary<int, string> Assmap = new Dictionary<int, string>();


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
            MOmap.Add(i, MissionOBBox.ToString());
            ABTmap.Add(i, ABETLearningBox.ToString());
            Assmap.Add(i, AssessmentBox.ToString());
            LoadLearningOutcomesList();
            i++;
            sizeOfList = outcome.Count;
            if (outcome[i-1] == outcome[sizeOfList-1])
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
                foreach (KeyValuePair<int, string> kvp in MOmap)
                {
                    worksheet.Cells[i + 1, i + 1] = kvp.Value;
                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
