namespace EnrolmentTimetableSystem
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            panel1 = new Panel();
            logoutButton = new Button();
            panel5 = new Panel();
            otherLabel = new Label();
            removeFromASubjectButton = new Button();
            panel4 = new Panel();
            addSubjectAndActivitiesButton = new Button();
            panel3 = new Panel();
            viewSubjectRequestsButton = new Button();
            panel2 = new Panel();
            welcomeLabel = new Label();
            roleLabel = new Label();
            titleLabel = new Label();
            pictureBox1 = new PictureBox();
            adminTabControl = new TabControl();
            viewSubjectRequestsPage = new TabPage();
            viewRequestsGroupBox = new GroupBox();
            subjectRequestsTableLayoutPanel = new TableLayoutPanel();
            requestIDLabel = new Label();
            requestTeacherIDLabel = new Label();
            requestSubjectLabel = new Label();
            requestMessageLabel = new Label();
            requestStatusLabel = new Label();
            requestReasonForRejectionLabel = new Label();
            approveRequestGroupBox = new GroupBox();
            rejectionReasonRichTextBox = new RichTextBox();
            rejectionReasonLabel = new Label();
            rejectButton = new Button();
            approveButton = new Button();
            messageRichTextBox = new RichTextBox();
            subjectTextBox = new TextBox();
            statusTextBox = new TextBox();
            teacherFullNameTextBox = new TextBox();
            statusLabel = new Label();
            messageLabel = new Label();
            subjectLabel = new Label();
            teacherFullNameLabel = new Label();
            requestLabel = new Label();
            requestsComboBox = new ComboBox();
            addASubjectAndActivitiesPage = new TabPage();
            addActivitiesGroup = new GroupBox();
            activityEndDateTimePicker = new DateTimePicker();
            activityEndLabel = new Label();
            activityStartDateTimePicker = new DateTimePicker();
            addSubjectActivityButton = new Button();
            activityDurationNumericUpDown = new NumericUpDown();
            activityLocationTextBox = new TextBox();
            activityCampusTextBox = new TextBox();
            activityDescriptionTextBox = new TextBox();
            activityDateTimePicker = new DateTimePicker();
            activityDayComboBox = new ComboBox();
            activityDescriptionLabel = new Label();
            activityStartLabel = new Label();
            activityDurationLabel = new Label();
            activityLocationLabel = new Label();
            activityCampusLabel = new Label();
            activityTimeLabel = new Label();
            activityDayLabel = new Label();
            activityTypeLabel = new Label();
            activityTypeComboxBox = new ComboBox();
            addASubjectGroup = new GroupBox();
            generateSubjectCodeButton = new Button();
            addSubjectButton = new Button();
            sjNameTextBox = new TextBox();
            sjCodeTextBox = new TextBox();
            sjNameLabel = new Label();
            sjCodeLabel = new Label();
            removeFromASubjectPage = new TabPage();
            enrolmentTabControl = new TabControl();
            studentsEnrolmentTabPage = new TabPage();
            removeStudentFromSubjectButton = new Button();
            studentsListBox = new ListBox();
            teachersEnrolmentTabPage = new TabPage();
            removeTeacherFromSubjectButton = new Button();
            teachersListBox = new ListBox();
            subjectsListBox = new ListBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            adminTabControl.SuspendLayout();
            viewSubjectRequestsPage.SuspendLayout();
            viewRequestsGroupBox.SuspendLayout();
            subjectRequestsTableLayoutPanel.SuspendLayout();
            approveRequestGroupBox.SuspendLayout();
            addASubjectAndActivitiesPage.SuspendLayout();
            addActivitiesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)activityDurationNumericUpDown).BeginInit();
            addASubjectGroup.SuspendLayout();
            removeFromASubjectPage.SuspendLayout();
            enrolmentTabControl.SuspendLayout();
            studentsEnrolmentTabPage.SuspendLayout();
            teachersEnrolmentTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.Controls.Add(logoutButton);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(removeFromASubjectButton);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(addSubjectAndActivitiesButton);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(viewSubjectRequestsButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 767);
            panel1.TabIndex = 0;
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
            logoutButton.Size = new Size(270, 35);
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
            panel5.Size = new Size(270, 40);
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
            // removeFromASubjectButton
            // 
            removeFromASubjectButton.BackColor = Color.FromArgb(106, 106, 106);
            removeFromASubjectButton.Cursor = Cursors.Hand;
            removeFromASubjectButton.Dock = DockStyle.Top;
            removeFromASubjectButton.FlatAppearance.BorderSize = 0;
            removeFromASubjectButton.FlatAppearance.MouseDownBackColor = Color.White;
            removeFromASubjectButton.FlatAppearance.MouseOverBackColor = Color.White;
            removeFromASubjectButton.FlatStyle = FlatStyle.Flat;
            removeFromASubjectButton.ForeColor = Color.Black;
            removeFromASubjectButton.Location = new Point(0, 250);
            removeFromASubjectButton.Name = "removeFromASubjectButton";
            removeFromASubjectButton.Size = new Size(270, 35);
            removeFromASubjectButton.TabIndex = 1;
            removeFromASubjectButton.Text = "Remove From a Subject";
            removeFromASubjectButton.UseVisualStyleBackColor = false;
            removeFromASubjectButton.Click += RemoveFromASubjectButton_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 235);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 15);
            panel4.TabIndex = 5;
            // 
            // addSubjectAndActivitiesButton
            // 
            addSubjectAndActivitiesButton.BackColor = Color.FromArgb(106, 106, 106);
            addSubjectAndActivitiesButton.Cursor = Cursors.Hand;
            addSubjectAndActivitiesButton.Dock = DockStyle.Top;
            addSubjectAndActivitiesButton.FlatAppearance.BorderSize = 0;
            addSubjectAndActivitiesButton.FlatAppearance.MouseDownBackColor = Color.White;
            addSubjectAndActivitiesButton.FlatAppearance.MouseOverBackColor = Color.White;
            addSubjectAndActivitiesButton.FlatStyle = FlatStyle.Flat;
            addSubjectAndActivitiesButton.ForeColor = Color.Black;
            addSubjectAndActivitiesButton.Location = new Point(0, 200);
            addSubjectAndActivitiesButton.Name = "addSubjectAndActivitiesButton";
            addSubjectAndActivitiesButton.Size = new Size(270, 35);
            addSubjectAndActivitiesButton.TabIndex = 3;
            addSubjectAndActivitiesButton.Text = "Add a Subject and Activities";
            addSubjectAndActivitiesButton.UseVisualStyleBackColor = false;
            addSubjectAndActivitiesButton.Click += AddSubjectAndActivitiesButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 185);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 15);
            panel3.TabIndex = 2;
            // 
            // viewSubjectRequestsButton
            // 
            viewSubjectRequestsButton.BackColor = Color.FromArgb(106, 106, 106);
            viewSubjectRequestsButton.Cursor = Cursors.Hand;
            viewSubjectRequestsButton.Dock = DockStyle.Top;
            viewSubjectRequestsButton.FlatAppearance.BorderSize = 0;
            viewSubjectRequestsButton.FlatAppearance.MouseDownBackColor = Color.White;
            viewSubjectRequestsButton.FlatAppearance.MouseOverBackColor = Color.White;
            viewSubjectRequestsButton.FlatStyle = FlatStyle.Flat;
            viewSubjectRequestsButton.ForeColor = Color.Black;
            viewSubjectRequestsButton.Location = new Point(0, 150);
            viewSubjectRequestsButton.Name = "viewSubjectRequestsButton";
            viewSubjectRequestsButton.Size = new Size(270, 35);
            viewSubjectRequestsButton.TabIndex = 1;
            viewSubjectRequestsButton.Text = "View Subject Requests";
            viewSubjectRequestsButton.UseVisualStyleBackColor = false;
            viewSubjectRequestsButton.Click += ViewSubjectRequestsButton_Click;
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
            panel2.Size = new Size(270, 150);
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
            roleLabel.Size = new Size(111, 21);
            roleLabel.TabIndex = 2;
            roleLabel.Text = "Adminstrator";
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
            // adminTabControl
            // 
            adminTabControl.Controls.Add(viewSubjectRequestsPage);
            adminTabControl.Controls.Add(addASubjectAndActivitiesPage);
            adminTabControl.Controls.Add(removeFromASubjectPage);
            adminTabControl.Dock = DockStyle.Fill;
            adminTabControl.Location = new Point(270, 0);
            adminTabControl.Name = "adminTabControl";
            adminTabControl.SelectedIndex = 0;
            adminTabControl.Size = new Size(977, 767);
            adminTabControl.TabIndex = 7;
            // 
            // viewSubjectRequestsPage
            // 
            viewSubjectRequestsPage.Controls.Add(viewRequestsGroupBox);
            viewSubjectRequestsPage.Controls.Add(approveRequestGroupBox);
            viewSubjectRequestsPage.Location = new Point(4, 24);
            viewSubjectRequestsPage.Name = "viewSubjectRequestsPage";
            viewSubjectRequestsPage.Padding = new Padding(3);
            viewSubjectRequestsPage.Size = new Size(969, 739);
            viewSubjectRequestsPage.TabIndex = 0;
            viewSubjectRequestsPage.Text = "viewSubjectRequestsTab";
            viewSubjectRequestsPage.UseVisualStyleBackColor = true;
            // 
            // viewRequestsGroupBox
            // 
            viewRequestsGroupBox.Controls.Add(subjectRequestsTableLayoutPanel);
            viewRequestsGroupBox.Dock = DockStyle.Fill;
            viewRequestsGroupBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            viewRequestsGroupBox.Location = new Point(3, 402);
            viewRequestsGroupBox.Name = "viewRequestsGroupBox";
            viewRequestsGroupBox.Size = new Size(963, 334);
            viewRequestsGroupBox.TabIndex = 5;
            viewRequestsGroupBox.TabStop = false;
            viewRequestsGroupBox.Text = "View Requests";
            // 
            // subjectRequestsTableLayoutPanel
            // 
            subjectRequestsTableLayoutPanel.AutoSize = true;
            subjectRequestsTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            subjectRequestsTableLayoutPanel.ColumnCount = 6;
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            subjectRequestsTableLayoutPanel.Controls.Add(requestIDLabel, 0, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestTeacherIDLabel, 1, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestSubjectLabel, 2, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestMessageLabel, 3, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestStatusLabel, 4, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestReasonForRejectionLabel, 5, 0);
            subjectRequestsTableLayoutPanel.Dock = DockStyle.Top;
            subjectRequestsTableLayoutPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            subjectRequestsTableLayoutPanel.Location = new Point(3, 28);
            subjectRequestsTableLayoutPanel.Name = "subjectRequestsTableLayoutPanel";
            subjectRequestsTableLayoutPanel.RowCount = 2;
            subjectRequestsTableLayoutPanel.RowStyles.Add(new RowStyle());
            subjectRequestsTableLayoutPanel.RowStyles.Add(new RowStyle());
            subjectRequestsTableLayoutPanel.Size = new Size(957, 30);
            subjectRequestsTableLayoutPanel.TabIndex = 5;
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
            // requestReasonForRejectionLabel
            // 
            requestReasonForRejectionLabel.AutoSize = true;
            requestReasonForRejectionLabel.Dock = DockStyle.Fill;
            requestReasonForRejectionLabel.Location = new Point(521, 3);
            requestReasonForRejectionLabel.Name = "requestReasonForRejectionLabel";
            requestReasonForRejectionLabel.Size = new Size(430, 21);
            requestReasonForRejectionLabel.TabIndex = 9;
            requestReasonForRejectionLabel.Text = "Reason For Rejection";
            requestReasonForRejectionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // approveRequestGroupBox
            // 
            approveRequestGroupBox.Controls.Add(rejectionReasonRichTextBox);
            approveRequestGroupBox.Controls.Add(rejectionReasonLabel);
            approveRequestGroupBox.Controls.Add(rejectButton);
            approveRequestGroupBox.Controls.Add(approveButton);
            approveRequestGroupBox.Controls.Add(messageRichTextBox);
            approveRequestGroupBox.Controls.Add(subjectTextBox);
            approveRequestGroupBox.Controls.Add(statusTextBox);
            approveRequestGroupBox.Controls.Add(teacherFullNameTextBox);
            approveRequestGroupBox.Controls.Add(statusLabel);
            approveRequestGroupBox.Controls.Add(messageLabel);
            approveRequestGroupBox.Controls.Add(subjectLabel);
            approveRequestGroupBox.Controls.Add(teacherFullNameLabel);
            approveRequestGroupBox.Controls.Add(requestLabel);
            approveRequestGroupBox.Controls.Add(requestsComboBox);
            approveRequestGroupBox.Dock = DockStyle.Top;
            approveRequestGroupBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            approveRequestGroupBox.Location = new Point(3, 3);
            approveRequestGroupBox.Name = "approveRequestGroupBox";
            approveRequestGroupBox.Size = new Size(963, 399);
            approveRequestGroupBox.TabIndex = 4;
            approveRequestGroupBox.TabStop = false;
            approveRequestGroupBox.Text = "Approve a Request";
            // 
            // rejectionReasonRichTextBox
            // 
            rejectionReasonRichTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rejectionReasonRichTextBox.Location = new Point(700, 220);
            rejectionReasonRichTextBox.Name = "rejectionReasonRichTextBox";
            rejectionReasonRichTextBox.Size = new Size(353, 96);
            rejectionReasonRichTextBox.TabIndex = 13;
            rejectionReasonRichTextBox.Text = "";
            rejectionReasonRichTextBox.Visible = false;
            // 
            // rejectionReasonLabel
            // 
            rejectionReasonLabel.AutoSize = true;
            rejectionReasonLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rejectionReasonLabel.Location = new Point(700, 190);
            rejectionReasonLabel.Name = "rejectionReasonLabel";
            rejectionReasonLabel.Size = new Size(129, 21);
            rejectionReasonLabel.TabIndex = 12;
            rejectionReasonLabel.Text = "Rejection Reason";
            rejectionReasonLabel.Visible = false;
            // 
            // rejectButton
            // 
            rejectButton.BackColor = Color.LightCoral;
            rejectButton.Cursor = Cursors.Hand;
            rejectButton.Enabled = false;
            rejectButton.FlatAppearance.BorderColor = Color.White;
            rejectButton.FlatAppearance.MouseDownBackColor = Color.Red;
            rejectButton.FlatAppearance.MouseOverBackColor = Color.Red;
            rejectButton.FlatStyle = FlatStyle.Flat;
            rejectButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rejectButton.ForeColor = Color.White;
            rejectButton.Location = new Point(827, 361);
            rejectButton.Name = "rejectButton";
            rejectButton.Size = new Size(130, 32);
            rejectButton.TabIndex = 11;
            rejectButton.Text = "Reject";
            rejectButton.UseVisualStyleBackColor = false;
            rejectButton.Click += RejectButton_Click;
            // 
            // approveButton
            // 
            approveButton.BackColor = Color.LightGreen;
            approveButton.Cursor = Cursors.Hand;
            approveButton.Enabled = false;
            approveButton.FlatAppearance.BorderColor = Color.White;
            approveButton.FlatAppearance.MouseDownBackColor = Color.Lime;
            approveButton.FlatAppearance.MouseOverBackColor = Color.Lime;
            approveButton.FlatStyle = FlatStyle.Flat;
            approveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            approveButton.ForeColor = Color.White;
            approveButton.Location = new Point(691, 361);
            approveButton.Name = "approveButton";
            approveButton.Size = new Size(130, 32);
            approveButton.TabIndex = 10;
            approveButton.Text = "Approve";
            approveButton.UseVisualStyleBackColor = false;
            approveButton.Click += ApproveButton_Click;
            // 
            // messageRichTextBox
            // 
            messageRichTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            messageRichTextBox.Location = new Point(400, 140);
            messageRichTextBox.Name = "messageRichTextBox";
            messageRichTextBox.ReadOnly = true;
            messageRichTextBox.Size = new Size(255, 148);
            messageRichTextBox.TabIndex = 9;
            messageRichTextBox.Text = "";
            // 
            // subjectTextBox
            // 
            subjectTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            subjectTextBox.Location = new Point(700, 60);
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.ReadOnly = true;
            subjectTextBox.Size = new Size(180, 29);
            subjectTextBox.TabIndex = 8;
            // 
            // statusTextBox
            // 
            statusTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusTextBox.Location = new Point(700, 140);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.ReadOnly = true;
            statusTextBox.Size = new Size(180, 29);
            statusTextBox.TabIndex = 7;
            // 
            // teacherFullNameTextBox
            // 
            teacherFullNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teacherFullNameTextBox.Location = new Point(400, 60);
            teacherFullNameTextBox.Name = "teacherFullNameTextBox";
            teacherFullNameTextBox.ReadOnly = true;
            teacherFullNameTextBox.Size = new Size(180, 29);
            teacherFullNameTextBox.TabIndex = 6;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusLabel.Location = new Point(700, 110);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(52, 21);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            messageLabel.Location = new Point(400, 110);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(71, 21);
            messageLabel.TabIndex = 4;
            messageLabel.Text = "Message";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            subjectLabel.Location = new Point(700, 30);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(61, 21);
            subjectLabel.TabIndex = 3;
            subjectLabel.Text = "Subject";
            // 
            // teacherFullNameLabel
            // 
            teacherFullNameLabel.AutoSize = true;
            teacherFullNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teacherFullNameLabel.Location = new Point(400, 30);
            teacherFullNameLabel.Name = "teacherFullNameLabel";
            teacherFullNameLabel.Size = new Size(137, 21);
            teacherFullNameLabel.TabIndex = 2;
            teacherFullNameLabel.Text = "Teacher Full Name";
            // 
            // requestLabel
            // 
            requestLabel.AutoSize = true;
            requestLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            requestLabel.Location = new Point(100, 30);
            requestLabel.Name = "requestLabel";
            requestLabel.Size = new Size(73, 21);
            requestLabel.TabIndex = 1;
            requestLabel.Text = "Requests";
            // 
            // requestsComboBox
            // 
            requestsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            requestsComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            requestsComboBox.FormattingEnabled = true;
            requestsComboBox.Location = new Point(100, 60);
            requestsComboBox.Name = "requestsComboBox";
            requestsComboBox.Size = new Size(180, 29);
            requestsComboBox.TabIndex = 0;
            requestsComboBox.SelectedIndexChanged += RequestsComboBox_SelectedIndexChanged;
            // 
            // addASubjectAndActivitiesPage
            // 
            addASubjectAndActivitiesPage.Controls.Add(addActivitiesGroup);
            addASubjectAndActivitiesPage.Controls.Add(addASubjectGroup);
            addASubjectAndActivitiesPage.Location = new Point(4, 24);
            addASubjectAndActivitiesPage.Name = "addASubjectAndActivitiesPage";
            addASubjectAndActivitiesPage.Padding = new Padding(3);
            addASubjectAndActivitiesPage.Size = new Size(969, 739);
            addASubjectAndActivitiesPage.TabIndex = 1;
            addASubjectAndActivitiesPage.Text = "addASubjectAndActivitiesTab";
            addASubjectAndActivitiesPage.UseVisualStyleBackColor = true;
            // 
            // addActivitiesGroup
            // 
            addActivitiesGroup.Controls.Add(activityEndDateTimePicker);
            addActivitiesGroup.Controls.Add(activityEndLabel);
            addActivitiesGroup.Controls.Add(activityStartDateTimePicker);
            addActivitiesGroup.Controls.Add(addSubjectActivityButton);
            addActivitiesGroup.Controls.Add(activityDurationNumericUpDown);
            addActivitiesGroup.Controls.Add(activityLocationTextBox);
            addActivitiesGroup.Controls.Add(activityCampusTextBox);
            addActivitiesGroup.Controls.Add(activityDescriptionTextBox);
            addActivitiesGroup.Controls.Add(activityDateTimePicker);
            addActivitiesGroup.Controls.Add(activityDayComboBox);
            addActivitiesGroup.Controls.Add(activityDescriptionLabel);
            addActivitiesGroup.Controls.Add(activityStartLabel);
            addActivitiesGroup.Controls.Add(activityDurationLabel);
            addActivitiesGroup.Controls.Add(activityLocationLabel);
            addActivitiesGroup.Controls.Add(activityCampusLabel);
            addActivitiesGroup.Controls.Add(activityTimeLabel);
            addActivitiesGroup.Controls.Add(activityDayLabel);
            addActivitiesGroup.Controls.Add(activityTypeLabel);
            addActivitiesGroup.Controls.Add(activityTypeComboxBox);
            addActivitiesGroup.Dock = DockStyle.Fill;
            addActivitiesGroup.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            addActivitiesGroup.Location = new Point(3, 126);
            addActivitiesGroup.Name = "addActivitiesGroup";
            addActivitiesGroup.Size = new Size(963, 610);
            addActivitiesGroup.TabIndex = 1;
            addActivitiesGroup.TabStop = false;
            addActivitiesGroup.Text = "Add an Activity";
            addActivitiesGroup.Visible = false;
            // 
            // activityEndDateTimePicker
            // 
            activityEndDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityEndDateTimePicker.Location = new Point(400, 305);
            activityEndDateTimePicker.MinDate = new DateTime(2023, 10, 26, 0, 0, 0, 0);
            activityEndDateTimePicker.Name = "activityEndDateTimePicker";
            activityEndDateTimePicker.Size = new Size(280, 29);
            activityEndDateTimePicker.TabIndex = 27;
            activityEndDateTimePicker.Value = new DateTime(2023, 10, 26, 0, 0, 0, 0);
            // 
            // activityEndLabel
            // 
            activityEndLabel.AutoSize = true;
            activityEndLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityEndLabel.Location = new Point(400, 275);
            activityEndLabel.Name = "activityEndLabel";
            activityEndLabel.Size = new Size(36, 21);
            activityEndLabel.TabIndex = 26;
            activityEndLabel.Text = "End";
            // 
            // activityStartDateTimePicker
            // 
            activityStartDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityStartDateTimePicker.Location = new Point(400, 225);
            activityStartDateTimePicker.MinDate = new DateTime(2023, 10, 26, 0, 0, 0, 0);
            activityStartDateTimePicker.Name = "activityStartDateTimePicker";
            activityStartDateTimePicker.Size = new Size(280, 29);
            activityStartDateTimePicker.TabIndex = 25;
            activityStartDateTimePicker.Value = new DateTime(2023, 10, 26, 0, 0, 0, 0);
            activityStartDateTimePicker.ValueChanged += ActivityStartDateTimePicker_ValueChanged;
            // 
            // addSubjectActivityButton
            // 
            addSubjectActivityButton.BackColor = Color.LightSkyBlue;
            addSubjectActivityButton.Cursor = Cursors.Hand;
            addSubjectActivityButton.FlatAppearance.BorderColor = Color.White;
            addSubjectActivityButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            addSubjectActivityButton.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            addSubjectActivityButton.FlatStyle = FlatStyle.Flat;
            addSubjectActivityButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addSubjectActivityButton.ForeColor = Color.White;
            addSubjectActivityButton.Location = new Point(680, 570);
            addSubjectActivityButton.Name = "addSubjectActivityButton";
            addSubjectActivityButton.Size = new Size(160, 32);
            addSubjectActivityButton.TabIndex = 7;
            addSubjectActivityButton.Text = "Add Activity";
            addSubjectActivityButton.UseVisualStyleBackColor = false;
            addSubjectActivityButton.Click += AddSubjectActivityButton_Click;
            // 
            // activityDurationNumericUpDown
            // 
            activityDurationNumericUpDown.DecimalPlaces = 1;
            activityDurationNumericUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityDurationNumericUpDown.Location = new Point(700, 65);
            activityDurationNumericUpDown.Minimum = new decimal(new int[] { 10, 0, 0, 65536 });
            activityDurationNumericUpDown.Name = "activityDurationNumericUpDown";
            activityDurationNumericUpDown.Size = new Size(180, 29);
            activityDurationNumericUpDown.TabIndex = 24;
            activityDurationNumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            // 
            // activityLocationTextBox
            // 
            activityLocationTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityLocationTextBox.Location = new Point(100, 305);
            activityLocationTextBox.Name = "activityLocationTextBox";
            activityLocationTextBox.Size = new Size(180, 29);
            activityLocationTextBox.TabIndex = 22;
            // 
            // activityCampusTextBox
            // 
            activityCampusTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityCampusTextBox.Location = new Point(100, 225);
            activityCampusTextBox.Name = "activityCampusTextBox";
            activityCampusTextBox.Size = new Size(180, 29);
            activityCampusTextBox.TabIndex = 21;
            // 
            // activityDescriptionTextBox
            // 
            activityDescriptionTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityDescriptionTextBox.Location = new Point(400, 145);
            activityDescriptionTextBox.Name = "activityDescriptionTextBox";
            activityDescriptionTextBox.Size = new Size(180, 29);
            activityDescriptionTextBox.TabIndex = 20;
            // 
            // activityDateTimePicker
            // 
            activityDateTimePicker.Checked = false;
            activityDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityDateTimePicker.Format = DateTimePickerFormat.Time;
            activityDateTimePicker.Location = new Point(100, 145);
            activityDateTimePicker.Name = "activityDateTimePicker";
            activityDateTimePicker.Size = new Size(180, 29);
            activityDateTimePicker.TabIndex = 18;
            // 
            // activityDayComboBox
            // 
            activityDayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            activityDayComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityDayComboBox.FormattingEnabled = true;
            activityDayComboBox.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" });
            activityDayComboBox.Location = new Point(400, 65);
            activityDayComboBox.Name = "activityDayComboBox";
            activityDayComboBox.Size = new Size(180, 29);
            activityDayComboBox.TabIndex = 17;
            // 
            // activityDescriptionLabel
            // 
            activityDescriptionLabel.AutoSize = true;
            activityDescriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityDescriptionLabel.Location = new Point(400, 115);
            activityDescriptionLabel.Name = "activityDescriptionLabel";
            activityDescriptionLabel.Size = new Size(89, 21);
            activityDescriptionLabel.TabIndex = 16;
            activityDescriptionLabel.Text = "Description";
            // 
            // activityStartLabel
            // 
            activityStartLabel.AutoSize = true;
            activityStartLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityStartLabel.Location = new Point(400, 195);
            activityStartLabel.Name = "activityStartLabel";
            activityStartLabel.Size = new Size(42, 21);
            activityStartLabel.TabIndex = 15;
            activityStartLabel.Text = "Start";
            // 
            // activityDurationLabel
            // 
            activityDurationLabel.AutoSize = true;
            activityDurationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityDurationLabel.Location = new Point(700, 35);
            activityDurationLabel.Name = "activityDurationLabel";
            activityDurationLabel.Size = new Size(71, 21);
            activityDurationLabel.TabIndex = 14;
            activityDurationLabel.Text = "Duration";
            // 
            // activityLocationLabel
            // 
            activityLocationLabel.AutoSize = true;
            activityLocationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityLocationLabel.Location = new Point(100, 275);
            activityLocationLabel.Name = "activityLocationLabel";
            activityLocationLabel.Size = new Size(69, 21);
            activityLocationLabel.TabIndex = 13;
            activityLocationLabel.Text = "Location";
            // 
            // activityCampusLabel
            // 
            activityCampusLabel.AutoSize = true;
            activityCampusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityCampusLabel.Location = new Point(100, 195);
            activityCampusLabel.Name = "activityCampusLabel";
            activityCampusLabel.Size = new Size(67, 21);
            activityCampusLabel.TabIndex = 12;
            activityCampusLabel.Text = "Campus";
            // 
            // activityTimeLabel
            // 
            activityTimeLabel.AutoSize = true;
            activityTimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityTimeLabel.Location = new Point(100, 115);
            activityTimeLabel.Name = "activityTimeLabel";
            activityTimeLabel.Size = new Size(44, 21);
            activityTimeLabel.TabIndex = 11;
            activityTimeLabel.Text = "Time";
            // 
            // activityDayLabel
            // 
            activityDayLabel.AutoSize = true;
            activityDayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityDayLabel.Location = new Point(400, 35);
            activityDayLabel.Name = "activityDayLabel";
            activityDayLabel.Size = new Size(37, 21);
            activityDayLabel.TabIndex = 10;
            activityDayLabel.Text = "Day";
            // 
            // activityTypeLabel
            // 
            activityTypeLabel.AutoSize = true;
            activityTypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityTypeLabel.Location = new Point(100, 35);
            activityTypeLabel.Name = "activityTypeLabel";
            activityTypeLabel.Size = new Size(97, 21);
            activityTypeLabel.TabIndex = 9;
            activityTypeLabel.Text = "Activity Type";
            // 
            // activityTypeComboxBox
            // 
            activityTypeComboxBox.DropDownStyle = ComboBoxStyle.DropDownList;
            activityTypeComboxBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityTypeComboxBox.FormattingEnabled = true;
            activityTypeComboxBox.Items.AddRange(new object[] { "Lecture", "Tutorial", "Workshop", "Seminar", "Lab Session" });
            activityTypeComboxBox.Location = new Point(100, 65);
            activityTypeComboxBox.Name = "activityTypeComboxBox";
            activityTypeComboxBox.Size = new Size(180, 29);
            activityTypeComboxBox.TabIndex = 8;
            // 
            // addASubjectGroup
            // 
            addASubjectGroup.Controls.Add(generateSubjectCodeButton);
            addASubjectGroup.Controls.Add(addSubjectButton);
            addASubjectGroup.Controls.Add(sjNameTextBox);
            addASubjectGroup.Controls.Add(sjCodeTextBox);
            addASubjectGroup.Controls.Add(sjNameLabel);
            addASubjectGroup.Controls.Add(sjCodeLabel);
            addASubjectGroup.Dock = DockStyle.Top;
            addASubjectGroup.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            addASubjectGroup.Location = new Point(3, 3);
            addASubjectGroup.Name = "addASubjectGroup";
            addASubjectGroup.Size = new Size(963, 123);
            addASubjectGroup.TabIndex = 0;
            addASubjectGroup.TabStop = false;
            addASubjectGroup.Text = "Add a Subject";
            // 
            // generateSubjectCodeButton
            // 
            generateSubjectCodeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            generateSubjectCodeButton.Location = new Point(286, 60);
            generateSubjectCodeButton.Name = "generateSubjectCodeButton";
            generateSubjectCodeButton.Size = new Size(80, 32);
            generateSubjectCodeButton.TabIndex = 4;
            generateSubjectCodeButton.Text = "generate";
            generateSubjectCodeButton.UseVisualStyleBackColor = true;
            generateSubjectCodeButton.Click += GenerateSubjectCodeButton_Click;
            // 
            // addSubjectButton
            // 
            addSubjectButton.BackColor = Color.LightSkyBlue;
            addSubjectButton.Cursor = Cursors.Hand;
            addSubjectButton.Enabled = false;
            addSubjectButton.FlatAppearance.BorderColor = Color.White;
            addSubjectButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            addSubjectButton.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            addSubjectButton.FlatStyle = FlatStyle.Flat;
            addSubjectButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addSubjectButton.ForeColor = Color.White;
            addSubjectButton.Location = new Point(680, 60);
            addSubjectButton.Name = "addSubjectButton";
            addSubjectButton.Size = new Size(130, 32);
            addSubjectButton.TabIndex = 1;
            addSubjectButton.Text = "Add Subject";
            addSubjectButton.UseVisualStyleBackColor = false;
            addSubjectButton.Click += AddSubjectButton_Click;
            // 
            // sjNameTextBox
            // 
            sjNameTextBox.Location = new Point(450, 60);
            sjNameTextBox.Name = "sjNameTextBox";
            sjNameTextBox.Size = new Size(180, 32);
            sjNameTextBox.TabIndex = 3;
            sjNameTextBox.TextChanged += SjCodeNameTextBox_TextChanged;
            // 
            // sjCodeTextBox
            // 
            sjCodeTextBox.Location = new Point(100, 60);
            sjCodeTextBox.MaxLength = 5;
            sjCodeTextBox.Name = "sjCodeTextBox";
            sjCodeTextBox.Size = new Size(180, 32);
            sjCodeTextBox.TabIndex = 2;
            sjCodeTextBox.TextChanged += SjCodeNameTextBox_TextChanged;
            // 
            // sjNameLabel
            // 
            sjNameLabel.AutoSize = true;
            sjNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sjNameLabel.Location = new Point(450, 30);
            sjNameLabel.Name = "sjNameLabel";
            sjNameLabel.Size = new Size(107, 21);
            sjNameLabel.TabIndex = 1;
            sjNameLabel.Text = "Subject Name";
            // 
            // sjCodeLabel
            // 
            sjCodeLabel.AutoSize = true;
            sjCodeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sjCodeLabel.Location = new Point(100, 30);
            sjCodeLabel.Name = "sjCodeLabel";
            sjCodeLabel.Size = new Size(101, 21);
            sjCodeLabel.TabIndex = 0;
            sjCodeLabel.Text = "Subject Code";
            // 
            // removeFromASubjectPage
            // 
            removeFromASubjectPage.Controls.Add(enrolmentTabControl);
            removeFromASubjectPage.Controls.Add(subjectsListBox);
            removeFromASubjectPage.Location = new Point(4, 24);
            removeFromASubjectPage.Name = "removeFromASubjectPage";
            removeFromASubjectPage.Size = new Size(969, 739);
            removeFromASubjectPage.TabIndex = 2;
            removeFromASubjectPage.Text = "removeFromASubjectTab";
            removeFromASubjectPage.UseVisualStyleBackColor = true;
            // 
            // enrolmentTabControl
            // 
            enrolmentTabControl.Alignment = TabAlignment.Left;
            enrolmentTabControl.Controls.Add(studentsEnrolmentTabPage);
            enrolmentTabControl.Controls.Add(teachersEnrolmentTabPage);
            enrolmentTabControl.Dock = DockStyle.Fill;
            enrolmentTabControl.Location = new Point(300, 0);
            enrolmentTabControl.Multiline = true;
            enrolmentTabControl.Name = "enrolmentTabControl";
            enrolmentTabControl.SelectedIndex = 0;
            enrolmentTabControl.Size = new Size(669, 739);
            enrolmentTabControl.TabIndex = 1;
            // 
            // studentsEnrolmentTabPage
            // 
            studentsEnrolmentTabPage.Controls.Add(removeStudentFromSubjectButton);
            studentsEnrolmentTabPage.Controls.Add(studentsListBox);
            studentsEnrolmentTabPage.Location = new Point(27, 4);
            studentsEnrolmentTabPage.Name = "studentsEnrolmentTabPage";
            studentsEnrolmentTabPage.Padding = new Padding(3);
            studentsEnrolmentTabPage.Size = new Size(638, 731);
            studentsEnrolmentTabPage.TabIndex = 0;
            studentsEnrolmentTabPage.Text = "studentsTab";
            studentsEnrolmentTabPage.UseVisualStyleBackColor = true;
            // 
            // removeStudentFromSubjectButton
            // 
            removeStudentFromSubjectButton.BackColor = Color.LightCoral;
            removeStudentFromSubjectButton.Cursor = Cursors.Hand;
            removeStudentFromSubjectButton.Enabled = false;
            removeStudentFromSubjectButton.FlatAppearance.BorderColor = Color.White;
            removeStudentFromSubjectButton.FlatAppearance.MouseDownBackColor = Color.Red;
            removeStudentFromSubjectButton.FlatAppearance.MouseOverBackColor = Color.Red;
            removeStudentFromSubjectButton.FlatStyle = FlatStyle.Flat;
            removeStudentFromSubjectButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            removeStudentFromSubjectButton.ForeColor = Color.White;
            removeStudentFromSubjectButton.Location = new Point(502, 97);
            removeStudentFromSubjectButton.Name = "removeStudentFromSubjectButton";
            removeStudentFromSubjectButton.Size = new Size(130, 32);
            removeStudentFromSubjectButton.TabIndex = 12;
            removeStudentFromSubjectButton.Text = "Remove";
            removeStudentFromSubjectButton.UseVisualStyleBackColor = false;
            // 
            // studentsListBox
            // 
            studentsListBox.Dock = DockStyle.Top;
            studentsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            studentsListBox.FormattingEnabled = true;
            studentsListBox.ItemHeight = 21;
            studentsListBox.Location = new Point(3, 3);
            studentsListBox.Name = "studentsListBox";
            studentsListBox.Size = new Size(632, 88);
            studentsListBox.TabIndex = 0;
            // 
            // teachersEnrolmentTabPage
            // 
            teachersEnrolmentTabPage.Controls.Add(removeTeacherFromSubjectButton);
            teachersEnrolmentTabPage.Controls.Add(teachersListBox);
            teachersEnrolmentTabPage.Location = new Point(27, 4);
            teachersEnrolmentTabPage.Name = "teachersEnrolmentTabPage";
            teachersEnrolmentTabPage.Padding = new Padding(3);
            teachersEnrolmentTabPage.Size = new Size(638, 731);
            teachersEnrolmentTabPage.TabIndex = 1;
            teachersEnrolmentTabPage.Text = "teachersTab";
            teachersEnrolmentTabPage.UseVisualStyleBackColor = true;
            // 
            // removeTeacherFromSubjectButton
            // 
            removeTeacherFromSubjectButton.BackColor = Color.LightCoral;
            removeTeacherFromSubjectButton.Cursor = Cursors.Hand;
            removeTeacherFromSubjectButton.Enabled = false;
            removeTeacherFromSubjectButton.FlatAppearance.BorderColor = Color.White;
            removeTeacherFromSubjectButton.FlatAppearance.MouseDownBackColor = Color.Red;
            removeTeacherFromSubjectButton.FlatAppearance.MouseOverBackColor = Color.Red;
            removeTeacherFromSubjectButton.FlatStyle = FlatStyle.Flat;
            removeTeacherFromSubjectButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            removeTeacherFromSubjectButton.ForeColor = Color.White;
            removeTeacherFromSubjectButton.Location = new Point(502, 97);
            removeTeacherFromSubjectButton.Name = "removeTeacherFromSubjectButton";
            removeTeacherFromSubjectButton.Size = new Size(130, 32);
            removeTeacherFromSubjectButton.TabIndex = 13;
            removeTeacherFromSubjectButton.Text = "Remove";
            removeTeacherFromSubjectButton.UseVisualStyleBackColor = false;
            // 
            // teachersListBox
            // 
            teachersListBox.Dock = DockStyle.Top;
            teachersListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teachersListBox.FormattingEnabled = true;
            teachersListBox.ItemHeight = 21;
            teachersListBox.Location = new Point(3, 3);
            teachersListBox.Name = "teachersListBox";
            teachersListBox.Size = new Size(632, 88);
            teachersListBox.TabIndex = 0;
            // 
            // subjectsListBox
            // 
            subjectsListBox.Dock = DockStyle.Left;
            subjectsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            subjectsListBox.FormattingEnabled = true;
            subjectsListBox.ItemHeight = 21;
            subjectsListBox.Location = new Point(0, 0);
            subjectsListBox.Name = "subjectsListBox";
            subjectsListBox.Size = new Size(300, 739);
            subjectsListBox.TabIndex = 0;
            subjectsListBox.SelectedIndexChanged += SubjectsListBox_SelectedIndexChanged;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 767);
            Controls.Add(adminTabControl);
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            adminTabControl.ResumeLayout(false);
            viewSubjectRequestsPage.ResumeLayout(false);
            viewRequestsGroupBox.ResumeLayout(false);
            viewRequestsGroupBox.PerformLayout();
            subjectRequestsTableLayoutPanel.ResumeLayout(false);
            subjectRequestsTableLayoutPanel.PerformLayout();
            approveRequestGroupBox.ResumeLayout(false);
            approveRequestGroupBox.PerformLayout();
            addASubjectAndActivitiesPage.ResumeLayout(false);
            addActivitiesGroup.ResumeLayout(false);
            addActivitiesGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)activityDurationNumericUpDown).EndInit();
            addASubjectGroup.ResumeLayout(false);
            addASubjectGroup.PerformLayout();
            removeFromASubjectPage.ResumeLayout(false);
            enrolmentTabControl.ResumeLayout(false);
            studentsEnrolmentTabPage.ResumeLayout(false);
            teachersEnrolmentTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label titleLabel;
        private Button viewSubjectRequestsButton;
        private Button addSubjectAndActivitiesButton;
        private Panel panel3;
        private Panel panel4;
        private Button removeFromASubjectButton;
        private Label welcomeLabel;
        private Label roleLabel;
        private Panel panel5;
        private Label otherLabel;
        private Button logoutButton;
        private TabControl adminTabControl;
        private TabPage viewSubjectRequestsPage;
        private TabPage addASubjectAndActivitiesPage;
        private TabPage removeFromASubjectPage;
        private GroupBox addASubjectGroup;
        private Label sjNameLabel;
        private Label sjCodeLabel;
        private Button addSubjectButton;
        private TextBox sjNameTextBox;
        private TextBox sjCodeTextBox;
        private GroupBox addActivitiesGroup;
        private Label activityTypeLabel;
        private ComboBox activityTypeComboxBox;
        private Label activityDescriptionLabel;
        private Label activityStartLabel;
        private Label activityDurationLabel;
        private Label activityLocationLabel;
        private Label activityCampusLabel;
        private Label activityTimeLabel;
        private Label activityDayLabel;
        private DateTimePicker activityDateTimePicker;
        private ComboBox activityDayComboBox;
        private TextBox activityDescriptionTextBox;
        private Button addSubjectActivityButton;
        private NumericUpDown activityDurationNumericUpDown;
        private TextBox activityLocationTextBox;
        private TextBox activityCampusTextBox;
        private TabControl enrolmentTabControl;
        private TabPage studentsEnrolmentTabPage;
        private TabPage teachersEnrolmentTabPage;
        private ListBox subjectsListBox;
        private Button generateSubjectCodeButton;
        private DateTimePicker activityStartDateTimePicker;
        private DateTimePicker activityEndDateTimePicker;
        private Label activityEndLabel;
        private GroupBox viewRequestsGroupBox;
        private GroupBox approveRequestGroupBox;
        private Label teacherFullNameLabel;
        private Label requestLabel;
        private ComboBox requestsComboBox;
        private TextBox teacherFullNameTextBox;
        private Label statusLabel;
        private Label messageLabel;
        private Label subjectLabel;
        private Button rejectButton;
        private Button approveButton;
        private RichTextBox messageRichTextBox;
        private TextBox subjectTextBox;
        private TextBox statusTextBox;
        private TableLayoutPanel subjectRequestsTableLayoutPanel;
        private Label requestIDLabel;
        private Label requestTeacherIDLabel;
        private Label requestSubjectLabel;
        private Label requestMessageLabel;
        private Label requestStatusLabel;
        private Label requestReasonForRejectionLabel;
        private ListBox teachersListBox;
        private ListBox studentsListBox;
        private Button removeStudentFromSubjectButton;
        private Button removeTeacherFromSubjectButton;
        private RichTextBox rejectionReasonRichTextBox;
        private Label rejectionReasonLabel;
    }
}