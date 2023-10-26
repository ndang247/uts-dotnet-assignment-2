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

        private void ViewSubjectRequestsButton_Click(object sender, EventArgs e)
        {
            adminTabControl.SelectedTab = viewSubjectRequestsPage;
            LoadRequestsComboBox();
        }

        private void AddSubjectAndActivitiesButton_Click(object sender, EventArgs e)
        {
            adminTabControl.SelectedTab = addASubjectAndActivitiesPage;
        }

        private void RemoveFromASubjectButton_Click(object sender, EventArgs e)
        {
            adminTabControl.SelectedTab = removeFromASubjectPage;
            LoadSubjectsListBox();
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
            string data = $"{activityCode}" +
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
                    if (activityData[1] == $"{activityTypeComboxBox.SelectedItem}" &&
                        activityData[2] == $"{activityDateTimePicker.Value:t}" &&
                        activityData[3] == $"{activityCampusTextBox.Text}" &&
                        activityData[4] == $"{activityLocationTextBox.Text}" &&
                        activityData[5] == $"{activityDayComboBox.SelectedItem}" &&
                        activityData[6] == $"{activityDescriptionTextBox.Text}" &&
                        activityData[7] == $"{activityStartDateTimePicker.Value:d}" &&
                        activityData[8] == $"{activityEndDateTimePicker.Value:d}" &&
                        activityData[9] == $"{activityDurationNumericUpDown.Value}")
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

            LoadSubjectsListBox();
            LoadRequestsComboBox();
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

                    // Teacher details
                    string teacher = File.ReadAllText($"Teachers\\{requestData[1]}.txt");
                    string[] teacherData = teacher.Split(':');
                    //

                    requestsComboBox.Items.Add($"{requestData[0]} - {teacherData[0]}");
                }
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            loginForm.ResetLoginForm();
            loginForm.Show();
            Close();
        }

        private void requestsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
