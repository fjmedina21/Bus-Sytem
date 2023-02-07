namespace Entities
{
    public class E_Routes

    {
        private int _RouteID;
        private string _RouteCode;
		private string _Origin;
		private string _Destination;
		private int _Price;

        public int RouteID { get => _RouteID; set => _RouteID = value; }
        public string RouteCode { get => _RouteCode; set => _RouteCode = value; }
        public string Origin { get => _Origin; set => _Origin = value; }
        public string Destination { get => _Destination; set => _Destination = value; }
        public int Price { get => _Price; set => _Price = value; }
    }
}