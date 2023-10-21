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
        public AdminForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
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
            subjectsListBox.Items.Clear();
            string[] subjects = Directory.GetFiles("Subjects");
            foreach (string subject in subjects)
            {
                string[] data = File.ReadAllLines(subject);
                subjectsListBox.Items.Add($"{data[0].Split(':')[0]} - {data[0].Split(':')[1]}");
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            loginForm.ResetLoginForm();
            loginForm.Show();
            Close();
        }
    }
}
