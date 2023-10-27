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
		private bool subjectsAllocationComboBoxPopulated = false;
		private string loggedInTeacherID;
		private string[] details;


		public TeacherForm(LoginForm loginForm, string[] details)
		{
			this.loginForm = loginForm;
			InitializeComponent();
			loggedInTeacherID = details[0];
			this.details = details;
		}

		private void TeacherForm_Load(object sender, EventArgs e)
		{
			teacherSubjectsComboBox.Items.Clear();
			teacherSubjectAllocationComboBox.Items.Clear();
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
			LoadTeacherSubjectAllocationComboBox();
		}

		private void LoadTeacherSubjectAllocationComboBox()
		{
			if (!subjectsAllocationComboBoxPopulated)
			{
				teacherSubjectAllocationComboBox.Items.Clear();
				string teacherID = loggedInTeacherID;

				string[] subjectFiles = Directory.GetFiles("Enrolment");

				foreach (string subjectFile in subjectFiles)
				{
					string fileName = Path.GetFileNameWithoutExtension(subjectFile);
					string[] lines = File.ReadAllLines(subjectFile);

					foreach (string line in lines)
					{
						if (line.Contains(teacherID))
						{
							teacherSubjectAllocationComboBox.Items.Add(fileName);
							break; // If teacherID is found in the file, no need to continue checking other lines
						}
					}
				}

				subjectsAllocationComboBoxPopulated = true; // Set the flag to true after populating
			}
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

		private void teacherSubjectAllocationComboBox_DropDown(object sender, EventArgs e)
		{
			// Load subjects only when the dropdown is opened
			LoadTeacherSubjectAllocationComboBox();
		}

		private void teacherSubjectAllocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedRequest = $"{teacherSubjectsComboBox.SelectedItem}";
			string[] selectedRequestDetails = selectedRequest.Split('-');
		}


		private void loadActivitiesButton_Click(object sender, EventArgs e)
		{
			if (teacherSubjectAllocationComboBox.SelectedIndex != -1)
			{
				// Read the selected subject from the combobox
				string selectedSubject = teacherSubjectAllocationComboBox.SelectedItem.ToString();

				// Extract the subject ID from the selected subject
				string subjectID = GetSubjectID(selectedSubject);

				// Read the content of the subject activities file for the selected subject
				string activitiesFilePath = Path.Combine("SubjectActivities", $"{subjectID}.txt");

				if (File.Exists(activitiesFilePath))
				{
					// Load and display the content in the subjectActivitiesTextBox
					subjectActivitiesTextBox.Text = File.ReadAllText(activitiesFilePath);
				}
				else
				{
					// Subject activities file doesn't exist for the selected subject
					subjectActivitiesTextBox.Text = "No activities available for this subject.";
				}
			}
			else
			{
				MessageBox.Show("Please select a subject from the dropdown.");
			}
		}

		private string GetSubjectID(string subjectName)
		{
			// You need to extract the subject ID from the subjectName
			// This is a simplified example; you may need to adjust it based on your file naming conventions
			string[] parts = subjectName.Split('-');
			if (parts.Length == 2)
			{
				return parts[0].Trim();
			}
			return "";
		}

		private void subjectActivitiesAllocateButton_Click(object sender, EventArgs e)
		{
			if (teacherSubjectAllocationComboBox.SelectedIndex != -1)
			{
				string selectedSubject = teacherSubjectAllocationComboBox.SelectedItem.ToString();
				string subjectID = GetSubjectID(selectedSubject);
				string teacherID = loggedInTeacherID;
				string teacherFirstName = details[2]; // Assuming the first name is at index 2
				string teacherLastName = details[3]; // Assuming the last name is at index 3
				string teacherName = $"{teacherFirstName} {teacherLastName}";

				// Check if the teacher has already allocated for this subject
				string allocationFileName = Path.Combine("Allocation", $"{subjectID}.txt");
				if (File.Exists(allocationFileName))
				{
					string[] existingAllocations = File.ReadAllLines(allocationFileName);
					foreach (string allocation in existingAllocations)
					{
						if (allocation.Contains(teacherID))
						{
							MessageBox.Show("You have already allocated to activities for this subject.");
							return; // Exit the function if already allocated
						}
					}
				}

				// Read the subject activities from the SubjectActivities file for the selected subject
				string activitiesFilePath = Path.Combine("SubjectActivities", $"{subjectID}.txt");

				if (File.Exists(activitiesFilePath))
				{
					string[] activityLines = File.ReadAllLines(activitiesFilePath);

					foreach (string line in activityLines)
					{
						string[] activityData = line.Split('|');

						// Ensure the line has at least one element before accessing the activity ID
						if (activityData.Length > 0)
						{
							string activityID = activityData[0];

							// Use the activity's ID as the allocation file name
							string activityAllocationFileName = Path.Combine("Allocation", $"{subjectID}.txt");

							// Append allocation data (teacher ID, teacher name, role, and activity ID)
							string allocationData = $"{teacherID}:{teacherName}:teacher:{activityID}";

							File.AppendAllText(activityAllocationFileName, allocationData + Environment.NewLine);
						}
					}

					// Notify the user that the allocation has been made
					MessageBox.Show("Allocation successful.");
				}
				else
				{
					// Subject activities file doesn't exist for the selected subject
					MessageBox.Show("No activities available for this subject.");
				}
			}
			else
			{
				MessageBox.Show("Please select a subject from the dropdown.");
			}
		}




	}

}