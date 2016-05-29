using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Coordinate
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("x")]
        public double XCoordinate { get; set; }

        [JsonProperty("y")]
        public double YCoordinate { get; set; }
    }

    public class Station
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public int? Score { get; set; }

        [JsonProperty("coordinate")]
        public Coordinate Coordinate { get; set; }

        [JsonProperty("distance")]
        public double? Distance { get; set; }

        /// <summary>
        /// Return name for usage in ComboBox.Items
        /// </summary>
        /// <returns>Name of the station</returns>
        public override string ToString()
        {
            return Name;
        }
    }

    public class Stations
    {
        [JsonProperty("stations")]
        public List<Station> StationList { get; set; }
    }
}