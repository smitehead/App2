using Xamarin.Forms;

namespace App2
{
    public partial class KoreanPainting : ContentPage
    {
        public KoreanPainting()
        {
            InitializeComponent();

            // HTML 문자열 생성
            string htmlContent = "<html><body><h1>Hello, WebView!</h1></body></html>";

            // WebView에 HTML 문자열 로드
            webView.Source = new HtmlWebViewSource { Html = htmlContent };
        }
    }
}
