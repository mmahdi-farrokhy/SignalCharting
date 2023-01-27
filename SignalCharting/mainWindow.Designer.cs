using System.Windows.Forms;

namespace SignalCharting
{
    partial class mainWindow
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
        /// 

        private void resetChannels()
        {
            channel1.Items.Clear();
            channel2.Items.Clear();
            channel3.Items.Clear();
            channel4.Items.Clear();
            channel5.Items.Clear();

            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            chart5.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            channel1.Text = "";
            channel2.Text = "";
            channel3.Text = "";
            channel4.Text = "";
            channel5.Text = "";
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.browseButton = new System.Windows.Forms.Button();
            this.sampleRateLabel = new System.Windows.Forms.Label();
            this.channel1 = new System.Windows.Forms.ComboBox();
            this.rate = new System.Windows.Forms.TextBox();
            this.Channel1Label = new System.Windows.Forms.Label();
            this.Channel2Label = new System.Windows.Forms.Label();
            this.channel2 = new System.Windows.Forms.ComboBox();
            this.Channel4Label = new System.Windows.Forms.Label();
            this.channel4 = new System.Windows.Forms.ComboBox();
            this.Channel3Label = new System.Windows.Forms.Label();
            this.channel3 = new System.Windows.Forms.ComboBox();
            this.Channel5Label = new System.Windows.Forms.Label();
            this.channel5 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.changeSampleRate = new System.Windows.Forms.Button();
            this.phoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.medicalFileNumber = new System.Windows.Forms.MaskedTextBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.addressLabel = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.MaskedTextBox();
            this.enabledEditing = new System.Windows.Forms.CheckBox();
            this.choosePatientButton = new System.Windows.Forms.Button();
            this.saveEditButton = new System.Windows.Forms.Button();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.MaskedTextBox();
            this.medicalFileNumberLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.channelPanel = new System.Windows.Forms.Panel();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.patientsList = new System.Windows.Forms.DataGridView();
            this.tablePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.chartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsList)).BeginInit();
            this.tablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(31, 37);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(195, 28);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse .txt File";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // sampleRateLabel
            // 
            this.sampleRateLabel.AutoSize = true;
            this.sampleRateLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sampleRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleRateLabel.Location = new System.Drawing.Point(338, 25);
            this.sampleRateLabel.Name = "sampleRateLabel";
            this.sampleRateLabel.Size = new System.Drawing.Size(120, 17);
            this.sampleRateLabel.TabIndex = 1;
            this.sampleRateLabel.Text = "Sample Rate (Hz)";
            // 
            // channel1
            // 
            this.channel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.channel1.FormattingEnabled = true;
            this.channel1.Location = new System.Drawing.Point(489, 45);
            this.channel1.Name = "channel1";
            this.channel1.Size = new System.Drawing.Size(70, 23);
            this.channel1.TabIndex = 4;
            this.channel1.Tag = "1";
            this.channel1.SelectedIndexChanged += new System.EventHandler(this.channel1_SelectedIndexChanged);
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(341, 45);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(100, 20);
            this.rate.TabIndex = 3;
            this.rate.Text = "500";
            this.rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Channel1Label
            // 
            this.Channel1Label.AutoSize = true;
            this.Channel1Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Channel1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Channel1Label.Location = new System.Drawing.Point(486, 25);
            this.Channel1Label.Name = "Channel1Label";
            this.Channel1Label.Size = new System.Drawing.Size(72, 17);
            this.Channel1Label.TabIndex = 4;
            this.Channel1Label.Tag = "1";
            this.Channel1Label.Text = "Channel 1";
            // 
            // Channel2Label
            // 
            this.Channel2Label.AutoSize = true;
            this.Channel2Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Channel2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Channel2Label.Location = new System.Drawing.Point(601, 25);
            this.Channel2Label.Name = "Channel2Label";
            this.Channel2Label.Size = new System.Drawing.Size(72, 17);
            this.Channel2Label.TabIndex = 6;
            this.Channel2Label.Tag = "2";
            this.Channel2Label.Text = "Channel 2";
            // 
            // channel2
            // 
            this.channel2.FormattingEnabled = true;
            this.channel2.Location = new System.Drawing.Point(604, 47);
            this.channel2.Name = "channel2";
            this.channel2.Size = new System.Drawing.Size(70, 21);
            this.channel2.TabIndex = 5;
            this.channel2.Tag = "2";
            this.channel2.SelectedIndexChanged += new System.EventHandler(this.channel2_SelectedIndexChanged);
            // 
            // Channel4Label
            // 
            this.Channel4Label.AutoSize = true;
            this.Channel4Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Channel4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Channel4Label.Location = new System.Drawing.Point(830, 24);
            this.Channel4Label.Name = "Channel4Label";
            this.Channel4Label.Size = new System.Drawing.Size(72, 17);
            this.Channel4Label.TabIndex = 10;
            this.Channel4Label.Tag = "4";
            this.Channel4Label.Text = "Channel 4";
            // 
            // channel4
            // 
            this.channel4.FormattingEnabled = true;
            this.channel4.Location = new System.Drawing.Point(833, 47);
            this.channel4.Name = "channel4";
            this.channel4.Size = new System.Drawing.Size(70, 21);
            this.channel4.TabIndex = 9;
            this.channel4.Tag = "4";
            this.channel4.SelectedIndexChanged += new System.EventHandler(this.channel4_SelectedIndexChanged);
            // 
            // Channel3Label
            // 
            this.Channel3Label.AutoSize = true;
            this.Channel3Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Channel3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Channel3Label.Location = new System.Drawing.Point(715, 24);
            this.Channel3Label.Name = "Channel3Label";
            this.Channel3Label.Size = new System.Drawing.Size(72, 17);
            this.Channel3Label.TabIndex = 8;
            this.Channel3Label.Tag = "3";
            this.Channel3Label.Text = "Channel 3";
            // 
            // channel3
            // 
            this.channel3.FormattingEnabled = true;
            this.channel3.Location = new System.Drawing.Point(718, 47);
            this.channel3.Name = "channel3";
            this.channel3.Size = new System.Drawing.Size(70, 21);
            this.channel3.TabIndex = 7;
            this.channel3.Tag = "3";
            this.channel3.SelectedIndexChanged += new System.EventHandler(this.channel3_SelectedIndexChanged);
            // 
            // Channel5Label
            // 
            this.Channel5Label.AutoSize = true;
            this.Channel5Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Channel5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Channel5Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Channel5Label.Location = new System.Drawing.Point(947, 25);
            this.Channel5Label.Name = "Channel5Label";
            this.Channel5Label.Size = new System.Drawing.Size(72, 17);
            this.Channel5Label.TabIndex = 12;
            this.Channel5Label.Tag = "5";
            this.Channel5Label.Text = "Channel 5";
            // 
            // channel5
            // 
            this.channel5.FormattingEnabled = true;
            this.channel5.Location = new System.Drawing.Point(950, 46);
            this.channel5.Name = "channel5";
            this.channel5.Size = new System.Drawing.Size(70, 21);
            this.channel5.TabIndex = 11;
            this.channel5.Tag = "5";
            this.channel5.SelectedIndexChanged += new System.EventHandler(this.channel5_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "CA1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 18F;
            legend1.Position.Width = 6.565988F;
            legend1.Position.X = 50F;
            legend1.Position.Y = 82F;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "CA1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Amplitude";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1524, 143);
            this.chart1.TabIndex = 13;
            this.chart1.Tag = "1";
            this.chart1.Visible = false;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.Name = "CA2";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(18, 354);
            this.chart2.Name = "chart2";
            series2.ChartArea = "CA2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Amplitude";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1524, 143);
            this.chart2.TabIndex = 14;
            this.chart2.Tag = "2";
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            // 
            // chart4
            // 
            this.chart4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.Name = "CA4";
            this.chart4.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart4.Legends.Add(legend3);
            this.chart4.Location = new System.Drawing.Point(18, 658);
            this.chart4.Name = "chart4";
            series3.ChartArea = "CA4";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Amplitude";
            this.chart4.Series.Add(series3);
            this.chart4.Size = new System.Drawing.Size(1524, 143);
            this.chart4.TabIndex = 16;
            this.chart4.Tag = "4";
            this.chart4.Text = "chart3";
            this.chart4.Visible = false;
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea4.CursorX.IsUserSelectionEnabled = true;
            chartArea4.Name = "CA3";
            this.chart3.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart3.Legends.Add(legend4);
            this.chart3.Location = new System.Drawing.Point(18, 506);
            this.chart3.Name = "chart3";
            series4.ChartArea = "CA3";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.Name = "Amplitude";
            this.chart3.Series.Add(series4);
            this.chart3.Size = new System.Drawing.Size(1524, 143);
            this.chart3.TabIndex = 15;
            this.chart3.Tag = "3";
            this.chart3.Visible = false;
            // 
            // chart5
            // 
            this.chart5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea5.CursorX.IsUserSelectionEnabled = true;
            chartArea5.Name = "CA5";
            this.chart5.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chart5.Legends.Add(legend5);
            this.chart5.Location = new System.Drawing.Point(18, 811);
            this.chart5.Name = "chart5";
            series5.ChartArea = "CA5";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.Legend = "Legend1";
            series5.Name = "Amplitude";
            this.chart5.Series.Add(series5);
            this.chart5.Size = new System.Drawing.Size(1524, 143);
            this.chart5.TabIndex = 17;
            this.chart5.Tag = "5";
            this.chart5.Text = "chart5";
            this.chart5.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(22, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 19;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(22, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 20;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(22, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 25);
            this.label3.TabIndex = 21;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(22, 717);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 22;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(22, 867);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 25);
            this.label5.TabIndex = 23;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // changeSampleRate
            // 
            this.changeSampleRate.Location = new System.Drawing.Point(312, 44);
            this.changeSampleRate.Name = "changeSampleRate";
            this.changeSampleRate.Size = new System.Drawing.Size(21, 21);
            this.changeSampleRate.TabIndex = 24;
            this.changeSampleRate.UseVisualStyleBackColor = true;
            this.changeSampleRate.Click += new System.EventHandler(this.changeSampleRate_Click);
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(426, 24);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            this.phoneNumber.Size = new System.Drawing.Size(110, 20);
            this.phoneNumber.TabIndex = 29;
            // 
            // medicalFileNumber
            // 
            this.medicalFileNumber.Location = new System.Drawing.Point(9, 24);
            this.medicalFileNumber.Name = "medicalFileNumber";
            this.medicalFileNumber.ReadOnly = true;
            this.medicalFileNumber.Size = new System.Drawing.Size(136, 20);
            this.medicalFileNumber.TabIndex = 30;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoPanel.Controls.Add(this.addressLabel);
            this.infoPanel.Controls.Add(this.address);
            this.infoPanel.Controls.Add(this.enabledEditing);
            this.infoPanel.Controls.Add(this.choosePatientButton);
            this.infoPanel.Controls.Add(this.saveEditButton);
            this.infoPanel.Controls.Add(this.phoneNumberLabel);
            this.infoPanel.Controls.Add(this.medicalFileNumber);
            this.infoPanel.Controls.Add(this.phoneNumber);
            this.infoPanel.Controls.Add(this.firstNameLabel);
            this.infoPanel.Controls.Add(this.lastName);
            this.infoPanel.Controls.Add(this.medicalFileNumberLabel);
            this.infoPanel.Controls.Add(this.firstName);
            this.infoPanel.Controls.Add(this.lastNameLabel);
            this.infoPanel.Location = new System.Drawing.Point(0, 91);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1033, 98);
            this.infoPanel.TabIndex = 32;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(562, 4);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 39;
            this.addressLabel.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(565, 24);
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Size = new System.Drawing.Size(438, 20);
            this.address.TabIndex = 38;
            // 
            // enabledEditing
            // 
            this.enabledEditing.AutoSize = true;
            this.enabledEditing.Location = new System.Drawing.Point(9, 69);
            this.enabledEditing.Name = "enabledEditing";
            this.enabledEditing.Size = new System.Drawing.Size(94, 17);
            this.enabledEditing.TabIndex = 37;
            this.enabledEditing.Text = "Enable Editing";
            this.enabledEditing.UseVisualStyleBackColor = true;
            this.enabledEditing.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // choosePatientButton
            // 
            this.choosePatientButton.Location = new System.Drawing.Point(913, 62);
            this.choosePatientButton.Name = "choosePatientButton";
            this.choosePatientButton.Size = new System.Drawing.Size(90, 30);
            this.choosePatientButton.TabIndex = 33;
            this.choosePatientButton.Text = "Choose Patient";
            this.choosePatientButton.UseVisualStyleBackColor = true;
            this.choosePatientButton.Click += new System.EventHandler(this.choosePatientButton_Click);
            // 
            // saveEditButton
            // 
            this.saveEditButton.Enabled = false;
            this.saveEditButton.Location = new System.Drawing.Point(173, 61);
            this.saveEditButton.Name = "saveEditButton";
            this.saveEditButton.Size = new System.Drawing.Size(90, 30);
            this.saveEditButton.TabIndex = 34;
            this.saveEditButton.Text = "Save Edit";
            this.saveEditButton.UseVisualStyleBackColor = true;
            this.saveEditButton.Click += new System.EventHandler(this.saveEditButton_Click);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(423, 4);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.phoneNumberLabel.TabIndex = 36;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(170, 4);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 35;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(300, 24);
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 27;
            // 
            // medicalFileNumberLabel
            // 
            this.medicalFileNumberLabel.AutoSize = true;
            this.medicalFileNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalFileNumberLabel.Location = new System.Drawing.Point(6, 4);
            this.medicalFileNumberLabel.Name = "medicalFileNumberLabel";
            this.medicalFileNumberLabel.Size = new System.Drawing.Size(136, 17);
            this.medicalFileNumberLabel.TabIndex = 35;
            this.medicalFileNumberLabel.Text = "Medical File Number";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(173, 24);
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 34;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(297, 4);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 34;
            this.lastNameLabel.Text = "Last Name";
            // 
            // channelPanel
            // 
            this.channelPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.channelPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.channelPanel.Location = new System.Drawing.Point(0, 2);
            this.channelPanel.Name = "channelPanel";
            this.channelPanel.Size = new System.Drawing.Size(1033, 90);
            this.channelPanel.TabIndex = 35;
            // 
            // chartPanel
            // 
            this.chartPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chartPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chartPanel.Controls.Add(this.label1);
            this.chartPanel.Controls.Add(this.chart1);
            this.chartPanel.Location = new System.Drawing.Point(0, 195);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(1563, 769);
            this.chartPanel.TabIndex = 36;
            // 
            // patientsList
            // 
            this.patientsList.AllowUserToAddRows = false;
            this.patientsList.AllowUserToDeleteRows = false;
            this.patientsList.AllowUserToResizeColumns = false;
            this.patientsList.AllowUserToResizeRows = false;
            this.patientsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.patientsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.patientsList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientsList.ColumnHeadersHeight = 25;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientsList.DefaultCellStyle = dataGridViewCellStyle1;
            this.patientsList.Location = new System.Drawing.Point(0, -2);
            this.patientsList.Name = "patientsList";
            this.patientsList.Size = new System.Drawing.Size(524, 185);
            this.patientsList.TabIndex = 1;
            this.patientsList.Visible = false;
            this.patientsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsList_CellContentClick);
            // 
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel.Controls.Add(this.patientsList);
            this.tablePanel.Location = new System.Drawing.Point(1035, 2);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(528, 187);
            this.tablePanel.TabIndex = 37;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1564, 961);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeSampleRate);
            this.Controls.Add(this.chart5);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.Channel5Label);
            this.Controls.Add(this.channel5);
            this.Controls.Add(this.Channel4Label);
            this.Controls.Add(this.channel4);
            this.Controls.Add(this.Channel3Label);
            this.Controls.Add(this.channel3);
            this.Controls.Add(this.Channel2Label);
            this.Controls.Add(this.channel2);
            this.Controls.Add(this.Channel1Label);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.channel1);
            this.Controls.Add(this.sampleRateLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.channelPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.chartPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainWindow";
            this.Text = "EEG Signal Charting";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.chartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientsList)).EndInit();
            this.tablePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label sampleRateLabel;
        private System.Windows.Forms.ComboBox channel1;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.Label Channel1Label;
        private System.Windows.Forms.Label Channel2Label;
        private System.Windows.Forms.ComboBox channel2;
        private System.Windows.Forms.Label Channel4Label;
        private System.Windows.Forms.ComboBox channel4;
        private System.Windows.Forms.Label Channel3Label;
        private System.Windows.Forms.ComboBox channel3;
        private System.Windows.Forms.Label Channel5Label;
        private System.Windows.Forms.ComboBox channel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button changeSampleRate;
        private System.Windows.Forms.MaskedTextBox phoneNumber;
        private System.Windows.Forms.MaskedTextBox medicalFileNumber;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.MaskedTextBox lastName;
        private System.Windows.Forms.Label medicalFileNumberLabel;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Button choosePatientButton;
        private System.Windows.Forms.Button saveEditButton;
        private System.Windows.Forms.Panel channelPanel;
        private System.Windows.Forms.Panel chartPanel;
        private System.Windows.Forms.CheckBox enabledEditing;
        private System.Windows.Forms.DataGridView patientsList;
        private Panel tablePanel;
        private Label addressLabel;
        private MaskedTextBox address;
    }
}

