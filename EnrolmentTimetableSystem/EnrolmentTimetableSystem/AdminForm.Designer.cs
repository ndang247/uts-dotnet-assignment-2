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
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Size = new Size(255, 450);
            panel1.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.Dock = DockStyle.Top;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.ForeColor = Color.Black;
            logoutButton.Location = new Point(0, 325);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(255, 35);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
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
            removeFromASubjectButton.Text = "Remove From A Subject";
            removeFromASubjectButton.UseVisualStyleBackColor = false;
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
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "AdminForm";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}