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
        private string firstName, lastName;
        public StudentForm(LoginForm loginForm, string[] studentDetails)
        {
            this.loginForm = loginForm;
            firstName = studentDetails[2];
            lastName = studentDetails[3];
            InitializeComponent();
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
        }

        private void addSubjectAndActivitiesButton_Click(object sender, EventArgs e)
        {
            studentTabControl.SelectedTab = studentTabControl.TabPages["subjectAllocation"];
        }

        private void removeFromASubjectButton_Click(object sender, EventArgs e)
        {
            studentTabControl.SelectedTab = studentTabControl.TabPages["viewTimetable"];
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                //connect to allocate button
            }
            else
            {
                //do nothing
            }
        }

        private void activityTypeComboxBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] enrolments = Directory.GetFiles("Enrolment");
            activityTypeComboxBox.Items.Clear();
            foreach (string enrolment in enrolments)
            {
                string[] data = File.ReadAllLines(enrolment);
                activityTypeComboxBox.Items.Add($"{data[0].Split(':')[0]} - {data[0].Split(':')[1]}");
            }
        }


        /*
private void StudenForm_Load(object sender, EventArgs e)
{
welcomeLabel.Text = $"Welcome back, {firstName} {lastName}!";

subjectsListBox.Items.Clear();
string[] subjects = Directory.GetFiles("Subjects");
foreach (string subject in subjects)
{
string[] data = File.ReadAllLines(subject);
subjectsListBox.Items.Add($"{data[0].Split(':')[0]} - {data[0].Split(':')[1]}");
}
}*/
    }
}
