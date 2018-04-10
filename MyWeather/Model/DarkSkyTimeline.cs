// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using MyWeather.Models;
//
//    var data = DarkSkyTimeline.FromJson(jsonString);
//
namespace MyWeather.Models.DarkSkyTimeline
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class DarkSkyTimeline
    {
        [JsonProperty("currently")]
        public FluffyDatum Currently { get; set; }

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

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
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
        public List<PurpleDatum> Data { get; set; }
    }

    public partial class PurpleDatum
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

        [JsonProperty("precipIntensity")]
        public long PrecipIntensity { get; set; }

        [JsonProperty("precipIntensityMax")]
        public long PrecipIntensityMax { get; set; }

        [JsonProperty("precipProbability")]
        public long PrecipProbability { get; set; }

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

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("windBearing")]
        public long WindBearing { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }
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

        [JsonProperty("precipIntensity")]
        public long? PrecipIntensity { get; set; }

        [JsonProperty("precipProbability")]
        public long? PrecipProbability { get; set; }

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

        [JsonIgnore]
        public string DisplayDate
        {
            get
            {
                var now = DateTime.Now.AddSeconds((double)Time);
                return now.ToString("g");
            }
        }

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("windBearing")]
        public long? WindBearing { get; set; }

        [JsonProperty("windSpeed")]
        public double? WindSpeed { get; set; }
    }

    public partial class DarkSkyTimeline
    {
        public static DarkSkyTimeline FromJson(string json) => JsonConvert.DeserializeObject<DarkSkyTimeline>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this DarkSkyTimeline self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
