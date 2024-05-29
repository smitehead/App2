using Xamarin.Forms;

namespace App2
{
    public partial class Csc : ContentPage
    {
        public Csc()
        {
            InitializeComponent();

            // HTML 문자열을 통해 구글 맵을 로드
            var htmlSource = new HtmlWebViewSource
            {
                Html = @"<!DOCTYPE html>
                        <html>
                        <head>
                            <title>Google Map</title>
                            <meta name='viewport' content='initial-scale=1.0, user-scalable=no'>
                            <meta charset='utf-8'>
                            <script src='https://maps.googleapis.com/maps/api/js?key=AIzaSyASufxgy93d9XEAsliXeUgBtZfSSYEy5a8'></script>
                            <script>
                                function initMap() {
                                    var location = { lat: 37.7749, lng: -122.4194 };
                                    var map = new google.maps.Map(document.getElementById('map'), {
                                        zoom: 10,
                                        center: location
                                    });
                                    var marker = new google.maps.Marker({
                                        position: location,
                                        map: map
                                    });
                                }
                            </script>
                        </head>
                        <body onload='initMap()'>
                            <div id='map' style='height: 100%; width: 100%;'></div>
                        </body>
                        </html>"
            };

            GoogleMapWebView.Source = htmlSource;
        }
    }
}
