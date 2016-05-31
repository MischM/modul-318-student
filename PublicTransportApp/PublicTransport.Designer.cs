namespace PublicTransportApp
{
    partial class PublicTransport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicTransport));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.btnNearestStation = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.llbTo = new System.Windows.Forms.LinkLabel();
            this.llbFrom = new System.Windows.Forms.LinkLabel();
            this.rdbArrival = new System.Windows.Forms.RadioButton();
            this.rdbDeparture = new System.Windows.Forms.RadioButton();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lsvConnections = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabStation = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnSearchStationboard = new System.Windows.Forms.Button();
            this.cmbStationboard = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lsvStationboard = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslStatusStationboards = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabNearestStation = new System.Windows.Forms.TabPage();
            this.cmbCurrentAddress = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNearestStation = new System.Windows.Forms.TextBox();
            this.btnSearchNearestStations = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.tabStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabNearestStation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStart);
            this.tabControl1.Controls.Add(this.tabConnection);
            this.tabControl1.Controls.Add(this.tabStation);
            this.tabControl1.Controls.Add(this.tabNearestStation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 613);
            this.tabControl1.TabIndex = 1;
            // 
            // tabStart
            // 
            this.tabStart.Controls.Add(this.btnNearestStation);
            this.tabStart.Controls.Add(this.label9);
            this.tabStart.Controls.Add(this.label8);
            this.tabStart.Controls.Add(this.pictureBox1);
            this.tabStart.Location = new System.Drawing.Point(4, 22);
            this.tabStart.Name = "tabStart";
            this.tabStart.Size = new System.Drawing.Size(675, 587);
            this.tabStart.TabIndex = 2;
            this.tabStart.Text = "Start";
            this.tabStart.UseVisualStyleBackColor = true;
            // 
            // btnNearestStation
            // 
            this.btnNearestStation.Location = new System.Drawing.Point(467, 71);
            this.btnNearestStation.Name = "btnNearestStation";
            this.btnNearestStation.Size = new System.Drawing.Size(200, 29);
            this.btnNearestStation.TabIndex = 3;
            this.btnNearestStation.Text = "Find nearest station";
            this.btnNearestStation.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(625, 39);
            this.label9.TabIndex = 2;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(224, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Public transport app";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.splitContainer1);
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnection.Size = new System.Drawing.Size(675, 587);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Search Connection";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.llbTo);
            this.splitContainer1.Panel1.Controls.Add(this.llbFrom);
            this.splitContainer1.Panel1.Controls.Add(this.rdbArrival);
            this.splitContainer1.Panel1.Controls.Add(this.rdbDeparture);
            this.splitContainer1.Panel1.Controls.Add(this.cmbTo);
            this.splitContainer1.Panel1.Controls.Add(this.cmbFrom);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearchConnection);
            this.splitContainer1.Panel1.Controls.Add(this.dtpTime);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDate);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSendMail);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip2);
            this.splitContainer1.Panel2.Controls.Add(this.lsvConnections);
            this.splitContainer1.Size = new System.Drawing.Size(669, 581);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // llbTo
            // 
            this.llbTo.AutoSize = true;
            this.llbTo.Location = new System.Drawing.Point(310, 104);
            this.llbTo.Name = "llbTo";
            this.llbTo.Size = new System.Drawing.Size(115, 13);
            this.llbTo.TabIndex = 15;
            this.llbTo.TabStop = true;
            this.llbTo.Text = "Show on Google Maps";
            this.llbTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenGoogleMaps);
            // 
            // llbFrom
            // 
            this.llbFrom.AutoSize = true;
            this.llbFrom.Location = new System.Drawing.Point(310, 63);
            this.llbFrom.Name = "llbFrom";
            this.llbFrom.Size = new System.Drawing.Size(115, 13);
            this.llbFrom.TabIndex = 14;
            this.llbFrom.TabStop = true;
            this.llbFrom.Text = "Show on Google Maps";
            this.llbFrom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenGoogleMaps);
            // 
            // rdbArrival
            // 
            this.rdbArrival.AutoSize = true;
            this.rdbArrival.Location = new System.Drawing.Point(177, 206);
            this.rdbArrival.Name = "rdbArrival";
            this.rdbArrival.Size = new System.Drawing.Size(54, 17);
            this.rdbArrival.TabIndex = 13;
            this.rdbArrival.Text = "Arrival";
            this.rdbArrival.UseVisualStyleBackColor = true;
            // 
            // rdbDeparture
            // 
            this.rdbDeparture.AutoSize = true;
            this.rdbDeparture.Checked = true;
            this.rdbDeparture.Location = new System.Drawing.Point(177, 183);
            this.rdbDeparture.Name = "rdbDeparture";
            this.rdbDeparture.Size = new System.Drawing.Size(72, 17);
            this.rdbDeparture.TabIndex = 12;
            this.rdbDeparture.TabStop = true;
            this.rdbDeparture.Text = "Departure";
            this.rdbDeparture.UseVisualStyleBackColor = true;
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(86, 101);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(200, 21);
            this.cmbTo.TabIndex = 1;
            this.cmbTo.TextChanged += new System.EventHandler(this.cmbStationSearch_TextChanged);
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(86, 60);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(200, 21);
            this.cmbFrom.TabIndex = 0;
            this.cmbFrom.TextChanged += new System.EventHandler(this.cmbStationSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time";
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchConnection.Location = new System.Drawing.Point(469, 215);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(200, 29);
            this.btnSearchConnection.TabIndex = 4;
            this.btnSearchConnection.Text = "Search Connection";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.btnSearchConnection_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(86, 179);
            this.dtpTime.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(61, 20);
            this.dtpTime.TabIndex = 3;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(86, 140);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(287, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection";
            // 
            // btnSendMail
            // 
            this.btnSendMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMail.Location = new System.Drawing.Point(548, 285);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(116, 21);
            this.btnSendMail.TabIndex = 16;
            this.btnSendMail.Text = "Send per Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tslStatus});
            this.statusStrip2.Location = new System.Drawing.Point(0, 309);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(669, 22);
            this.statusStrip2.TabIndex = 1;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(573, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel2.Text = "Status:";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(39, 17);
            this.tslStatus.Text = "Ready";
            // 
            // lsvConnections
            // 
            this.lsvConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.lsvConnections.Location = new System.Drawing.Point(0, 0);
            this.lsvConnections.Name = "lsvConnections";
            this.lsvConnections.Size = new System.Drawing.Size(664, 279);
            this.lsvConnections.TabIndex = 0;
            this.lsvConnections.UseCompatibleStateImageBehavior = false;
            this.lsvConnections.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "From";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Departure time";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Departure platform";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "To";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Arrival time";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 6;
            this.columnHeader3.Text = "Duration";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 5;
            this.columnHeader5.Text = "Arrival platform";
            this.columnHeader5.Width = 100;
            // 
            // tabStation
            // 
            this.tabStation.Controls.Add(this.splitContainer2);
            this.tabStation.Controls.Add(this.statusStrip1);
            this.tabStation.Location = new System.Drawing.Point(4, 22);
            this.tabStation.Name = "tabStation";
            this.tabStation.Padding = new System.Windows.Forms.Padding(3);
            this.tabStation.Size = new System.Drawing.Size(675, 587);
            this.tabStation.TabIndex = 1;
            this.tabStation.Text = "Search Station";
            this.tabStation.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnSearchStationboard);
            this.splitContainer2.Panel1.Controls.Add(this.cmbStationboard);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lsvStationboard);
            this.splitContainer2.Size = new System.Drawing.Size(669, 559);
            this.splitContainer2.SplitterDistance = 278;
            this.splitContainer2.TabIndex = 5;
            // 
            // btnSearchStationboard
            // 
            this.btnSearchStationboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchStationboard.Location = new System.Drawing.Point(464, 87);
            this.btnSearchStationboard.Name = "btnSearchStationboard";
            this.btnSearchStationboard.Size = new System.Drawing.Size(200, 29);
            this.btnSearchStationboard.TabIndex = 3;
            this.btnSearchStationboard.Text = "Search";
            this.btnSearchStationboard.UseVisualStyleBackColor = true;
            this.btnSearchStationboard.Click += new System.EventHandler(this.btnSearchStationboard_Click);
            // 
            // cmbStationboard
            // 
            this.cmbStationboard.FormattingEnabled = true;
            this.cmbStationboard.Location = new System.Drawing.Point(86, 60);
            this.cmbStationboard.Name = "cmbStationboard";
            this.cmbStationboard.Size = new System.Drawing.Size(200, 21);
            this.cmbStationboard.TabIndex = 2;
            this.cmbStationboard.TextChanged += new System.EventHandler(this.cmbStationSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(258, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Stationboards";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Station";
            // 
            // lsvStationboard
            // 
            this.lsvStationboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader15});
            this.lsvStationboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvStationboard.Location = new System.Drawing.Point(0, 0);
            this.lsvStationboard.Name = "lsvStationboard";
            this.lsvStationboard.Size = new System.Drawing.Size(669, 277);
            this.lsvStationboard.TabIndex = 1;
            this.lsvStationboard.UseCompatibleStateImageBehavior = false;
            this.lsvStationboard.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "From";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Departure time";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "To";
            this.columnHeader15.Width = 200;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.tslStatusStationboards});
            this.statusStrip1.Location = new System.Drawing.Point(3, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(669, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(573, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel4.Text = "Status:";
            // 
            // tslStatusStationboards
            // 
            this.tslStatusStationboards.Name = "tslStatusStationboards";
            this.tslStatusStationboards.Size = new System.Drawing.Size(39, 17);
            this.tslStatusStationboards.Text = "Ready";
            // 
            // tabNearestStation
            // 
            this.tabNearestStation.Controls.Add(this.cmbCurrentAddress);
            this.tabNearestStation.Controls.Add(this.label12);
            this.tabNearestStation.Controls.Add(this.txtNearestStation);
            this.tabNearestStation.Controls.Add(this.btnSearchNearestStations);
            this.tabNearestStation.Controls.Add(this.label11);
            this.tabNearestStation.Controls.Add(this.label10);
            this.tabNearestStation.Location = new System.Drawing.Point(4, 22);
            this.tabNearestStation.Name = "tabNearestStation";
            this.tabNearestStation.Padding = new System.Windows.Forms.Padding(3);
            this.tabNearestStation.Size = new System.Drawing.Size(675, 587);
            this.tabNearestStation.TabIndex = 3;
            this.tabNearestStation.Text = "Search Nearest Station";
            this.tabNearestStation.UseVisualStyleBackColor = true;
            // 
            // cmbCurrentAddress
            // 
            this.cmbCurrentAddress.FormattingEnabled = true;
            this.cmbCurrentAddress.Location = new System.Drawing.Point(107, 60);
            this.cmbCurrentAddress.Name = "cmbCurrentAddress";
            this.cmbCurrentAddress.Size = new System.Drawing.Size(200, 21);
            this.cmbCurrentAddress.TabIndex = 7;
            this.cmbCurrentAddress.TextChanged += new System.EventHandler(this.cmbStationSearch_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LimeGreen;
            this.label12.Location = new System.Drawing.Point(258, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 29);
            this.label12.TabIndex = 6;
            this.label12.Text = "Nearest stations";
            // 
            // txtNearestStation
            // 
            this.txtNearestStation.Location = new System.Drawing.Point(107, 122);
            this.txtNearestStation.Name = "txtNearestStation";
            this.txtNearestStation.ReadOnly = true;
            this.txtNearestStation.Size = new System.Drawing.Size(200, 20);
            this.txtNearestStation.TabIndex = 3;
            // 
            // btnSearchNearestStations
            // 
            this.btnSearchNearestStations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchNearestStations.Location = new System.Drawing.Point(351, 57);
            this.btnSearchNearestStations.Name = "btnSearchNearestStations";
            this.btnSearchNearestStations.Size = new System.Drawing.Size(75, 23);
            this.btnSearchNearestStations.TabIndex = 5;
            this.btnSearchNearestStations.Text = "Search";
            this.btnSearchNearestStations.UseVisualStyleBackColor = true;
            this.btnSearchNearestStations.Click += new System.EventHandler(this.btnSearchNearestStations_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nearest station:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Current address";
            // 
            // PublicTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 613);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PublicTransport";
            this.Text = "Public Transport App";
            this.tabControl1.ResumeLayout(false);
            this.tabStart.ResumeLayout(false);
            this.tabStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabConnection.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.tabStation.ResumeLayout(false);
            this.tabStation.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabNearestStation.ResumeLayout(false);
            this.tabNearestStation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.TabPage tabStation;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.ListView lsvConnections;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnSearchStationboard;
        private System.Windows.Forms.ComboBox cmbStationboard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tslStatusStationboards;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lsvStationboard;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.RadioButton rdbArrival;
        private System.Windows.Forms.RadioButton rdbDeparture;
        private System.Windows.Forms.LinkLabel llbTo;
        private System.Windows.Forms.LinkLabel llbFrom;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNearestStation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabNearestStation;
        private System.Windows.Forms.Button btnSearchNearestStations;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNearestStation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCurrentAddress;
    }
}

