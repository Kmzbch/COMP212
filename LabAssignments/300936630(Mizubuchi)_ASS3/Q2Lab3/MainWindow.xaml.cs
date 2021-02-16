using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// Question2 [4 marks]
// [GUI 1 mark;  Create Entity Data model: 1 mark; Business logic: 2 marks] 

// Build WPF app to execute a query against the Players table of the Baseball database.
// Display the result in a DataGrid, and add a TextBox and Button to allow 
// the user to search for a specific player by last name.
// Use a Label to identify the TextBox. 
// Clicking the Button should execute the appropriate query. 
// Also, provide a Button that enables the user to return to browsing 
// the complete set of players.

namespace Q2Lab3
{
    public partial class MainWindow : Window
    {
        BaseballEntities ds = new BaseballEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgPlayerList.ItemsSource = ds.Players.ToList();
        }

        private void BtnRunQuery_Click(object sender, RoutedEventArgs e)
        {
            dgPlayerList.ItemsSource = ds.Players.Where(
                x => x.LastName== tbxPlayerName.Text).ToList();            
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            dgPlayerList.ItemsSource = ds.Players.ToList();
        }
    }
}
