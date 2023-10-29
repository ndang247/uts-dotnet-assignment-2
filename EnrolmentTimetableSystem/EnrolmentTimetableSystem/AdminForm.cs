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
    public partial class AdminForm : Form
    {
        private readonly LoginForm loginForm;
        private readonly string firstName, lastName;

        private static string GenerateCode
        {
            get
            {
                // Random generate 5 digits code
                Random random = new();
                int code = random.Next(10000, 99999);
                while (File.Exists($"Subjects\\{code}.txt"))
                {
                    code = random.Next(10000, 99999);
                }
                return code.ToString();
            }
        }

        public AdminForm(LoginForm loginForm, string[] adminDetails)
        {
            this.loginForm = loginForm;
            firstName = adminDetails[2];
            lastName = adminDetails[3];
            InitializeComponent();
        }

        #region Form load
        private void AdminForm_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = $"Welcome back, {firstName} {lastName}!";

            LoadRequestsComboBox();
            UpdateRequestsTable();
        }
        #endregion

        #region Approve and view requests
        private void ViewSubjectRequestsButton_Click(object sender, EventArgs e)
        {
            adminTabControl.SelectedTab = viewSubjectRequestsPage;
            LoadRequestsComboBox();
            ResetApproveRequestForm();
        }

        private void LoadRequestsComboBox()
        {
            requestsComboBox.Items.Clear();
            string[] requests = Directory.GetFiles("Requests");
            foreach (string request in requests)
            {
                string[] lines = File.ReadAllLines(request);

                foreach (string line in lines)
                {
                    string[] requestData = line.Split(':');

                    if (requestData[4] == "Awaiting for approval")
                    {
                        // Teacher details
                        string teacher = File.ReadAllText($"Teachers\\{requestData[1]}.txt");
                        string[] teacherData = teacher.Split(':');
                        //

                        requestsComboBox.Items.Add($"{requestData[0]} - {teacherData[0]}");
                    }
                }
            }
        }

        private void RequestsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRequest = $"{requestsComboBox.SelectedItem}";
            string[] selectedRequestDetails = selectedRequest.Split('-');

            string requestID = selectedRequestDetails[0].Trim();
            string teacherID = selectedRequestDetails[1].Trim();

            // Get Request details
            selectedRequestDetails = GetRequestDetails(requestID, teacherID);
            //

            // Teacher details
            string teacher = File.ReadAllText($"Teachers\\{teacherID}.txt");
            string[] teacherDetails = teacher.Split(':');
            //

            teacherFullNameTextBox.Text = $"{teacherDetails[2]} {teacherDetails[3]}";
            subjectTextBox.Text = $"{selectedRequestDetails[2]}";
            messageRichTextBox.Text = $"{selectedRequestDetails[3]}";
            statusTextBox.Text = $"{selectedRequestDetails[4]}";

            if (statusTextBox.Text == "Awaiting for approval")
            {
                approveButton.Enabled = true;
                rejectButton.Enabled = true;
            }
            else
            {
                approveButton.Enabled = false;
                rejectButton.Enabled = false;
            }
        }

        private static string[] GetRequestDetails(string requestID, string teacherID)
        {
            string[] requests = File.ReadAllLines($"Requests\\{teacherID}.txt");

            foreach (string request in requests)
            {
                string[] requestData = request.Split(':');
                if (requestData[0] == requestID)
                {
                    return requestData;
                }
            }

            return Array.Empty<string>();
        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            string selectedRequest = $"{requestsComboBox.SelectedItem}";
            string[] selectedRequestDetails = selectedRequest.Split('-');
            string requestID = selectedRequestDetails[0].Trim();
            string teacherID = selectedRequestDetails[1].Trim();
            string teacherFullName = teacherFullNameTextBox.Text.Trim();

            string[] requests = File.ReadAllLines($"Requests\\{teacherID}.txt");
            for (int i = 0; i < requests.Length; i++)
            {
                string[] requestData = requests[i].Split(':');
                if (requestData[0] == $"{requestID}")
                {
                    requests[i] = $"{requestData[0]}:{requestData[1]}:{requestData[2]}:{requestData[3]}:Approved:{requestData[5]}";
                    File.WriteAllLines($"Requests\\{teacherID}.txt", requests);

                    AllocateToSubject(teacherID, teacherFullName, requestData[2]);

                    requestData = GetRequestDetails(requestID, teacherID);
                    AddNewRow(requestData[0], requestData[1], requestData[2], requestData[3], "Approved", requestData[5]);
                    ResetApproveRequestForm();
                    break;
                }
            }
        }

        private static void AllocateToSubject(string teacherID, string teacherFullName, string subjectID)
        {
            string data = $"{teacherID}:{teacherFullName}:teacher";

            if (File.Exists($"Enrolment\\{subjectID}.txt"))
            {
                File.AppendAllText($"Enrolment\\{subjectID}.txt", $"\n{data}");
            }
            else
            {
                File.WriteAllText($"Enrolment\\{subjectID}.txt", data);
            }
        }

        private void RejectButton_Click(object sender, EventArgs e)
        {
            rejectionReasonLabel.Visible = true;
            rejectionReasonRichTextBox.Visible = true;

            if (string.IsNullOrEmpty(rejectionReasonRichTextBox.Text))
            {
                MessageBox.Show("Please fill in the rejection reason", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedRequest = $"{requestsComboBox.SelectedItem}";
            string[] selectedRequestDetails = selectedRequest.Split('-');
            string requestID = selectedRequestDetails[0].Trim();
            string teacherID = selectedRequestDetails[1].Trim();

            string[] requests = File.ReadAllLines($"Requests\\{teacherID}.txt");
            for (int i = 0; i < requests.Length; i++)
            {
                string[] requestData = requests[i].Split(':');
                if (requestData[0] == $"{requestID}")
                {
                    requests[i] = $"{requestData[0]}:{requestData[1]}:{requestData[2]}:{requestData[3]}:Rejected:{rejectionReasonRichTextBox.Text}";
                    File.WriteAllLines($"Requests\\{teacherID}.txt", requests);

                    requestData = GetRequestDetails(requestID, teacherID);
                    AddNewRow(requestData[0], requestData[1], requestData[2], requestData[3], "Rejected", requestData[5]);
                    ResetApproveRequestForm();
                    break;
                }
            }
        }

        private void ResetApproveRequestForm()
        {
            teacherFullNameTextBox.Text = "";
            subjectTextBox.Text = "";
            messageRichTextBox.Text = "";
            statusTextBox.Text = "";
            rejectionReasonRichTextBox.Text = "";
            approveButton.Enabled = false;
            rejectButton.Enabled = false;
        }

        private void UpdateRequestsTable()
        {
            // Read all files in requests folder
            string[] requests = Directory.GetFiles("Requests");
            foreach (string request in requests)
            {
                string[] lines = File.ReadAllLines(request);
                foreach (string line in lines)
                {
                    string status = line.Split(':')[4];
                    if (status == "Approved" || status == "Rejected")
                    {
                        string requestID = line.Split(':')[0];
                        string tID = line.Split(':')[1];
                        string subject = line.Split(':')[2];
                        string message = line.Split(':')[3];
                        string reason = line.Split(':')[5];
                        AddNewRow(requestID, tID, subject, message, status, reason);
                    }
                }
            }
        }

        private void AddNewRow(string requestID, string tID, string subject, string message, string status, string rfr)
        {
            // Create a label for each subjectRequestsTableLayoutPanel cell and display the request details
            Label requestIDLabel = new()
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                Text = requestID,
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.None,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Margin = new Padding(0),
            };
            Label teacherID = new()
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                Text = tID,
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.None,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Margin = new Padding(0),
            };
            Label subjectLabel = new()
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                Text = subject,
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.None,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Margin = new Padding(0),
            };
            Label messageLabel = new()
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                Text = message,
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.None,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Margin = new Padding(0),
            };
            Label statusLabel = new()
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                Text = status,
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.None,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Margin = new Padding(0),
            };
            Label reasonForRejection = new()
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                Text = rfr,
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.None,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Margin = new Padding(0),
            };

            // Add the labels to the subjectRequestsTableLayoutPanel
            int row = subjectRequestsTableLayoutPanel.RowCount - 1;
            subjectRequestsTableLayoutPanel.RowCount++;

            subjectRequestsTableLayoutPanel.Controls.Add(requestIDLabel, 0, row);
            subjectRequestsTableLayoutPanel.Controls.Add(teacherID, 1, row);
            subjectRequestsTableLayoutPanel.Controls.Add(subjectLabel, 2, row);
            subjectRequestsTableLayoutPanel.Controls.Add(messageLabel, 3, row);
            subjectRequestsTableLayoutPanel.Controls.Add(statusLabel, 4, row);
            subjectRequestsTableLayoutPanel.Controls.Add(reasonForRejection, 5, row);
            subjectRequestsTableLayoutPanel.RowStyles.Add(new RowStyle());
        }
        #endregion

        #region Add subject and activities
        private void AddSubjectAndActivitiesButton_Click(object sender, EventArgs e)
        {
            adminTabControl.SelectedTab = addASubjectAndActivitiesPage;
            activityStartDateTimePicker.MinDate = DateTime.Now;
            activityEndDateTimePicker.MinDate = activityStartDateTimePicker.Value.AddDays(7);
        }

        private void SjCodeNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string code = sjCodeTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(code))
            {
                if (File.Exists($"Subjects\\{code}.txt"))
                {
                    string[] data = File.ReadAllLines($"Subjects\\{code}.txt");
                    sjNameTextBox.Text = data[0].Split(':')[1];
                    addSubjectButton.Enabled = true;
                }

                string name = sjNameTextBox.Text.Trim();
                addSubjectButton.Enabled = !string.IsNullOrEmpty(name);
                if (string.IsNullOrEmpty(name))
                {
                    addActivitiesGroup.Visible = false;
                }
            }
            else
            {
                addSubjectButton.Enabled = false;
                addActivitiesGroup.Visible = false;
            }
        }

        private void GenerateSubjectCodeButton_Click(object sender, EventArgs e)
        {
            sjCodeTextBox.Text = GenerateCode;
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(sjCodeTextBox.Text, out _) || sjCodeTextBox.Text.Length != 5)
            {
                MessageBox.Show("Subject code must be 5 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists($"Subjects\\{sjCodeTextBox.Text}.txt"))
            {
                // Check if the subject name already taken
                string[] subjects = Directory.GetFiles("Subjects");
                foreach (string subject in subjects)
                {
                    string[] s = File.ReadAllLines(subject);
                    if (s[0].Split(':')[1] == sjNameTextBox.Text)
                    {
                        MessageBox.Show("The subject name already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        addActivitiesGroup.Visible = false;
                        return;
                    }
                }
                string data = $"{sjCodeTextBox.Text}:{sjNameTextBox.Text}";
                // Create a new subject file
                File.WriteAllText($"Subjects\\{sjCodeTextBox.Text}.txt", data);
            }
            else
            {
                MessageBox.Show($"The subject already added, you can now start adding activity for {sjCodeTextBox.Text}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            addActivitiesGroup.Visible = true;
        }

        private void ActivityStartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            activityEndDateTimePicker.MinDate = activityStartDateTimePicker.Value;
        }

        private void AddSubjectActivityButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists($"Subjects\\{sjCodeTextBox.Text.Trim()}.txt"))
            {
                MessageBox.Show("Subject does not exist! Please add a subject first before creating an activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if all the fields are filled
            if (string.IsNullOrEmpty($"{activityTypeComboxBox.SelectedItem}") ||
                string.IsNullOrEmpty($"{activityDateTimePicker.Value:t}") ||
                string.IsNullOrEmpty(activityCampusTextBox.Text) ||
                string.IsNullOrEmpty(activityLocationTextBox.Text) ||
                string.IsNullOrEmpty($"{activityDayComboBox.SelectedItem}") ||
                string.IsNullOrEmpty(activityDescriptionTextBox.Text) ||
                string.IsNullOrEmpty($"{activityStartDateTimePicker.Value:d}") ||
                string.IsNullOrEmpty($"{activityEndDateTimePicker.Value:d}") ||
                string.IsNullOrEmpty($"{activityDurationNumericUpDown.Value}"))
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /* 1. Check if the activity file exists
             * 2. If not, create a new subject file and append the activity
             * 3. Otherwise just append the activity
             */
            string activityCode = GenerateCode;
            string data = $"{sjCodeTextBox.Text.Trim()}" +
                          $"|{sjNameTextBox.Text.Trim()}" +
                          $"|{activityCode}" +
                          $"|{activityTypeComboxBox.SelectedItem}" +
                          $"|{activityDateTimePicker.Value:t}" +
                          $"|{activityCampusTextBox.Text}" +
                          $"|{activityLocationTextBox.Text}" +
                          $"|{activityDayComboBox.SelectedItem}" +
                          $"|{activityDescriptionTextBox.Text}" +
                          $"|{activityStartDateTimePicker.Value:d}" +
                          $"|{activityEndDateTimePicker.Value:d}" +
                          $"|{activityDurationNumericUpDown.Value}";
            if (File.Exists($"SubjectActivities\\{sjCodeTextBox.Text}.txt"))
            {
                // Check if the activity already exists at the same allocated time
                string[] activities = File.ReadAllLines($"SubjectActivities\\{sjCodeTextBox.Text}.txt");
                foreach (string activity in activities)
                {
                    string[] activityData = activity.Split('|');
                    if (activityData[0] == $"{sjCodeTextBox.Text.Trim()}" &&
                        activityData[1] == $"{sjNameTextBox.Text.Trim()}" &&
                        activityData[3] == $"{activityTypeComboxBox.SelectedItem}" &&
                        activityData[4] == $"{activityDateTimePicker.Value:t}" &&
                        activityData[5] == $"{activityCampusTextBox.Text}" &&
                        activityData[6] == $"{activityLocationTextBox.Text}" &&
                        activityData[7] == $"{activityDayComboBox.SelectedItem}" &&
                        activityData[8] == $"{activityDescriptionTextBox.Text}" &&
                        activityData[9] == $"{activityStartDateTimePicker.Value:d}" &&
                        activityData[10] == $"{activityEndDateTimePicker.Value:d}" &&
                        activityData[11] == $"{activityDurationNumericUpDown.Value}")
                    {
                        MessageBox.Show("The activity already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                File.AppendAllText($"SubjectActivities\\{sjCodeTextBox.Text}.txt", $"\n{data}");
            }
            else
            {
                File.WriteAllText($"SubjectActivities\\{sjCodeTextBox.Text}.txt", data);
            }
            MessageBox.Show("The activity has been added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Remove teacher and student from a subject
        private void RemoveFromASubjectButton_Click(object sender, EventArgs e)
        {
            adminTabControl.SelectedTab = removeFromASubjectPage;
            LoadSubjectsListBox();
        }

        private void LoadSubjectsListBox()
        {
            subjectsListBox.Items.Clear();
            string[] subjects = Directory.GetFiles("Subjects");
            foreach (string subject in subjects)
            {
                string[] data = File.ReadAllLines(subject);
                subjectsListBox.Items.Add($"{data[0].Split(':')[0]} - {data[0].Split(':')[1]}");
            }
        }

        private void SubjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedSubject = $"{subjectsListBox.SelectedItem}";
                string[] selectedSubjectDetails = selectedSubject.Split('-');

                string subjectID = selectedSubjectDetails[0].Trim();
                string subjectName = selectedSubjectDetails[1].Trim();

                if (File.Exists($"Enrolment\\{subjectID} - {subjectName}.txt"))
                {
                    LoadEnrolmentListBox(subjectID, subjectName);
                }
                else
                {
                    teachersListBox.Items.Clear();
                    studentsListBox.Items.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEnrolmentListBox(string subjectID, string subjectName)
        {
            teachersListBox.Items.Clear();
            studentsListBox.Items.Clear();

            // Get enrolement by subject ID
            string[] enrolments = File.ReadAllLines($"Enrolment\\{subjectID} - {subjectName}.txt");

            // For each enrolment if it has teacher role add to the teacherListbox else add to the studentListbox
            foreach (string enrolment in enrolments)
            {
                string[] enrolmentData = enrolment.Split(':');
                if (enrolmentData[2] == "teacher")
                {
                    string teacher = File.ReadAllText($"Teachers\\{enrolmentData[0]}.txt");
                    string[] teacherData = teacher.Split(':');
                    teachersListBox.Items.Add($"{teacherData[0]} - {teacherData[2]} {teacherData[3]}");
                }
                else
                {
                    string student = File.ReadAllText($"Students\\{enrolmentData[0]}.txt");
                    string[] studentData = student.Split(':');
                    studentsListBox.Items.Add($"{studentData[0]} - {studentData[2]} {studentData[3]}");
                }
            }
        }

        private void TeachersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeTeacherFromSubjectButton.Enabled = true;
        }

        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeStudentFromSubjectButton.Enabled = true;
        }

        private void RemoveStudentFromSubjectButton_Click(object sender, EventArgs e)
        {
            string[] selectedSubjectDetails = $"{subjectsListBox.SelectedItem}".Split('-');
            string subjectID = selectedSubjectDetails[0].Trim();
            string subjectName = selectedSubjectDetails[1].Trim();

            string[] selectedStudentDetails = $"{studentsListBox.SelectedItem}".Split('-');
            string studentID = selectedStudentDetails[0].Trim();

            RemoveFromSubject(subjectID, subjectName, studentID);

            RemoveFromAllocation(subjectID, studentID);

            LoadEnrolmentListBox(subjectID, subjectName);

            removeStudentFromSubjectButton.Enabled = false;
        }

        private void RemoveTeacherFromSubjectButton_Click(object sender, EventArgs e)
        {
            string[] selectedSubjectDetails = $"{subjectsListBox.SelectedItem}".Split('-');
            string subjectID = selectedSubjectDetails[0].Trim();
            string subjectName = selectedSubjectDetails[1].Trim();

            string[] selectedTeacherDetails = $"{teachersListBox.SelectedItem}".Split('-');
            string teacherID = selectedTeacherDetails[0].Trim();

            RemoveFromSubject(subjectID, subjectName, teacherID);

            RemoveFromAllocation(subjectID, teacherID);

            LoadEnrolmentListBox(subjectID, subjectName);

            removeTeacherFromSubjectButton.Enabled = false;
        }

        private static void RemoveFromSubject(string subjectID, string subjectName, string userID)
        {
            // Find the subject in the enrolment folder
            string[] enrolments = File.ReadAllLines($"Enrolment\\{subjectID} - {subjectName}.txt");

            // Remove the user from the subject
            for (int i = 0; i < enrolments.Length; i++)
            {
                string[] enrolmentData = enrolments[i].Split(':');
                if (enrolmentData[0] == userID)
                {
                    enrolments[i] = "";
                    break;
                }
            }

            // Convert the array to list and remove the empty elements
            List<string> enrolmentsList = enrolments.ToList();
            enrolmentsList.RemoveAll(x => x == "");

            // Write the new enrolment data to the file
            File.WriteAllLines($"Enrolment\\{subjectID} - {subjectName}.txt", enrolmentsList);
        }

        private static void RemoveFromAllocation(string subjectID, string userID)
        {
            // Remove the user from the allocation
            string[] allocations = File.ReadAllLines($"Allocation\\{subjectID}.txt");
            for (int i = 0; i < allocations.Length; i++)
            {
                string[] allocationData = allocations[i].Split(':');
                if (allocationData[0] == userID)
                {
                    allocations[i] = "";
                }
            }

            // Convert the array to list and remove the empty elements
            List<string> allocationsList = allocations.ToList();
            allocationsList.RemoveAll(x => x == "");

            // Write the new allocation data to the file
            File.WriteAllLines($"Allocation\\{subjectID}.txt", allocationsList);
        }
        #endregion

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            loginForm.ResetLoginForm();
            loginForm.Show();
            Close();
        }

    }
}
