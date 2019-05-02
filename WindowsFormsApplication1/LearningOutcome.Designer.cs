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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearningOutcome));
            this.NextButton = new System.Windows.Forms.Button();
            this.MissionOBBox = new System.Windows.Forms.CheckedListBox();
            this.ABETLearningBox = new System.Windows.Forms.CheckedListBox();
            this.AssessmentBox = new System.Windows.Forms.CheckedListBox();
            this.dataGridViewLO = new System.Windows.Forms.DataGridView();
            this.OutcomeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutcomeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLO)).BeginInit();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(675, 222);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(159, 36);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next Objective";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MissionOBBox
            // 
            this.MissionOBBox.FormattingEnabled = true;
            this.MissionOBBox.Location = new System.Drawing.Point(675, 96);
            this.MissionOBBox.Name = "MissionOBBox";
            this.MissionOBBox.Size = new System.Drawing.Size(120, 94);
            this.MissionOBBox.TabIndex = 2;
            // 
            // ABETLearningBox
            // 
            this.ABETLearningBox.FormattingEnabled = true;
            this.ABETLearningBox.Location = new System.Drawing.Point(818, 96);
            this.ABETLearningBox.Name = "ABETLearningBox";
            this.ABETLearningBox.Size = new System.Drawing.Size(120, 94);
            this.ABETLearningBox.TabIndex = 3;
            // 
            // AssessmentBox
            // 
            this.AssessmentBox.FormattingEnabled = true;
            this.AssessmentBox.Location = new System.Drawing.Point(957, 96);
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
            this.dataGridViewLO.Location = new System.Drawing.Point(21, 96);
            this.dataGridViewLO.Name = "dataGridViewLO";
            this.dataGridViewLO.Size = new System.Drawing.Size(624, 150);
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(893, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 36);
            this.button1.TabIndex = 30;
            this.button1.Text = "Previous Objective";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1114, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 36);
            this.button2.TabIndex = 31;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(670, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 50);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mission \r\nObjectives";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Outcomes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(813, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 50);
            this.label3.TabIndex = 34;
            this.label3.Text = "ABET Learning \r\nObjectives";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(952, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Assessments";
            // 
            // LearningOutcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1249, 321);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewLO);
            this.Controls.Add(this.AssessmentBox);
            this.Controls.Add(this.ABETLearningBox);
            this.Controls.Add(this.MissionOBBox);
            this.Controls.Add(this.NextButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LearningOutcome";
            this.Text = "LearningOutcome";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.CheckedListBox MissionOBBox;
        private System.Windows.Forms.CheckedListBox ABETLearningBox;
        private System.Windows.Forms.CheckedListBox AssessmentBox;
        private System.Windows.Forms.DataGridView dataGridViewLO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutcomeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutcomeDesc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}