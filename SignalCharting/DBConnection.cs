using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace SignalCharting
{
    public static class DBConnection
    {
        private static string CONNECTION_STRING = Resource.connectionString;
        private static MySqlConnection connection = new MySqlConnection(CONNECTION_STRING);
        private const string SELECT_BY_FILE_NUMBER = "SELECT * FROM information WHERE MedicalFileNumber = @MedicalFileNumber";
        private const string SELECT_ALL_RECORDS = "SELECT MedicalFileNumber, FirstName, LastName, PhoneNumber, Address FROM information";
        private const string GET_COLUMN_HEADERS = "SELECT EEGInformation FROM information WHERE MedicalFileNumber = @MedicalFileNumber";
        private static string UPDATE_A_RECORD = "UPDATE information SET MedicalFileNumber = @MedicalFileNumber, FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, Address = @Address WHERE MedicalFileNumber = @CurrentMedicalFileNumber";

        public static Patient getPatientInformation(string medicalFileNumber)
        {
            Patient patient = new Patient();

            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(SELECT_BY_FILE_NUMBER, connection))
                {
                    command.Parameters.AddWithValue("@MedicalFileNumber", medicalFileNumber);
                    using (MySqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            patient.MedicalFileNumber = reader.GetString("MedicalFileNumber");
                            patient.FirstName = reader.GetString("FirstName");
                            patient.LastName = reader.GetString("LastName");
                            patient.Address = reader.GetString("Address");
                            patient.PhoneNumber = reader.GetString("PhoneNumber");
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception)
            {
                return null;
            }

            if (patientNotFound(patient))
                return null;

            return patient;
        }

        public static string getEEGInformation(string medicalFileNumber)
        {
            string EEGInformation = "";

            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(GET_COLUMN_HEADERS, connection))
                {
                    command.Parameters.AddWithValue("@MedicalFileNumber", medicalFileNumber);
                    using (MySqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            EEGInformation = reader.GetString("EEGInformation");
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception)
            {
                EEGInformation = null;
            }

            return EEGInformation;
        }

        public static DataTable getPatients()
        {
            DataTable patientsTable = new DataTable();

            try
            {
                MySqlCommand command = new MySqlCommand(SELECT_ALL_RECORDS, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(patientsTable);
            }
            catch (Exception)
            {
                patientsTable = null;
            }

            return patientsTable;
        }

        public static bool updatePatient(Patient patient)
        {
            bool isUpdated;

            try
            {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(UPDATE_A_RECORD, connection))
                {
                    command.Parameters.AddWithValue("@MedicalFileNumber", patient.MedicalFileNumber);
                    command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    command.Parameters.AddWithValue("@LastName", patient.LastName);
                    command.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", patient.Address);
                    command.Parameters.AddWithValue("@CurrentMedicalFileNumber", mainWindow.getCurrentPatient().MedicalFileNumber);
                    command.ExecuteNonQuery();
                }
                connection.Close();
                isUpdated = true;
            }
            catch (Exception)
            {
                isUpdated = false;
            }

            return isUpdated;
        }

        private static bool patientNotFound(Patient patient)
        {
            return ((patient.MedicalFileNumber == null) ||
            (patient.FirstName == null) ||
            (patient.LastName == null) ||
            (patient.Address == null) ||
            (patient.PhoneNumber == null));
        }
    }
}
