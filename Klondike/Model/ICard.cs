using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klondike.Model
{
    interface ICard
    {
        Suit Suit { get; set; }
        int CardValue { get; set; }
        string DisplayValue { get; }
    }
}
