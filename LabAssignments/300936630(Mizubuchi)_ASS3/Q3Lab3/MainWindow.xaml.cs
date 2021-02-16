using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows;

//Question3 [12 marks]

// [GUI: 1 mark; Create Entity Data model: 1 mark]

//Create a Windows Form App to manipulate the data within Books database and displays the results of the following queries: 

namespace Q3Lab3
{

    public partial class MainWindow : Window
    {
        BooksEntities ds = new BooksEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        // 1. Get a list of all the titles and the authors who wrote them.
        // Sort the results by title. [2 marks]
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //query:
            //select titles.Title, Authors.FirstName, Authors.LastName from titles, AuthorISBN, authors
            //where titles.ISBN = AuthorISBN.ISBN and AuthorISBN.AuthorID = Authors.AuthorID
            //order by titles.Title;

            dataGrid.ItemsSource = (from title in ds.Titles
                                    from author in ds.Authors
                                    where author.Titles.Contains(title)
                                    orderby title.Title1
                                    select new { title.Title1, author.FirstName, author.LastName }).ToList();

        }


        // 2. Get a list of all the titles and the authors who wrote them.
        // Sort the results by title. Each title sort the authors 
        // alphabetically by last name, then first name[4 marks]
        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            dataGrid.ItemsSource = (from title in ds.Titles
                                    from author in ds.Authors
                                    where author.Titles.Contains(title)
                                    orderby title.Title1, author.LastName, author.FirstName
                                    select new { title.Title1, author.FirstName, author.LastName }).ToList();

        }

        // 3.	 Get a list of all the authors grouped by title, sorted by title;
        // for a given title sort the author names alphabetically
        // by last name then first name.[4 marks]
        private void Button3_Click(object sender, RoutedEventArgs e)
        {

            var x = (from title in ds.Titles
                     from author in ds.Authors
                     orderby title.Title1
                     group author by title into t
                     select new
                     {
                         CoAuthors = (from a in t.Key.Authors
                                      orderby a.LastName, a.FirstName
                                      select a.LastName + ", " + a.FirstName),

                         Title = t.Key.Title1
                     }).ToList();

            // workaround for concatenation of Authorsname
            List<Object> itemSource = new List<Object>();

            foreach(var y in x)
            {
                itemSource.Add(new { coAuthors = string.Join(" - ", y.CoAuthors), y.Title });
            }
            
            dataGrid.ItemsSource = itemSource;

        }

    }




}
