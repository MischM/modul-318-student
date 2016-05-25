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
        public Form1()
        {
            InitializeComponent();
            //
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "HH:mm";
            dtpTime.ShowUpDown = true;

            //lsvConnections.Columns.Add("From");
            //lsvConnections.Columns.Add("To");
            lsvConnections.Columns.Add("Departure time");
            lsvConnections.Columns.Add("Arrival time");
            lsvConnections.Columns.Add("Duration");
            lsvConnections.Columns.Add("Departure platform");
            lsvConnections.Columns.Add("Arrival platform");
        }

        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            lsvConnections.Items.Clear();
            var placeOfDeparture = txtFrom.Text ?? "";
            var destination = txtTo.Text ?? "";
            var date = dtpDate.Value;
            var time = dtpTime.Value;

            var transport = new Transport();
            Connections connections = transport.GetConnections(placeOfDeparture, destination);

            FillListView(connections);
        }

        private void FillListView(Connections connections)
        {
            foreach (var con in connections.ConnectionList)
            {
                var item = new ListViewItem(con.From.Departure);
                item.SubItems.Add(con.To.Arrival);
                item.SubItems.Add(con.Duration);
                item.SubItems.Add(con.From.Platform);
                item.SubItems.Add(con.To.Platform);

                lsvConnections.Items.Add(item);
            }
        }
    }
}
