using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Blackjack.Views;

namespace Blackjack
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           //return new NavigationPage(new MainPage());
        }

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GamePage());
        }
    }
}
