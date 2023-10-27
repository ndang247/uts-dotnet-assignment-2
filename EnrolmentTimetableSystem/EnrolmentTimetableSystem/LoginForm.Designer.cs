namespace EnrolmentTimetableSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            splitter1 = new Splitter();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            titleLabel = new Label();
            loginButton = new Button();
            password = new TextBox();
            id = new TextBox();
            passwordLabel = new Label();
            idLabel = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 450);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(36, 92, 150);
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 254F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(797, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 232, 230);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(password);
            panel1.Controls.Add(id);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(idLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(546, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 444);
            panel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.FromArgb(36, 92, 150);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(221, 45);
            titleLabel.TabIndex = 5;
            titleLabel.Text = "myEnrolment";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.BackColor = Color.FromArgb(15, 75, 235);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderColor = Color.White;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.DarkBlue;
            loginButton.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(3, 267);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(149, 30);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += LoginButton_Click;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(3, 232);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(240, 29);
            password.TabIndex = 3;
            password.TextChanged += Password_TextChanged;
            // 
            // id
            // 
            id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            id.Location = new Point(3, 150);
            id.Name = "id";
            id.Size = new Size(240, 29);
            id.TabIndex = 2;
            id.TextChanged += Id_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(3, 208);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 21);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idLabel.Location = new Point(3, 126);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 21);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(537, 444);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(splitter1);
            Name = "LoginForm";
            Text = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Splitter splitter1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button loginButton;
        private TextBox password;
        private TextBox id;
        private Label passwordLabel;
        private Label idLabel;
        private Label titleLabel;
        private PictureBox pictureBox1;
    }
}