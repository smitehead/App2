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
	public partial class Orientalpainting : ContentPage
	{
		public Orientalpainting ()
		{
			InitializeComponent ();
		}
        private async void Kprinting(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KoreanPainting());
        }
        private async void Jprinting(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JapanPainting());
        }
        private async void Cprinting(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChinaPainting());
        }

    }
}