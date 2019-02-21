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
        
        //
    }
}
