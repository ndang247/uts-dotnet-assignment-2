﻿namespace EnrolmentTimetableSystem
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            panel1 = new Panel();
            logoutButton = new Button();
            panel5 = new Panel();
            otherLabel = new Label();
            viewTimetableButton = new Button();
            panel4 = new Panel();
            studentAllocationButton = new Button();
            panel3 = new Panel();
            this.subjectEnrolmentButton = new Button();
            panel2 = new Panel();
            welcomeLabel = new Label();
            roleLabel = new Label();
            titleLabel = new Label();
            pictureBox1 = new PictureBox();
            studentTabControl = new TabControl();
            this.subjectEnrolmentPage = new TabPage();
            this.subjectAllocationPage = new TabPage();
            activityTypeComboxBox = new ComboBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            textBox3 = new TextBox();
            viewTimetablePage = new TabPage();
            groupBox2 = new GroupBox();
            panel7 = new Panel();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            panel6 = new Panel();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            panel9 = new Panel();
            textBox14 = new TextBox();
            panel8 = new Panel();
            textBox13 = new TextBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            studentTabControl.SuspendLayout();
            subjectAllocationPage.SuspendLayout();
            groupBox1.SuspendLayout();
            viewTimetablePage.SuspendLayout();
            groupBox2.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.Controls.Add(logoutButton);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(viewTimetableButton);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(studentAllocationButton);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(this.subjectEnrolmentButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 767);
            panel1.TabIndex = 2;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.LightCoral;
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.Dock = DockStyle.Top;
            logoutButton.FlatAppearance.BorderColor = Color.LightCoral;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatAppearance.MouseDownBackColor = Color.Red;
            logoutButton.FlatAppearance.MouseOverBackColor = Color.Red;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.ForeColor = Color.WhiteSmoke;
            logoutButton.Location = new Point(0, 325);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(255, 35);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(otherLabel);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 285);
            panel5.Name = "panel5";
            panel5.Size = new Size(255, 40);
            panel5.TabIndex = 6;
            // 
            // otherLabel
            // 
            otherLabel.AutoSize = true;
            otherLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            otherLabel.Location = new Point(12, 15);
            otherLabel.Name = "otherLabel";
            otherLabel.Size = new Size(43, 15);
            otherLabel.TabIndex = 0;
            otherLabel.Text = "OTHER";
            otherLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // viewTimetableButton
            // 
            viewTimetableButton.BackColor = Color.FromArgb(106, 106, 106);
            viewTimetableButton.Cursor = Cursors.Hand;
            viewTimetableButton.Dock = DockStyle.Top;
            viewTimetableButton.FlatAppearance.BorderSize = 0;
            viewTimetableButton.FlatAppearance.MouseDownBackColor = Color.White;
            viewTimetableButton.FlatAppearance.MouseOverBackColor = Color.White;
            viewTimetableButton.FlatStyle = FlatStyle.Flat;
            viewTimetableButton.ForeColor = Color.Black;
            viewTimetableButton.Location = new Point(0, 250);
            viewTimetableButton.Name = "viewTimetableButton";
            viewTimetableButton.Size = new Size(255, 35);
            viewTimetableButton.TabIndex = 1;
            viewTimetableButton.Text = "View Timetable";
            viewTimetableButton.UseVisualStyleBackColor = false;
            viewTimetableButton.Click += removeFromASubjectButton_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 235);
            panel4.Name = "panel4";
            panel4.Size = new Size(255, 15);
            panel4.TabIndex = 5;
            // 
            // studentAllocationButton
            // 
            studentAllocationButton.BackColor = Color.FromArgb(106, 106, 106);
            studentAllocationButton.Cursor = Cursors.Hand;
            studentAllocationButton.Dock = DockStyle.Top;
            studentAllocationButton.FlatAppearance.BorderSize = 0;
            studentAllocationButton.FlatAppearance.MouseDownBackColor = Color.White;
            studentAllocationButton.FlatAppearance.MouseOverBackColor = Color.White;
            studentAllocationButton.FlatStyle = FlatStyle.Flat;
            studentAllocationButton.ForeColor = Color.Black;
            studentAllocationButton.Location = new Point(0, 200);
            studentAllocationButton.Name = "studentAllocationButton";
            studentAllocationButton.Size = new Size(255, 35);
            studentAllocationButton.TabIndex = 3;
            studentAllocationButton.Text = "Subject Allocation";
            studentAllocationButton.UseVisualStyleBackColor = false;
            studentAllocationButton.Click += addSubjectAndActivitiesButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 185);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 15);
            panel3.TabIndex = 2;
            // 
            // subjectEnrolmentButton
            // 
            this.subjectEnrolmentButton.BackColor = Color.FromArgb(106, 106, 106);
            this.subjectEnrolmentButton.Cursor = Cursors.Hand;
            this.subjectEnrolmentButton.Dock = DockStyle.Top;
            this.subjectEnrolmentButton.FlatAppearance.BorderSize = 0;
            this.subjectEnrolmentButton.FlatAppearance.MouseDownBackColor = Color.White;
            this.subjectEnrolmentButton.FlatAppearance.MouseOverBackColor = Color.White;
            this.subjectEnrolmentButton.FlatStyle = FlatStyle.Flat;
            this.subjectEnrolmentButton.ForeColor = Color.Black;
            this.subjectEnrolmentButton.Location = new Point(0, 150);
            this.subjectEnrolmentButton.Name = "subjectEnrolmentButton";
            this.subjectEnrolmentButton.Size = new Size(255, 35);
            this.subjectEnrolmentButton.TabIndex = 1;
            this.subjectEnrolmentButton.Text = "Subject Enrolment";
            this.subjectEnrolmentButton.UseVisualStyleBackColor = false;
            this.subjectEnrolmentButton.Click += this.viewSubjectRequestsButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(welcomeLabel);
            panel2.Controls.Add(roleLabel);
            panel2.Controls.Add(titleLabel);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 150);
            panel2.TabIndex = 1;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(12, 89);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(115, 21);
            welcomeLabel.TabIndex = 3;
            welcomeLabel.Text = "Welcome Back!";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roleLabel.Location = new Point(73, 46);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(70, 21);
            roleLabel.TabIndex = 2;
            roleLabel.Text = "Student";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(73, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(180, 21);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Allocate+Schedule 1.0";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // studentTabControl
            // 
            studentTabControl.Controls.Add(this.subjectEnrolmentPage);
            studentTabControl.Controls.Add(this.subjectAllocationPage);
            studentTabControl.Controls.Add(viewTimetablePage);
            studentTabControl.Dock = DockStyle.Fill;
            studentTabControl.Location = new Point(255, 0);
            studentTabControl.Name = "studentTabControl";
            studentTabControl.SelectedIndex = 0;
            studentTabControl.Size = new Size(992, 767);
            studentTabControl.TabIndex = 9;
            // 
            // subjectEnrolmentPage
            // 
            this.subjectEnrolmentPage.Location = new Point(4, 24);
            this.subjectEnrolmentPage.Name = "subjectEnrolmentPage";
            this.subjectEnrolmentPage.Padding = new Padding(3);
            this.subjectEnrolmentPage.Size = new Size(984, 739);
            this.subjectEnrolmentPage.TabIndex = 0;
            this.subjectEnrolmentPage.Text = "subjectEnrolmentTab";
            this.subjectEnrolmentPage.UseVisualStyleBackColor = true;
            // 
            // subjectAllocationPage
            // 
            this.subjectAllocationPage.Controls.Add(activityTypeComboxBox);
            this.subjectAllocationPage.Controls.Add(groupBox1);
            this.subjectAllocationPage.Controls.Add(button1);
            this.subjectAllocationPage.Controls.Add(textBox3);
            this.subjectAllocationPage.Location = new Point(4, 24);
            this.subjectAllocationPage.Name = "subjectAllocationPage";
            this.subjectAllocationPage.Padding = new Padding(3);
            this.subjectAllocationPage.Size = new Size(984, 739);
            this.subjectAllocationPage.TabIndex = 1;
            this.subjectAllocationPage.Text = "subjectAllocationTab";
            this.subjectAllocationPage.UseVisualStyleBackColor = true;
            // 
            // activityTypeComboxBox
            // 
            activityTypeComboxBox.DropDownStyle = ComboBoxStyle.DropDownList;
            activityTypeComboxBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityTypeComboxBox.FormattingEnabled = true;
            activityTypeComboxBox.Location = new Point(483, 102);
            activityTypeComboxBox.Name = "activityTypeComboxBox";
            activityTypeComboxBox.Size = new Size(180, 29);
            activityTypeComboxBox.TabIndex = 9;
            activityTypeComboxBox.SelectedIndexChanged += activityTypeComboxBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(56, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 97);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Subjects";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(19, 23);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = ".Net";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(19, 48);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cloud";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(397, 401);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Allocate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(93, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 16);
            textBox3.TabIndex = 0;
            textBox3.Text = "Subject Allocation";
            // 
            // viewTimetablePage
            // 
            viewTimetablePage.BackColor = Color.Pink;
            viewTimetablePage.BackgroundImageLayout = ImageLayout.Stretch;
            viewTimetablePage.Controls.Add(groupBox2);
            viewTimetablePage.Controls.Add(panel6);
            viewTimetablePage.Location = new Point(4, 24);
            viewTimetablePage.Name = "viewTimetablePage";
            viewTimetablePage.Size = new Size(984, 739);
            viewTimetablePage.TabIndex = 2;
            viewTimetablePage.Text = "viewTimetableTab";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightCyan;
            groupBox2.Controls.Add(panel7);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(100, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(0);
            groupBox2.Size = new Size(786, 46);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // panel7
            // 
            panel7.Location = new Point(0, 46);
            panel7.Name = "panel7";
            panel7.Size = new Size(786, 100);
            panel7.TabIndex = 0;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.LightCyan;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox9.ForeColor = Color.PaleVioletRed;
            textBox9.Location = new Point(675, 11);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 5;
            textBox9.Text = "4-6";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.LightCyan;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.ForeColor = Color.PaleVioletRed;
            textBox8.Location = new Point(536, 11);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 4;
            textBox8.Text = "2-4";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.LightCyan;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.ForeColor = Color.PaleVioletRed;
            textBox7.Location = new Point(398, 11);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 3;
            textBox7.Text = "12-2";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LightCyan;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.ForeColor = Color.PaleVioletRed;
            textBox6.Location = new Point(275, 11);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 2;
            textBox6.Text = "10-12";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightCyan;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.PaleVioletRed;
            textBox5.Location = new Point(152, 11);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 1;
            textBox5.Text = "8-10";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightCyan;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.PaleVioletRed;
            textBox4.Location = new Point(16, 11);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 0;
            textBox4.Text = "Days";
            // 
            // panel6
            // 
            panel6.BackColor = Color.GhostWhite;
            panel6.Controls.Add(textBox12);
            panel6.Controls.Add(textBox11);
            panel6.Controls.Add(textBox10);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.ForeColor = SystemColors.ActiveCaption;
            panel6.Location = new Point(100, 100);
            panel6.Name = "panel6";
            panel6.Size = new Size(786, 552);
            panel6.TabIndex = 0;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.GhostWhite;
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox12.ForeColor = Color.PaleVioletRed;
            textBox12.Location = new Point(16, 497);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 8;
            textBox12.Text = "Friday";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.GhostWhite;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox11.ForeColor = Color.PaleVioletRed;
            textBox11.Location = new Point(16, 286);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 7;
            textBox11.Text = "Wednesday";
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.GhostWhite;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox10.ForeColor = Color.PaleVioletRed;
            textBox10.Location = new Point(16, 82);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 6;
            textBox10.Text = "Monday";
            // 
            // panel9
            // 
            panel9.BackColor = Color.LavenderBlush;
            panel9.BackgroundImageLayout = ImageLayout.None;
            panel9.Controls.Add(textBox14);
            panel9.Location = new Point(0, 352);
            panel9.Name = "panel9";
            panel9.Size = new Size(786, 100);
            panel9.TabIndex = 1;
            // 
            // textBox14
            // 
            textBox14.BackColor = Color.LavenderBlush;
            textBox14.BorderStyle = BorderStyle.None;
            textBox14.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox14.ForeColor = Color.PaleVioletRed;
            textBox14.Location = new Point(16, 47);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(100, 23);
            textBox14.TabIndex = 10;
            textBox14.Text = "Thursday";
            // 
            // panel8
            // 
            panel8.BackColor = Color.LavenderBlush;
            panel8.BackgroundImageLayout = ImageLayout.None;
            panel8.Controls.Add(textBox13);
            panel8.Location = new Point(0, 140);
            panel8.Name = "panel8";
            panel8.Size = new Size(786, 100);
            panel8.TabIndex = 0;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.LavenderBlush;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox13.ForeColor = Color.PaleVioletRed;
            textBox13.Location = new Point(16, 42);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(100, 23);
            textBox13.TabIndex = 9;
            textBox13.Text = "Tuesday";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 767);
            Controls.Add(studentTabControl);
            Controls.Add(panel1);
            Name = "StudentForm";
            Text = "StudentForm";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            studentTabControl.ResumeLayout(false);
            this.subjectAllocationPage.ResumeLayout(false);
            this.subjectAllocationPage.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            viewTimetablePage.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button logoutButton;
        private Panel panel5;
        private Label otherLabel;
        private Button viewTimetableButton;
        private Panel panel4;
        private Button studentAllocationButton;
        private Panel panel3;
        private Button subjectEnrolmentButton;
        private Button studentEnrolmentButton;
        private Panel panel2;
        private Label welcomeLabel;
        private Label roleLabel;
        private Label titleLabel;
        private PictureBox pictureBox1;
        private TabControl studentTabControl;
        private TabPage subjectEnrolmentPage;
        private TabPage homePage;
        private TextBox textBox2;
        private TabPage subjectEnrolment;
        private TextBox textBox1;
        private VScrollBar vScrollBar1;
        private TabPage subjectAllocation;
        private TextBox textBox3;
        private TabPage viewTimetablePage;
        private Button button1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private TabPage subjectAllocationPage;
        private ComboBox activityTypeComboxBox;
        private Panel panel6;
        private GroupBox groupBox2;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox14;
        private TextBox textBox13;
    }
}