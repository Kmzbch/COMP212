using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _300936630_mizubuchi__ASS2
{
    public class FoodItem : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        private uint _quantity = 1;

        public uint Quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged("Quantity");
                }
            }
        }

        //INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}







//namespace _300936630_mizubuchi__ASS2
//{
//    public class FoodItem : Base4Model
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Category { get; set; }
//        public decimal Price { get; set; }
//        private uint _quantity = 1;

//        public uint Quantity
//        {
//            get { return _quantity; }
//            set
//            {
//                if (_quantity != value)
//                {
//                    _quantity = value;
//                    OnPropertyChanged("Quantity");
//                }
//            }
//        }

//    }
//}




