using System;
using System.Collections.Generic;

namespace DeckOCards
{
    class Player
    {
        public List<Card> Hand;
        // Player class should have the following: 
        // fields
        //      hand, arrayList of cards(5)
        public string Name;
        public Player(string Name)
        {
            this.Name = Name;

        }
        public Card Discard(int Index)
        {
            Card CardDiscarded = this.Hand[Index];
            return CardDiscarded;
        }
        public void Draw(Deck Deck)
        {
            // draws a card from the deck and adds it to the players hand
        }
        public void DisplayHand()
        {
            // prints all cards in hand to console
        }
    }
}
