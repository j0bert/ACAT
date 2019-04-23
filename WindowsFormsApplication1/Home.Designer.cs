namespace WindowsFormsApplication1
{
    partial class Home
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.ClassesView = new System.Windows.Forms.ListView();
            this.ClassText = new System.Windows.Forms.TextBox();
            this.CRNText = new System.Windows.Forms.TextBox();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SemesterText = new System.Windows.Forms.TextBox();
            this.yearLaber = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(657, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ClassesView
            // 
            this.ClassesView.Location = new System.Drawing.Point(12, 165);
            this.ClassesView.Name = "ClassesView";
            this.ClassesView.Size = new System.Drawing.Size(450, 162);
            this.ClassesView.TabIndex = 10;
            this.ClassesView.UseCompatibleStateImageBehavior = false;
            this.ClassesView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ClassesView_ColumnClick);
            this.ClassesView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClassesView_MouseClick);
            this.ClassesView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ClassesView_MouseDoubleClick);
            // 
            // ClassText
            // 
            this.ClassText.Location = new System.Drawing.Point(588, 194);
            this.ClassText.Name = "ClassText";
            this.ClassText.Size = new System.Drawing.Size(144, 20);
            this.ClassText.TabIndex = 11;
            // 
            // CRNText
            // 
            this.CRNText.Location = new System.Drawing.Point(588, 172);
            this.CRNText.Name = "CRNText";
            this.CRNText.Size = new System.Drawing.Size(144, 20);
            this.CRNText.TabIndex = 13;
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterLabel.ForeColor = System.Drawing.Color.White;
            this.SemesterLabel.Location = new System.Drawing.Point(501, 220);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(53, 13);
            this.SemesterLabel.TabIndex = 15;
            this.SemesterLabel.Text = "Semester:";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLabel.ForeColor = System.Drawing.Color.White;
            this.ClassLabel.Location = new System.Drawing.Point(501, 197);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(64, 13);
            this.ClassLabel.TabIndex = 17;
            this.ClassLabel.Text = "Class Name:";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(43, 372);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 18;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(203, 372);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(75, 23);
            this.Remove_Button.TabIndex = 19;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Teacher Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Courses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(501, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "CRN Number:";
            // 
            // SemesterText
            // 
            this.SemesterText.Location = new System.Drawing.Point(588, 217);
            this.SemesterText.Name = "SemesterText";
            this.SemesterText.Size = new System.Drawing.Size(144, 20);
            this.SemesterText.TabIndex = 23;
            // 
            // yearLaber
            // 
            this.yearLaber.AutoSize = true;
            this.yearLaber.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLaber.ForeColor = System.Drawing.Color.White;
            this.yearLaber.Location = new System.Drawing.Point(501, 242);
            this.yearLaber.Name = "yearLaber";
            this.yearLaber.Size = new System.Drawing.Size(30, 13);
            this.yearLaber.TabIndex = 24;
            this.yearLaber.Text = "Year:";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(588, 239);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(144, 20);
            this.yearText.TabIndex = 25;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(160)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(755, 471);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.yearLaber);
            this.Controls.Add(this.SemesterText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.SemesterLabel);
            this.Controls.Add(this.CRNText);
            this.Controls.Add(this.ClassText);
            this.Controls.Add(this.ClassesView);
            this.Controls.Add(this.logoutButton);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ListView ClassesView;
        private System.Windows.Forms.TextBox ClassText;
        private System.Windows.Forms.TextBox CRNText;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SemesterText;
        private System.Windows.Forms.Label yearLaber;
        private System.Windows.Forms.TextBox yearText;
    }
}