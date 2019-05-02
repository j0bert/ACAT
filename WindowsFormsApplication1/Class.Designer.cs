﻿namespace WindowsFormsApplication1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class));
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pushObjDesc = new System.Windows.Forms.Button();
            this.pushOutcomeDesc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonObjectiveUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewABET = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abetLearningObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ABETLearningObjDesc_txt = new System.Windows.Forms.TextBox();
            this.ObjDesc_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOutcomeUpdate = new System.Windows.Forms.Button();
            this.OutcomeDesc_txt = new System.Windows.Forms.TextBox();
            this.buttonAssessmentUpdate = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissionObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewABET)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Learning Outcomes";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(188)))));
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(591, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(88, 34);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dashboard (Specific Class)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F);
            this.label3.Location = new System.Drawing.Point(4, 689);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comments";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBox2.Location = new System.Drawing.Point(8, 712);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(585, 175);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Assessments";
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(188)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(494, 870);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 46);
            this.button6.TabIndex = 19;
            this.button6.Text = "Export Excel";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mission Objectives";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assessmentName,
            this.high,
            this.medium,
            this.low,
            this.Average,
            this.StandardDeviation});
            this.dataGridView1.Location = new System.Drawing.Point(19, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 758);
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
            this.dataGridViewLO.AllowUserToResizeColumns = false;
            this.dataGridViewLO.AllowUserToResizeRows = false;
            this.dataGridViewLO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewLO.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridViewLO.Location = new System.Drawing.Point(8, 104);
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
            this.dataGridViewMissionObj.AllowUserToResizeColumns = false;
            this.dataGridViewMissionObj.AllowUserToResizeRows = false;
            this.dataGridViewMissionObj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewMissionObj.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMissionObj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMissionObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMissionObj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectiveNumber,
            this.objDesc});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMissionObj.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMissionObj.Location = new System.Drawing.Point(8, 300);
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
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Location = new System.Drawing.Point(0, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(150)))), ((int)(((byte)(210)))));
            this.splitContainer1.Panel1.Controls.Add(this.pushObjDesc);
            this.splitContainer1.Panel1.Controls.Add(this.pushOutcomeDesc);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonObjectiveUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewABET);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.ABETLearningObjDesc_txt);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewLO);
            this.splitContainer1.Panel1.Controls.Add(this.ObjDesc_txt);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewMissionObj);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOutcomeUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.OutcomeDesc_txt);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(150)))), ((int)(((byte)(210)))));
            this.splitContainer1.Panel2.Controls.Add(this.buttonAssessmentUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.HomeButton);
            this.splitContainer1.Panel2.Controls.Add(this.LogoutButton);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Size = new System.Drawing.Size(1289, 927);
            this.splitContainer1.SplitterDistance = 605;
            this.splitContainer1.TabIndex = 39;
            // 
            // pushObjDesc
            // 
            this.pushObjDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pushObjDesc.BackColor = System.Drawing.Color.Transparent;
            this.pushObjDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pushObjDesc.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pushObjDesc.ForeColor = System.Drawing.Color.Transparent;
            this.pushObjDesc.Image = global::WindowsFormsApplication1.Properties.Resources.PushLeft;
            this.pushObjDesc.Location = new System.Drawing.Point(551, 271);
            this.pushObjDesc.Name = "pushObjDesc";
            this.pushObjDesc.Size = new System.Drawing.Size(42, 23);
            this.pushObjDesc.TabIndex = 44;
            this.pushObjDesc.UseVisualStyleBackColor = false;
            this.pushObjDesc.Click += new System.EventHandler(this.pushObjDesc_Click);
            // 
            // pushOutcomeDesc
            // 
            this.pushOutcomeDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pushOutcomeDesc.BackColor = System.Drawing.Color.Transparent;
            this.pushOutcomeDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pushOutcomeDesc.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pushOutcomeDesc.ForeColor = System.Drawing.Color.Transparent;
            this.pushOutcomeDesc.Image = global::WindowsFormsApplication1.Properties.Resources.PushLeft;
            this.pushOutcomeDesc.Location = new System.Drawing.Point(551, 75);
            this.pushOutcomeDesc.Name = "pushOutcomeDesc";
            this.pushOutcomeDesc.Size = new System.Drawing.Size(42, 23);
            this.pushOutcomeDesc.TabIndex = 43;
            this.pushOutcomeDesc.UseVisualStyleBackColor = false;
            this.pushOutcomeDesc.Click += new System.EventHandler(this.pushOutcomeDesc_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.button1.Location = new System.Drawing.Point(551, 683);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonObjectiveUpdate
            // 
            this.buttonObjectiveUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonObjectiveUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonObjectiveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObjectiveUpdate.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObjectiveUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.buttonObjectiveUpdate.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.buttonObjectiveUpdate.Location = new System.Drawing.Point(209, 271);
            this.buttonObjectiveUpdate.Name = "buttonObjectiveUpdate";
            this.buttonObjectiveUpdate.Size = new System.Drawing.Size(42, 23);
            this.buttonObjectiveUpdate.TabIndex = 41;
            this.buttonObjectiveUpdate.UseVisualStyleBackColor = false;
            this.buttonObjectiveUpdate.Click += new System.EventHandler(this.ButtonObjectiveUpdate_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "ABET Learning Outcomes";
            // 
            // dataGridViewABET
            // 
            this.dataGridViewABET.AllowUserToResizeColumns = false;
            this.dataGridViewABET.AllowUserToResizeRows = false;
            this.dataGridViewABET.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewABET.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewABET.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewABET.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewABET.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.abetLearningObj});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewABET.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewABET.Location = new System.Drawing.Point(8, 504);
            this.dataGridViewABET.Name = "dataGridViewABET";
            this.dataGridViewABET.Size = new System.Drawing.Size(243, 150);
            this.dataGridViewABET.TabIndex = 39;
            this.dataGridViewABET.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewABET_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Outcome #";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // abetLearningObj
            // 
            this.abetLearningObj.HeaderText = "ABET Learning Objective";
            this.abetLearningObj.Name = "abetLearningObj";
            // 
            // ABETLearningObjDesc_txt
            // 
            this.ABETLearningObjDesc_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ABETLearningObjDesc_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABETLearningObjDesc_txt.Location = new System.Drawing.Point(276, 504);
            this.ABETLearningObjDesc_txt.Multiline = true;
            this.ABETLearningObjDesc_txt.Name = "ABETLearningObjDesc_txt";
            this.ABETLearningObjDesc_txt.ReadOnly = true;
            this.ABETLearningObjDesc_txt.Size = new System.Drawing.Size(317, 150);
            this.ABETLearningObjDesc_txt.TabIndex = 35;
            // 
            // ObjDesc_txt
            // 
            this.ObjDesc_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ObjDesc_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjDesc_txt.Location = new System.Drawing.Point(276, 300);
            this.ObjDesc_txt.Multiline = true;
            this.ObjDesc_txt.Name = "ObjDesc_txt";
            this.ObjDesc_txt.Size = new System.Drawing.Size(317, 150);
            this.ObjDesc_txt.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Description";
            this.label5.UseWaitCursor = true;
            // 
            // buttonOutcomeUpdate
            // 
            this.buttonOutcomeUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOutcomeUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonOutcomeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutcomeUpdate.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOutcomeUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.buttonOutcomeUpdate.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.buttonOutcomeUpdate.Location = new System.Drawing.Point(209, 75);
            this.buttonOutcomeUpdate.Name = "buttonOutcomeUpdate";
            this.buttonOutcomeUpdate.Size = new System.Drawing.Size(42, 23);
            this.buttonOutcomeUpdate.TabIndex = 32;
            this.buttonOutcomeUpdate.UseVisualStyleBackColor = false;
            this.buttonOutcomeUpdate.Click += new System.EventHandler(this.ButtonOutcomeUpdate_Click);
            // 
            // OutcomeDesc_txt
            // 
            this.OutcomeDesc_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutcomeDesc_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutcomeDesc_txt.Location = new System.Drawing.Point(276, 106);
            this.OutcomeDesc_txt.Multiline = true;
            this.OutcomeDesc_txt.Name = "OutcomeDesc_txt";
            this.OutcomeDesc_txt.Size = new System.Drawing.Size(317, 148);
            this.OutcomeDesc_txt.TabIndex = 33;
            // 
            // buttonAssessmentUpdate
            // 
            this.buttonAssessmentUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAssessmentUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonAssessmentUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssessmentUpdate.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAssessmentUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAssessmentUpdate.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.buttonAssessmentUpdate.Location = new System.Drawing.Point(620, 77);
            this.buttonAssessmentUpdate.Name = "buttonAssessmentUpdate";
            this.buttonAssessmentUpdate.Size = new System.Drawing.Size(42, 23);
            this.buttonAssessmentUpdate.TabIndex = 33;
            this.buttonAssessmentUpdate.UseVisualStyleBackColor = false;
            this.buttonAssessmentUpdate.Click += new System.EventHandler(this.ButtonAssessmentUpdate_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(188)))));
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(514, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(77, 34);
            this.HomeButton.TabIndex = 28;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1290, 929);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Class";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissionObj)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewABET)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewMissionObj;
        private System.Windows.Forms.Button buttonOutcomeUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutcomeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutcomeDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn high;
        private System.Windows.Forms.DataGridViewTextBoxColumn medium;
        private System.Windows.Forms.DataGridViewTextBoxColumn low;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
        private System.Windows.Forms.DataGridViewTextBoxColumn StandardDeviation;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox ABETLearningObjDesc_txt;
        private System.Windows.Forms.TextBox ObjDesc_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OutcomeDesc_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewABET;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectiveNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn objDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn abetLearningObj;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.DataGridView dataGridViewLO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonObjectiveUpdate;
        private System.Windows.Forms.Button buttonAssessmentUpdate;
        private System.Windows.Forms.Button pushObjDesc;
        private System.Windows.Forms.Button pushOutcomeDesc;
    }
}