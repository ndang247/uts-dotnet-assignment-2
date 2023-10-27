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
			teacherTabControl = new TabControl();
			homePage = new TabPage();
			textBox2 = new TextBox();
			subjectRequest = new TabPage();
			SubmitSubjectRequest = new Button();
			textBox16 = new TextBox();
			textBox15 = new TextBox();
			requestMessageTextBox = new TextBox();
			teacherSubjectsComboBox = new ComboBox();
			textBox1 = new TextBox();
			vScrollBar1 = new VScrollBar();
			subjectAllocation = new TabPage();
			subjectActivitiesTextBox = new RichTextBox();
			loadActivitiesButton = new Button();
			textBox17 = new TextBox();
			teacherSubjectAllocationComboBox = new ComboBox();
			textBox3 = new TextBox();
			viewActivities = new TabPage();
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
			subjectActivitiesAllocateButton = new Button();
			panel1.SuspendLayout();
			panel5.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			teacherTabControl.SuspendLayout();
			homePage.SuspendLayout();
			subjectRequest.SuspendLayout();
			subjectAllocation.SuspendLayout();
			viewActivities.SuspendLayout();
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
			removeFromASubjectButton.Text = "View Activities";
			removeFromASubjectButton.UseVisualStyleBackColor = false;
			removeFromASubjectButton.Click += removeFromASubjectButton_Click;
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
			addSubjectAndActivitiesButton.Text = "Subject Allocation";
			addSubjectAndActivitiesButton.UseVisualStyleBackColor = false;
			addSubjectAndActivitiesButton.Click += addSubjectAndActivitiesButton_Click;
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
			viewSubjectRequestsButton.Text = "Subject Request";
			viewSubjectRequestsButton.UseVisualStyleBackColor = false;
			viewSubjectRequestsButton.Click += viewSubjectRequestsButton_Click;
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
			teacherTabControl.Controls.Add(homePage);
			teacherTabControl.Controls.Add(subjectRequest);
			teacherTabControl.Controls.Add(subjectAllocation);
			teacherTabControl.Controls.Add(viewActivities);
			teacherTabControl.Dock = DockStyle.Fill;
			teacherTabControl.Location = new Point(255, 0);
			teacherTabControl.Name = "teacherTabControl";
			teacherTabControl.SelectedIndex = 0;
			teacherTabControl.Size = new Size(992, 767);
			teacherTabControl.TabIndex = 8;
			// 
			// homePage
			// 
			homePage.Controls.Add(textBox2);
			homePage.Location = new Point(4, 24);
			homePage.Name = "homePage";
			homePage.Size = new Size(984, 739);
			homePage.TabIndex = 3;
			homePage.Text = "Home Page";
			homePage.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			textBox2.BorderStyle = BorderStyle.None;
			textBox2.Location = new Point(181, 148);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 16);
			textBox2.TabIndex = 0;
			textBox2.Text = "Home Page";
			// 
			// subjectRequest
			// 
			subjectRequest.Controls.Add(SubmitSubjectRequest);
			subjectRequest.Controls.Add(textBox16);
			subjectRequest.Controls.Add(textBox15);
			subjectRequest.Controls.Add(requestMessageTextBox);
			subjectRequest.Controls.Add(teacherSubjectsComboBox);
			subjectRequest.Controls.Add(textBox1);
			subjectRequest.Controls.Add(vScrollBar1);
			subjectRequest.Location = new Point(4, 24);
			subjectRequest.Name = "subjectRequest";
			subjectRequest.Padding = new Padding(3);
			subjectRequest.Size = new Size(984, 739);
			subjectRequest.TabIndex = 0;
			subjectRequest.Text = "Subject Request";
			subjectRequest.UseVisualStyleBackColor = true;
			// 
			// SubmitSubjectRequest
			// 
			SubmitSubjectRequest.Location = new Point(403, 341);
			SubmitSubjectRequest.Name = "SubmitSubjectRequest";
			SubmitSubjectRequest.Size = new Size(75, 23);
			SubmitSubjectRequest.TabIndex = 7;
			SubmitSubjectRequest.Text = "Submit";
			SubmitSubjectRequest.UseVisualStyleBackColor = true;
			SubmitSubjectRequest.Click += SubmitSubjectRequest_Click;
			// 
			// textBox16
			// 
			textBox16.BorderStyle = BorderStyle.None;
			textBox16.Location = new Point(93, 49);
			textBox16.Multiline = true;
			textBox16.Name = "textBox16";
			textBox16.Size = new Size(156, 37);
			textBox16.TabIndex = 6;
			textBox16.Text = "select the subject from the dropdown menu";
			// 
			// textBox15
			// 
			textBox15.BorderStyle = BorderStyle.None;
			textBox15.Location = new Point(548, 70);
			textBox15.Multiline = true;
			textBox15.Name = "textBox15";
			textBox15.Size = new Size(124, 37);
			textBox15.TabIndex = 5;
			textBox15.Text = "Reason for wanted to teach the subject";
			// 
			// requestMessageTextBox
			// 
			requestMessageTextBox.Location = new Point(501, 113);
			requestMessageTextBox.Multiline = true;
			requestMessageTextBox.Name = "requestMessageTextBox";
			requestMessageTextBox.Size = new Size(234, 161);
			requestMessageTextBox.TabIndex = 4;
			// 
			// teacherSubjectsComboBox
			// 
			teacherSubjectsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			teacherSubjectsComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			teacherSubjectsComboBox.FormattingEnabled = true;
			teacherSubjectsComboBox.Location = new Point(81, 97);
			teacherSubjectsComboBox.Name = "teacherSubjectsComboBox";
			teacherSubjectsComboBox.Size = new Size(250, 29);
			teacherSubjectsComboBox.TabIndex = 3;
			teacherSubjectsComboBox.SelectedIndexChanged += teacherSubjectsComboBox_SelectedIndexChanged;
			// 
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Location = new Point(369, 27);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(124, 16);
			textBox1.TabIndex = 2;
			textBox1.Text = "Subject Request Page";
			// 
			// vScrollBar1
			// 
			vScrollBar1.Dock = DockStyle.Right;
			vScrollBar1.Location = new Point(964, 3);
			vScrollBar1.Name = "vScrollBar1";
			vScrollBar1.Size = new Size(17, 733);
			vScrollBar1.TabIndex = 1;
			// 
			// subjectAllocation
			// 
			subjectAllocation.Controls.Add(subjectActivitiesAllocateButton);
			subjectAllocation.Controls.Add(subjectActivitiesTextBox);
			subjectAllocation.Controls.Add(loadActivitiesButton);
			subjectAllocation.Controls.Add(textBox17);
			subjectAllocation.Controls.Add(teacherSubjectAllocationComboBox);
			subjectAllocation.Controls.Add(textBox3);
			subjectAllocation.Location = new Point(4, 24);
			subjectAllocation.Name = "subjectAllocation";
			subjectAllocation.Padding = new Padding(3);
			subjectAllocation.Size = new Size(984, 739);
			subjectAllocation.TabIndex = 1;
			subjectAllocation.Text = "Subject Allocation";
			subjectAllocation.UseVisualStyleBackColor = true;
			// 
			// subjectActivitiesTextBox
			// 
			subjectActivitiesTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			subjectActivitiesTextBox.Location = new Point(36, 226);
			subjectActivitiesTextBox.Name = "subjectActivitiesTextBox";
			subjectActivitiesTextBox.ReadOnly = true;
			subjectActivitiesTextBox.Size = new Size(910, 148);
			subjectActivitiesTextBox.TabIndex = 10;
			subjectActivitiesTextBox.Text = "";
			// 
			// loadActivitiesButton
			// 
			loadActivitiesButton.Location = new Point(392, 114);
			loadActivitiesButton.Name = "loadActivitiesButton";
			loadActivitiesButton.Size = new Size(75, 23);
			loadActivitiesButton.TabIndex = 8;
			loadActivitiesButton.Text = "Load";
			loadActivitiesButton.UseVisualStyleBackColor = true;
			loadActivitiesButton.Click += loadActivitiesButton_Click;
			// 
			// textBox17
			// 
			textBox17.BorderStyle = BorderStyle.None;
			textBox17.Location = new Point(78, 71);
			textBox17.Multiline = true;
			textBox17.Name = "textBox17";
			textBox17.Size = new Size(156, 37);
			textBox17.TabIndex = 7;
			textBox17.Text = "select the subject from the dropdown menu";
			// 
			// teacherSubjectAllocationComboBox
			// 
			teacherSubjectAllocationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			teacherSubjectAllocationComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			teacherSubjectAllocationComboBox.FormattingEnabled = true;
			teacherSubjectAllocationComboBox.Location = new Point(67, 114);
			teacherSubjectAllocationComboBox.Name = "teacherSubjectAllocationComboBox";
			teacherSubjectAllocationComboBox.Size = new Size(250, 29);
			teacherSubjectAllocationComboBox.TabIndex = 4;
			teacherSubjectAllocationComboBox.SelectedIndexChanged += teacherSubjectAllocationComboBox_SelectedIndexChanged;
			// 
			// textBox3
			// 
			textBox3.BorderStyle = BorderStyle.None;
			textBox3.Location = new Point(381, 27);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 16);
			textBox3.TabIndex = 0;
			textBox3.Text = "Subject Allocation";
			// 
			// viewActivities
			// 
			viewActivities.BackColor = Color.Pink;
			viewActivities.BackgroundImageLayout = ImageLayout.Stretch;
			viewActivities.Controls.Add(groupBox2);
			viewActivities.Controls.Add(panel6);
			viewActivities.Location = new Point(4, 24);
			viewActivities.Name = "viewActivities";
			viewActivities.Size = new Size(984, 739);
			viewActivities.TabIndex = 2;
			viewActivities.Text = "View Activities";
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
			// subjectActivitiesAllocateButton
			// 
			subjectActivitiesAllocateButton.Location = new Point(406, 491);
			subjectActivitiesAllocateButton.Name = "subjectActivitiesAllocateButton";
			subjectActivitiesAllocateButton.Size = new Size(75, 23);
			subjectActivitiesAllocateButton.TabIndex = 11;
			subjectActivitiesAllocateButton.Text = "Allocate";
			subjectActivitiesAllocateButton.UseVisualStyleBackColor = true;
			subjectActivitiesAllocateButton.Click += subjectActivitiesAllocateButton_Click;
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
			panel1.ResumeLayout(false);
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			teacherTabControl.ResumeLayout(false);
			homePage.ResumeLayout(false);
			homePage.PerformLayout();
			subjectRequest.ResumeLayout(false);
			subjectRequest.PerformLayout();
			subjectAllocation.ResumeLayout(false);
			subjectAllocation.PerformLayout();
			viewActivities.ResumeLayout(false);
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
		private Button removeFromASubjectButton;
		private Panel panel4;
		private Button addSubjectAndActivitiesButton;
		private Panel panel3;
		private Button viewSubjectRequestsButton;
		private Panel panel2;
		private Label welcomeLabel;
		private Label roleLabel;
		private Label titleLabel;
		private PictureBox pictureBox1;
		private TabControl teacherTabControl;
		private TabPage subjectRequest;
		private VScrollBar vScrollBar1;
		private TabPage subjectAllocation;
		private TabPage viewActivities;
		private TabPage homePage;
		private TextBox textBox2;
		private TextBox textBox1;
		private TextBox textBox3;
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
		private ComboBox teacherSubjectsComboBox;
		private TextBox requestMessageTextBox;
		private TextBox textBox16;
		private TextBox textBox15;
		private Button SubmitSubjectRequest;
		private Button loadActivitiesButton;
		private TextBox textBox17;
		private ComboBox teacherSubjectAllocationComboBox;
		private RichTextBox subjectActivitiesTextBox;
		private Button subjectActivitiesAllocateButton;
	}
}