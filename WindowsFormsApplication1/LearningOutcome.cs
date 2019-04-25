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
            for (int i = 0; i < outcome.Count; i++)
            {
                LearningOutcomeGrid.Rows.Add(outcome[i].OutcomeID, outcome[i].outcome);
            }
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
    }
}
