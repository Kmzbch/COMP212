using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows;
using Example4Week7_001.BookLibrary;
using System.Linq;

namespace DisplayBooks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BooksEntities db = new BooksEntities();

        public MainWindow()
        {
            InitializeComponent();

            db.Titles.Load();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource titleViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("titleViewSource")));
            // Load data by setting the CollectionViewSource.Source property:           
            // titleViewSource.Source = [generic data source]

            titleDataGrid.ItemsSource = db.Titles.Local;

            titleCbox.ItemsSource = (from author in db.Authors
                                    select author.FirstName + " " + author.LastName).ToList();
        }

        private void TitleCbox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            //switch (titleCbox.SelectedIndex)
            //{

            //    case 0:
            //        titleDataGrid.ItemsSource = (from book in db.Titles 
            //                                    where book.Title1.EndsWith("How to Program")
            //                                    select book).ToList();
            //        break;
            //    case 1:
            //        titleDataGrid.ItemsSource = (from book in db.Titles where book.Copyright == "2014"
            //                                    select book).ToList();
            //        break;
            //    default:
            //        break;
            //}

            string[] names = titleCbox.SelectedValue.ToString().Split();
            string firstName = names[0];
            string lastName = names[1];

            titleDataGrid.ItemsSource = (from book in db.Titles
                                         from author in book.Authors
                                         where author.FirstName == firstName &&
                                         author.LastName == lastName
                                         select new { book.Title1, book.Copyright, book.EditionNumber, book.ISBN}).ToList();

        }
    }
}
