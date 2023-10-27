using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EnrolmentTimetableSystem
{
	public partial class TeacherForm : Form
	{
		private readonly LoginForm loginForm;
		private bool subjectsComboBoxPopulated = false;
		private string loggedInTeacherID;


		public TeacherForm(LoginForm loginForm, string[] details)
		{
			this.loginForm = loginForm;
			InitializeComponent();
			loggedInTeacherID = details[0];
		}

		private void TeacherForm_Load(object sender, EventArgs e)
		{
			//welcomeLabel.Text = $"Welcome back, {firstName} {lastName}!";

			//LoadTeacherSubjectsComboBox();
			//UpdateTeacherSubjectsTable();
			teacherSubjectsComboBox.Items.Clear();
		}

		private void TeacherLogsIn(string teacherID)
		{
			loggedInTeacherID = teacherID;
		}

		private void viewSubjectRequestsButton_Click(object sender, EventArgs e)
		{
			teacherTabControl.SelectedTab = teacherTabControl.TabPages["subjectRequest"];
			LoadTeacherSubjectsComboBox();
		}

		private void LoadTeacherSubjectsComboBox()
		{
			if (!subjectsComboBoxPopulated)
			{
				teacherSubjectsComboBox.Items.Clear();
				string[] subjectFiles = Directory.GetFiles("Subjects");

				foreach (string subjectFile in subjectFiles)
				{
					string fileName = Path.GetFileNameWithoutExtension(subjectFile);
					string[] lines = File.ReadAllLines(subjectFile);

					if (lines.Length > 0)
					{
						string[] subjectData = lines[0].Split(':');
						if (subjectData.Length == 2)
						{
							string subjectID = subjectData[0];
							string subjectName = subjectData[1];
							teacherSubjectsComboBox.Items.Add($"{subjectID} - {subjectName}");
						}
					}
				}

				subjectsComboBoxPopulated = true; // Set the flag to true after populating
			}
		}

		private void teacherSubjectsComboBox_DropDown(object sender, EventArgs e)
		{
			// Load subjects only when the dropdown is opened
			LoadTeacherSubjectsComboBox();
		}

		private void teacherSubjectsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedRequest = $"{teacherSubjectsComboBox.SelectedItem}";
			string[] selectedRequestDetails = selectedRequest.Split('-');
		}

		private void addSubjectAndActivitiesButton_Click(object sender, EventArgs e)
		{
			teacherTabControl.SelectedTab = teacherTabControl.TabPages["subjectAllocation"];
		}

		private void removeFromASubjectButton_Click(object sender, EventArgs e)
		{
			teacherTabControl.SelectedTab = teacherTabControl.TabPages["viewActivities"];
		}

		// Need to check if this actually logs the user out
		private void logoutButton_Click(object sender, EventArgs e)
		{
			loginForm.ResetLoginForm();
			loginForm.Show();
			Close();
		}

		private void SubmitSubjectRequest_Click(object sender, EventArgs e)
		{
			if (teacherSubjectsComboBox.SelectedIndex != -1)
			{
				string selectedSubject = teacherSubjectsComboBox.SelectedItem.ToString();
				string subjectInfo = selectedSubject.Trim();

				// Replace the hard-coded teacherID with the actual logic to retrieve the logged-in teacher's ID
				string teacherID = loggedInTeacherID; // Replace with your logic to get the logged-in teacher's ID

				// Trim the message to remove any leading/trailing spaces
				string message = requestMessageTextBox.Text.Trim();

				// Format the request data with ":" at the end
				string requestData = $"{GenerateRandomNumber()}:{teacherID}:{subjectInfo}:{message}:Awaiting for approval:";

				// Use only the teacher's ID as the request file name
				string requestFileName = $"{teacherID}.txt";

				// Load the teacher's previous requests
				string[] previousRequests = File.ReadAllLines("Requests\\" + requestFileName);

				// Check if the new request already exists in the teacher's previous requests
				bool isDuplicateRequest = previousRequests.Any(line => line.Contains(subjectInfo));

				if (isDuplicateRequest)
				{
					// A request for this subject already exists
					MessageBox.Show("You have already submitted a request for this subject.");
				}
				else
				{
					// Write the request data to the appropriate request file
					File.AppendAllText("Requests\\" + requestFileName, requestData + Environment.NewLine);

					// Notify the user that the request has been submitted
					MessageBox.Show("Request submitted successfully.");
				}
			}
			else
			{
				MessageBox.Show("Please select a subject from the dropdown.");
			}
		}






		private int GenerateRandomNumber()
		{
			// Implement a method to generate a random number as per your requirements
			Random random = new Random();
			return random.Next(10000, 99999); // Change the range as needed
		}

	}

}

