// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using MyWeather.Models;
//
//    var data = DarkSky.FromJson(jsonString);
//
namespace MyWeather.Models.DarkSky
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class DarkSky
    {
        [JsonProperty("currently")]
        public Currently Currently { get; set; }

        [JsonProperty("daily")]
        public Daily Daily { get; set; }

        [JsonProperty("flags")]
        public Flags Flags { get; set; }

        [JsonProperty("hourly")]
        public Hourly Hourly { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("minutely")]
        public Minutely Minutely { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public partial class Minutely
    {
        [JsonProperty("data")]
        public List<PurpleDatum> Data { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public partial class PurpleDatum
    {
        [JsonProperty("precipIntensity")]
        public long PrecipIntensity { get; set; }

        [JsonProperty("precipProbability")]
        public long PrecipProbability { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }
    }

    public partial class Hourly
    {
        [JsonProperty("data")]
        public List<FluffyDatum> Data { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public partial class FluffyDatum
    {
        [JsonProperty("apparentTemperature")]
        public double ApparentTemperature { get; set; }

        [JsonProperty("cloudCover")]
        public double CloudCover { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("ozone")]
        public double Ozone { get; set; }

        [JsonProperty("precipIntensity")]
        public double PrecipIntensity { get; set; }

        [JsonProperty("precipProbability")]
        public double PrecipProbability { get; set; }

        [JsonProperty("precipType")]
        public string PrecipType { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("uvIndex")]
        public long UvIndex { get; set; }

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("windBearing")]
        public long WindBearing { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }
    }

    public partial class Flags
    {
        [JsonProperty("isd-stations")]
        public List<string> IsdStations { get; set; }

        [JsonProperty("sources")]
        public List<string> Sources { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public partial class Daily
    {
        [JsonProperty("data")]
        public List<TentacledDatum> Data { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public partial class TentacledDatum
    {
        [JsonProperty("apparentTemperatureHigh")]
        public double ApparentTemperatureHigh { get; set; }

        [JsonProperty("apparentTemperatureHighTime")]
        public long ApparentTemperatureHighTime { get; set; }

        [JsonProperty("apparentTemperatureLow")]
        public double ApparentTemperatureLow { get; set; }

        [JsonProperty("apparentTemperatureLowTime")]
        public long ApparentTemperatureLowTime { get; set; }

        [JsonProperty("apparentTemperatureMax")]
        public double ApparentTemperatureMax { get; set; }

        [JsonProperty("apparentTemperatureMaxTime")]
        public long ApparentTemperatureMaxTime { get; set; }

        [JsonProperty("apparentTemperatureMin")]
        public double ApparentTemperatureMin { get; set; }

        [JsonProperty("apparentTemperatureMinTime")]
        public long ApparentTemperatureMinTime { get; set; }

        [JsonProperty("cloudCover")]
        public double CloudCover { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("moonPhase")]
        public double MoonPhase { get; set; }

        [JsonProperty("ozone")]
        public double Ozone { get; set; }

        [JsonProperty("precipIntensity")]
        public double PrecipIntensity { get; set; }

        [JsonProperty("precipIntensityMax")]
        public double PrecipIntensityMax { get; set; }

        [JsonProperty("precipIntensityMaxTime")]
        public long? PrecipIntensityMaxTime { get; set; }

        [JsonProperty("precipProbability")]
        public double PrecipProbability { get; set; }

        [JsonProperty("precipType")]
        public string PrecipType { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("sunriseTime")]
        public long SunriseTime { get; set; }

        [JsonProperty("sunsetTime")]
        public long SunsetTime { get; set; }

        [JsonProperty("temperatureHigh")]
        public double TemperatureHigh { get; set; }

        [JsonProperty("temperatureHighTime")]
        public long TemperatureHighTime { get; set; }

        [JsonProperty("temperatureLow")]
        public double TemperatureLow { get; set; }

        [JsonProperty("temperatureLowTime")]
        public long TemperatureLowTime { get; set; }

        [JsonProperty("temperatureMax")]
        public double TemperatureMax { get; set; }

        [JsonProperty("temperatureMaxTime")]
        public long TemperatureMaxTime { get; set; }

        [JsonProperty("temperatureMin")]
        public double TemperatureMin { get; set; }

        [JsonProperty("temperatureMinTime")]
        public long TemperatureMinTime { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("uvIndex")]
        public long UvIndex { get; set; }

        [JsonProperty("uvIndexTime")]
        public long UvIndexTime { get; set; }

        [JsonProperty("visibility")]
        public long? Visibility { get; set; }

        [JsonProperty("windBearing")]
        public long WindBearing { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windGustTime")]
        public long WindGustTime { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }
    }

    public partial class Currently
    {
        [JsonProperty("apparentTemperature")]
        public double ApparentTemperature { get; set; }

        [JsonProperty("cloudCover")]
        public double CloudCover { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("nearestStormDistance")]
        public long NearestStormDistance { get; set; }

        [JsonProperty("ozone")]
        public long Ozone { get; set; }

        [JsonProperty("precipIntensity")]
        public long PrecipIntensity { get; set; }

        [JsonProperty("precipProbability")]
        public long PrecipProbability { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("uvIndex")]
        public long UvIndex { get; set; }

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("windBearing")]
        public long WindBearing { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }
    }

    public partial class DarkSky
    {
        public static DarkSky FromJson(string json) => JsonConvert.DeserializeObject<DarkSky>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this DarkSky self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
