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
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.assessmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.high = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StandardDeviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLO = new System.Windows.Forms.DataGridView();
            this.OutcomeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutcomeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewMissionObj = new System.Windows.Forms.DataGridView();
            this.objectiveNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abetLearningObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.OutcomeDesc_txt = new System.Windows.Forms.TextBox();
            this.ObjDesc_txt = new System.Windows.Forms.TextBox();
            this.ABETLearningObjDesc_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissionObj)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(158, 648);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comments";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(269, 648);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(460, 162);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(135, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Assessments";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(918, 576);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(918, 680);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 91);
            this.button6.TabIndex = 19;
            this.button6.Text = "Export";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            this.low,
            this.Average,
            this.StandardDeviation});
            this.dataGridView1.Location = new System.Drawing.Point(269, 449);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
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
            // Average
            // 
            this.Average.HeaderText = "Average";
            this.Average.Name = "Average";
            // 
            // StandardDeviation
            // 
            this.StandardDeviation.HeaderText = "Standard Deviation";
            this.StandardDeviation.Name = "StandardDeviation";
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
            // dataGridViewMissionObj
            // 
            this.dataGridViewMissionObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMissionObj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectiveNumber,
            this.objDesc,
            this.abetLearningObj});
            this.dataGridViewMissionObj.Location = new System.Drawing.Point(271, 262);
            this.dataGridViewMissionObj.Name = "dataGridViewMissionObj";
            this.dataGridViewMissionObj.Size = new System.Drawing.Size(243, 150);
            this.dataGridViewMissionObj.TabIndex = 29;
            this.dataGridViewMissionObj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMissionObj_CellContentClick);
            // 
            // objectiveNumber
            // 
            this.objectiveNumber.HeaderText = "Objective #";
            this.objectiveNumber.Name = "objectiveNumber";
            // 
            // objDesc
            // 
            this.objDesc.HeaderText = "Objective Description";
            this.objDesc.Name = "objDesc";
            // 
            // abetLearningObj
            // 
            this.abetLearningObj.HeaderText = "ABET Learning Objective";
            this.abetLearningObj.Name = "abetLearningObj";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 787);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 389);
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
            this.OutcomeDesc_txt.Location = new System.Drawing.Point(735, 84);
            this.OutcomeDesc_txt.Multiline = true;
            this.OutcomeDesc_txt.Name = "OutcomeDesc_txt";
            this.OutcomeDesc_txt.ReadOnly = true;
            this.OutcomeDesc_txt.Size = new System.Drawing.Size(453, 150);
            this.OutcomeDesc_txt.TabIndex = 33;
            // 
            // ObjDesc_txt
            // 
            this.ObjDesc_txt.Location = new System.Drawing.Point(735, 262);
            this.ObjDesc_txt.Multiline = true;
            this.ObjDesc_txt.Name = "ObjDesc_txt";
            this.ObjDesc_txt.Size = new System.Drawing.Size(168, 156);
            this.ObjDesc_txt.TabIndex = 34;
            // 
            // ABETLearningObjDesc_txt
            // 
            this.ABETLearningObjDesc_txt.Location = new System.Drawing.Point(1020, 262);
            this.ABETLearningObjDesc_txt.Multiline = true;
            this.ABETLearningObjDesc_txt.Name = "ABETLearningObjDesc_txt";
            this.ABETLearningObjDesc_txt.Size = new System.Drawing.Size(168, 156);
            this.ABETLearningObjDesc_txt.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(648, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 36);
            this.label5.TabIndex = 36;
            this.label5.Text = "Outcome\r\nDescription";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(648, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 36);
            this.label6.TabIndex = 37;
            this.label6.Text = "Objective\r\nDescription";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(932, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 72);
            this.label7.TabIndex = 38;
            this.label7.Text = "ABET \r\nLearning\r\nObjective\r\nDescription";
            this.label7.UseWaitCursor = true;
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1264, 831);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ABETLearningObjDesc_txt);
            this.Controls.Add(this.ObjDesc_txt);
            this.Controls.Add(this.OutcomeDesc_txt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewMissionObj);
            this.Controls.Add(this.dataGridViewLO);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissionObj)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewLO;
        private System.Windows.Forms.DataGridView dataGridViewMissionObj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox OutcomeDesc_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutcomeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutcomeDesc;
        private System.Windows.Forms.TextBox ObjDesc_txt;
        private System.Windows.Forms.TextBox ABETLearningObjDesc_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn high;
        private System.Windows.Forms.DataGridViewTextBoxColumn medium;
        private System.Windows.Forms.DataGridViewTextBoxColumn low;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
        private System.Windows.Forms.DataGridViewTextBoxColumn StandardDeviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectiveNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn objDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn abetLearningObj;
    }
}