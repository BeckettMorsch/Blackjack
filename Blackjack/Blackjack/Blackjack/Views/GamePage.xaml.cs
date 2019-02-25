using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

        private void Hit_Clicked(object sender, EventArgs e)
        {

        }

        private void Stand_Clicked(object sender, EventArgs e)
        {

        }
    }
}