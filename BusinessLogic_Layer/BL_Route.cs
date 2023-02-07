using Entities;
using Data_Layer;


namespace BusinessLogic_Layer
{
    public class BL_Route
    {
        DBConfig data = new DBConfig();

        
        public List<E_Routes> RoutesRecord(string search)
        {
            return data.RoutesRecord(search);   
        }
        
        public void InsertRoute(E_Routes route)
        {
            data.InsertRoute(route);
        }

        public void UpdateRoute(E_Routes route)
        {
            data.UpdateRoute(route);
        }

        public void DeleteRoute(E_Routes route)
        {
            data.DeleteRoute(route);
        }


    }
}