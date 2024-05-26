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
        private async void Button_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Orientalpainting());
        }
        private async void Button_Clicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Westernpaint());
        }
        private async void Button_Clicked4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Artcategory());
        }
        private async void Button_Clicked5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Csc());
        }

    }
}


