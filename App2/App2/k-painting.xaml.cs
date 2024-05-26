﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class k_painting : ContentPage
    {
        public k_painting()
        {
            InitializeComponent();

            // HTML 파일의 경로
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>My Homepage</title>
    <style>
        /* CSS 스타일은 그대로 유지됩니다. */
        /* ... */
    </style>
</head>
<body>
    <!-- Header 부분은 그대로 유지됩니다. -->
    <header>
        <h1>Welcome to My Homepage</h1>
    </header>
    <!-- Nav 부분도 그대로 유지됩니다. -->
    <nav>
        <a href=""about.html"">About</a>
        <a href=""#services"">Services</a>
        <a href=""#contact"">Contact</a>
    </nav>
    <main>
        <!-- About Us, Our Services 섹션은 그대로 유지됩니다. -->
        <!-- ... -->
        <!-- Contact Us 섹션은 생략하고 간단한 내용을 추가합니다. -->
        <section id=""contact"">
            <h2>Contact Us</h2>
            <p>Email: info@example.com</p>
            <p>Phone: 123-456-7890</p>
            <!-- 하이퍼링크를 사용하여 about.html 파일로 이동하는 링크 추가 -->
            <p><a href=""about.html"">About Page</a></p>
        </section>
    </main>
    <!-- Footer 부분은 그대로 유지됩니다. -->
    <footer>
        <p>&copy; 2024 My Homepage</p>
    </footer>
</body>
</html>
";

            // WebView에 HTML 파일 설정
            webView.Source = htmlSource;
        }
    }
}
