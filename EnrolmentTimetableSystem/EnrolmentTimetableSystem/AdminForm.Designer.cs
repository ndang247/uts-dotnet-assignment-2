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
            subjectRequestsTableLayoutPanel = new TableLayoutPanel();
            requestIDLabel = new Label();
            requestTeacherFirstNameLabel = new Label();
            requestTeacherLastNameLabel = new Label();
            requestMessageLabel = new Label();
            requestStatusLabel = new Label();
            requestReasonForRejectionLabel = new Label();
            requestActionsLabel = new Label();
            vScrollBar1 = new VScrollBar();
            addASubjectAndActivitiesPage = new TabPage();
            addActivitiesGroup = new GroupBox();
            addButton = new Button();
            activityDurationNumericUpDown = new NumericUpDown();
            activityLocationTextBox = new TextBox();
            activityCampusTextBox = new TextBox();
            activityDescriptionTextBox = new TextBox();
            activityWeeksMonthCalendar = new MonthCalendar();
            activityDateTimePicker = new DateTimePicker();
            activityDayComboBox = new ComboBox();
            activityDescriptionLabel = new Label();
            activityWeeksLabel = new Label();
            activityDurationLabel = new Label();
            activityLocationLabel = new Label();
            activityCampusLabel = new Label();
            activityTimeLabel = new Label();
            activityDayLabel = new Label();
            activityTypeLabel = new Label();
            activityTypeComboxBox = new ComboBox();
            addASubjectGroup = new GroupBox();
            addActivitiesButton = new Button();
            sjNameTextBox = new TextBox();
            sjCodeTextBox = new TextBox();
            sjNameLabel = new Label();
            sjCodeLabel = new Label();
            removeFromASubjectPage = new TabPage();
            requestAcceptButton = new Button();
            requestRejectButton = new Button();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            adminTabControl.SuspendLayout();
            viewSubjectRequestsPage.SuspendLayout();
            subjectRequestsTableLayoutPanel.SuspendLayout();
            addASubjectAndActivitiesPage.SuspendLayout();
            addActivitiesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)activityDurationNumericUpDown).BeginInit();
            addASubjectGroup.SuspendLayout();
            panel6.SuspendLayout();
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
            panel1.Size = new Size(255, 767);
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
            logoutButton.Size = new Size(255, 35);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
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
            removeFromASubjectButton.Size = new Size(255, 35);
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
            panel4.Size = new Size(255, 15);
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
            addSubjectAndActivitiesButton.Size = new Size(255, 35);
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
            panel3.Size = new Size(255, 15);
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
            viewSubjectRequestsButton.Size = new Size(255, 35);
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
            panel2.Size = new Size(255, 150);
            panel2.TabIndex = 1;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(12, 89);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(180, 21);
            welcomeLabel.TabIndex = 3;
            welcomeLabel.Text = "Welcome Back <name>!";
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
            adminTabControl.Location = new Point(255, 0);
            adminTabControl.Name = "adminTabControl";
            adminTabControl.SelectedIndex = 0;
            adminTabControl.Size = new Size(992, 767);
            adminTabControl.TabIndex = 7;
            // 
            // viewSubjectRequestsPage
            // 
            viewSubjectRequestsPage.Controls.Add(subjectRequestsTableLayoutPanel);
            viewSubjectRequestsPage.Controls.Add(vScrollBar1);
            viewSubjectRequestsPage.Location = new Point(4, 24);
            viewSubjectRequestsPage.Name = "viewSubjectRequestsPage";
            viewSubjectRequestsPage.Padding = new Padding(3);
            viewSubjectRequestsPage.Size = new Size(984, 739);
            viewSubjectRequestsPage.TabIndex = 0;
            viewSubjectRequestsPage.Text = "viewSubjectRequestsTab";
            viewSubjectRequestsPage.UseVisualStyleBackColor = true;
            // 
            // subjectRequestsTableLayoutPanel
            // 
            subjectRequestsTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            subjectRequestsTableLayoutPanel.ColumnCount = 7;
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            subjectRequestsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            subjectRequestsTableLayoutPanel.Controls.Add(panel6, 6, 1);
            subjectRequestsTableLayoutPanel.Controls.Add(requestIDLabel, 0, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestTeacherFirstNameLabel, 1, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestTeacherLastNameLabel, 2, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestMessageLabel, 3, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestStatusLabel, 4, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestReasonForRejectionLabel, 5, 0);
            subjectRequestsTableLayoutPanel.Controls.Add(requestActionsLabel, 6, 0);
            subjectRequestsTableLayoutPanel.Dock = DockStyle.Top;
            subjectRequestsTableLayoutPanel.Location = new Point(3, 3);
            subjectRequestsTableLayoutPanel.Name = "subjectRequestsTableLayoutPanel";
            subjectRequestsTableLayoutPanel.RowCount = 2;
            subjectRequestsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            subjectRequestsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            subjectRequestsTableLayoutPanel.Size = new Size(961, 100);
            subjectRequestsTableLayoutPanel.TabIndex = 3;
            // 
            // requestIDLabel
            // 
            requestIDLabel.AutoSize = true;
            requestIDLabel.Dock = DockStyle.Fill;
            requestIDLabel.Location = new Point(6, 3);
            requestIDLabel.Name = "requestIDLabel";
            requestIDLabel.Size = new Size(94, 45);
            requestIDLabel.TabIndex = 4;
            requestIDLabel.Text = "Request ID";
            requestIDLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // requestTeacherFirstNameLabel
            // 
            requestTeacherFirstNameLabel.AutoSize = true;
            requestTeacherFirstNameLabel.Dock = DockStyle.Fill;
            requestTeacherFirstNameLabel.Location = new Point(109, 3);
            requestTeacherFirstNameLabel.Name = "requestTeacherFirstNameLabel";
            requestTeacherFirstNameLabel.Size = new Size(94, 45);
            requestTeacherFirstNameLabel.TabIndex = 5;
            requestTeacherFirstNameLabel.Text = "Teacher First Name";
            requestTeacherFirstNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // requestTeacherLastNameLabel
            // 
            requestTeacherLastNameLabel.AutoSize = true;
            requestTeacherLastNameLabel.Dock = DockStyle.Fill;
            requestTeacherLastNameLabel.Location = new Point(212, 3);
            requestTeacherLastNameLabel.Name = "requestTeacherLastNameLabel";
            requestTeacherLastNameLabel.Size = new Size(94, 45);
            requestTeacherLastNameLabel.TabIndex = 6;
            requestTeacherLastNameLabel.Text = "Teacher Last Name";
            requestTeacherLastNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // requestMessageLabel
            // 
            requestMessageLabel.AutoSize = true;
            requestMessageLabel.Dock = DockStyle.Fill;
            requestMessageLabel.Location = new Point(315, 3);
            requestMessageLabel.Name = "requestMessageLabel";
            requestMessageLabel.Size = new Size(94, 45);
            requestMessageLabel.TabIndex = 7;
            requestMessageLabel.Text = "Request Message";
            requestMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // requestStatusLabel
            // 
            requestStatusLabel.AutoSize = true;
            requestStatusLabel.Dock = DockStyle.Fill;
            requestStatusLabel.Location = new Point(418, 3);
            requestStatusLabel.Name = "requestStatusLabel";
            requestStatusLabel.Size = new Size(94, 45);
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
            requestReasonForRejectionLabel.Size = new Size(94, 45);
            requestReasonForRejectionLabel.TabIndex = 9;
            requestReasonForRejectionLabel.Text = "Reason For Rejection";
            requestReasonForRejectionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // requestActionsLabel
            // 
            requestActionsLabel.AutoSize = true;
            requestActionsLabel.Dock = DockStyle.Fill;
            requestActionsLabel.Location = new Point(624, 3);
            requestActionsLabel.Name = "requestActionsLabel";
            requestActionsLabel.Size = new Size(331, 45);
            requestActionsLabel.TabIndex = 10;
            requestActionsLabel.Text = "Actions";
            requestActionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Location = new Point(964, 3);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 733);
            vScrollBar1.TabIndex = 1;
            // 
            // addASubjectAndActivitiesPage
            // 
            addASubjectAndActivitiesPage.Controls.Add(addActivitiesGroup);
            addASubjectAndActivitiesPage.Controls.Add(addASubjectGroup);
            addASubjectAndActivitiesPage.Location = new Point(4, 24);
            addASubjectAndActivitiesPage.Name = "addASubjectAndActivitiesPage";
            addASubjectAndActivitiesPage.Padding = new Padding(3);
            addASubjectAndActivitiesPage.Size = new Size(984, 739);
            addASubjectAndActivitiesPage.TabIndex = 1;
            addASubjectAndActivitiesPage.Text = "addASubjectAndActivitiesTab";
            addASubjectAndActivitiesPage.UseVisualStyleBackColor = true;
            // 
            // addActivitiesGroup
            // 
            addActivitiesGroup.Controls.Add(addButton);
            addActivitiesGroup.Controls.Add(activityDurationNumericUpDown);
            addActivitiesGroup.Controls.Add(activityLocationTextBox);
            addActivitiesGroup.Controls.Add(activityCampusTextBox);
            addActivitiesGroup.Controls.Add(activityDescriptionTextBox);
            addActivitiesGroup.Controls.Add(activityWeeksMonthCalendar);
            addActivitiesGroup.Controls.Add(activityDateTimePicker);
            addActivitiesGroup.Controls.Add(activityDayComboBox);
            addActivitiesGroup.Controls.Add(activityDescriptionLabel);
            addActivitiesGroup.Controls.Add(activityWeeksLabel);
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
            addActivitiesGroup.Size = new Size(978, 610);
            addActivitiesGroup.TabIndex = 1;
            addActivitiesGroup.TabStop = false;
            addActivitiesGroup.Text = "Add Activities";
            addActivitiesGroup.Visible = false;
            // 
            // addButton
            // 
            addButton.BackColor = Color.LightSkyBlue;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatAppearance.BorderColor = Color.White;
            addButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            addButton.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(680, 572);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 32);
            addButton.TabIndex = 7;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            // 
            // activityDurationNumericUpDown
            // 
            activityDurationNumericUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityDurationNumericUpDown.Location = new Point(450, 425);
            activityDurationNumericUpDown.Name = "activityDurationNumericUpDown";
            activityDurationNumericUpDown.Size = new Size(180, 29);
            activityDurationNumericUpDown.TabIndex = 24;
            // 
            // activityLocationTextBox
            // 
            activityLocationTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityLocationTextBox.Location = new Point(100, 288);
            activityLocationTextBox.Name = "activityLocationTextBox";
            activityLocationTextBox.Size = new Size(180, 29);
            activityLocationTextBox.TabIndex = 22;
            // 
            // activityCampusTextBox
            // 
            activityCampusTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityCampusTextBox.Location = new Point(100, 219);
            activityCampusTextBox.Name = "activityCampusTextBox";
            activityCampusTextBox.Size = new Size(180, 29);
            activityCampusTextBox.TabIndex = 21;
            // 
            // activityDescriptionTextBox
            // 
            activityDescriptionTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityDescriptionTextBox.Location = new Point(450, 143);
            activityDescriptionTextBox.Name = "activityDescriptionTextBox";
            activityDescriptionTextBox.Size = new Size(180, 29);
            activityDescriptionTextBox.TabIndex = 20;
            // 
            // activityWeeksMonthCalendar
            // 
            activityWeeksMonthCalendar.Location = new Point(450, 219);
            activityWeeksMonthCalendar.MaxSelectionCount = 365;
            activityWeeksMonthCalendar.Name = "activityWeeksMonthCalendar";
            activityWeeksMonthCalendar.TabIndex = 19;
            // 
            // activityDateTimePicker
            // 
            activityDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityDateTimePicker.Location = new Point(100, 143);
            activityDateTimePicker.Name = "activityDateTimePicker";
            activityDateTimePicker.Size = new Size(180, 29);
            activityDateTimePicker.TabIndex = 18;
            // 
            // activityDayComboBox
            // 
            activityDayComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityDayComboBox.FormattingEnabled = true;
            activityDayComboBox.Location = new Point(450, 67);
            activityDayComboBox.Name = "activityDayComboBox";
            activityDayComboBox.Size = new Size(180, 29);
            activityDayComboBox.TabIndex = 17;
            // 
            // activityDescriptionLabel
            // 
            activityDescriptionLabel.AutoSize = true;
            activityDescriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityDescriptionLabel.Location = new Point(450, 114);
            activityDescriptionLabel.Name = "activityDescriptionLabel";
            activityDescriptionLabel.Size = new Size(89, 21);
            activityDescriptionLabel.TabIndex = 16;
            activityDescriptionLabel.Text = "Description";
            // 
            // activityWeeksLabel
            // 
            activityWeeksLabel.AutoSize = true;
            activityWeeksLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityWeeksLabel.Location = new Point(450, 189);
            activityWeeksLabel.Name = "activityWeeksLabel";
            activityWeeksLabel.Size = new Size(55, 21);
            activityWeeksLabel.TabIndex = 15;
            activityWeeksLabel.Text = "Weeks";
            // 
            // activityDurationLabel
            // 
            activityDurationLabel.AutoSize = true;
            activityDurationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityDurationLabel.Location = new Point(450, 395);
            activityDurationLabel.Name = "activityDurationLabel";
            activityDurationLabel.Size = new Size(71, 21);
            activityDurationLabel.TabIndex = 14;
            activityDurationLabel.Text = "Duration";
            // 
            // activityLocationLabel
            // 
            activityLocationLabel.AutoSize = true;
            activityLocationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityLocationLabel.Location = new Point(100, 264);
            activityLocationLabel.Name = "activityLocationLabel";
            activityLocationLabel.Size = new Size(69, 21);
            activityLocationLabel.TabIndex = 13;
            activityLocationLabel.Text = "Location";
            // 
            // activityCampusLabel
            // 
            activityCampusLabel.AutoSize = true;
            activityCampusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityCampusLabel.Location = new Point(100, 189);
            activityCampusLabel.Name = "activityCampusLabel";
            activityCampusLabel.Size = new Size(67, 21);
            activityCampusLabel.TabIndex = 12;
            activityCampusLabel.Text = "Campus";
            // 
            // activityTimeLabel
            // 
            activityTimeLabel.AutoSize = true;
            activityTimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityTimeLabel.Location = new Point(100, 114);
            activityTimeLabel.Name = "activityTimeLabel";
            activityTimeLabel.Size = new Size(44, 21);
            activityTimeLabel.TabIndex = 11;
            activityTimeLabel.Text = "Time";
            // 
            // activityDayLabel
            // 
            activityDayLabel.AutoSize = true;
            activityDayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityDayLabel.Location = new Point(450, 35);
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
            activityTypeComboxBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityTypeComboxBox.FormattingEnabled = true;
            activityTypeComboxBox.Items.AddRange(new object[] { "Lecture", "Tutorial", "Workshop", "Seminar", "Lab Session" });
            activityTypeComboxBox.Location = new Point(100, 67);
            activityTypeComboxBox.Name = "activityTypeComboxBox";
            activityTypeComboxBox.Size = new Size(180, 29);
            activityTypeComboxBox.TabIndex = 8;
            // 
            // addASubjectGroup
            // 
            addASubjectGroup.Controls.Add(addActivitiesButton);
            addASubjectGroup.Controls.Add(sjNameTextBox);
            addASubjectGroup.Controls.Add(sjCodeTextBox);
            addASubjectGroup.Controls.Add(sjNameLabel);
            addASubjectGroup.Controls.Add(sjCodeLabel);
            addASubjectGroup.Dock = DockStyle.Top;
            addASubjectGroup.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            addASubjectGroup.Location = new Point(3, 3);
            addASubjectGroup.Name = "addASubjectGroup";
            addASubjectGroup.Size = new Size(978, 123);
            addASubjectGroup.TabIndex = 0;
            addASubjectGroup.TabStop = false;
            addASubjectGroup.Text = "Add a Subject";
            // 
            // addActivitiesButton
            // 
            addActivitiesButton.BackColor = Color.LightSkyBlue;
            addActivitiesButton.Enabled = false;
            addActivitiesButton.FlatAppearance.BorderColor = Color.White;
            addActivitiesButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            addActivitiesButton.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            addActivitiesButton.FlatStyle = FlatStyle.Flat;
            addActivitiesButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addActivitiesButton.ForeColor = Color.White;
            addActivitiesButton.Location = new Point(680, 60);
            addActivitiesButton.Name = "addActivitiesButton";
            addActivitiesButton.Size = new Size(130, 32);
            addActivitiesButton.TabIndex = 1;
            addActivitiesButton.Text = "Add Activities";
            addActivitiesButton.UseVisualStyleBackColor = false;
            // 
            // sjNameTextBox
            // 
            sjNameTextBox.Location = new Point(450, 60);
            sjNameTextBox.Name = "sjNameTextBox";
            sjNameTextBox.Size = new Size(180, 32);
            sjNameTextBox.TabIndex = 3;
            // 
            // sjCodeTextBox
            // 
            sjCodeTextBox.Location = new Point(100, 60);
            sjCodeTextBox.Name = "sjCodeTextBox";
            sjCodeTextBox.Size = new Size(180, 32);
            sjCodeTextBox.TabIndex = 2;
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
            removeFromASubjectPage.Location = new Point(4, 24);
            removeFromASubjectPage.Name = "removeFromASubjectPage";
            removeFromASubjectPage.Size = new Size(984, 739);
            removeFromASubjectPage.TabIndex = 2;
            removeFromASubjectPage.Text = "removeFromASubjectTab";
            removeFromASubjectPage.UseVisualStyleBackColor = true;
            // 
            // requestAcceptButton
            // 
            requestAcceptButton.BackColor = Color.LightGreen;
            requestAcceptButton.FlatAppearance.BorderColor = Color.White;
            requestAcceptButton.FlatAppearance.MouseDownBackColor = Color.Green;
            requestAcceptButton.FlatAppearance.MouseOverBackColor = Color.Green;
            requestAcceptButton.FlatStyle = FlatStyle.Flat;
            requestAcceptButton.Location = new Point(3, 3);
            requestAcceptButton.Name = "requestAcceptButton";
            requestAcceptButton.Size = new Size(75, 23);
            requestAcceptButton.TabIndex = 11;
            requestAcceptButton.Text = "Accept";
            requestAcceptButton.UseVisualStyleBackColor = false;
            // 
            // requestRejectButton
            // 
            requestRejectButton.BackColor = Color.LightCoral;
            requestRejectButton.FlatAppearance.BorderColor = Color.White;
            requestRejectButton.FlatAppearance.MouseDownBackColor = Color.Red;
            requestRejectButton.FlatAppearance.MouseOverBackColor = Color.Red;
            requestRejectButton.FlatStyle = FlatStyle.Flat;
            requestRejectButton.Location = new Point(84, 3);
            requestRejectButton.Name = "requestRejectButton";
            requestRejectButton.Size = new Size(75, 23);
            requestRejectButton.TabIndex = 4;
            requestRejectButton.Text = "Reject";
            requestRejectButton.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(requestRejectButton);
            panel6.Controls.Add(requestAcceptButton);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(624, 54);
            panel6.Name = "panel6";
            panel6.Size = new Size(331, 40);
            panel6.TabIndex = 12;
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
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            adminTabControl.ResumeLayout(false);
            viewSubjectRequestsPage.ResumeLayout(false);
            subjectRequestsTableLayoutPanel.ResumeLayout(false);
            subjectRequestsTableLayoutPanel.PerformLayout();
            addASubjectAndActivitiesPage.ResumeLayout(false);
            addActivitiesGroup.ResumeLayout(false);
            addActivitiesGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)activityDurationNumericUpDown).EndInit();
            addASubjectGroup.ResumeLayout(false);
            addASubjectGroup.PerformLayout();
            panel6.ResumeLayout(false);
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
        private Button addActivitiesButton;
        private TextBox sjNameTextBox;
        private TextBox sjCodeTextBox;
        private GroupBox addActivitiesGroup;
        private Label activityTypeLabel;
        private ComboBox activityTypeComboxBox;
        private Label activityDescriptionLabel;
        private Label activityWeeksLabel;
        private Label activityDurationLabel;
        private Label activityLocationLabel;
        private Label activityCampusLabel;
        private Label activityTimeLabel;
        private Label activityDayLabel;
        private MonthCalendar activityWeeksMonthCalendar;
        private DateTimePicker activityDateTimePicker;
        private ComboBox activityDayComboBox;
        private TextBox activityDescriptionTextBox;
        private Button addButton;
        private NumericUpDown activityDurationNumericUpDown;
        private TextBox activityLocationTextBox;
        private TextBox activityCampusTextBox;
        private VScrollBar vScrollBar1;
        private TableLayoutPanel subjectRequestsTableLayoutPanel;
        private Label requestIDLabel;
        private Label requestTeacherFirstNameLabel;
        private Label requestTeacherLastNameLabel;
        private Label requestMessageLabel;
        private Label requestStatusLabel;
        private Label requestReasonForRejectionLabel;
        private Label requestActionsLabel;
        private Button requestRejectButton;
        private Button requestAcceptButton;
        private Panel panel6;
    }
}