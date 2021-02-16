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

namespace Kei_Mizubuchi_Sec001_Ex02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] intArray = new int[10];
        double[] doubleArray = new double[10];

        public MainWindow()
        {
            InitializeComponent();

        }

        // button events
        private void BtnGenerateIntArray_Click(object sender, RoutedEventArgs e)
        {
            GenerateRandomIntArrays();

            tbxIntArray.Text = String.Join(", ", intArray.Select(x => x.ToString()).ToArray());
        }

        // button events
        private void BtnGenerateDoubleArray_Click(object sender, RoutedEventArgs e)
        {
            GenerateRandomDoubleArrays();

            tbxDoubleArray.Text = String.Join(", ", doubleArray.Select(x => x.ToString()).ToArray());
        }

        // generate and set arrays
        private void GenerateRandomIntArrays()
        {
            Random rnd = new Random();

            for (int i = 0; i < intArray.Length; i++) {
                intArray[i] = rnd.Next(50, 100) ;
            };
        }

        // generate and set arrays
        private void GenerateRandomDoubleArrays()
        {
            Random rnd = new Random();

            for (int i = 0; i < doubleArray.Length; i++)
            {
                doubleArray[i] = Math.Round(50 + (100 - 50) * rnd.NextDouble(), 2);
            };
        }


        private void BtnFindLargest_Click(object sender, RoutedEventArgs e)
        {
            int startIndex = int.Parse(txtStartIndex.Text);
            int endIndex = int.Parse(txtEndIndex.Text);
            MessageBox.Show($"The largest int number is {MaxSubArrayElement(intArray, startIndex, endIndex).ToString()}");
            MessageBox.Show($"The largest double number is {MaxSubArrayElement(doubleArray, startIndex, endIndex).ToString()}");
        }

        private void BtnFindLargestInt_Click(object sender, RoutedEventArgs e)
        {
            int startIndex = int.Parse(txtStartIndex.Text);
            int endIndex = int.Parse(txtEndIndex.Text);
            MessageBox.Show($"The largest int number is {MaxSubArrayElement(intArray, startIndex, endIndex).ToString()}");
        }

        // solution
        private T MaxSubArrayElement<T>(T[] inputArray, int startIndex, int endIndex) where T : IComparable<T>
        {
            T max = default(T);

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (inputArray[i].CompareTo(max) > 0)
                    max = inputArray[i];
            }

            return max;
        }

        //// solution
        //private T MaxSubArrayElement<T>(T[] inputArray, int startIndex, int endIndex) where T : IComparable<T>
        //{
        //    T max = default(T);

        //    //for (int i = 0; i < inputArray.Length; i++)
        //    //{
        //    //    if (i < startIndex || i > endIndex)
        //    //        continue;
        //    //    if (inputArray[i].CompareTo(max) > 0)
        //    //        max = inputArray[i];
        //    //}

        //    for (int i = startIndex; i <= endIndex; i++)
        //    {
        //        if (inputArray[i].CompareTo(max) > 0)
        //            max = inputArray[i];
        //    }

        //    return max;
        //}

    }
}
