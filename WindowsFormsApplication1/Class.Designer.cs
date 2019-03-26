namespace WindowsFormsApplication1
{
    partial class Class
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
            this.label1 = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.assessmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.high = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLO = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.objectiveNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectiveDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abetLearningObjective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.OutcomeDesc_txt = new System.Windows.Forms.TextBox();
            this.OutcomeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutcomeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(82, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Learning Outcomes";
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(6, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 23);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.Text = "Logout";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(256, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dashboard (Specific Class)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(158, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comments";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 437);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(460, 162);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(135, 658);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Assessments";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(737, 785);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(735, 687);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Export Excel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(735, 716);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "Export PDF";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(735, 658);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 21;
            this.button8.Text = "Import Excel";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(89, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mission Objectives";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assessmentName,
            this.high,
            this.medium,
            this.low});
            this.dataGridView1.Location = new System.Drawing.Point(271, 658);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 27;
            // 
            // assessmentName
            // 
            this.assessmentName.HeaderText = "Assessment Name";
            this.assessmentName.Name = "assessmentName";
            // 
            // high
            // 
            this.high.HeaderText = "High";
            this.high.Name = "high";
            // 
            // medium
            // 
            this.medium.HeaderText = "Medium";
            this.medium.Name = "medium";
            // 
            // low
            // 
            this.low.HeaderText = "Low";
            this.low.Name = "low";
            // 
            // dataGridViewLO
            // 
            this.dataGridViewLO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OutcomeNumber,
            this.OutcomeDesc});
            this.dataGridViewLO.Location = new System.Drawing.Point(271, 84);
            this.dataGridViewLO.Name = "dataGridViewLO";
            this.dataGridViewLO.Size = new System.Drawing.Size(243, 150);
            this.dataGridViewLO.TabIndex = 28;
            this.dataGridViewLO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLO_CellContentClick_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectiveNumber,
            this.objectiveDesc,
            this.abetLearningObjective});
            this.dataGridView3.Location = new System.Drawing.Point(271, 262);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(346, 150);
            this.dataGridView3.TabIndex = 29;
            // 
            // objectiveNumber
            // 
            this.objectiveNumber.HeaderText = "Objective #";
            this.objectiveNumber.Name = "objectiveNumber";
            // 
            // objectiveDesc
            // 
            this.objectiveDesc.HeaderText = "Objective Description";
            this.objectiveDesc.Name = "objectiveDesc";
            // 
            // abetLearningObjective
            // 
            this.abetLearningObjective.HeaderText = "ABET Learning Objective";
            this.abetLearningObjective.Name = "abetLearningObjective";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(737, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // OutcomeDesc_txt
            // 
            this.OutcomeDesc_txt.Location = new System.Drawing.Point(701, 84);
            this.OutcomeDesc_txt.Multiline = true;
            this.OutcomeDesc_txt.Name = "OutcomeDesc_txt";
            this.OutcomeDesc_txt.ReadOnly = true;
            this.OutcomeDesc_txt.Size = new System.Drawing.Size(280, 150);
            this.OutcomeDesc_txt.TabIndex = 33;
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
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1044, 1062);
            this.Controls.Add(this.OutcomeDesc_txt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridViewLO);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.label1);
            this.Name = "Class";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn high;
        private System.Windows.Forms.DataGridViewTextBoxColumn medium;
        private System.Windows.Forms.DataGridViewTextBoxColumn low;
        private System.Windows.Forms.DataGridView dataGridViewLO;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectiveNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectiveDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn abetLearningObjective;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox OutcomeDesc_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutcomeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutcomeDesc;
    }
}