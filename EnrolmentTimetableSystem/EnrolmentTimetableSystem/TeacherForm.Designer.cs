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
			textBox1 = new TextBox();
			vScrollBar1 = new VScrollBar();
			subjectAllocation = new TabPage();
			textBox3 = new TextBox();
			viewActivities = new TabPage();
			textBox4 = new TextBox();
			panel1.SuspendLayout();
			panel5.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			teacherTabControl.SuspendLayout();
			homePage.SuspendLayout();
			subjectRequest.SuspendLayout();
			subjectAllocation.SuspendLayout();
			viewActivities.SuspendLayout();
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
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Location = new Point(314, 203);
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
			subjectAllocation.Controls.Add(textBox3);
			subjectAllocation.Location = new Point(4, 24);
			subjectAllocation.Name = "subjectAllocation";
			subjectAllocation.Padding = new Padding(3);
			subjectAllocation.Size = new Size(984, 739);
			subjectAllocation.TabIndex = 1;
			subjectAllocation.Text = "Subject Allocation";
			subjectAllocation.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			textBox3.BorderStyle = BorderStyle.None;
			textBox3.Location = new Point(137, 184);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 16);
			textBox3.TabIndex = 0;
			textBox3.Text = "Subject Allocation";
			// 
			// viewActivities
			// 
			viewActivities.BackgroundImageLayout = ImageLayout.Stretch;
			viewActivities.Controls.Add(textBox4);
			viewActivities.Location = new Point(4, 24);
			viewActivities.Name = "viewActivities";
			viewActivities.Size = new Size(984, 739);
			viewActivities.TabIndex = 2;
			viewActivities.Text = "View Activities";
			viewActivities.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			textBox4.BorderStyle = BorderStyle.None;
			textBox4.Location = new Point(183, 145);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(100, 16);
			textBox4.TabIndex = 0;
			textBox4.Text = "view activities";
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
			viewActivities.PerformLayout();
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
		private TextBox textBox4;
	}
}