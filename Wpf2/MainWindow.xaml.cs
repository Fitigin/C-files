using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
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

namespace Wpf2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _searchText;

        public string SearchText
        {
            get { return _searchText; }
            set 
            {
                _searchText = value;

                OnPropertyChanged("SearchText");
                OnPropertyChanged("FilteredCoins");
            }
        }

        public List<string> CoinList { get; set; }

        public IEnumerable<string> FilteredCoins
        {
            get
            {
                if (SearchText == null) return CoinList;

                return CoinList.Where(x => x.ToUpper().StartsWith(SearchText.ToUpper()));
            }
        }
        
        public MainWindow()
        {
            InitializeComponent();
            listBox1.ItemsSource = CoinViewModel.Coins;

            CoinList = CoinViewModel.names;
            this.DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
