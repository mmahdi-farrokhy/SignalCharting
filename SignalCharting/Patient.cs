namespace SignalCharting
{
    public class Patient
    {
        public string MedicalFileNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EEGInformation { get; set; }

        public Patient()
        {
            this.MedicalFileNumber = null;
            this.FirstName = null;
            this.LastName = null;
            this.Address = null;
            this.PhoneNumber = null;
            this.EEGInformation = null;
        }
    }
}
