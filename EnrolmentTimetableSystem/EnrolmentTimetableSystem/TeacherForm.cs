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
    public partial class TeacherForm : Form
    {
        private readonly LoginForm loginForm;
        private string id, firstName, lastName;

        public TeacherForm(LoginForm loginForm, string[] teacherDetails)
        {
            this.loginForm = loginForm;
            id = teacherDetails[0];
            firstName = teacherDetails[2];
            lastName = teacherDetails[3];
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            loginForm.ResetLoginForm();
            loginForm.Show();
            Close();
        }

        private void SubjectRequestButton_Click(object sender, EventArgs e)
        {
            teacherTabControl.SelectedTab = subjectRequestPage;
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = $"Welcome back, {firstName} {lastName}!";

            requestSubjectsComboBox.Items.Clear();
            string[] subjects = Directory.GetFiles("Subjects");
            foreach (string subject in subjects)
            {
                string[] s = File.ReadAllLines(subject);
                requestSubjectsComboBox.Items.Add($"{s[0].Split(':')[0]} - {s[0].Split(':')[1]}");
            }

            if (File.Exists($"Requests\\{id}.txt"))
            {
                string[] requests = File.ReadAllLines($"Requests\\{id}.txt");
                foreach (string request in requests)
                {
                    string requestID = request.Split(':')[0];
                    string tID = request.Split(':')[1];
                    string subject = request.Split(':')[2];
                    string message = request.Split(':')[3];
                    string status = request.Split(':')[4];
                    string reason = request.Split(':')[5];

                    AddNewRow(requestID, tID, subject, message, status, reason);
                }
            }
        }

        private void OnFormChange(object sender, EventArgs e)
        {
            // Check subjectsComboBox is selected and Message is not empty
            if (!string.IsNullOrEmpty($"{requestSubjectsComboBox.SelectedItem}") && !string.IsNullOrEmpty(requestMessageRichTextBox.Text))
            {
                requestSubmitButton.Enabled = true;
            }
            else
            {
                requestSubmitButton.Enabled = false;
            }
        }

        private void RequestSubmitButton_Click(object sender, EventArgs e)
        {
            // Random generate 5 digits request ID
            Random random = new();
            int requestID = random.Next(10000, 99999);

            string data = $"{requestID}:{id}:{requestSubjectsComboBox.SelectedItem}:{requestMessageRichTextBox.Text}:Awaiting for approval:";

            // Check if the teacher already requested a subject previously
            if (File.Exists($"Requests\\{id}.txt"))
            {
                // Check if the teacher already requested the same subject
                string[] requests = File.ReadAllLines($"Requests\\{id}.txt");
                foreach (string request in requests)
                {
                    string subject = request.Split(':')[2];
                    string status = request.Split(':')[4];
                    if (subject == $"{requestSubjectsComboBox.SelectedItem}" && status == "Awaiting for approval")
                    {
                        MessageBox.Show("You already requested this subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Append the request to the teacher's request file
                File.AppendAllText($"Requests\\{id}.txt", $"\n{data}");
            }
            else
            {
                // Create a new request file
                File.WriteAllText($"Requests\\{id}.txt", data);
                MessageBox.Show($"Your request has been sent to the admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            AddNewRow(requestID.ToString(), id, $"{requestSubjectsComboBox.SelectedItem}", requestMessageRichTextBox.Text, "Awaiting for approval", "");
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

        private void SubjectAllocationButton_Click(object sender, EventArgs e)
        {
            teacherTabControl.SelectedTab = subjectAllocationPage;
        }

        private void ViewActivitiesButton_Click(object sender, EventArgs e)
        {
            teacherTabControl.SelectedTab = viewActivitiesPage;
        }
    }
}
