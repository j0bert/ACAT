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
            this.MissionOBBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ABETLearningBox = new System.Windows.Forms.CheckedListBox();
            this.AssessmentBox = new System.Windows.Forms.CheckedListBox();
            this.LearningOutcomeGrid = new System.Windows.Forms.DataGridView();
            this.OutcomeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutcomeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LearningOutcomeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MissionOBBox
            // 
            this.MissionOBBox.FormattingEnabled = true;
            this.MissionOBBox.Location = new System.Drawing.Point(500, 127);
            this.MissionOBBox.Name = "MissionOBBox";
            this.MissionOBBox.Size = new System.Drawing.Size(120, 94);
            this.MissionOBBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mission Objective";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ABET Learning Objective";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(993, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Assessments";
            // 
            // ABETLearningBox
            // 
            this.ABETLearningBox.FormattingEnabled = true;
            this.ABETLearningBox.Location = new System.Drawing.Point(693, 127);
            this.ABETLearningBox.Name = "ABETLearningBox";
            this.ABETLearningBox.Size = new System.Drawing.Size(120, 94);
            this.ABETLearningBox.TabIndex = 7;
            // 
            // AssessmentBox
            // 
            this.AssessmentBox.FormattingEnabled = true;
            this.AssessmentBox.Location = new System.Drawing.Point(982, 127);
            this.AssessmentBox.Name = "AssessmentBox";
            this.AssessmentBox.Size = new System.Drawing.Size(120, 94);
            this.AssessmentBox.TabIndex = 8;
            // 
            // LearningOutcomeGrid
            // 
            this.LearningOutcomeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LearningOutcomeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OutcomeNumber,
            this.OutcomeDesc});
            this.LearningOutcomeGrid.Location = new System.Drawing.Point(51, 91);
            this.LearningOutcomeGrid.Name = "LearningOutcomeGrid";
            this.LearningOutcomeGrid.Size = new System.Drawing.Size(243, 150);
            this.LearningOutcomeGrid.TabIndex = 29;
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
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1188, 696);
            this.Controls.Add(this.LearningOutcomeGrid);
            this.Controls.Add(this.AssessmentBox);
            this.Controls.Add(this.ABETLearningBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MissionOBBox);
            this.Name = "LearningOutcome";
            this.Text = "LearningOutcome";
            ((System.ComponentModel.ISupportInitialize)(this.LearningOutcomeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox MissionOBBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ABETLearningBox;
        private System.Windows.Forms.CheckedListBox AssessmentBox;
        private System.Windows.Forms.DataGridView LearningOutcomeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutcomeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutcomeDesc;
    }
}