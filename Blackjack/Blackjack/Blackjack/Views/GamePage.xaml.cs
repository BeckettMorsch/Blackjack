using Blackjack.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Blackjack.ViewModels;

namespace Blackjack.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GamePage : ContentPage
	{
        BlackjackViewModel vm;
		public GamePage ()
		{
			InitializeComponent ();
            this.BindingContext = vm = BlackjackViewModel.Current;
            MoneyDis.Text = "" + vm.DisplayMoney;
        }
       
        public int bet = 0;
        //public int playerTotal = 0;
        //public int dealerTotal = 0;
        
        private void Hit_Clicked(object sender, EventArgs e)
        {
            MoneyDis.Text = "" + vm.DisplayMoney;
        }

        private void Stand_Clicked(object sender, EventArgs e)
        {

        }

        private void Bet_50(object sender, EventArgs e)
        {
            vm.Bet(50);
            BetDis.Text = "" + vm.CurrentBet;
        }

        private void Bet_100(object sender, EventArgs e)
        {
            vm.Bet(100);
            BetDis.Text = "" + vm.CurrentBet;
        }

        private void Bet_500(object sender, EventArgs e)
        {
            vm.Bet(500);
            BetDis.Text = "" + vm.CurrentBet;
        }

        private void Bet_1000(object sender, EventArgs e)
        {
            vm.Bet(1000);
            BetDis.Text = "" + vm.CurrentBet;
        }

        private void Bet_5000(object sender, EventArgs e)
        {
            vm.Bet(5000);
            BetDis.Text = "" + vm.CurrentBet;
        }

        
    }
}