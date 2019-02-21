using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Blackjack.Models
{
    public class Card : INotifyPropertyChanged
    {
        private string cardName;
        private int cardValue;
        private string suit;


        public string CardName
        {
            get
            {
                return cardName;
            }

            set
            {
                cardName = value;
                OnPropertyChanged("CardName");

            }
        }

        public int CardValue
        {
            get
            {
                return cardValue;
            }
            set
            {
                cardValue = value;
                OnPropertyChanged("CardValue");
            }


        }

        public string Suit
        {
            get
            {
                return suit;
            }
            set
            {
                suit = value;
                OnPropertyChanged("Suit");
            }
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
