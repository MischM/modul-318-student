using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Net;
using System.Text.RegularExpressions;

namespace PublicTransportApp
{
    public partial class Mail : Form
    {
        private Connections Connections { get; set; }
        private const string MailRegex = @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b";

        public Mail(PublicTransport currentForm)
        {
            InitializeComponent();
            Connections = currentForm.CurrentConnections;
            FillComboBox();
        }

        #region Events
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (ValidateMailForm())
            {

                var fromAddress = new MailAddress(txtMailAddress.Text, "PublicTransport Transport App");
                var toAddress = new MailAddress(txtRecipient.Text);
                MailMessage mail = new MailMessage(fromAddress, toAddress);
                var host = (ComboBoxItem)cmbHost.SelectedItem;

                var client = new SmtpClient
                {
                    Host = "smtp." + host.Value + ".com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, txtPassword.Text)
                };

                mail.Subject = txtSubject.Text;
                mail.Body = txtMessage.Text + Environment.NewLine;
                foreach (var connection in Connections.ConnectionList)
                {
                    mail.Body += string.Format(
                       "From: {0} Departure time: {1} Platform: {2} To: {3} Arrival time: {4} Arrival platform: {5} Duration{6}" + Environment.NewLine,
                       connection.From.Station.Name,
                       DateTime.Parse(connection.From.Departure).ToShortTimeString(),
                       connection.From.Platform,
                       connection.To.Station.Name,
                       DateTime.Parse(connection.To.Arrival).ToShortTimeString(),
                       connection.To.Platform,
                       TimeSpan.ParseExact(connection.Duration, @"dd\dhh\:mm\:ss", null).ToString(@"hh\:mm")
                       );
                }

                try
                {
                    client.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("Mail sent");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Methods
        private bool ValidateMailForm()
        {
            if (string.IsNullOrEmpty(txtMailAddress.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtRecipient.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Missing information");
                return false;
            }
            else if (!Regex.IsMatch(txtMailAddress.Text, MailRegex) || !Regex.IsMatch(txtRecipient.Text, MailRegex))
            {
                MessageBox.Show($"Please insert a valid eMail address.{Environment.NewLine}Exampe: abc_123@transport_123.info", "Invalid eMail address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void FillComboBox()
        {
            cmbHost.Items.Add(new ComboBoxItem("Gmail", "gmail"));
            cmbHost.Items.Add(new ComboBoxItem("Hotmail", "live"));
            cmbHost.Items.Add(new ComboBoxItem("Outlook", "live"));
            cmbHost.Items.Add(new ComboBoxItem("Bluewin", "live"));
            cmbHost.SelectedIndex = 0;
        }
        #endregion
    }

    public class ComboBoxItem
    {
        public ComboBoxItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
