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
	public partial class Artcategory : ContentPage
	{
		public Artcategory ()
		{
			InitializeComponent ();
		}
        private async void Modernart(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ModernArt());
        }
        private async void Surrealism(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SurrealismArt());

        }
        private async void Popart(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Popart());
        }
    }
}