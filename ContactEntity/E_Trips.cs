namespace Entities
{
    public class E_Trips
    {
        private string _TripCode;
        private int _DriverID;
        private int _BusID;
        private int _RouteID;

        public string TripCode { get => _TripCode; set => _TripCode = value; }
        public int DriverID { get => _DriverID; set => _DriverID = value; }
        public int BusID { get => _BusID; set => _BusID = value; }
        public int RouteID { get => _RouteID; set => _RouteID = value; }
    }
}