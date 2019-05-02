namespace WindowsFormsApplication1
{
    partial class LearningOutcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NextButton = new System.Windows.Forms.Button();
            this.MissionOBBox = new System.Windows.Forms.CheckedListBox();
            this.ABETLearningBox = new System.Windows.Forms.CheckedListBox();
            this.AssessmentBox = new System.Windows.Forms.CheckedListBox();
            this.dataGridViewLO = new System.Windows.Forms.DataGridView();
            this.OutcomeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutcomeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLO)).BeginInit();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(751, 156);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MissionOBBox
            // 
            this.MissionOBBox.FormattingEnabled = true;
            this.MissionOBBox.Location = new System.Drawing.Point(310, 115);
            this.MissionOBBox.Name = "MissionOBBox";
            this.MissionOBBox.Size = new System.Drawing.Size(120, 94);
            this.MissionOBBox.TabIndex = 2;
            // 
            // ABETLearningBox
            // 
            this.ABETLearningBox.FormattingEnabled = true;
            this.ABETLearningBox.Location = new System.Drawing.Point(453, 115);
            this.ABETLearningBox.Name = "ABETLearningBox";
            this.ABETLearningBox.Size = new System.Drawing.Size(120, 94);
            this.ABETLearningBox.TabIndex = 3;
            // 
            // AssessmentBox
            // 
            this.AssessmentBox.FormattingEnabled = true;
            this.AssessmentBox.Location = new System.Drawing.Point(592, 115);
            this.AssessmentBox.Name = "AssessmentBox";
            this.AssessmentBox.Size = new System.Drawing.Size(120, 94);
            this.AssessmentBox.TabIndex = 4;
            // 
            // dataGridViewLO
            // 
            this.dataGridViewLO.AllowUserToResizeColumns = false;
            this.dataGridViewLO.AllowUserToResizeRows = false;
            this.dataGridViewLO.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewLO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OutcomeNumber,
            this.OutcomeDesc});
            this.dataGridViewLO.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewLO.Name = "dataGridViewLO";
            this.dataGridViewLO.Size = new System.Drawing.Size(243, 150);
            this.dataGridViewLO.TabIndex = 29;
            // 
            // OutcomeNumber
            // 
            this.OutcomeNumber.HeaderText = "Outcome #";
            this.OutcomeNumber.Name = "OutcomeNumber";
            // 
            // OutcomeDesc
            // 
            this.OutcomeDesc.HeaderText = "Outcome Description";
            this.OutcomeDesc.Name = "OutcomeDesc";
            // 
            // LearningOutcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 470);
            this.Controls.Add(this.dataGridViewLO);
            this.Controls.Add(this.AssessmentBox);
            this.Controls.Add(this.ABETLearningBox);
            this.Controls.Add(this.MissionOBBox);
            this.Controls.Add(this.NextButton);
            this.Name = "LearningOutcome";
            this.Text = "LearningOutcome";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.CheckedListBox MissionOBBox;
        private System.Windows.Forms.CheckedListBox ABETLearningBox;
        private System.Windows.Forms.CheckedListBox AssessmentBox;
        private System.Windows.Forms.DataGridView dataGridViewLO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutcomeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutcomeDesc;
    }
}