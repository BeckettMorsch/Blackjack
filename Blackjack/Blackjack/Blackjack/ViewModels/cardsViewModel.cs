using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Blackjack.Models;

namespace Blackjack.ViewModels
{
    class CardsViewModel: INotifyPropertyChanged
    { 
        
            public ObservableCollection<Card> Cards { get; set; }

            public void cardsViewModel()
            {
                Cards = new ObservableCollection<Card>();


            }

            

            public event PropertyChangedEventHandler PropertyChanged;

            public void OnPropertyChanged(string name)
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs(name));
                }
            }

        /* Console app code, need to adapt to MVVM
          bool game = true;
            Random rng = new Random();
            int deal = -1, total = 0;
            string input = "";

        while (game)
            {
                List<int> deck = new List<int> { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 11, 11, 11, 11, 12, 12, 12, 12, 13, 13, 13, 13 };
                List<int> playerDeck = new List<int> { };
                List<int> houseDeck = new List<int> { };

                deal = rng.Next(0, deck.Count());
                playerDeck.Add(deck[deal]);
                deck.Remove(deal);

                deal = rng.Next(0, deck.Count());
                playerDeck.Add(deck[deal]);
                deck.Remove(deal);
                Console.Write(playerDeck[0] + " " + playerDeck[1]);

                while (counter(playerDeck) < 21)
                {
                    input = Console.ReadLine();

                    if (input.Equals("hit")) // sub for a button press event
                    {
                        deal = rng.Next(0, deck.Count());
                        playerDeck.Add(deck[deal]);
                        Console.Write(deck[deal]);
                        deck.Remove(deal);

                    }
                    else if (input.Equals("stand"))
                    {
                        break;
                    }
                }

               

                while (counter(houseDeck) < 17)
                {
                    deal = rng.Next(0, deck.Count());
                    houseDeck.Add(deck[deal]);
                    deck.Remove(deal);
                }

                if (counter(playerDeck) > 21)
                {
                    Console.Write("Bust");
                    
                }

                else if (counter(houseDeck) > 21)
                {
                    Console.Write("House bust");
                }

                else if (counter(playerDeck) == counter(houseDeck))
                {
                    Console.Write("tie");
                    
                }

                else if(counter(playerDeck) > counter(houseDeck))
                {
                    Console.Write("BIIIIG WIN");
                        
                }

                else if (counter(playerDeck) < counter(houseDeck))
                {
                    Console.Write("house takes the pot");
                }

               

                Console.Write("\nplay again?");
                if (Console.ReadLine().Equals("no"))
                {
                    break;
                }



            }
            Console.ReadLine();
        }


        public static int counter(List<int> hand)
        {
            int total = 0;

            foreach (int card in hand)
            {
                if (card <= 9)
                {
                    total += card;
                }
                else
                {
                    total += 10;
                }
            }

            return total;
        }

          */
    }
}
