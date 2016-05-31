﻿using System;
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

namespace PublicTransportApp
{
    public partial class Mail : Form
    {
        private Connections connections { get; set; }

        public Mail(PublicTransport currentForm)
        {
            InitializeComponent();
            connections = currentForm.CurrentConnections;
            FillComboBox();
        }

        #region Events
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (ValidateMailForm())
            {
                try
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
                    foreach (var connection in connections.ConnectionList)
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

                    client.Send(mail);
                    MessageBox.Show("Mail sent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            return true;
        }

        private void FillComboBox()
        {
            cmbHost.Items.Add(new ComboBoxItem("Outlook", "live"));
            cmbHost.Items.Add(new ComboBoxItem("Hotmail", "live"));
            cmbHost.Items.Add(new ComboBoxItem("Bluewin", "live"));
            cmbHost.Items.Add(new ComboBoxItem("GMail", "gmail"));
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
