using System;
using System.Net.Http;

namespace MyWeather.Helpers
{
    public static class Constants
    {
        public const string DARK_SKY_API_KEY = "3b872674fe2b89f83e827166de73968a";

        public static readonly HttpClient DARK_SKY_CLIENT = new HttpClient()
        {
            BaseAddress = new Uri("https://api.darksky.net")
        };
    }
}
