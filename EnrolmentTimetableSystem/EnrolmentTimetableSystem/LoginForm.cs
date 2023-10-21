namespace EnrolmentTimetableSystem
{
    public partial class LoginForm : Form
    {
        private string enteredID = "", enteredPassword = "";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Id_TextChanged(object sender, EventArgs e)
        {
            enteredID = id.Text;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            enteredPassword = password.Text;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(enteredID);
                string file = $"{enteredID}.txt";

                // Check if the file exists in three role directories
                if (File.Exists($"Students\\{file}"))
                {
                    CheckCredentials(enteredID, enteredPassword, "Students", file);
                }
                else if (File.Exists($"Teachers\\{file}"))
                {
                    CheckCredentials(enteredID, enteredPassword, "Teachers", file);
                }
                else if (File.Exists($"Admin\\{file}"))
                {
                    CheckCredentials(enteredID, enteredPassword, "Admin", file);
                }
                else
                {
                    throw new Exception("Invalid ID or account user doesn't exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckCredentials(string id, string password, string role, string file)
        {
            // Read the file
            string[] lines = File.ReadAllLines($"{role}\\{file}");
            string[] details = lines[0].Split(':');

            // Check if the id and password is correct
            if (id == details[0] && password == details[1])
            {
                switch (role)
                {
                    case "Students":

                        break;
                    case "Teachers":
						Hide();
						new TeacherForm().Show();
						break;
						break;
                    case "Admin":
                        Hide();
                        AdminForm adminForm = new(this);
                        adminForm.Show();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                throw new Exception("\nInvalid password");
            }
        }

        public void ResetLoginForm()
        {
            id.Text = "";
            password.Text = "";
        }
    }
}