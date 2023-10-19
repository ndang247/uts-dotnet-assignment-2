namespace EnrolmentTimetableSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Id_TextChanged(object sender, EventArgs e)
        {
            // Enter ID

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            // Enter Password

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string enteredID = id.Text;
            string enteredPassword = password.Text;

            try
            {
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

        private static void CheckCredentials(string id, string password, string role, string file)
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

                        break;
                    case "Admin":
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
    }
}