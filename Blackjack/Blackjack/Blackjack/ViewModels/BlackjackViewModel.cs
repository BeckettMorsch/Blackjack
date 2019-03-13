using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Blackjack.Models;
using Blackjack.ViewModels;
using System.Numerics;

namespace Blackjack.ViewModels
{
    public class BlackjackViewModel
    {
        private static BlackjackViewModel current = null;
        private ObservableCollection<CardItem> Cards { get; set; }
        
        
        //List of cards that have been drawn?
        public void Reset()
        {
            //Cards.Clear();
            Cards.Add(new CardItem
            {
                number = 11,
                suit = "hearts",
                name = "ace_hearts",
                cardNumber = 1
            }
                );
            Cards.Add(new CardItem
            {
                number = 2,
                suit = "hearts",
                name = "two_hearts",
                cardNumber = 2
            }
                );
            Cards.Add(new CardItem
            {
                number = 3,
                suit = "hearts",
                name = "three_hearts",
                cardNumber = 3
            }
                );
            Cards.Add(new CardItem
            {
                number = 4,
                suit = "hearts",
                name = "four_hearts",
                cardNumber = 4
            }
                );
            Cards.Add(new CardItem
            {
                number = 5,
                suit = "hearts",
                name = "five_hearts",
                cardNumber = 5
            }
                );
            Cards.Add(new CardItem
            {
                number = 6,
                suit = "hearts",
                name = "six_hearts",
                cardNumber = 6
            }
                );
            Cards.Add(new CardItem
            {
                number = 7,
                suit = "hearts",
                name = "seven_hearts",
                cardNumber = 7
            }
                );
            Cards.Add(new CardItem
            {
                number = 8,
                suit = "hearts",
                name = "eight_hearts",
                cardNumber = 8
            }
                );
            Cards.Add(new CardItem
            {
                number = 9,
                suit = "hearts",
                name = "nine_hearts",
                cardNumber = 9
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "hearts",
                name = "ten_hearts",
                cardNumber = 10
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "hearts",
                name = "jack_hearts",
                cardNumber = 11
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "hearts",
                name = "queen_hearts",
                cardNumber = 12
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "hearts",
                name = "king_hearts",
                cardNumber = 13
            }
                );
            Cards.Add(new CardItem
            {
                number = 11,
                suit = "diamonds",
                name = "ace_diamonds",
                cardNumber = 14
            }
                );
            Cards.Add(new CardItem
            {
                number = 2,
                suit = "diamonds",
                name = "two_diamonds",
                cardNumber = 15
            }
                );
            Cards.Add(new CardItem
            {
                number = 3,
                suit = "diamonds",
                name = "three_diamonds",
                cardNumber = 16
            }
                );
            Cards.Add(new CardItem
            {
                number = 4,
                suit = "diamonds",
                name = "four_diamonds",
                cardNumber = 17
            }
                );
            Cards.Add(new CardItem
            {
                number = 5,
                suit = "diamonds",
                name = "five_diamonds",
                cardNumber = 18
            }
                );
            Cards.Add(new CardItem
            {
                number = 6,
                suit = "diamonds",
                name = "six_diamonds",
                cardNumber = 19
            }
                );
            Cards.Add(new CardItem
            {
                number = 7,
                suit = "diamonds",
                name = "seven_diamonds",
                cardNumber = 20
            }
                );
            Cards.Add(new CardItem
            {
                number = 8,
                suit = "diamonds",
                name = "eight_diamonds",
                cardNumber = 21
            }
                );
            Cards.Add(new CardItem
            {
                number = 9,
                suit = "diamonds",
                name = "nine_diamonds",
                cardNumber = 22
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "diamonds",
                name = "ten_diamonds",
                cardNumber = 23
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "diamonds",
                name = "jack_diamonds",
                cardNumber = 24
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "diamonds",
                name = "queen_diamonds",
                cardNumber = 25
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "diamonds",
                name = "king_diamonds",
                cardNumber = 26
            }
                );
            Cards.Add(new CardItem
            {
                number = 11,
                suit = "clubs",
                name = "ace_clubs",
                cardNumber = 27
            }
                );
            Cards.Add(new CardItem
            {
                number = 2,
                suit = "clubs",
                name = "two_clubs",
                cardNumber = 28
            }
                );
            Cards.Add(new CardItem
            {
                number = 3,
                suit = "clubs",
                name = "three_clubs",
                cardNumber = 29
            }
                );
            Cards.Add(new CardItem
            {
                number = 4,
                suit = "clubs",
                name = "four_clubs",
                cardNumber = 30
            }
                );
            Cards.Add(new CardItem
            {
                number = 5,
                suit = "clubs",
                name = "five_clubs",
                cardNumber = 31
            }
                );
            Cards.Add(new CardItem
            {
                number = 6,
                suit = "clubs",
                name = "six_clubs",
                cardNumber = 32
            }
                );
            Cards.Add(new CardItem
            {
                number = 7,
                suit = "clubs",
                name = "seven_clubs",
                cardNumber = 33
            }
                );
            Cards.Add(new CardItem
            {
                number = 8,
                suit = "clubs",
                name = "eight_clubs",
                cardNumber = 34
            }
                );
            Cards.Add(new CardItem
            {
                number = 9,
                suit = "club",
                name = "nine_clubs",
                cardNumber = 35
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "clubs",
                name = "ten_clubs",
                cardNumber = 36
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "clubs",
                name = "jack_clubs",
                cardNumber = 37
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "clubs",
                name = "queen_clubs",
                cardNumber = 38
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "clubs",
                name = "king_clubs",
                cardNumber = 39
            }
                );
            Cards.Add(new CardItem
            {
                number = 11,
                suit = "spades",
                name = "ace_spades",
                cardNumber = 40
            }
                );
            Cards.Add(new CardItem
            {
                number = 2,
                suit = "spades",
                name = "two_spades",
                cardNumber = 41
            }
                );
            Cards.Add(new CardItem
            {
                number = 3,
                suit = "spades",
                name = "three_spades",
                cardNumber = 42
            }
                );
            Cards.Add(new CardItem
            {
                number = 4,
                suit = "spades",
                name = "four_spades",
                cardNumber = 43
            }
                );
            Cards.Add(new CardItem
            {
                number = 5,
                suit = "spades",
                name = "five_spades",
                cardNumber = 44
            }
                );
            Cards.Add(new CardItem
            {
                number = 6,
                suit = "spades",
                name = "six_spades",
                cardNumber = 45
            }
                );
            Cards.Add(new CardItem
            {
                number = 7,
                suit = "spades",
                name = "seven_spades",
                cardNumber = 46
            }
                );
            Cards.Add(new CardItem
            {
                number = 8,
                suit = "spades",
                name = "eight_spades",
                cardNumber = 47
            }
                );
            Cards.Add(new CardItem
            {
                number = 9,
                suit = "spades",
                name = "nine_spades",
                cardNumber = 48
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "spades",
                name = "ten_spades",
                cardNumber = 49
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "spades",
                name = "jack_spades",
                cardNumber = 50
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "spades",
                name = "queen_spades",
                cardNumber = 51
            }
                );
            Cards.Add(new CardItem
            {
                number = 10,
                suit = "spades",
                name = "king_spades",
                cardNumber = 52
            }
                );

            //reset variables

        }
        ObservableCollection<CardItem> pHand { get; set; }
        ObservableCollection<CardItem> dHand { get; set; }
        // Returns number between 1 and 52
        List<int> drawn = new List<int>() { };

        int bet = 0;
        public int Bet(int num)
        {
            bet += num;
            return CurrentBet;
        }

        public static BlackjackViewModel Current
        {
            get
            {
                if(current == null)
                {
                    current = new BlackjackViewModel();
                }

                return current;
            }
        }

        public int ClearBet
        {
            set
            {
                bet = 0;
                OnPropertyChanged("ClearBet"); 
            }
            get
            {
                bet = 0;
                return bet;
            }
        }

        public int currentBet;
        public int CurrentBet
        {
            set
            {
                currentBet = bet;
                OnPropertyChanged("CurrentBet");
            }
            get
            {
                currentBet = bet;
                return currentBet;
            }
            
        }

        public int Draw()
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 52);

            if(drawn.Contains(rand))
            {
                return Draw();                
            }
            else
            {
                drawn.Add(rand);
                return rand;
            }

        }

        
        
        public void OnPropertyChanged (string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }



        public event PropertyChangedEventHandler PropertyChanged;
    }
}

