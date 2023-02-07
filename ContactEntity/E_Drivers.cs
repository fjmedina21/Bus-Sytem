namespace Entities
{
    public class E_Drivers
    {
        private int _DriverID;
        private string _DriverCode;
		private string _Cedula;
		private string _FirstName;
		private string _LastName;
		private DateTime _Birthdate;
		private string _Movil;
		private string _Email;

        public int DriverID { get => _DriverID; set => _DriverID = value; }
        public string DriverCode { get => _DriverCode; set => _DriverCode = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public DateTime Birthdate { get => _Birthdate; set => _Birthdate = value; }
        public string Movil { get => _Movil; set => _Movil = value; }
        public string Email { get => _Email; set => _Email = value; }
    }
}