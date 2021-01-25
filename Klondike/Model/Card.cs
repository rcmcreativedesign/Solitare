using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klondike.Model
{
    public class Card : ICard
    {
        public Suit Suit { get; set; }
        public int CardValue { get; set; }
        public string DisplayValue => CardValue.ToString();
    }
}
