namespace PublicTransportApp
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvConnections = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabStation = new System.Windows.Forms.TabPage();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStart);
            this.tabControl1.Controls.Add(this.tabConnection);
            this.tabControl1.Controls.Add(this.tabStation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 559);
            this.tabControl1.TabIndex = 1;
            // 
            // tabStart
            // 
            this.tabStart.Location = new System.Drawing.Point(4, 22);
            this.tabStart.Name = "tabStart";
            this.tabStart.Size = new System.Drawing.Size(685, 533);
            this.tabStart.TabIndex = 2;
            this.tabStart.Text = "Start";
            this.tabStart.UseVisualStyleBackColor = true;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.splitContainer1);
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnection.Size = new System.Drawing.Size(685, 533);
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
            this.splitContainer1.Panel2.Controls.Add(this.lsvConnections);
            this.splitContainer1.Size = new System.Drawing.Size(679, 527);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time";
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(431, 194);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(200, 29);
            this.btnSearchConnection.TabIndex = 4;
            this.btnSearchConnection.Text = "Search Connection";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.btnSearchConnection_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(431, 140);
            this.dtpTime.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 20);
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
            this.label4.Location = new System.Drawing.Point(21, 146);
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
            // lsvConnections
            // 
            this.lsvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvConnections.Location = new System.Drawing.Point(0, 0);
            this.lsvConnections.Name = "lsvConnections";
            this.lsvConnections.Size = new System.Drawing.Size(679, 297);
            this.lsvConnections.TabIndex = 0;
            this.lsvConnections.UseCompatibleStateImageBehavior = false;
            this.lsvConnections.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "From";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Departure time";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 3;
            this.columnHeader7.Text = "To";
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 4;
            this.columnHeader2.Text = "Arrival time";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 6;
            this.columnHeader3.Text = "Duration";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 2;
            this.columnHeader4.Text = "Departure platform";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 5;
            this.columnHeader5.Text = "Arrival platform";
            this.columnHeader5.Width = 100;
            // 
            // tabStation
            // 
            this.tabStation.Location = new System.Drawing.Point(4, 22);
            this.tabStation.Name = "tabStation";
            this.tabStation.Padding = new System.Windows.Forms.Padding(3);
            this.tabStation.Size = new System.Drawing.Size(685, 533);
            this.tabStation.TabIndex = 1;
            this.tabStation.Text = "Search Station";
            this.tabStation.UseVisualStyleBackColor = true;
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
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(86, 101);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(200, 21);
            this.cmbTo.TabIndex = 1;
            this.cmbTo.TextChanged += new System.EventHandler(this.cmbStationSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 559);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Public Transport App";
            this.tabControl1.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
    }
}

