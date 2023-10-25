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

        public AdminForm(LoginForm loginForm, string[] adminDetails)
        {
            this.loginForm = loginForm;
            firstName = adminDetails[2];
            lastName = adminDetails[3];
            InitializeComponent();
        }

        private void ViewSubjectRequestsButton_Click(object sender, EventArgs e)
        {
            adminTabControl.SelectedTab = viewSubjectRequestsPage;
        }

        private void AddSubjectAndActivitiesButton_Click(object sender, EventArgs e)
        {
            adminTabControl.SelectedTab = addASubjectAndActivitiesPage;
        }

        private void RemoveFromASubjectButton_Click(object sender, EventArgs e)
        {
            adminTabControl.SelectedTab = removeFromASubjectPage;
        }

        private void AddActivityButton_Click(object sender, EventArgs e)
        {
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
                        return;
                    }
                }
                string data = $"{sjCodeTextBox.Text}:{sjNameTextBox.Text}";
                // Create a new subject file
                File.WriteAllText($"Subjects\\{sjCodeTextBox.Text}.txt", data);
            }
            addActivitiesGroup.Visible = true;
        }

        private void SjCodeNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(sjCodeTextBox.Text) && string.IsNullOrEmpty(sjNameTextBox.Text))
            {
                if (File.Exists($"Subjects\\{sjCodeTextBox.Text}.txt"))
                {
                    string[] data = File.ReadAllLines($"Subjects\\{sjCodeTextBox.Text}.txt");
                    sjNameTextBox.Text = data[0].Split(':')[1];
                    addActivityButton.Enabled = true;
                }
                addActivityButton.Enabled = false;
            }
            else if (!string.IsNullOrEmpty(sjNameTextBox.Text) && !string.IsNullOrEmpty(sjCodeTextBox.Text))
            {
                addActivityButton.Enabled = true;
            }
            else
            {
                addActivityButton.Enabled = false;
            }
        }

        private void GenerateSubjectCodeButton_Click(object sender, EventArgs e)
        {
            // Random generate 5 digits code
            Random random = new();
            int code = random.Next(10000, 99999);
            while (File.Exists($"Subjects\\{code}.txt"))
            {
                code = random.Next(10000, 99999);
            }
            sjCodeTextBox.Text = code.ToString();
        }

        private void AddSubjectActivityButton_Click(object sender, EventArgs e)
        {
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
            string data = $"{activityTypeComboxBox.SelectedItem}" +
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
                // Check if the activity already exists at the same time
                string[] activities = File.ReadAllLines($"SubjectActivities\\{sjCodeTextBox.Text}.txt");
                foreach (string activity in activities)
                {
                    string[] activityData = activity.Split('|');
                    if (activityData[0] == $"{activityTypeComboxBox.SelectedItem}" &&
                        activityData[1] == $"{activityDateTimePicker.Value:t}" &&
                        activityData[2] == $"{activityCampusTextBox.Text}" &&
                        activityData[3] == $"{activityLocationTextBox.Text}" &&
                        activityData[4] == $"{activityDayComboBox.SelectedItem}" &&
                        activityData[5] == $"{activityDescriptionTextBox.Text}" &&
                        activityData[6] == $"{activityStartDateTimePicker.Value:d}" &&
                        activityData[7] == $"{activityEndDateTimePicker.Value:d}" &&
                        activityData[8] == $"{activityDurationNumericUpDown.Value}")
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

        private void ActivityStartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            activityEndDateTimePicker.MinDate = activityStartDateTimePicker.Value;
        }

        private void SubjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = $"Welcome back, {firstName} {lastName}!";

            subjectsListBox.Items.Clear();
            string[] subjects = Directory.GetFiles("Subjects");
            foreach (string subject in subjects)
            {
                string[] data = File.ReadAllLines(subject);
                subjectsListBox.Items.Add($"{data[0].Split(':')[0]} - {data[0].Split(':')[1]}");
            }

            // read all files in requests folder
            string[] requests = Directory.GetFiles("Requests");
            foreach (string request in requests)
            {
                string[] lines = File.ReadAllLines(request);
                foreach (string line in lines)
                {
                    string requestID = line.Split(':')[0];
                    string tID = line.Split(':')[1];
                    string subject = line.Split(':')[2];
                    string message = line.Split(':')[3];
                    string status = line.Split(':')[4];
                    string reason = line.Split(':')[5];
                    AddNewRow(requestID, tID, subject, message, status, reason);
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
            AddActions(row, requestID);
            subjectRequestsTableLayoutPanel.RowStyles.Add(new RowStyle());
        }

        private void AddActions(int row, string requestID)
        {
            // 
            // requestAcceptButton
            // 
            Button requestAcceptButton = new()
            {
                BackColor = Color.LightGreen,
                FlatAppearance =
                {
                    BorderColor = Color.White,
                    MouseDownBackColor = Color.Green,
                    MouseOverBackColor = Color.Green
                },
                FlatStyle = FlatStyle.Flat,
                Location = new Point(3, 3),
                Name = "requestAcceptButton",
                Size = new Size(75, 32),
                TabIndex = 11,
                Text = "Accept",
                UseVisualStyleBackColor = false,
                Enabled = false
            };
            requestAcceptButton.Click += (sender, e) => RequestAcceptButton_Click(requestID);
            // 
            // requestRejectButton
            // 
            Button requestRejectButton = new()
            {
                BackColor = Color.LightCoral,
                FlatAppearance =
                {
                    BorderColor = Color.White,
                    MouseDownBackColor = Color.Red,
                    MouseOverBackColor = Color.Red
                },
                FlatStyle = FlatStyle.Flat,
                Location = new Point(84, 3),
                Name = "requestRejectButton",
                Size = new Size(75, 32),
                TabIndex = 4,
                Text = "Reject",
                UseVisualStyleBackColor = false,
                Enabled = false
            };
            requestRejectButton.Click += (sender, e) => RejectButton_Click(requestID);
            // 
            // panel6
            // 
            Panel panel6 = new()
            {
                Dock = DockStyle.Fill,
                Location = new Point(686, 30),
                Name = "panel6",
                Size = new Size(300, 50),
                TabIndex = 12
            };
            panel6.Controls.Add(requestRejectButton);
            panel6.Controls.Add(requestAcceptButton);

            subjectRequestsTableLayoutPanel.Controls.Add(panel6, 6, row);
        }

        private static void RequestAcceptButton_Click(string requestID)
        {
            MessageBox.Show($"The request {requestID} has been accepted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void RejectButton_Click(string requestID)
        {
            MessageBox.Show($"The request {requestID} has been rejected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            loginForm.ResetLoginForm();
            loginForm.Show();
            Close();
        }
    }
}
