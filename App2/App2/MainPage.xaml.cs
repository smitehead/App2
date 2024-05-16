using App2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigateToArtists(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArtistsPage());
        }
    }
}


