using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        // Changed to avoid redundancy with the overload method 
        public Stations GetStations(string query)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
            return GetStations(request);
        }

        /// <summary>
        /// Overload method of GetStations for x and y coordinates
        /// </summary>
        /// <param name="x">x-coordinate</param>
        /// <param name="y">y-coordinate</param>
        /// <returns></returns>
        public Stations GetStations(double x, double y)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?x=" + x + "&y=" + y);
            return GetStations(request);
        }

        /// <summary>
        /// Common method for loading stations from the API
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private Stations GetStations(WebRequest request)
        {
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var message = new StreamReader(responseStream).ReadToEnd();
                var stations = JsonConvert.DeserializeObject<Stations>(message);
                return stations;
            }

            return null;
        }

        public StationBoardRoot GetStationBoard(string station, string id)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }

        public Connections GetConnections(string fromStation, string toStattion)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
                return connections;
            }

            return null;
        }

        /// <summary>
        /// Get the connection with time filter
        /// </summary>
        /// <param name="fromStation">Departure</param>
        /// <param name="toStattion">Destination</param>
        /// <param name="date">Date of connection</param>
        /// <param name="time">Time of connection</param>
        /// <returns></returns>
        public Connections GetConnectionsByDateTime(string fromStation, string toStattion, DateTime date, DateTime time, bool isArrival)
        {
            //expected time format 15:55
            //expected date format 2016-05-25
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion + "&date=" + date.ToString("yyyy-MM-dd") + "&time=" + time.ToString("HH:mm") + "&isArrivalTime=" + isArrival);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
                return connections;
            }

            return null;
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;

            return request;
        }
    }
}
