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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearningOutcome));
            this.NextButton = new System.Windows.Forms.Button();
            this.MissionOBBox = new System.Windows.Forms.CheckedListBox();
            this.ABETLearningBox = new System.Windows.Forms.CheckedListBox();
            this.AssessmentBox = new System.Windows.Forms.CheckedListBox();
            this.dataGridViewLO = new System.Windows.Forms.DataGridView();
            this.OutcomeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutcomeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.MissionSelect = new System.Windows.Forms.Button();
            this.MissionDeselect = new System.Windows.Forms.Button();
            this.ABETDeselect = new System.Windows.Forms.Button();
            this.AbetSelect = new System.Windows.Forms.Button();
            this.AssDeselect = new System.Windows.Forms.Button();
            this.AssSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLO)).BeginInit();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(673, 273);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(184, 36);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next Outcome";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MissionOBBox
            // 
            this.MissionOBBox.FormattingEnabled = true;
            this.MissionOBBox.Location = new System.Drawing.Point(673, 71);
            this.MissionOBBox.Name = "MissionOBBox";
            this.MissionOBBox.Size = new System.Drawing.Size(120, 109);
            this.MissionOBBox.TabIndex = 2;
            // 
            // ABETLearningBox
            // 
            this.ABETLearningBox.FormattingEnabled = true;
            this.ABETLearningBox.Location = new System.Drawing.Point(843, 71);
            this.ABETLearningBox.Name = "ABETLearningBox";
            this.ABETLearningBox.Size = new System.Drawing.Size(120, 109);
            this.ABETLearningBox.TabIndex = 3;
            // 
            // AssessmentBox
            // 
            this.AssessmentBox.FormattingEnabled = true;
            this.AssessmentBox.Location = new System.Drawing.Point(1012, 71);
            this.AssessmentBox.Name = "AssessmentBox";
            this.AssessmentBox.Size = new System.Drawing.Size(120, 109);
            this.AssessmentBox.TabIndex = 4;
            // 
            // dataGridViewLO
            // 
            this.dataGridViewLO.AllowUserToResizeColumns = false;
            this.dataGridViewLO.AllowUserToResizeRows = false;
            this.dataGridViewLO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLO.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OutcomeNumber,
            this.OutcomeDesc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLO.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLO.Location = new System.Drawing.Point(21, 71);
            this.dataGridViewLO.Name = "dataGridViewLO";
            this.dataGridViewLO.Size = new System.Drawing.Size(624, 238);
            this.dataGridViewLO.TabIndex = 29;
            // 
            // OutcomeNumber
            // 
            this.OutcomeNumber.FillWeight = 25.38071F;
            this.OutcomeNumber.HeaderText = "Outcome #";
            this.OutcomeNumber.Name = "OutcomeNumber";
            // 
            // OutcomeDesc
            // 
            this.OutcomeDesc.FillWeight = 174.6193F;
            this.OutcomeDesc.HeaderText = "Outcome Description";
            this.OutcomeDesc.Name = "OutcomeDesc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(668, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 60);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mission \r\nObjectives";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 37);
            this.label2.TabIndex = 33;
            this.label2.Text = "Learning Outcomes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(838, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 60);
            this.label3.TabIndex = 34;
            this.label3.Text = "ABET Learning \r\nObjectives";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1007, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 30);
            this.label4.TabIndex = 35;
            this.label4.Text = "Assessments";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1034, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 36);
            this.button3.TabIndex = 36;
            this.button3.Text = "Export";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MissionSelect
            // 
            this.MissionSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MissionSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionSelect.ForeColor = System.Drawing.Color.White;
            this.MissionSelect.Location = new System.Drawing.Point(673, 184);
            this.MissionSelect.Name = "MissionSelect";
            this.MissionSelect.Size = new System.Drawing.Size(120, 29);
            this.MissionSelect.TabIndex = 37;
            this.MissionSelect.Text = "Select All";
            this.MissionSelect.UseVisualStyleBackColor = true;
            this.MissionSelect.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MissionDeselect
            // 
            this.MissionDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MissionDeselect.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionDeselect.ForeColor = System.Drawing.Color.White;
            this.MissionDeselect.Location = new System.Drawing.Point(673, 220);
            this.MissionDeselect.Name = "MissionDeselect";
            this.MissionDeselect.Size = new System.Drawing.Size(120, 30);
            this.MissionDeselect.TabIndex = 38;
            this.MissionDeselect.Text = "Deselect All";
            this.MissionDeselect.UseVisualStyleBackColor = true;
            this.MissionDeselect.Click += new System.EventHandler(this.button4_Click);
            // 
            // ABETDeselect
            // 
            this.ABETDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ABETDeselect.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ABETDeselect.ForeColor = System.Drawing.Color.White;
            this.ABETDeselect.Location = new System.Drawing.Point(843, 220);
            this.ABETDeselect.Name = "ABETDeselect";
            this.ABETDeselect.Size = new System.Drawing.Size(120, 30);
            this.ABETDeselect.TabIndex = 40;
            this.ABETDeselect.Text = "Deselect All";
            this.ABETDeselect.UseVisualStyleBackColor = true;
            this.ABETDeselect.Click += new System.EventHandler(this.ABETDeselect_Click);
            // 
            // AbetSelect
            // 
            this.AbetSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbetSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.AbetSelect.ForeColor = System.Drawing.Color.White;
            this.AbetSelect.Location = new System.Drawing.Point(843, 184);
            this.AbetSelect.Name = "AbetSelect";
            this.AbetSelect.Size = new System.Drawing.Size(120, 30);
            this.AbetSelect.TabIndex = 39;
            this.AbetSelect.Text = "Select All";
            this.AbetSelect.UseVisualStyleBackColor = true;
            this.AbetSelect.Click += new System.EventHandler(this.AbetSelect_Click);
            // 
            // AssDeselect
            // 
            this.AssDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssDeselect.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.AssDeselect.ForeColor = System.Drawing.Color.White;
            this.AssDeselect.Location = new System.Drawing.Point(1012, 220);
            this.AssDeselect.Name = "AssDeselect";
            this.AssDeselect.Size = new System.Drawing.Size(120, 30);
            this.AssDeselect.TabIndex = 42;
            this.AssDeselect.Text = "Deselect All";
            this.AssDeselect.UseVisualStyleBackColor = true;
            this.AssDeselect.Click += new System.EventHandler(this.AssDeselect_Click);
            // 
            // AssSelect
            // 
            this.AssSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.AssSelect.ForeColor = System.Drawing.Color.White;
            this.AssSelect.Location = new System.Drawing.Point(1012, 185);
            this.AssSelect.Name = "AssSelect";
            this.AssSelect.Size = new System.Drawing.Size(120, 29);
            this.AssSelect.TabIndex = 41;
            this.AssSelect.Text = "Select All";
            this.AssSelect.UseVisualStyleBackColor = true;
            this.AssSelect.Click += new System.EventHandler(this.AssSelect_Click);
            // 
            // LearningOutcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1148, 321);
            this.Controls.Add(this.AssDeselect);
            this.Controls.Add(this.AssSelect);
            this.Controls.Add(this.ABETDeselect);
            this.Controls.Add(this.AbetSelect);
            this.Controls.Add(this.MissionDeselect);
            this.Controls.Add(this.MissionSelect);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button MissionSelect;
        private System.Windows.Forms.Button MissionDeselect;
        private System.Windows.Forms.Button ABETDeselect;
        private System.Windows.Forms.Button AbetSelect;
        private System.Windows.Forms.Button AssDeselect;
        private System.Windows.Forms.Button AssSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutcomeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutcomeDesc;
    }
}