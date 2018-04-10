using MyWeather.Models.DarkSky;
using MyWeather.Models.DarkSkyTimeline;
using MyWeather.Helpers;
using System.Net.Http;
using System.Threading.Tasks;
using static Newtonsoft.Json.JsonConvert;

namespace MyWeather.Services
{
    public enum Units
    {
        Imperial,
        Metric
    }

    public class WeatherService : IWeatherService
    {
        public async Task<DarkSky> GetForecast(double latitude, double longitude, string units = "us")
        {
            using(var client = new HttpClient())
            {
                var url = $"https://api.darksky.net/forecast/{Constants.DARK_SKY_API_KEY}/{latitude},{longitude}?units={units}";
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                return DarkSky.FromJson(json);
            }
        }

        public async Task<DarkSkyTimeline> GetTimeMachine(double latitude, double longitude, long time = 0, string units = "us")
        {
            using(var client = new HttpClient())
            {
                var url = $"https://api.darksky.net/forecast/{Constants.DARK_SKY_API_KEY}/{latitude},{longitude},{time}?units={units}";
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                   return null;

                return DarkSkyTimeline.FromJson(json);
            }
        }
    }
}
