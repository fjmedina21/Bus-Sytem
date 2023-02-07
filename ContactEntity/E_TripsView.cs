namespace Entities
{
    public class E_TripsView
    {
        private string _TripCode;
        private string _DriverFullName;
        private string _Bus;
        private string _Origin;
        private string _Destination;
        private int _Price;

        public string TripCode { get => _TripCode; set => _TripCode = value; }
        public string DriverFullName { get => _DriverFullName; set => _DriverFullName = value; }
        public string Bus { get => _Bus; set => _Bus = value; }
        public string Origin { get => _Origin; set => _Origin = value; }
        public string Destination { get => _Destination; set => _Destination = value; }
        public int Price { get => _Price; set => _Price = value; }
    }
}