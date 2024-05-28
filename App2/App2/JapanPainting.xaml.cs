using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JapanPainting : ContentPage
    {
        public JapanPainting()
        {
            InitializeComponent();

            webView.Source = new UrlWebViewSource
            {
                Url = "https://namu.wiki/w/%EC%9A%B0%ED%82%A4%EC%9A%94%EC%97%90",
            };
        }
    }
}