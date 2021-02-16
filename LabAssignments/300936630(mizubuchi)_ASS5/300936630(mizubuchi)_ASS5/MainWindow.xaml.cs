using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace _300936630_mizubuchi__ASS5
{
    public partial class MainWindow : Window
    {
        const string DATAFILE = "stockData.tsv";
        List<StockData> stockDataCollection = new List<StockData>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void BtnStartLoading_Click(object sender, RoutedEventArgs e)
        {

            //// async task
            //Task<List<StockData>> loadTask = Task.Run(() =>
            //{
            //    float percentage = 100F / File.ReadAllLines(DATAFILE).Where(x => !x.Contains('(')).Count();

            //    List<StockData> result = File.ReadAllLines(DATAFILE).Where(x => !x.Contains('('))
            //                .Select(x =>
            //                {
            //                    Thread.Sleep(1);
            //                    Dispatcher.BeginInvoke(new ThreadStart(() =>
            //                    {
            //                        // update progress bar
            //                        // update progress bar
            //                        progressBar.Value += percentage;
            //                        lblPercentage.Content = $"{progressBar.Value / 100:P0}";
            //                    }));


            //                    // create object from a line
            //                    string[] columns = x.Split('\t');
            //                    return new StockData
            //                    {
            //                        Symbol = columns[0].Trim('"', ' '),
            //                        Date = columns[1].Trim('"', ' '),
            //                        Open = columns[2].Trim('"', ' '),
            //                        High = columns[3].Trim('"', ' '),
            //                        Low = columns[4].Trim('"', ' '),
            //                        Close = columns[5].Trim('"', ' ')
            //                    };

            //                })
            //                // operate on stockdata collection
            //                .Skip(1).OrderBy(x => x.Date).ToList();
            //    return result;
            //});

            Task<List<StockData>> loadTask = Task.Run(() =>
            {


                List<StockData> result = new List<StockData>();
                string[] lines = File.ReadAllLines(DATAFILE);

                float percentage = 100F / lines.Count();

                foreach (string line in lines)
                {
                    Thread.Sleep(1);
                    Dispatcher.BeginInvoke(new ThreadStart(() =>
                    {
                        // update progress bar
                        progressBar.Value += percentage;
                        lblPercentage.Content = $"{progressBar.Value / 100:P0}";
                    }));

                    if (!line.Contains('('))
                    {

                        // create object from a line
                        string[] columns = line.Split('\t');
                        result.Add(new StockData
                        {
                            Symbol = columns[0].Trim('"', ' '),
                            Date = columns[1].Trim('"', ' '),
                            Open = columns[2].Trim('"', ' '),
                            High = columns[3].Trim('"', ' '),
                            Low = columns[4].Trim('"', ' '),
                            Close = columns[5].Trim('"', ' ')
                        });
                    }
                }

                return result;
            });

            stockDataCollection = await loadTask;


            dgStockData.ItemsSource = stockDataCollection;

            // enable/disable after loading
            tbxSearchKey.IsEnabled = true;
            btnSearch.IsEnabled = true;
            btnStartLoading.IsEnabled = false;
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            // search by key
            dgStockData.ItemsSource = stockDataCollection.Where(
                                x => x.Symbol.Contains(tbxSearchKey.Text)).ToList();
        }

        private async void BtnRollDie_Click(object sender, RoutedEventArgs e)
        {
            if (tbxFrequency.Text == String.Empty)
                tbxFrequency.Text = "300000000";

            tBlockResult.Text = "Rolling the die ...";

            int number = int.Parse(tbxFrequency.Text);

            Task<long[]> rollDieTask = Task.Run(() => RollDie(number));
            await rollDieTask;

            long[] frequencies = rollDieTask.Result;

            tBlockResult.Text = "Face\tFrequency";
            tBlockResult.Text =
            $"1\t{frequencies[0]}\n2\t{frequencies[1]}\n3\t{frequencies[2]}\n4\t{frequencies[3]}\n5\t{frequencies[4]}\n6\t{frequencies[5]}";

        }

        public long[] RollDie(int number = 300000000)
        {
            long[] frequencies = new long[6];
            Random randomNumbers = new Random();
            int face;

            for (int roll = 1; roll <= number; ++roll)
            {
                face = randomNumbers.Next(1, 7); // number from 1 to 6
                frequencies[face - 1]++;
            }

            return frequencies;
        }
    }
}
