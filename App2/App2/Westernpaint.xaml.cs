using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Westernpaint : ContentPage
	{
		public Westernpaint ()
		{
			InitializeComponent ();
		}
        private async void Portraitpaint(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PortraitPainting());

        }
        private async void AbstractArt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbstractArt());

        }
        private async void Landscape(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LandscapeArt());

        }

    }
}
