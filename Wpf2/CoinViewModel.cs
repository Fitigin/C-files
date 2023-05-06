using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2
{
    public class CoinViewModel
    {
        public ObservableCollection<CoinModel> DataSource { get; set; }

        public CoinViewModel() 
        {
            //var dta = new CoinData().GenerateCoin();
           // DataSource = new ObservableCollection<CoinModel>(dta);
        }
    }
}
