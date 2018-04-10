using MyWeather.Helpers;
using MyWeather.Models.DarkSkyTimeline;
using MyWeather.Models.DarkSky;
using MyWeather.Services;
using Plugin.Geolocator;
using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Refit;

namespace MyWeather.ViewModels
{
    public class WeatherViewModel : INotifyPropertyChanged
    {
        IWeatherService WeatherService { get; } = new WeatherService(); //RestService.For<IWeatherService>(Constants.DARK_SKY_CLIENT);

        string location = Settings.City;
        public string Location
        {
            get { return location; }
            set
            {
                location = value;
                OnPropertyChanged();
                Settings.City = value;
            }
        }

        bool useGPS;
        public bool UseGPS
        {
            get { return useGPS; }
            set
            {
                useGPS = value;
                OnPropertyChanged();
            }
        }




        bool isImperial = Settings.IsImperial;
        public bool IsImperial
        {
            get { return isImperial; }
            set
            {
                isImperial = value;
                OnPropertyChanged();
                Settings.IsImperial = value;
            }
        }



        string temp = string.Empty;
        public string Temp
        {
            get { return temp; }
            set { temp = value; OnPropertyChanged(); }
        }

        string condition = string.Empty;
        public string Condition
        {
            get { return condition; }
            set { condition = value; OnPropertyChanged(); }
        }



        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }

        DarkSkyTimeline forecast;
        public DarkSkyTimeline Forecast
        {
            get { return forecast; }
            set { forecast = value; OnPropertyChanged(); }
        }


        ICommand getWeather;
        public ICommand GetWeatherCommand =>
                getWeather ??
                (getWeather = new Command(async () => await ExecuteGetWeatherCommand()));

        private async Task ExecuteGetWeatherCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            try
            {
                DarkSky weatherRoot = null;
                var units = IsImperial ? "us" : "si";

                if (UseGPS)
                {
                    var gps = await CrossGeolocator.Current.GetPositionAsync(new TimeSpan(0, 0, 1));
                    weatherRoot = await WeatherService.GetForecast(gps.Latitude, gps.Latitude, units);
                }
                else
                {
                    //Get weather by city
                    var positions = await CrossGeolocator.Current.GetPositionsForAddressAsync(Location.Trim());
                    if (positions?.Any() == true)
                        weatherRoot = await WeatherService.GetForecast(positions.First().Latitude, positions.First().Longitude, units);
                }


                //Get forecast based on cityId
                Forecast = await WeatherService.GetTimeMachine(weatherRoot.Latitude, weatherRoot.Longitude, 0, units);

                var unit = IsImperial ? "F" : "C";
                Temp = $"Temp: {weatherRoot?.Currently?.Temperature ?? 0}°{unit}";
                Condition = weatherRoot?.Currently?.Summary ?? string.Empty;
                await CrossTextToSpeech.Current.Speak(Temp + " " + Condition);
            }
            catch (Exception ex)
            {
                Temp = "Unable to get Weather";
            }
            finally
            {
                IsBusy = false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
