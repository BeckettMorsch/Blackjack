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
		public GamePage ()
		{
			InitializeComponent ();
		}
        public int bet = 0;
        //public int playerTotal = 0;
        //public int dealerTotal = 0;

        private void Hit_Clicked(object sender, EventArgs e)
        {

        }

        private void Stand_Clicked(object sender, EventArgs e)
        {

        }
    }
}