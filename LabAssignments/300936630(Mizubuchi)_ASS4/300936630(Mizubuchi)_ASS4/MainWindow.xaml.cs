using System;
using System.Linq;
using System.Windows;

namespace _300936630_Mizubuchi__ASS4
{
    /// <summary>
    /// Question 1 										[5 marks]
    /// Write a generic method, Search[int Search<T>(T[ ] values ] that searches 
    /// an array using linear search algorithm.Method Search should compare the search key with each element
    /// in its array parameter until the search key is found or until the end of the array is searched.
    /// If the search key is found, return its location in the array; otherwise return -1. 
    /// Write a WPF app that inputs and searches an int array and a double array.Provide buttons that the user can click 
    /// to randomly generate int and double values (at least 10 values). 
    /// 
    /// Display the generated values so that the user knows what values he/she can search for.
    /// 
    /// [Hint: use (T: IComparable<t>) in the where clause for method Search so that you can use method CompareTo()
    /// to compare the search key to the elements in the array]
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        // fixed-size arrays
        int[] intArray = new int[10];
        double[] doubleArray = new double[10];

        public MainWindow()
        {
            InitializeComponent();
        }

        // linear search algorithm
        private int Search<T>(T[] values, T searchKey) where T : IComparable<T>
        {

            Func<T[], T, int, bool> hasSearchItem = (array, key, index) => {
                return array[index].CompareTo(key) == 0;
            };
            //alternative:
            //bool hasSearchItem(T[] array, T key, int index)
            //{
            //    return array[index].CompareTo(key) == 0;
            //}

            for (int i = 0; i < values.Length; i++)
            {
                if (hasSearchItem(values, searchKey, i)) return i;
            }

            return -1;

        }
        
        // generate and set arrays
        private void GenerateRandomArrays()
        {
            Random rnd = new Random();

            for (int i = 0; i < intArray.Length; i++) { intArray[i] = rnd.Next(0, 100); };
            for (int i = 0; i < doubleArray.Length; i++) { doubleArray[i] = Math.Round(rnd.NextDouble() * 100, 2); };

        }

        // button events
        private void BtnGenerateArray_Click(object sender, RoutedEventArgs e)
        {
            GenerateRandomArrays();

            tbxIntArray.Text = String.Join(", ", intArray.Select(x => x.ToString()).ToArray());
            tbxDoubleArray.Text = String.Join(", ", doubleArray.Select(x => x.ToString()).ToArray());
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rdbSearchInt.IsChecked)
            {
                int.TryParse(tbxSearchBy.Text, out int searchBy);
                MessageBox.Show($"{searchBy} is found at [{Search(intArray, searchBy)}]");
            }
            else
            {
                double.TryParse(tbxSearchBy.Text, out double searchBy);
                MessageBox.Show($"{searchBy} is found at [{Search(doubleArray, searchBy)}]");
            }

        }
        
    }
}
