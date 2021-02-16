using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace _300936630_Mizubuchi__Test1
{

    public partial class MakePaymentWindow : Window
    {
        private AMSEntities db = new AMSEntities();
        private ObservableCollection<Account> accountlist = new ObservableCollection<Account>();

        public MakePaymentWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource titleViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("titleViewSource")));
            // Load data by setting the CollectionViewSource.Source property:           
            // titleViewSource.Source = [generic data source]

            accountlist = db.Accounts.Local;
            dgAccountList.ItemsSource = accountlist;

            //accountCbox.ItemsSource = (from account in db.Accounts
            //                         select account.Account + " " + author.LastName).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal amount = Decimal.Parse(tbxAmount.Text);
            //
            decimal balance = 0;

            if (amount > balance)
            {
                MessageBox.Show("Not enough fund to make the payment!");
            } else
            {

            }
        }

        private void DgAccountList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
