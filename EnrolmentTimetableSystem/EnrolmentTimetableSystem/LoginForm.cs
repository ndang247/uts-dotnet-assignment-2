namespace EnrolmentTimetableSystem
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void id_TextChanged(object sender, EventArgs e)
		{
			// Enter ID

		}

		private void password_TextChanged(object sender, EventArgs e)
		{
			//Enter Password

		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			string enteredUsername = id.Text;
			string enteredPassword = password.Text;
			bool loginSuccessful = false;

			// Replace with the path to your TeacherLogin file
			string teacherFilePath = "C:\\Users\\User\\Desktop\\net a2\\uts-dotnet-assignment-2\\EnrolmentTimetableSystem\\EnrolmentTimetableSystem\\bin\\Debug\\net6.0-windows\\TeacherLogin.txt";

			// Attempt to read from TeacherLogin
			if (File.Exists(teacherFilePath))
			{
				string[] teacherLines = File.ReadAllLines(teacherFilePath);
				if (teacherLines.Length == 2)
				{
					string teacherUsername = teacherLines[0];
					string teacherPassword = teacherLines[1];

					if (enteredUsername == teacherUsername && enteredPassword == teacherPassword)
					{
						loginSuccessful = true;
					}
				}
			}

			// If login is not successful with TeacherLogin, attempt StudentLogin
			if (!loginSuccessful)
			{
				// Replace with the path to your StudentLogin file
				string studentFilePath = "C:\\Users\\User\\Desktop\\net a2\\uts-dotnet-assignment-2\\EnrolmentTimetableSystem\\EnrolmentTimetableSystem\\bin\\Debug\\net6.0-windows\\StudentLogin.txt";

				if (File.Exists(studentFilePath))
				{
					string[] studentLines = File.ReadAllLines(studentFilePath);
					if (studentLines.Length == 2)
					{
						string studentUsername = studentLines[0];
						string studentPassword = studentLines[1];

						if (enteredUsername == studentUsername && enteredPassword == studentPassword)
						{
							loginSuccessful = true;
						}
					}
				}
			}

			if (loginSuccessful)
			{
				MessageBox.Show("Login Successful");
				// You can add code here to open the main application or perform other actions.
			}
			else
			{
				MessageBox.Show("Login Failed. Please check your username and password.");
			}
		}

	}
}