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
    public partial class Form1 : Form
    {
        #region Constructors & Initialize
        private Transport Transport { get; } = new Transport();
        private Timer AutocompleteTimer { get; }
        private string LastStationText { get; set; }
        private ComboBox LastStationBox { get; set; }

        public Form1()
        {
            InitializeComponent();
            //
            AutocompleteTimer = new Timer
            {
                Interval = 500
            };
            AutocompleteTimer.Tick += AutocompleteTimer_Tick;
            AutoCompleteLoaded += this_AutoComplete;

            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "HH:mm";
            dtpTime.ShowUpDown = true;
        }

        #endregion

        #region Events

        private delegate void AutoCompleteEventHandler(object sender, AutocompleteEventArgs e);
        private event AutoCompleteEventHandler AutoCompleteLoaded;

        private void AutocompleteTimer_Tick(object sender, EventArgs e)
        {
            AutocompleteTimer.Stop();
            //todo method call loadStations
            AutoCompleteLoaded(this, new AutocompleteEventArgs { stations = null });
        }

        /// <summary>
        /// Search Connections and input validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            lsvConnections.Items.Clear();
            var placeOfDeparture = cmbFrom.Text ?? "";
            var destination = cmbTo.Text ?? "";
            var date = dtpDate.Value; //DateTime.ParseExact(dtpDate.Value.ToString(), @"dd\.MM\.yyyy\ hh\:mm\:ss", null).ToString(@"yyyy\-MM\-\dd\T");
            var time = dtpTime.Value;
            //todo error handling
            //"2016-05-25T15:55:00+0200"
            Connections connections = Transport.GetConnections(placeOfDeparture, destination);

            FillListView(connections);
        }

        private void cmbStationSearch_TextChanged(object sender, EventArgs e)
        {
            AutocompleteTimer.Stop();
            AutocompleteTimer.Start();
        }

        private void this_AutoComplete(object sender, AutocompleteEventArgs e)
        {
            Console.WriteLine("Completed till here");
            //cmb abfüllen
        }

        #endregion

        #region Methods

        /// <summary>
        /// displaying the Connections returned by the API to the ListView
        /// </summary>
        /// <param name="connections">Connections object</param>
        private void FillListView(Connections connections)
        {
            foreach (var connection in connections.ConnectionList)
            {
                var subitems = new[] {
                    connection.From.Station.Name,
                    DateTime.Parse(connection.From.Departure).ToShortTimeString(),
                    connection.From.Platform,
                    connection.To.Station.Name,
                    DateTime.Parse(connection.To.Arrival).ToShortTimeString(),
                    connection.To.Platform,
                // Duration gets delivered in the Following Format: 00d11:22:33, where the 0=d, 1=h, 2=m and 3=s
                // https://msdn.microsoft.com/en-us/library/ee372286(v=vs.110).aspx
                    TimeSpan.ParseExact(connection.Duration, @"dd\dhh\:mm\:ss", null).ToString(@"hh\:mm"),
                };
                var item = new ListViewItem(subitems);
                lsvConnections.Items.Add(item);
            }
        }

        private void GetAutocomplete()
        {

        }

        #endregion
    }
    class AutocompleteEventArgs : EventArgs
    {
        public Stations stations { get; set; }
    }
}
