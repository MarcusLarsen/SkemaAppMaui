namespace SkemaAppMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            string webUrl;
        #if ANDROID
            webUrl = "https://192.168.1.129:5173/";  // Use 10.0.2.2 for Android emulator
        #else
            webUrl = "https://localhost:5173/";
        #endif

            WebView webView = new WebView
            {
                Source = webUrl,
                HeightRequest = 500
            };

            Content = new VerticalStackLayout
            {
                Children = {
                new Label
                {
                    Text = "Velkommen til min MAUI App!",
                    FontSize = 24,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Start
                },
                webView
            }
            };
        }
    }
}

