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
        //Chnage update button to be an image so its more efficient
        //Change default typeface (look into how package handles fonts)
        //Google Fonts may work; if not use Segue UI
        public Class()
        { 
            InitializeComponent();
            //Test comment for GitHub bullshit
            //string hexColorBack = "#9EB3B3";
            string hexColorBack = "#FFFFFF";
            string hexColorSplitContainerHalves = "#57A0BC";
            string hexColorText = "#FFFFFF";// #D9AC84 or #002121 or 87714D or FFDC8C
            string hexColorTextBox = "#FFFFFF";

            Color colorBack = System.Drawing.ColorTranslator.FromHtml(hexColorBack);
            Color colorSplitHalves = System.Drawing.ColorTranslator.FromHtml(hexColorSplitContainerHalves);
            Color colorText = System.Drawing.ColorTranslator.FromHtml(hexColorText);
            Color colorTextBox = System.Drawing.ColorTranslator.FromHtml(hexColorTextBox);

            splitContainer1.BackColor = colorBack;
            splitContainer1.Panel1.BackColor = colorSplitHalves;
            splitContainer1.Panel2.BackColor = colorSplitHalves;

            Label[] labels = { label1, label2, label3, label4, label5, label8, label9 };
            for (int i = 0; i < labels.Count(); i++)
            {
                labels[i].ForeColor = colorText;
            }

            TextBox[] boxes = { OutcomeDesc_txt, ObjDesc_txt, ABETLearningObjDesc_txt, textBox2 };
            for (int i = 0; i < boxes.Count(); i++)
            {
                boxes[i].BackColor = colorTextBox;
            }



        }

        



        private void button6_Click(object sender, EventArgs e)
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
                //Try and set up so that user can input sentences and change them through the description box
            }
        }

        private void dataGridViewMissionObj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewMissionObj.Rows[e.RowIndex];
                ObjDesc_txt.Text = row.Cells["objDesc"].Value.ToString();
                
            }
        }

        private void dataGridViewABET_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewABET.Rows[e.RowIndex];
                
                ABETLearningObjDesc_txt.Text = row.Cells["abetLearningObj"].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }
    }
}
