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
        public string Index { get; set; }
    }
}
