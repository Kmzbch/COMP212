using System.Collections.Generic;

using System.Security;
using System.Windows;

namespace Question2_v2
{
    public partial class MainWindow : Window
    {
        //variables
        private string msg;
        private List<Client> client = new List<Client>();

        public MainWindow()
        {
            InitializeComponent();
            InitDataSource();
        }

        private void InitDataSource()
        {
            //add users
            client.Add(new Client()
            {
                Username = "300936630",
                Password = StringToSecureString("keimizubuchi")
            });

            client.Add(new Client()
            {
                Username = "300000001",
                Password = StringToSecureString("student1")
            });

            client.Add(new Client()
            {
                Username = "300000002",
                Password = StringToSecureString("student2")
            });
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Client cli = client.Find(x => x.Username.Equals(loginUserControl.Username));

            // invalid username
            if (cli == null)
            {
                msg = "Invalid username! Please enter the username again";

                // reset textbox and passwordbox
                loginUserControl.ClearUsername();
                loginUserControl.ClearPassword();

                MessageBox.Show(msg);
            }
            else
            {
                // find entered password
                string password = new System.Net.NetworkCredential(string.Empty, loginUserControl.Password).Password;

                // find password from client
                string passwordClient = new System.Net.NetworkCredential(string.Empty, cli.Password).Password;            

                // invalid password
                if (!passwordClient.Equals(password))
                {
                    msg = "Invalid password! Please enter the password again.";

                    // reset textbox and passwordbox
                    loginUserControl.ClearPassword();

                }
                else
                {
                    msg = "You are successfully logged in with the information below:\n" +
                        $"User Name: {cli.Username}\n" + $"Password: {passwordClient}";

                    // reset textbox and passwordbox
                    loginUserControl.ClearUsername();
                    loginUserControl.ClearPassword();

                }

                MessageBox.Show(msg);

            }

        }

        private static SecureString StringToSecureString(string password)
        {
            if (password == null) return null;

            SecureString secureString = new SecureString();
            foreach (char c in password.ToCharArray())
            {
                secureString.AppendChar(c);
            }
            return secureString;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
