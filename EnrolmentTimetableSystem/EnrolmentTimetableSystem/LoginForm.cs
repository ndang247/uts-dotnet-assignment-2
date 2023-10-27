using System;
using System.Windows.Forms;
using System.IO;

namespace EnrolmentTimetableSystem
{
	public partial class LoginForm : Form
	{
		private string enteredID = "";
		private string enteredPassword = "";

		public LoginForm()
		{
			InitializeComponent();
		}

		private void Id_TextChanged(object sender, EventArgs e)
		{
			enteredID = id.Text.Trim();
		}

		private void Password_TextChanged(object sender, EventArgs e)
		{
			enteredPassword = password.Text.Trim();
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			try
			{
				Console.WriteLine(enteredID);
				string file = $"{enteredID}.txt";

				// Check if the file exists in three role directories
				if (File.Exists($"Students\\{file}"))
				{
					CheckCredentials(enteredID, enteredPassword, "Students", file);
				}
				else if (File.Exists($"Teachers\\{file}"))
				{
					CheckCredentials(enteredID, enteredPassword, "Teachers", file);
				}
				else if (File.Exists($"Admin\\{file}"))
				{
					CheckCredentials(enteredID, enteredPassword, "Admin", file);
				}
				else
				{
					throw new Exception("Invalid ID or account user doesn't exist");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CheckCredentials(string id, string password, string role, string file)
		{
			// Read the file
			string[] lines = File.ReadAllLines($"{role}\\{file}");
			string[] details = lines[0].Split(':');

			// Check if the id and password is correct
			if (id == details[0] && password == details[1])
			{
				switch (role)
				{
					case "Students":
						Hide();
						StudentForm studentForm = new(this, details);
						studentForm.Show();
						break;
					case "Teachers":
						Hide();
						TeacherForm teacherForm = new(this, details);
						teacherForm.Show();
						break;
					case "Admin":
						Hide();
						AdminForm adminForm = new(this, details);
						adminForm.Show();
						break;
					default:
						break;
				}
			}
			else
			{
				throw new Exception("Invalid password");
			}
		}

		public void ResetLoginForm()
		{
			id.Text = "";
			password.Text = "";
		}
	}
}