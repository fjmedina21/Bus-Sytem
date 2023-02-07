using Entities;
using Data_Layer;


namespace BusinessLogic_Layer
{
    public class BL_Trip
    {
        DBConfig data = new();

        
        public List<E_TripsView> TripsRecord(string search)
        {
            return  data.TripsRecord(search);  
        }

        public void InsertTrip(E_Trips trip)
        {
            data.InsertTrip(trip);
        }

        public void DeleteTrip(E_Trips trip)
        {
            data.DeleteTrip(trip);  
        }


    }
}