using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolmentTimetableSystem
{
	public partial class StudentForm : Form
	{
		private readonly LoginForm loginForm;
		private bool subjectsComboBoxPopulated = false;
		private string loggedInStudentID;

		public StudentForm(LoginForm loginForm, string[] details)
		{
			this.loginForm = loginForm;
			InitializeComponent();
			loggedInStudentID = details[0];
		}

		private string GetStudentName(string studentID)
		{
			// Create the file path using the student's ID
			string studentFilePath = Path.Combine("Students", $"{studentID}.txt");

			if (File.Exists(studentFilePath))
			{
				string[] studentData = File.ReadAllLines(studentFilePath);
				if (studentData.Length >= 1)
				{
					// Assuming the format is: ID:Username:FirstName:LastName
					string[] dataParts = studentData[0].Split(':');
					if (dataParts.Length >= 4)
					{
						string firstName = dataParts[2];
						string lastName = dataParts[3];
						return $"{firstName} {lastName}";
					}
				}
			}

			return "Unknown Student";
		}



		private void StudentForm_Load(object sender, EventArgs e)
		{
			//welcomeLabel.Text = $"Welcome back, {firstName} {lastName}!";

			//LoadStudentSubjectsComboBox();
			//UpdateStudentSubjectsTable();
			studentSubjectsComboBox.Items.Clear();
		}

		private void StudentLogsIn(string studentID)
		{
			loggedInStudentID = studentID;
		}

		private void logoutButton_Click(object sender, EventArgs e)
		{
			this.Close();
			LoginForm loginForm = new LoginForm();
			loginForm.Show();
		}

		private void viewSubjectRequestsButton_Click(object sender, EventArgs e)
		{
			studentTabControl.SelectedTab = studentTabControl.TabPages["subjectEnrolment"];
			LoadStudentSubjectsComboBox();
		}

		private void LoadStudentSubjectsComboBox()
		{
			if (!subjectsComboBoxPopulated)
			{
				studentSubjectsComboBox.Items.Clear();
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
							studentSubjectsComboBox.Items.Add($"{subjectID} - {subjectName}");
						}
					}
				}

				subjectsComboBoxPopulated = true; // Set the flag to true after populating
			}
		}

		private void studentSubjectsComboBox_DropDown(object sender, EventArgs e)
		{
			// Load subjects only when the dropdown is opened
			LoadStudentSubjectsComboBox();
		}

		private void addSubjectAndActivitiesButton_Click(object sender, EventArgs e)
		{
			studentTabControl.SelectedTab = studentTabControl.TabPages["subjectAllocation"];
		}

		private void removeFromASubjectButton_Click(object sender, EventArgs e)
		{
			studentTabControl.SelectedTab = studentTabControl.TabPages["viewTimetable"];
		}

		private void studentSubjectsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedRequest = $"{studentSubjectsComboBox.SelectedItem}";
			string[] selectedRequestDetails = selectedRequest.Split('-');
		}

		private void enrolmentButton_Click(object sender, EventArgs e)
		{
			if (studentSubjectsComboBox.SelectedIndex != -1)
			{
				string selectedSubject = studentSubjectsComboBox.SelectedItem.ToString();
				string subjectInfo = selectedSubject.Trim();

				// Replace the hard-coded studentID with the actual logic to retrieve the logged-in student's ID
				string studentID = loggedInStudentID; // Replace with your logic to get the logged-in student's ID

				// Get the student's name
				string studentName = GetStudentName(studentID);

				// Format the request data with ":" at the end
				string requestData = $"{studentID}:{studentName}:student";

				// Use only the student's ID as the request file name
				string requestFileName = $"{subjectInfo}.txt";

				// Load the students' previous requests
				string[] previousRequests = File.ReadAllLines("Enrolment\\" + requestFileName);

				// Check if the student has already enrolled in this subject
				bool isDuplicateRequest = previousRequests.Any(line => line.StartsWith(studentID + ":"));

				if (isDuplicateRequest)
				{
					// The student has already enrolled in this subject
					MessageBox.Show("You have already enrolled in this subject.");
				}
				else
				{
					// Write the request data to the appropriate request file
					File.AppendAllText("Enrolment\\" + requestFileName, requestData + Environment.NewLine);

					// Notify the user that the request has been submitted
					MessageBox.Show("Enrollment submitted successfully.");
				}
			}
			else
			{
				MessageBox.Show("Please select a subject from the dropdown.");
			}
		}

	}
}
