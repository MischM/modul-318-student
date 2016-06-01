using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace PublicTransportApp
{
    public partial class PublicTransport : Form
    {
        #region Constructors & Initialize
        private Transport Transport { get; } = new Transport();
        private Timer AutocompleteTimer { get; }
        private string LastStationText { get; set; }
        private ComboBox LastStationBox { get; set; }
        public Connections CurrentConnections { get; set; }

        public PublicTransport()
        {
            InitializeComponent();
            //
            AutocompleteTimer = new Timer
            {
                Interval = 500
            };
            AutocompleteTimer.Tick += AutocompleteTimer_Tick;
            AutoCompleteLoaded += this_AutoComplete;
        }

        #endregion

        #region Events

        private delegate void AutoCompleteEventHandler(object sender, AutocompleteEventArgs e);
        private event AutoCompleteEventHandler AutoCompleteLoaded;

        /// <summary>
        /// Load Stations and pass the result to the <see cref="AutoCompleteLoaded"/> Event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutocompleteTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Autocomplete Started");
            AutocompleteTimer.Stop();
            AutoCompleteLoaded(this, new AutocompleteEventArgs { Stations = Transport.GetStations(LastStationText) });
            Console.WriteLine("Autocomplete Finished");
        }

        /// <summary>
        /// Search Connections and input validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            UpdateStatusStrip("Loading");
            Cursor = Cursors.WaitCursor;
            lsvConnections.Items.Clear();

            var placeOfDeparture = cmbFrom.Text;
            var destination = cmbTo.Text;
            var date = dtpDate.Value;
            var time = dtpTime.Value;
            var isArrival = rdbArrival.Checked;

            CurrentConnections = Transport.GetConnectionsByDateTime(placeOfDeparture, destination, date, time, isArrival);

            FillConnectionList();
        }

        /// <summary>
        /// Wait some time before loading the Stations, because otherwise it will load too many times and show old search results.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbStationSearch_TextChanged(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            foreach (var item in box.Items)
            {
                if (item.ToString() == box.Text)
                {
                    return;
                }
            }

            LastStationBox = box;
            LastStationText = LastStationBox.Text;
            AutocompleteTimer.Stop();
            AutocompleteTimer.Start();
        }

        /// <summary>
        /// Add the stations to the ComboBox and display the dropdown
        /// This has to be done in this Event and not from the Timer, because the Timer Thread has no access to the LastStationBox (is not the owner of it)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void this_AutoComplete(object sender, AutocompleteEventArgs e)
        {
            if (!LastStationBox.Focused)
            {
                return;
            }

            var textPosition = LastStationBox.SelectionStart;

            LastStationBox.Items.Clear();
            LastStationBox.Items.Add(LastStationText);
            LastStationBox.Items.Add("*****");
            LastStationBox.Items.AddRange(e.Stations.StationList.ToArray());
            LastStationBox.DroppedDown = true;

            LastStationBox.Select(textPosition, 0);
        }

        /// <summary>
        /// Open Google Maps in the default browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenGoogleMaps(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkLabel = (LinkLabel)sender;
            var stationName = "";

            if (linkLabel.Name == this.llbFrom.Name)
            {
                stationName = cmbFrom.Text;
            }
            else
            {
                stationName = cmbTo.Text;
            }

            this.llbFrom.LinkVisited = true;
            var stations = Transport.GetStations(stationName);
            var station = stations.StationList.Find(x => x.Name == stationName);

            try
            {
                System.Diagnostics.Process.Start("https://www.google.ch/maps/place/" + station.Coordinate.XCoordinate + "," + station.Coordinate.YCoordinate + "/data=!3m1!1e3");
            }
            catch
            {
                MessageBox.Show($"Google Maps can't be opend right now.{Environment.NewLine}Please check your input and try again.", "Cant open Google maps", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Open new Mail form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMail_Click(object sender, EventArgs e)
        {
            if (this.CurrentConnections == null)
            {
                MessageBox.Show("There were no connections searched. Please search a connection first.", "No connection searched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var mail = new Mail(this);
            mail.ShowDialog();
        }

        /// <summary>
        /// Load the statioboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchStationboard_Click(object sender, EventArgs e)
        {
            UpdateStatusStrip("Loading");
            Cursor = Cursors.WaitCursor;
            lsvStationboard.Items.Clear();
            var stations = Transport.GetStations(cmbStationboard.Text);

            if (stations.StationList.Count != 1)
            {
                MessageBox.Show("Station cant be found.", "Station not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var stationboard = Transport.GetStationBoard(stations.StationList[0].Name, stations.StationList[0].Id);

            FillStationList(stationboard);
        }

        /// <summary>
        /// Displays the nearest connections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchNearestStations_Click(object sender, EventArgs e)
        {
            UpdateStatusStrip("Loading");
            Cursor = Cursors.WaitCursor;
            lsvNearestStations.Items.Clear();

            var stations = Transport.GetStations(cmbCurrentAddress.Text);

            if (stations.StationList.Count != 1)
            {
                MessageBox.Show("Location can't be found.", "Location not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nearStations = Transport.GetStations(stations.StationList[0].Coordinate.XCoordinate, stations.StationList[0].Coordinate.YCoordinate);
            FillNearestStationsList(nearStations);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Displaying the Connections returned by the API to the ListView
        /// </summary>
        /// <param name="connections">Connections object</param>
        private void FillConnectionList()
        {
            foreach (var connection in CurrentConnections.ConnectionList)
            {
                var subitems = new[] {
                    connection.From.Station.Name,
                    DateTime.Parse(connection.From.Departure).ToShortTimeString(),
                    (connection.From.Platform!="") ?connection.From.Platform: "Bus station",
                    connection.To.Station.Name,
                    DateTime.Parse(connection.To.Arrival).ToShortTimeString(),
                    (connection.To.Platform != "") ? connection.To.Platform:"Bus station",
                // Duration gets delivered in the Following Format: 00d11:22:33, where the 0=d, 1=h, 2=m and 3=s
                // https://msdn.microsoft.com/en-us/library/ee372286(v=vs.110).aspx
                    TimeSpan.ParseExact(connection.Duration, @"dd\dhh\:mm\:ss", null).ToString(@"hh\:mm"),
                };
                var item = new ListViewItem(subitems);
                lsvConnections.Items.Add(item);
            }
            Cursor = Cursors.Default;
            UpdateStatusStrip("Ready");
        }

        /// <summary>
        /// Load the stationboard ListView
        /// </summary>
        /// <param name="stationboard"></param>
        private void FillStationList(StationBoardRoot stationboard)
        {
            foreach (var entry in stationboard.Entries)
            {
                var subitems = new[]
                {
                    stationboard.Station.Name,
                    entry.Stop.Departure.ToShortTimeString(),
                    entry.To
                };
                var item = new ListViewItem(subitems);
                lsvStationboard.Items.Add(item);
            }
            Cursor = Cursors.Default;
            UpdateStatusStrip("Ready");
        }

        /// <summary>
        /// Load the stations in the ListView for the nearest stations
        /// </summary>
        /// <param name="stations"></param>
        private void FillNearestStationsList(Stations stations)
        {
            foreach (var station in stations.StationList)
            {
                var subitems = new[] {
                    station.Name,
                    station.Distance.ToString()
                };
                var item = new ListViewItem(subitems);
                lsvNearestStations.Items.Add(item);
            }
            Cursor = Cursors.Default;
            UpdateStatusStrip("Ready");
        }

        private void UpdateStatusStrip(string status)
        {
            tslStatus.Text = status;
            tslStatusStationboards.Text = status;
            tslStatusNearest.Text = status;
        }

        #endregion

    }

    /// <summary>
    /// The Event Args passed to the <see cref="PublicTransport.AutoCompleteLoaded"/> Event.
    /// </summary>
    class AutocompleteEventArgs : EventArgs
    {
        public Stations Stations { get; set; }
    }
}
