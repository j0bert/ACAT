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
        public Class()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

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
