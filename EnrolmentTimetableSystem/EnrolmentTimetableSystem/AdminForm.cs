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
        public AdminForm()
        {
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
    }
}
