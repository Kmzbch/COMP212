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

namespace DatabindingWithComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> students = new List<Person>();

        public MainWindow()
        {

            InitializeComponent();

            students.Add(new Person { FirstName = "Alice", LastName = "Aligator" });
            students.Add(new Person { FirstName = "Bob", LastName = "Bobinson" });


            //foreach (Person p in students)
            //{
            //    myComboBox.Items.Add(p.FullName);
            //}
            myComboBox.ItemsSource = students;
        }
    }
}
