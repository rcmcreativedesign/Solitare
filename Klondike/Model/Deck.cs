using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klondike.Model
{
    public class Deck
    {
        private IList<ICard> cards;

        public Deck()
        {
            LoadDeck();
            ShuffleDeck();
        }

        public void ShuffleDeck()
        {
            
        }

        private void LoadDeck()
        {
            cards = new List<ICard>();
            for (var suitLoop = 1; suitLoop < 5; suitLoop++)
            {
                for (var cardLoop = 1; cardLoop < 14; cardLoop++)
                {
                    if (cardLoop == 1 || cardLoop > 10)
                        cards.Add(new FaceCard() { Suit = (Suit)suitLoop, CardValue = cardLoop });
                    else
                        cards.Add(new Card() { Suit = (Suit)suitLoop, CardValue = cardLoop });
                }
            }
        }
    }
}
