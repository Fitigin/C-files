using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Wpf2
{
    public class CoinModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SolidColorBrush Color { get; set; }
    }

    /*public class CoinData
    {
        public List<CoinModel> Coin()
        {
            return new List<CoinModel>
            {
                new CoinModel { Color = new SolidColorBrush(Colors.Red), Id = 1, Name = "BitCoin" },
                new CoinModel { Color = new SolidColorBrush(Colors.Blue), Id = 2, Name = "LiteCoin" },
                new CoinModel { Color = new SolidColorBrush(Colors.Green), Id = 3, Name = "Solana" }
            };
        }
    }
    public class CoinModel
    {
        public int _id;
        public string _name;
        public SolidColorBrush _color;
        public CoinModel(int id, string name, SolidColorBrush color)
        {
            _id = id;
            _name = name;
            _color = color;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public SolidColorBrush Color
        {
            get { return _color; }
            set { _color = value; }
        }
    }

    public class CoinData : ObservableCollection<CoinModel>
    {
        public CoinData()
        {
            Add(new CoinModel(1, "Bitcoin", new SolidColorBrush(Colors.Red)));
            Add(new CoinModel(2, "Litecoin", new SolidColorBrush(Colors.Blue)));
            Add(new CoinModel(3, "Dogecoin", new SolidColorBrush(Colors.Orange)));
        }
    }*/
}
