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
    <title>Styled Maps - Night Mode</title>
    <meta name=""viewport"" content=""initial-scale=1.0, user-scalable=no"">
    <meta charset=""utf-8"">
    <style>
      #map {
        height: 100%;
      }
      html, body {
        height: 100%;
        margin: 0;
        padding: 0;
      }
    </style>
  </head>
  <body>
    <div id=""map""></div>
    <script>
      function initMap() {
        var location = {lat: 35.179481054964654, lng: 128.55545654390698}; // 설정된 위치
        var map = new google.maps.Map(document.getElementById('map'), {
          center: location,
          zoom: 17 // 초기 줌 레벨 설정
        });
        var marker = new google.maps.Marker({
          position: location,
          map: map,
          title: '경남대 1공학관'
        });
        marker.addListener('click', function() {
          infowindow.open(map, marker);
        });

        // 초기 정보 창 표시
        infowindow.open(map, marker);
      }
    </script>
    <script src=""https://maps.google.com/maps/api/js?key=AIzaSyASufxgy93d9XEAsliXeUgBtZfSSYEy5a8&callback=initMap"" 
            type=""text/javascript"" async defer></script>
  </body>
</html>"
            };

            GoogleMapWebView.Source = htmlSource;
        }
    }
}
