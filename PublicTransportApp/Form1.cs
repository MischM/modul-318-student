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
        private Transport Transport { get; } = new Transport();

        public Form1()
        {
            InitializeComponent();
            //
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "HH:mm";
            dtpTime.ShowUpDown = true;
        }

        private AutoCompleteStringCollection GetStationAutoComplete(string text)
        {
            var stations = Transport.GetStations(text);
            var autoCompleteList = new AutoCompleteStringCollection();
            foreach (var station in stations.StationList)
            {
                autoCompleteList.Add(station.Name);
            }

            return autoCompleteList;
        }

        /// <summary>
        /// Search Connections and input validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            lsvConnections.Items.Clear();
            var placeOfDeparture = txtFrom.Text ?? "";
            var destination = txtTo.Text ?? "";
            var date = dtpDate.Value; //DateTime.ParseExact(dtpDate.Value.ToString(), @"dd\.MM\.yyyy\ hh\:mm\:ss", null).ToString(@"yyyy\-MM\-\dd\T");
            var time = dtpTime.Value;
            //todo error handling
            //"2016-05-25T15:55:00+0200"
            Connections connections = Transport.GetConnections(placeOfDeparture, destination);

            FillListView(connections);
        }

        /// <summary>
        /// displaying the Connections returned by the API to the ListView
        /// </summary>
        /// <param name="connections">Connections object</param>
        private void FillListView(Connections connections)
        {
            foreach (var connection in connections.ConnectionList)
            {
                var item = new ListViewItem(DateTime.Parse(connection.From.Departure).ToShortTimeString());
                item.SubItems.Add(DateTime.Parse(connection.To.Arrival).ToShortTimeString());
                // Duration gets delivered in the Following Format: 00d11:22:33, where the 0=d, 1=h, 2=m and 3=s
                // https://msdn.microsoft.com/en-us/library/ee372286(v=vs.110).aspx
                item.SubItems.Add(TimeSpan.ParseExact(connection.Duration, @"dd\dhh\:mm\:ss", null).ToString(@"hh\:mm"));
                item.SubItems.Add(connection.From.Platform);
                item.SubItems.Add(connection.To.Platform);

                lsvConnections.Items.Add(item);
            }
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            //txtFrom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //txtFrom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection stringcol = new AutoCompleteStringCollection();
        }
    }
}
