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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.ClassesView = new System.Windows.Forms.ListView();
            this.ClassText = new System.Windows.Forms.TextBox();
            this.SemesterText = new System.Windows.Forms.TextBox();
            this.YearText = new System.Windows.Forms.TextBox();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 44);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Classes";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(12, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 29);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Teacher Name";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(682, 33);
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
            this.ClassesView.Size = new System.Drawing.Size(333, 162);
            this.ClassesView.TabIndex = 10;
            this.ClassesView.UseCompatibleStateImageBehavior = false;
            this.ClassesView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClassesView_MouseClick);
            this.ClassesView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ClassesView_MouseDoubleClick);
            // 
            // ClassText
            // 
            this.ClassText.Location = new System.Drawing.Point(429, 165);
            this.ClassText.Name = "ClassText";
            this.ClassText.Size = new System.Drawing.Size(144, 20);
            this.ClassText.TabIndex = 11;
            // 
            // SemesterText
            // 
            this.SemesterText.Location = new System.Drawing.Point(429, 217);
            this.SemesterText.Name = "SemesterText";
            this.SemesterText.Size = new System.Drawing.Size(100, 20);
            this.SemesterText.TabIndex = 13;
            // 
            // YearText
            // 
            this.YearText.Location = new System.Drawing.Point(429, 268);
            this.YearText.Name = "YearText";
            this.YearText.Size = new System.Drawing.Size(100, 20);
            this.YearText.TabIndex = 14;
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Location = new System.Drawing.Point(363, 220);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(54, 13);
            this.SemesterLabel.TabIndex = 15;
            this.SemesterLabel.Text = "Semester:";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(385, 271);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(32, 13);
            this.YearLabel.TabIndex = 16;
            this.YearLabel.Text = "Year:";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(351, 168);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(66, 13);
            this.ClassLabel.TabIndex = 17;
            this.ClassLabel.Text = "Class Name:";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(43, 372);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 18;
            this.Add_Button.Text = "ADD";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(203, 372);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(75, 23);
            this.Remove_Button.TabIndex = 19;
            this.Remove_Button.Text = "REMOVE";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 848);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.SemesterLabel);
            this.Controls.Add(this.YearText);
            this.Controls.Add(this.SemesterText);
            this.Controls.Add(this.ClassText);
            this.Controls.Add(this.ClassesView);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ListView ClassesView;
        private System.Windows.Forms.TextBox ClassText;
        private System.Windows.Forms.TextBox SemesterText;
        private System.Windows.Forms.TextBox YearText;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Remove_Button;
    }
}