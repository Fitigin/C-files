using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Wpf2
{
    public class CoinViewModel
    {
        public static List<CoinModel> Coins = new List<CoinModel>
        {
            new CoinModel { Color = new SolidColorBrush(Colors.Red), Id = 1, Name = "BitCoin" },
            new CoinModel { Color = new SolidColorBrush(Colors.Blue), Id = 2, Name = "LiteCoin" },
            new CoinModel { Color = new SolidColorBrush(Colors.Green), Id = 3, Name = "Solana" },
            new CoinModel { Color = new SolidColorBrush(Colors.Cyan), Id = 4, Name = "DogeCoin" },
            new CoinModel { Color = new SolidColorBrush (Colors.Magenta), Id =5, Name = "Etherium", Index= "ETH"}
        };

        public static List<string> names = Coins.Select(c => c.Name).ToList();
    }
}
