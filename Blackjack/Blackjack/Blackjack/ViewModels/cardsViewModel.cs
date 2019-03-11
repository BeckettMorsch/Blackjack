using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Blackjack.Models;

namespace Blackjack.ViewModels
{
    class CardsViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<Card> Cards { get; set; }
        public ObservableCollection<Card> pHand { get; set; }
        public ObservableCollection<Card> dHand { get; set; }
        public Card[] refresher = new Card[52];

        public void cardsViewModel()
        {

            Cards = new ObservableCollection<Card>();
            #region cards  
            Cards.Add(new Card {CardValue = 2, CardName = "Two_hearts", Suit = "Hearts"});
            Cards.Add(new Card { CardValue = 2, CardName = "Two_spades", Suit = "Spades" });
            Cards.Add(new Card { CardValue = 2, CardName = "Two_clubs", Suit = "Clubs" });
            Cards.Add(new Card { CardValue = 2, CardName = "Two_diamonds", Suit = "Diamonds" });
            Cards.Add(new Card { CardValue = 3, CardName = "Three_hearts", Suit = "Hearts" });
            Cards.Add(new Card { CardValue = 3, CardName = "Three_spades", Suit = "Spades" });
            Cards.Add(new Card { CardValue = 3, CardName = "Three_clubs", Suit = "Clubs" });
            Cards.Add(new Card { CardValue = 3, CardName = "Three_diamonds", Suit = "Diamonds" });
            Cards.Add(new Card { CardValue = 4, CardName = "Four_hearts", Suit = "Hearts" });
            Cards.Add(new Card { CardValue = 4, CardName = "Four_spades", Suit = "Spades" });
            Cards.Add(new Card { CardValue = 4, CardName = "Four_clubs", Suit = "Clubs" });
            Cards.Add(new Card { CardValue = 4, CardName = "Four_diamonds", Suit = "Diamonds" });
            Cards.Add(new Card { CardValue = 5, CardName = "Five_hearts", Suit = "Hearts" });
            Cards.Add(new Card { CardValue = 5, CardName = "Five_spades", Suit = "Spades" });
            Cards.Add(new Card { CardValue = 5, CardName = "Five_clubs", Suit = "Clubs" });
            Cards.Add(new Card { CardValue = 5, CardName = "Five_diamonds", Suit = "Diamonds" });
            Cards.Add(new Card { CardValue = 6, CardName = "Six_hearts", Suit = "Hearts" });
            Cards.Add(new Card { CardValue = 6, CardName = "Six_spades", Suit = "Spades" });
            Cards.Add(new Card { CardValue = 6, CardName = "Six_clubs", Suit = "Clubs" });
            Cards.Add(new Card { CardValue = 6, CardName = "Sixe_diamonds", Suit = "Diamonds" });
            Cards.Add(new Card { CardValue = 7, CardName = "Seven_hearts", Suit = "Hearts" });
            Cards.Add(new Card { CardValue = 7, CardName = "Seven_spades", Suit = "Spades" });
            Cards.Add(new Card { CardValue = 7, CardName = "Seven_clubs", Suit = "Clubs" });
            Cards.Add(new Card { CardValue = 7, CardName = "Seven_diamonds", Suit = "Diamonds" });
            Cards.Add(new Card { CardValue = 8, CardName = "Eight_hearts", Suit = "Hearts" });
            Cards.Add(new Card { CardValue = 8, CardName = "Eight_spades", Suit = "Spades" });
            Cards.Add(new Card { CardValue = 8, CardName = "Eight_clubs", Suit = "Clubs" });
            Cards.Add(new Card { CardValue = 8, CardName = "Eight_diamonds", Suit = "Diamonds" });
            Cards.Add(new Card { CardValue = 9, CardName = "Nine_hearts", Suit = "Hearts" });
            Cards.Add(new Card { CardValue = 9, CardName = "Nine_spades", Suit = "Spades" });
            Cards.Add(new Card { CardValue = 9, CardName = "Nine_clubs", Suit = "Clubs" });
            Cards.Add(new Card { CardValue = 9, CardName = "Nine_diamonds", Suit = "Diamonds" });
            Cards.Add(new Card { CardValue = 10, CardName = "Ten_hearts", Suit = "Hearts" });
            Cards.Add(new Card { CardValue = 10, CardName = "Ten_spades", Suit = "Spades" });
            Cards.Add(new Card { CardValue = 10, CardName = "Ten_clubs", Suit = "Clubs" });
            Cards.Add(new Card { CardValue = 10, CardName = "Ten_diamonds", Suit = "Diamonds" });
            Cards.Add(new Card { CardValue = 10, CardName = "Jack_hearts", Suit = "Hearts" });
            Cards.Add(new Card { CardValue = 10, CardName = "Jack_spades", Suit = "Spades" });
            Cards.Add(new Card { CardValue = 10, CardName = "Jack_clubs", Suit = "Clubs" });
            Cards.Add(new Card { CardValue = 10, CardName = "Jack_diamonds", Suit = "Diamonds" });
            Cards.Add(new Card { CardValue = 10, CardName = "Queen_hearts", Suit = "Hearts" });
            Cards.Add(new Card { CardValue = 10, CardName = "Queen_spades", Suit = "Spades" });
            Cards.Add(new Card { CardValue = 10, CardName = "Queen_clubs", Suit = "Clubs" });
            Cards.Add(new Card { CardValue = 10, CardName = "Queen_diamonds", Suit = "Diamonds" });
            Cards.Add(new Card { CardValue = 10, CardName = "King_hearts", Suit = "Hearts" });
            Cards.Add(new Card { CardValue = 10, CardName = "King_spades", Suit = "Spades" });
            Cards.Add(new Card { CardValue = 10, CardName = "King_clubs", Suit = "Clubs" });
            Cards.Add(new Card { CardValue = 10, CardName = "King_diamonds", Suit = "Diamonds" });
            Cards.Add(new Card { CardValue = 11, CardName = "Ace_hearts", Suit = "Hearts" });
            Cards.Add(new Card { CardValue = 11, CardName = "Ace_spades", Suit = "Spades" });
            Cards.Add(new Card { CardValue = 11, CardName = "Ace_clubs", Suit = "Clubs" });
            Cards.Add(new Card { CardValue = 11, CardName = "Ace_diamonds", Suit = "Diamonds" });
            #endregion
            Cards.CopyTo(refresher, 0);

            pHand = new ObservableCollection<Card>();
            dHand = new ObservableCollection<Card>();
        }

        

        public void draw(Boolean turn)
        {
            Random rng = new Random();
            int num = rng.Next(0, Cards.Count - 1);
            if (turn)
            {
                dHand.Add(Cards[num]);
                OnPropertyChanged("dHand");
            }
            else
            {
                pHand.Add(Cards[num]);
                OnPropertyChanged("pHand");
            }
            Cards.Remove(Cards[num]);
            OnPropertyChanged("Cards");
        }



        public void reset ()
        {
            pHand.Clear();
            dHand.Clear();
            Cards.Clear();
            
            foreach (Card i in refresher)
            {
                Cards.Add(i);
            }
            OnPropertyChanged("Cards");
            OnPropertyChanged("pHand");
            OnPropertyChanged("dHand");
        }


        
        public int handTotal(List<Card> hand)
        { 
            int total = 0;
            foreach(Card i in hand)
            {
                total += i.CardValue;
            }

            if (total > 21 && hand.Contains(Array.Find(refresher, x => x.CardValue == 11)))
            {
                hand.Find(x => x.CardValue == 11).CardValue = 1;
                return handTotal(hand);
            }

            return total;
        }
        
            

            public event PropertyChangedEventHandler PropertyChanged;

            public void OnPropertyChanged(string name)
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs(name));
                }
            }

        
    }
}
