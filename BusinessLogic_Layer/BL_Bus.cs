using Entities;
using Data_Layer;


namespace BusinessLogic_Layer
{
    public class BL_Bus
    {
        DBConfig data = new DBConfig();

        
        public List<E_Buses> BusesRecord(string search)
        {
            return data.BusesRecord(search);
        }

        public void InsertBus(E_Buses bus)
        {
            data.InsertBuses(bus);
        }

        public void DeleteBus(E_Buses bus)
        {
            data.DeleteBus(bus);
        }


    }
}