using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klondike.Model
{
    public class FaceCard : ICard
    {
        public Suit Suit { get; set; }
        public int CardValue { get; set; }
        public string DisplayValue 
        { 
            get 
            {
                switch (CardValue)
                {
                    case 1:
                        return "A";
                    case 11:
                        return "J";
                    case 12:
                        return "Q";
                    case 13:
                        return "K";
                    default:
                        return "U";
                }
            } 
        }
    }
}
