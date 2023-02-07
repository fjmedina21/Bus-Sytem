namespace Entities
{
    public class E_Buses
    {
        private int _BusID;
		private string _BusCode;
		private string _Brand;
		private string _Model;
		private string _LicensePlate;
		private string _Color;
		private int _ModelYear;

        public int BusID { get => _BusID; set => _BusID = value; }
        public string BusCode { get => _BusCode; set => _BusCode = value; }
        public string Brand { get => _Brand; set => _Brand = value; }
        public string Model { get => _Model; set => _Model = value; }
        public string LicensePlate { get => _LicensePlate; set => _LicensePlate = value; }
        public string Color { get => _Color; set => _Color = value; }
        public int ModelYear { get => _ModelYear; set => _ModelYear = value; }
    }
}