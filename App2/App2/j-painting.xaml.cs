using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class j_painting : ContentPage
    {
        public j_painting()
        {
            InitializeComponent();

            webView.Source = new UrlWebViewSource
            {
                Url = "https://namu.wiki/w/%ED%95%9C%EA%B5%AD%ED%99%94",
            };
        }
    }
}
