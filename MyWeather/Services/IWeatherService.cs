using System.Threading.Tasks;

using MyWeather.Models.DarkSkyTimeline;
using MyWeather.Models.DarkSky;
using MyWeather.Helpers;
using Refit;

namespace MyWeather.Services
{
    public interface IWeatherService
    {
        [Get("forecast/3b872674fe2b89f83e827166de73968a/{latitude},{longitude}?units={units}")]
        Task<DarkSky> GetForecast(double latitude, double longitude, string units = "us");

        [Get("forecast/3b872674fe2b89f83e827166de73968a/{latitude},{longitude},{time}?units={units}")]
        Task<DarkSkyTimeline> GetTimeMachine(double latitude, double longitude, long time = 0, string units = "us");
    }
}