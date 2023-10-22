namespace EnrolmentTimetableSystem
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            panel1 = new Panel();
            logoutButton = new Button();
            panel5 = new Panel();
            otherLabel = new Label();
            viewActivitiesButton = new Button();
            panel4 = new Panel();
            subjectAllocationButton = new Button();
            panel3 = new Panel();
            subjectRequestButton = new Button();
            panel2 = new Panel();
            welcomeLabel = new Label();
            roleLabel = new Label();
            titleLabel = new Label();
            pictureBox1 = new PictureBox();
            teacherTabControl = new TabControl();
            subjectRequestPage = new TabPage();
            viewRequestsGroupBox = new GroupBox();
            subjectRequestsTableLayoutPanel = new TableLayoutPanel();
            requestIDLabel = new Label();
            requestStatusLabel = new Label();
            requestTeacherIDLabel = new Label();
            requestSubjectLabel = new Label();
            requestMessageLabel = new Label();
            requestReasonForRejectionLabel = new Label();
            requestFormGroupBox = new GroupBox();
            requestSubmitButton = new Button();
            requestMessageRichTextBox = new RichTextBox();
            label2 = new Label();
            requestSubjectsComboBox = new ComboBox();
            label1 = new Label();
            subjectAllocationPage = new TabPage();
            viewActivitiesPage = new TabPage();
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
            teacherTabControl.SuspendLayout();
            subjectRequestPage.SuspendLayout();
            viewRequestsGroupBox.SuspendLayout();
            subjectRequestsTableLayoutPanel.SuspendLayout();
            requestFormGroupBox.SuspendLayout();
            viewActivitiesPage.SuspendLayout();
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
            panel1.Controls.Add(viewActivitiesButton);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(subjectAllocationButton);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(subjectRequestButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 767);
            panel1.TabIndex = 1;
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
            logoutButton.Click += LogoutButton_Click;
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
            // viewActivitiesButton
            // 
            viewActivitiesButton.BackColor = Color.FromArgb(106, 106, 106);
            viewActivitiesButton.Cursor = Cursors.Hand;
            viewActivitiesButton.Dock = DockStyle.Top;
            viewActivitiesButton.FlatAppearance.BorderSize = 0;
            viewActivitiesButton.FlatAppearance.MouseDownBackColor = Color.White;
            viewActivitiesButton.FlatAppearance.MouseOverBackColor = Color.White;
            viewActivitiesButton.FlatStyle = FlatStyle.Flat;
            viewActivitiesButton.ForeColor = Color.Black;
            viewActivitiesButton.Location = new Point(0, 250);
            viewActivitiesButton.Name = "viewActivitiesButton";
            viewActivitiesButton.Size = new Size(255, 35);
            viewActivitiesButton.TabIndex = 1;
            viewActivitiesButton.Text = "View Activities";
            viewActivitiesButton.UseVisualStyleBackColor = false;
            viewActivitiesButton.Click += ViewActivitiesButton_Click;
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
            // subjectAllocationButton
            // 
            subjectAllocationButton.BackColor = Color.FromArgb(106, 106, 106);
            subjectAllocationButton.Cursor = Cursors.Hand;
            subjectAllocationButton.Dock = DockStyle.Top;
            subjectAllocationButton.FlatAppearance.BorderSize = 0;
            subjectAllocationButton.FlatAppearance.MouseDownBackColor = Color.White;
            subjectAllocationButton.FlatAppearance.MouseOverBackColor = Color.White;
            subjectAllocationButton.FlatStyle = FlatStyle.Flat;
            subjectAllocationButton.ForeColor = Color.Black;
            subjectAllocationButton.Location = new Point(0, 200);
            subjectAllocationButton.Name = "subjectAllocationButton";
            subjectAllocationButton.Size = new Size(255, 35);
            subjectAllocationButton.TabIndex = 3;
            subjectAllocationButton.Text = "Subject Allocation";
            subjectAllocationButton.UseVisualStyleBackColor = false;
            subjectAllocationButton.Click += SubjectAllocationButton_Click;
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
            // subjectRequestButton
            // 
            subjectRequestButton.BackColor = Color.FromArgb(106, 106, 106);
            subjectRequestButton.Cursor = Cursors.Hand;
            subjectRequestButton.Dock = DockStyle.Top;
            subjectRequestButton.FlatAppearance.BorderSize = 0;
            subjectRequestButton.FlatAppearance.MouseDownBackColor = Color.White;
            subjectRequestButton.FlatAppearance.MouseOverBackColor = Color.White;
            subjectRequestButton.FlatStyle = FlatStyle.Flat;
            subjectRequestButton.ForeColor = Color.Black;
            subjectRequestButton.Location = new Point(0, 150);
            subjectRequestButton.Name = "subjectRequestButton";
            subjectRequestButton.Size = new Size(255, 35);
            subjectRequestButton.TabIndex = 1;
            subjectRequestButton.Text = "Subject Request";
            subjectRequestButton.UseVisualStyleBackColor = false;
            subjectRequestButton.Click += SubjectRequestButton_Click;
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
            roleLabel.Size = new Size(69, 21);
            roleLabel.TabIndex = 2;
            roleLabel.Text = "Teacher";
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
            // teacherTabControl
            // 
            teacherTabControl.Controls.Add(subjectRequestPage);
            teacherTabControl.Controls.Add(subjectAllocationPage);
            teacherTabControl.Controls.Add(viewActivitiesPage);
            teacherTabControl.Dock = DockStyle.Fill;
            teacherTabControl.Location = new Point(255, 0);
            teacherTabControl.Name = "teacherTabControl";
            teacherTabControl.SelectedIndex = 0;
            teacherTabControl.Size = new Size(992, 767);
            teacherTabControl.TabIndex = 8;
            // 
            // subjectRequestPage
            // 
            subjectRequestPage.Controls.Add(viewRequestsGroupBox);
            subjectRequestPage.Controls.Add(requestFormGroupBox);
            subjectRequestPage.Location = new Point(4, 24);
            subjectRequestPage.Name = "subjectRequestPage";
            subjectRequestPage.Padding = new Padding(3);
            subjectRequestPage.Size = new Size(984, 739);
            subjectRequestPage.TabIndex = 0;
            subjectRequestPage.Text = "subjectRequestTab";
            subjectRequestPage.UseVisualStyleBackColor = true;
            // 
            // viewRequestsGroupBox
            // 
            viewRequestsGroupBox.Controls.Add(subjectRequestsTableLayoutPanel);
            viewRequestsGroupBox.Dock = DockStyle.Fill;
            viewRequestsGroupBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            viewRequestsGroupBox.Location = new Point(3, 226);
            viewRequestsGroupBox.Name = "viewRequestsGroupBox";
            viewRequestsGroupBox.Size = new Size(978, 510);
            viewRequestsGroupBox.TabIndex = 1;
            viewRequestsGroupBox.TabStop = false;
            viewRequestsGroupBox.Text = "Requests";
            // 
            // subjectRequestsTableLayoutPanel
            // 
            subjectRequestsTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            subjectRequestsTableLayoutPanel.ColumnCount = 6;
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            subjectRequestsTableLayoutPanel.Controls.Add(requestIDLabel, 0, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestStatusLabel, 4, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestTeacherIDLabel, 1, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestSubjectLabel, 2, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestMessageLabel, 3, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestReasonForRejectionLabel, 5, 0);
            subjectRequestsTableLayoutPanel.Dock = DockStyle.Top;
            subjectRequestsTableLayoutPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            subjectRequestsTableLayoutPanel.Location = new Point(3, 28);
            subjectRequestsTableLayoutPanel.Name = "subjectRequestsTableLayoutPanel";
            subjectRequestsTableLayoutPanel.RowCount = 2;
            subjectRequestsTableLayoutPanel.RowStyles.Add(new RowStyle());
            subjectRequestsTableLayoutPanel.RowStyles.Add(new RowStyle());
            subjectRequestsTableLayoutPanel.Size = new Size(972, 100);
            subjectRequestsTableLayoutPanel.TabIndex = 4;
            // 
            // requestIDLabel
            // 
            requestIDLabel.AutoSize = true;
            requestIDLabel.Dock = DockStyle.Fill;
            requestIDLabel.Location = new Point(6, 3);
            requestIDLabel.Name = "requestIDLabel";
            requestIDLabel.Size = new Size(85, 21);
            requestIDLabel.TabIndex = 4;
            requestIDLabel.Text = "Request ID";
            requestIDLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // requestStatusLabel
            // 
            requestStatusLabel.AutoSize = true;
            requestStatusLabel.Dock = DockStyle.Fill;
            requestStatusLabel.Location = new Point(400, 3);
            requestStatusLabel.Name = "requestStatusLabel";
            requestStatusLabel.Size = new Size(112, 21);
            requestStatusLabel.TabIndex = 8;
            requestStatusLabel.Text = "Request Status";
            requestStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // requestTeacherIDLabel
            // 
            requestTeacherIDLabel.AutoSize = true;
            requestTeacherIDLabel.Dock = DockStyle.Fill;
            requestTeacherIDLabel.Location = new Point(100, 3);
            requestTeacherIDLabel.Name = "requestTeacherIDLabel";
            requestTeacherIDLabel.Size = new Size(81, 21);
            requestTeacherIDLabel.TabIndex = 5;
            requestTeacherIDLabel.Text = "Teacher ID";
            requestTeacherIDLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // requestSubjectLabel
            // 
            requestSubjectLabel.AutoSize = true;
            requestSubjectLabel.Dock = DockStyle.Fill;
            requestSubjectLabel.Location = new Point(190, 3);
            requestSubjectLabel.Name = "requestSubjectLabel";
            requestSubjectLabel.Size = new Size(61, 21);
            requestSubjectLabel.TabIndex = 6;
            requestSubjectLabel.Text = "Subject";
            requestSubjectLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // requestMessageLabel
            // 
            requestMessageLabel.AutoSize = true;
            requestMessageLabel.Dock = DockStyle.Fill;
            requestMessageLabel.Location = new Point(260, 3);
            requestMessageLabel.Name = "requestMessageLabel";
            requestMessageLabel.Size = new Size(131, 21);
            requestMessageLabel.TabIndex = 7;
            requestMessageLabel.Text = "Request Message";
            requestMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // requestReasonForRejectionLabel
            // 
            requestReasonForRejectionLabel.AutoSize = true;
            requestReasonForRejectionLabel.Dock = DockStyle.Fill;
            requestReasonForRejectionLabel.Location = new Point(521, 3);
            requestReasonForRejectionLabel.Name = "requestReasonForRejectionLabel";
            requestReasonForRejectionLabel.Size = new Size(445, 21);
            requestReasonForRejectionLabel.TabIndex = 9;
            requestReasonForRejectionLabel.Text = "Reason For Rejection";
            requestReasonForRejectionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // requestFormGroupBox
            // 
            requestFormGroupBox.Controls.Add(requestSubmitButton);
            requestFormGroupBox.Controls.Add(requestMessageRichTextBox);
            requestFormGroupBox.Controls.Add(label2);
            requestFormGroupBox.Controls.Add(requestSubjectsComboBox);
            requestFormGroupBox.Controls.Add(label1);
            requestFormGroupBox.Dock = DockStyle.Top;
            requestFormGroupBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            requestFormGroupBox.Location = new Point(3, 3);
            requestFormGroupBox.Name = "requestFormGroupBox";
            requestFormGroupBox.Size = new Size(978, 223);
            requestFormGroupBox.TabIndex = 0;
            requestFormGroupBox.TabStop = false;
            requestFormGroupBox.Text = "Submit a Request";
            // 
            // requestSubmitButton
            // 
            requestSubmitButton.BackColor = Color.LightSkyBlue;
            requestSubmitButton.Enabled = false;
            requestSubmitButton.FlatAppearance.BorderColor = Color.White;
            requestSubmitButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            requestSubmitButton.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            requestSubmitButton.FlatStyle = FlatStyle.Flat;
            requestSubmitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            requestSubmitButton.ForeColor = Color.White;
            requestSubmitButton.Location = new Point(720, 186);
            requestSubmitButton.Name = "requestSubmitButton";
            requestSubmitButton.Size = new Size(130, 32);
            requestSubmitButton.TabIndex = 4;
            requestSubmitButton.Text = "Submit";
            requestSubmitButton.UseVisualStyleBackColor = false;
            requestSubmitButton.Click += RequestSubmitButton_Click;
            // 
            // requestMessageRichTextBox
            // 
            requestMessageRichTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            requestMessageRichTextBox.Location = new Point(450, 80);
            requestMessageRichTextBox.Name = "requestMessageRichTextBox";
            requestMessageRichTextBox.Size = new Size(400, 100);
            requestMessageRichTextBox.TabIndex = 3;
            requestMessageRichTextBox.Text = "";
            requestMessageRichTextBox.TextChanged += OnFormChange;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(450, 50);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 2;
            label2.Text = "Message";
            // 
            // requestSubjectsComboBox
            // 
            requestSubjectsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            requestSubjectsComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            requestSubjectsComboBox.FormattingEnabled = true;
            requestSubjectsComboBox.Location = new Point(100, 80);
            requestSubjectsComboBox.Name = "requestSubjectsComboBox";
            requestSubjectsComboBox.Size = new Size(180, 29);
            requestSubjectsComboBox.TabIndex = 1;
            requestSubjectsComboBox.SelectedIndexChanged += OnFormChange;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 50);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 0;
            label1.Text = "Select a Subject";
            // 
            // subjectAllocationPage
            // 
            subjectAllocationPage.Location = new Point(4, 24);
            subjectAllocationPage.Name = "subjectAllocationPage";
            subjectAllocationPage.Padding = new Padding(3);
            subjectAllocationPage.Size = new Size(984, 739);
            subjectAllocationPage.TabIndex = 1;
            subjectAllocationPage.Text = "subjectAllocationTab";
            subjectAllocationPage.UseVisualStyleBackColor = true;
            // 
            // viewActivitiesPage
            // 
            viewActivitiesPage.BackColor = Color.Pink;
            viewActivitiesPage.BackgroundImageLayout = ImageLayout.Stretch;
            viewActivitiesPage.Controls.Add(groupBox2);
            viewActivitiesPage.Controls.Add(panel6);
            viewActivitiesPage.Location = new Point(4, 24);
            viewActivitiesPage.Name = "viewActivitiesPage";
            viewActivitiesPage.Size = new Size(984, 739);
            viewActivitiesPage.TabIndex = 2;
            viewActivitiesPage.Text = "viewActivitiesTab";
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
            groupBox2.TabIndex = 1;
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
            panel6.TabIndex = 2;
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
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 767);
            Controls.Add(teacherTabControl);
            Controls.Add(panel1);
            Name = "TeacherForm";
            Text = "TeacherForm";
            Load += TeacherForm_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            teacherTabControl.ResumeLayout(false);
            subjectRequestPage.ResumeLayout(false);
            viewRequestsGroupBox.ResumeLayout(false);
            subjectRequestsTableLayoutPanel.ResumeLayout(false);
            subjectRequestsTableLayoutPanel.PerformLayout();
            requestFormGroupBox.ResumeLayout(false);
            requestFormGroupBox.PerformLayout();
            viewActivitiesPage.ResumeLayout(false);
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
        private Button viewActivitiesButton;
        private Panel panel4;
        private Button subjectAllocationButton;
        private Panel panel3;
        private Button subjectRequestButton;
        private Panel panel2;
        private Label welcomeLabel;
        private Label roleLabel;
        private Label titleLabel;
        private PictureBox pictureBox1;
        private TabControl teacherTabControl;
        private TabPage subjectRequestPage;
        private TabPage subjectAllocationPage;
        private TabPage viewActivitiesPage;
        private GroupBox groupBox2;
        private Panel panel7;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Panel panel6;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private Panel panel9;
        private TextBox textBox14;
        private Panel panel8;
        private TextBox textBox13;
        private GroupBox requestFormGroupBox;
        private Label label1;
        private Label label2;
        private ComboBox requestSubjectsComboBox;
        private RichTextBox requestMessageRichTextBox;
        private Button requestSubmitButton;
        private GroupBox viewRequestsGroupBox;
        private TableLayoutPanel subjectRequestsTableLayoutPanel;
        private Label requestIDLabel;
        private Label requestTeacherIDLabel;
        private Label requestSubjectLabel;
        private Label requestMessageLabel;
        private Label requestStatusLabel;
        private Label requestReasonForRejectionLabel;
    }
}