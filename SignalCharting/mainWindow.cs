using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.Threading;
using System.IO;

// show the data on charts online

namespace SignalCharting
{
    public partial class mainWindow : Form
    {
        private static string fileName = Resource.defaultFile;
        private static int[] columnIndex = new int[5]; // index of each column to show on the chart
        private string[] rows; // the data read from the .txt file
        private string textData = ""; // the data read from the database
        private static int sampleRate; // number of samples per second
        private static Patient currentPatient;
        private static DataSource dataSource = DataSource.NOT_SELECTED;
        private const string FAILED_ERROR = "Failed";
        private const string FILE_BROWSER_FILTER = "All files |*.*|Text Files |*.txt";
        private const string INCORRECT_DATA_ERROR = "Incorrect Data!";
        private const string SERIES_NAME = "Amplitude";
        
        enum DataSource
        {
            DATA_BASE,
            TEXT_FILE,
            NOT_SELECTED
        }

        public mainWindow()
        {
            InitializeComponent();
            sampleRate = int.Parse(rate.Text);
        }

        public static Patient getCurrentPatient()
        {
            return currentPatient;
        }

        // method to open a file when browseButton is clicked
        private void browseButton_Click(object sender, EventArgs e)
        {            
            OpenFileDialog browse = new OpenFileDialog();
            browse.Title = "Choose the text file";
            browse.Filter = FILE_BROWSER_FILTER;
            //browse.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //browse.InitialDirectory = @"..\..\" + Directory.GetCurrentDirectory() + @"\Resources";
            browse.InitialDirectory = @"..\..\" + Directory.GetCurrentDirectory();
            browse.RestoreDirectory = true;
            FolderBrowserDialog folder = new FolderBrowserDialog();
            string directory = folder.SelectedPath;

            resetChannels();
            if (browse.ShowDialog() == DialogResult.OK)
            {
                clearPatientInformation();
                fileName = browse.FileName;
                rows = TextLoader.readLines(fileName);
                if (!(TextLoader.correctFile(rows)))
                {
                    MessageBox.Show(INCORRECT_DATA_ERROR, FAILED_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
                return;                        

            dataSource = DataSource.TEXT_FILE;
            initComboBoxes(channel1);
            initComboBoxes(channel2);
            initComboBoxes(channel3);
            initComboBoxes(channel4);
            initComboBoxes(channel5);
        }

        private void clearPatientInformation()
        {
            medicalFileNumber.Clear();
            firstName.Clear();
            lastName.Clear();
            phoneNumber.Clear();
            address.Clear();
        }

        // add the titles read from the .txt files to the items list of the combo boxes
        private void initComboBoxes(ComboBox channel)
        {
            string[] emptyElement = { "" };
            string[] titles = null;

            if (dataSource == DataSource.TEXT_FILE)
            {
                if (TextLoader.correctFile(rows))
                    titles = emptyElement.Concat(TextLoader.getHeaders(rows)).ToArray();
            }
            else if (dataSource == DataSource.DATA_BASE)
            {
                if (ExtractData.correctFile(textData))
                    titles = emptyElement.Concat(ExtractData.getHeaders(textData)).ToArray();
                else
                    MessageBox.Show(INCORRECT_DATA_ERROR, FAILED_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            channel.Items.AddRange(titles);            
        }

        // show data on a chart
        private void fillChart(Chart chart)
        {
            chart.Visible = true;            
            double xStep = 1 / sampleRate;
            string[] yData = null;
            int numOfSamples = 0;
            updateColumnIndex(channel1);
            updateColumnIndex(channel2);
            updateColumnIndex(channel3);
            updateColumnIndex(channel4);
            updateColumnIndex(channel5);

            if (dataSource == DataSource.TEXT_FILE)
            { 
                yData = TextLoader.getColumnData(rows, columnIndex[Convert.ToInt32(chart.Tag) - 1]);
                numOfSamples = TextLoader.countSamples(rows);
            }
            else if (dataSource == DataSource.DATA_BASE)
            {
                yData = ExtractData.getColumnData(textData, columnIndex[Convert.ToInt32(chart.Tag) - 1]);
                numOfSamples = ExtractData.countSamples(ExtractData.readLines(textData));
            }

            for (int sampleNumber = 0; sampleNumber < numOfSamples; sampleNumber++)
            {
                Thread.Sleep(Convert.ToInt32(xStep * 1000));
                chart.Series[SERIES_NAME].Points.AddXY(xStep * sampleNumber, yData[sampleNumber]);
                chart.Series[SERIES_NAME].Points[sampleNumber].AxisLabel = Math.Round(Convert.ToDouble(sampleNumber) / Convert.ToDouble(sampleRate)).ToString() + "s";
            }
        }

        // update the column index when the text of combo box is changed
        private void updateColumnIndex(ComboBox channel)
        {
            string[] titles = null;
            int numOfColumns = 0;

            if (dataSource == DataSource.TEXT_FILE)
            {
                titles = TextLoader.getHeaders(rows);
                numOfColumns = TextLoader.countColumns(rows, 0);
            }
            else if (dataSource == DataSource.DATA_BASE)
            {
                titles = ExtractData.getHeaders(textData);
                numOfColumns = ExtractData.countColumns(ExtractData.readLines(textData), 0);
            }

            for (int i = 0; i < numOfColumns; i++)
            {
                if (channel.Text == titles[i])
                    columnIndex[Convert.ToInt32(channel.Tag) - 1] = i;
            }
        }

        // updates chart1 when the channel1 combo box text is changed
        private void channel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateChart(channel1, chart1, label1);
        }

        // updates chart1 when the channel2 combo box text is changed
        private void channel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateChart(channel2, chart2, label2);
        }

        // updates chart1 when the channel3 combo box text is changed
        private void channel3_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateChart(channel3, chart3, label3);
        }

        // updates chart1 when the channel4 combo box text is changed
        private void channel4_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateChart(channel4, chart4, label4);
        }

        // updates chart1 when the channel5 combo box text is changed
        private void channel5_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateChart(channel5, chart5, label5);
        }

        // shows the data on a chart when the  text of the corresponding ComboBox is changed       
        private void updateChart(ComboBox channel, Chart chart, Label label)
        {
            if (channel.Text.Trim() == null || channel.Text.Trim() == string.Empty)
                chart.Visible = false;

            chart.Series[SERIES_NAME].Points.Clear();
            if (channel.Text.Trim() != null && channel.Text.Trim() != string.Empty)
                fillChart(chart);

            label.Visible = chart.Visible;
            label.Text = channel.Text;
        }

        // changes the sample rate when the buttons is clicked and updates the charts
        private void changeSampleRate_Click(object sender, EventArgs e)
        {
            sampleRate = int.Parse(rate.Text);
            updateChart(channel1, chart1, label1);
            updateChart(channel2, chart2, label2);
            updateChart(channel3, chart3, label3);
            updateChart(channel4, chart4, label4);
            updateChart(channel5, chart5, label5);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (enabledEditing.Checked)
            {
                saveEditButton.Enabled = true;
                firstName.ReadOnly = false;
                lastName.ReadOnly = false;
                medicalFileNumber.ReadOnly = false;
                phoneNumber.ReadOnly = false;
                address.ReadOnly = false;
            }
            else
                saveEditButton.Enabled = false;
        }

        private void choosePatientButton_Click(object sender, EventArgs e)
        {
            fillPatientsTable();
        }

        private void fillPatientsTable()
        {
            DataTable dataTable = DBConnection.getPatients();
            patientsList.Visible = true;
            patientsList.DataSource = dataTable;
        }

        private void saveEditButton_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.FirstName = firstName.Text;
            patient.LastName = lastName.Text;
            patient.MedicalFileNumber = medicalFileNumber.Text;
            patient.Address = address.Text;
            patient.PhoneNumber = phoneNumber.Text;
            
            if (DBConnection.updatePatient(patient))
            {
                MessageBox.Show("Patient's information updated.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentPatient.FirstName = firstName.Text;
                currentPatient.LastName = lastName.Text;
                currentPatient.MedicalFileNumber = medicalFileNumber.Text;
                currentPatient.Address = address.Text;
                currentPatient.PhoneNumber = phoneNumber.Text;
                    fillPatientsTable();
            }
            else
                MessageBox.Show("Could not update the patient.", FAILED_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void patientsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] textRows;            
            resetChannels();

            currentPatient = new Patient();
            currentPatient.MedicalFileNumber = patientsList.Rows[patientsList.CurrentCell.RowIndex].Cells[0].Value.ToString();
            currentPatient.FirstName = patientsList.Rows[patientsList.CurrentCell.RowIndex].Cells[1].Value.ToString();
            currentPatient.LastName = patientsList.Rows[patientsList.CurrentCell.RowIndex].Cells[2].Value.ToString();
            currentPatient.PhoneNumber = patientsList.Rows[patientsList.CurrentCell.RowIndex].Cells[3].Value.ToString();
            currentPatient.Address = patientsList.Rows[patientsList.CurrentCell.RowIndex].Cells[4].Value.ToString();

            channel1.Items.Clear();
            channel2.Items.Clear();
            channel3.Items.Clear();
            channel4.Items.Clear();
            channel5.Items.Clear();

            int rowIndex = patientsList.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = patientsList.Rows[rowIndex];
            medicalFileNumber.Text = selectedRow.Cells[0].Value.ToString();
            firstName.Text = selectedRow.Cells[1].Value.ToString();
            lastName.Text = selectedRow.Cells[2].Value.ToString();
            phoneNumber.Text = selectedRow.Cells[3].Value.ToString();
            address.Text = selectedRow.Cells[4].Value.ToString();

            textData = DBConnection.getEEGInformation(currentPatient.MedicalFileNumber);
            if (ExtractData.correctFile(textData))
                textRows = ExtractData.readLines(textData);
            else
            {
                MessageBox.Show(INCORRECT_DATA_ERROR, FAILED_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataSource = DataSource.DATA_BASE;
            initComboBoxes(channel1);
            initComboBoxes(channel2);
            initComboBoxes(channel3);
            initComboBoxes(channel4);
            initComboBoxes(channel5);
        }        
    }
}