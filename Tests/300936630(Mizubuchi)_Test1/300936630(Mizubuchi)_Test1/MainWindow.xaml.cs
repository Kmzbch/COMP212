using System.Collections.Generic;
using System.Windows;
using System.Linq;

namespace _300936630_Mizubuchi__Test1
{
    public partial class MainWindow : Window
    {

        private AMSEntities db = new AMSEntities();

        public MainWindow()
        {
            InitializeComponent();         
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            // invalid username
            if (false)
            {
                string msg = "Invalid username! Please enter the username again";
                MessageBox.Show(msg);
            }
            else
            {
                string username = loginUserControl.Username;
                string password = new System.Net.NetworkCredential(string.Empty, loginUserControl.Password).Password;
                List<Login> x = (from login in db.Logins select login).ToList();
//                List<Login> x = db.Logins.ToList();



                //string msg;

                //// invalid password
                //if (!passwordClient.Equals(password))
                //{
                //    msg = "Invalid password! Please enter the password again.";
                //}
                //else
                //{
                //    msg = "You are successfully logged in with the information below:\n" +
                //        $"User Name: {cli.Username}\n" + $"Password: {passwordClient}";
                //}

                //MessageBox.Show(msg);

            }

            //show MakePaymentWindow
            MakePaymentWindow makePaymentWindow = new MakePaymentWindow();
            makePaymentWindow.Show();
                       
        }
    }

}
