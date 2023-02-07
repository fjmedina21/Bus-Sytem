using Entities;
using Data_Layer;


namespace BusinessLogic_Layer
{
    public class BL_Driver
    {
        DBConfig data = new DBConfig();

        
        public List<E_Drivers> DriversRecord(string search)
        {
            return data.DriversRecord(search);
        }

        public void InsertDriver(E_Drivers driver)
        {
            data.InsertDriver(driver);      
        }

        public void UpdateDriver(E_Drivers driver)
        {
            data.UpdateDriver(driver);
        }

        public void DeleteDriver(E_Drivers driver)
        {
            data.DeleteDriver(driver);
        }


    }
}