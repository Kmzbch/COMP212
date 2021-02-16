using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using _300936630_mizubuchi__ASS2.Data;

namespace _300936630_mizubuchi__ASS2
{
    public partial class MainWindow : Window
    {
        private FoodItemService ds = new FoodItemService();
        private ObservableCollection<FoodItem> order = new ObservableCollection<FoodItem>();

        decimal subTotal = 0;
        decimal tax = 0;
        decimal total = 0;
        const decimal TAX_RATE = 0.13M;

        public MainWindow()
        {
            InitializeComponent();

            _initItemSources();
            _initEventListeners();

        }

        //set from data sources
        private void _initItemSources()
        {
            cbxBeverage.ItemsSource = ds.GetAll().Where(x => x.Category == "Beverage");
            cbxAppetizer.ItemsSource = ds.GetAll().Where(x => x.Category == "Appetizer");
            cbxMainCourse.ItemsSource = ds.GetAll().Where(x => x.Category == "Main Course");
            cbxDessert.ItemsSource = ds.GetAll().Where(x => x.Category == "Dessert");

            dgOrderList.ItemsSource = order;
        }


        private void _initEventListeners()
        {
            cbxBeverage.SelectionChanged += _addItemFromComboBox;
            cbxAppetizer.SelectionChanged += _addItemFromComboBox;
            cbxMainCourse.SelectionChanged += _addItemFromComboBox;
            cbxDessert.SelectionChanged += _addItemFromComboBox;

            dgOrderList.CellEditEnding += (s, e) => _updateBill();

            // button events
            btnRemoveOrderedItem.Click += _removeOrderedItem;
            btnClearAll.Click += _clearAll;
            btnImage.Click += (s, e) => { Process.Start("http://www.centennialcollege.ca"); };
            btnExit.Click += (s, e) => { this.Close(); };

        }

        private void _addItemFromComboBox(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            FoodItem selection = (FoodItem)cbx.SelectedItem;

            if (selection != null)
            {
                if (order.Contains(selection))
                    selection.Quantity++;
                else
                    order.Add(selection);
                cbx.SelectedItem = null;
                _updateBill();
            }
        }

        private void _removeOrderedItem(object sender, RoutedEventArgs e)
        {
            int selectedIndex = dgOrderList.SelectedIndex;

            if (selectedIndex == -1)
                MessageBox.Show("Select a food item in the list");
            else
            {
                order.ElementAt(selectedIndex).Quantity = 1;
                order.RemoveAt(selectedIndex);
                _updateBill();
            }
        }

        private void _clearAll(object sender, RoutedEventArgs e)
        {
            if (order.Count == 0)
                MessageBox.Show("No items in the list");
            else
            {
                order.AsEnumerable().Select(x => x.Quantity = 1).ToList();
                order.Clear();
                _updateBill();
            }
        }

        // update
        private void _updateBill()
        {
            subTotal = order.AsEnumerable().Aggregate(0, (decimal total, FoodItem next) => {
                return total += next.Quantity * next.Price;
            });
            tax = subTotal * TAX_RATE;
            total = subTotal + tax;

            //set values
            txtSubTotal.Text = string.Format("{0:C2}", subTotal);
            txtTax.Text = string.Format("{0:C2}", tax);
            txtTotal.Text = string.Format("{0:C2}", total);

        }


    }
}
