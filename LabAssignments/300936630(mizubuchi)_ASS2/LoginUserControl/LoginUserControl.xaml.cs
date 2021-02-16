using System.Security;
using System.Windows;
using System.Windows.Controls;

namespace LoginUserControl
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return (string)GetValue(usernameProperty); }
            private set { SetValue(usernameProperty, value); }
        }

        public readonly static DependencyProperty usernameProperty =
            DependencyProperty.Register(
                nameof(Username), 
                typeof(string), 
                typeof(LoginUserControl), 
                new PropertyMetadata(""));

        public SecureString Password
        {
            get { return (SecureString)GetValue(passwordProperty); }
            private set { SetValue(passwordProperty, value); }
        }

        //password dependency property
        public readonly static DependencyProperty passwordProperty =
            DependencyProperty.Register(
                nameof(Password), 
                typeof(SecureString),
                typeof(LoginUserControl),
                new PropertyMetadata(default(SecureString)));

        private void tbxPassword_PasswordChanged(object sender, RoutedEventArgs e) 
            => Password = _stringToSecureString(tbxPassword.Password);
        public void ClearUsername() => tbxUserName.Text = "";
        public void ClearPassword() => tbxPassword.Password = "";

        private static SecureString _stringToSecureString(string password)
        {
            if (password == null) return null;

            SecureString secureString = new SecureString();
            foreach (char c in password.ToCharArray())
            {
                secureString.AppendChar(c);
            }
            return secureString;
        }

    }
}
