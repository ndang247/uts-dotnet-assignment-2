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

        public TeacherForm(LoginForm loginForm, string[] details)
        {
            this.loginForm = loginForm;
            InitializeComponent();
        }

        private void viewSubjectRequestsButton_Click(object sender, EventArgs e)
        {
            teacherTabControl.SelectedTab = teacherTabControl.TabPages["subjectRequest"];
        }

        private void addSubjectAndActivitiesButton_Click(object sender, EventArgs e)
        {
            teacherTabControl.SelectedTab = teacherTabControl.TabPages["subjectAllocation"];
        }

        private void removeFromASubjectButton_Click(object sender, EventArgs e)
        {
            teacherTabControl.SelectedTab = teacherTabControl.TabPages["viewActivities"];
        }

        //Need to check if this actually logs the user out
        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginForm.ResetLoginForm();
            loginForm.Show();
            Close();
        }
    }
}
