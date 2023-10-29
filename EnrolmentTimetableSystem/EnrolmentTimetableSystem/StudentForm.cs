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
		private bool studentSubjectsAllocationComboBoxPopulated = false;
		private string loggedInStudentID;
		private string[] details;

		public StudentForm(LoginForm loginForm, string[] details)
		{
			this.loginForm = loginForm;
			InitializeComponent();
			loggedInStudentID = details[0];
			this.details = details;
			DisplayActivitiesForDay(mondayTimetable, "Monday");
			DisplayActivitiesForDay(tuesdayTimetable, "Tuesday");
			DisplayActivitiesForDay(wednesdayTimetable, "Wednesday");
			DisplayActivitiesForDay(thursdayTimetable, "Thursday");
			DisplayActivitiesForDay(fridayTimetable, "Friday");
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
			studentSubjectsComboBox.Items.Clear();
			studentSubjectAllocationComboBox.Items.Clear();
		}

		private void StudentLogsIn(string studentID)
		{
			loggedInStudentID = studentID;
		}

		private void logoutButton_Click(object sender, EventArgs e)
		{
			loginForm.ResetLoginForm();
			loginForm.Show();
			Close();
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
			LoadStudentSubjectAllocationComboBox();
		}

		private void LoadStudentSubjectAllocationComboBox()
		{
			if (!studentSubjectsAllocationComboBoxPopulated)
			{
				studentSubjectAllocationComboBox.Items.Clear();
				string studentID = loggedInStudentID;
				string[] subjectFiles = Directory.GetFiles("Enrolment");
				foreach (string subjectFile in subjectFiles)
				{
					string fileName = Path.GetFileNameWithoutExtension(subjectFile);
					string[] lines = File.ReadAllLines(subjectFile);
					foreach (string line in lines)
					{
						if (line.Contains(studentID))
						{
							studentSubjectAllocationComboBox.Items.Add(fileName);
							break; // If teacherID is found in the file, no need to continue checking other lines
						}
					}
				}
				studentSubjectsAllocationComboBoxPopulated = true; // Set the flag to true after populating
			}
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
				string requestFilePath = Path.Combine("Enrolment", requestFileName);
				if (!File.Exists(requestFilePath))
				{
					// If the enrollment file doesn't exist, create a new file
					File.Create(requestFilePath).Close();
				}
				// Load the students' previous requests
				string[] previousRequests = File.ReadAllLines(requestFilePath);
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
					File.AppendAllText(requestFilePath, requestData + Environment.NewLine);
					// Notify the user that the request has been submitted
					MessageBox.Show("Enrollment submitted successfully.");
				}
			}
			else
			{
				MessageBox.Show("Please select a subject from the dropdown.");
			}
		}

		private void studentSubjectAllocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedRequest = $"{studentSubjectAllocationComboBox.SelectedItem}";
			string[] selectedRequestDetails = selectedRequest.Split('-');
		}

		private void loadStudentActivitiesButton_Click(object sender, EventArgs e)
		{
			if (studentSubjectAllocationComboBox.SelectedIndex != -1)
			{
				// Read the selected subject from the combobox
				string selectedSubject = studentSubjectAllocationComboBox.SelectedItem.ToString();
				// Extract the subject ID from the selected subject
				string subjectID = GetSubjectID(selectedSubject);
				// Read the content of the subject activities file for the selected subject
				string activitiesFilePath = Path.Combine("SubjectActivities", $"{subjectID}.txt");
				if (File.Exists(activitiesFilePath))
				{
					// Load and display the content in the subjectActivitiesTextBox
					studentSubjectActivitiesTextBox.Text = File.ReadAllText(activitiesFilePath);
				}
				else
				{
					// Subject activities file doesn't exist for the selected subject
					studentSubjectActivitiesTextBox.Text = "No activities available for this subject.";
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

		private void studentSubjectActivitiesAllocateButton_Click(object sender, EventArgs e)
		{
			if (studentSubjectAllocationComboBox.SelectedIndex != -1)
			{
				string selectedSubject = studentSubjectAllocationComboBox.SelectedItem.ToString();
				string subjectID = GetSubjectID(selectedSubject);
				string studentID = loggedInStudentID;
				string studentFirstName = details[2]; // Assuming the first name is at index 2
				string studentLastName = details[3]; // Assuming the last name is at index 3
				string studentName = $"{studentFirstName} {studentLastName}";
				// Check if the teacher has already allocated for this subject
				string allocationFileName = Path.Combine("Allocation", $"{subjectID}.txt");
				if (File.Exists(allocationFileName))
				{
					string[] existingAllocations = File.ReadAllLines(allocationFileName);
					foreach (string allocation in existingAllocations)
					{
						if (allocation.Contains(studentID))
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
							string allocationData = $"{studentID}:{studentName}:student:{activityID}";
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

		private void DisplayActivitiesForDay(TextBox textBox, string day)
		{
			// Clear the textbox before populating it
			textBox.Clear();
			// Get the path to the "SubjectActivities" folder
			string activitiesFolderPath = "SubjectActivities";
			// Check if the folder exists
			if (Directory.Exists(activitiesFolderPath))
			{
				// Get a list of text files in the folder
				string[] activityFiles = Directory.GetFiles(activitiesFolderPath, "*.txt");
				foreach (string activityFile in activityFiles)
				{
					// Read the content of each activity file
					string[] activityLines = File.ReadAllLines(activityFile);
					foreach (string line in activityLines)
					{
						// Check if the line contains the specified day (e.g., "Monday")
						if (line.Contains(day, StringComparison.OrdinalIgnoreCase))
						{
							// Display the line in the specified textbox
							textBox.AppendText(line + Environment.NewLine);
						}
					}
				}
			}
			else
			{
				// The "SubjectActivities" folder doesn't exist
				textBox.Text = "Subject activities folder not found.";
			}
		}
	}
}