using Xamarin.Forms;

namespace MyWeather.View
{
    public partial class WeatherView : ContentPage
    {
        public WeatherView()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
                Icon = new FileImageSource { File = "tab1.png" };

            #region C# Code Behind View
            var layout = new StackLayout()
            {
                Padding = new Thickness(10),
                Spacing = 10
            };

            var locationEntry = new Entry();
            locationEntry.SetBinding(Entry.TextProperty, "Location");

            layout.Children.Add(locationEntry);

            var controlLayout = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal
            };

            controlLayout.Children.Add(new Label()
            {
                Text = "Use Imperial?",
                VerticalTextAlignment = TextAlignment.Center
            });

            var imperialSwitch = new Switch();
            imperialSwitch.SetBinding(Switch.IsToggledProperty, "IsImperial");

            controlLayout.Children.Add(imperialSwitch);

            layout.Children.Add(controlLayout);

            var gpsLayout = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal
            };

            gpsLayout.Children.Add(new Label()
            {
                Text = "Use GPS?",
                VerticalTextAlignment = TextAlignment.Center
            });

            var gpsSwitch = new Switch();
            gpsSwitch.SetBinding(Switch.IsToggledProperty, "UseGPS");

            gpsLayout.Children.Add(gpsSwitch);

            layout.Children.Add(gpsLayout);

            var getWeather = new Button()
            {
                Text = "Get Weather"
            };
            getWeather.SetBinding(Button.CommandProperty, "GetWeatherCommand");

            layout.Children.Add(getWeather);

            var temp = new Label()
            {
                FontSize = 30
            };
            temp.SetBinding(Label.TextProperty, "Temp");

            layout.Children.Add(temp);

            var cond = new Label();
            cond.SetBinding(Label.TextProperty, "Condition");

            layout.Children.Add(cond);

            var busy = new ActivityIndicator();
            busy.SetBinding(ActivityIndicator.IsRunningProperty, "IsBusy");
            busy.SetBinding(ActivityIndicator.IsVisibleProperty, "IsBusy");

            layout.Children.Add(busy);

            Content = layout;
            #endregion
        }
    }
}
