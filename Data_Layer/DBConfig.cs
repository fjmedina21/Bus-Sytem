using Entities;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Data_Layer
{
    public class DBConfig
    {
        SqlConnection conn = new(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString);

        public List<E_TripsView> TripsRecord(string search)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("sp_searchTrips", conn)
             {
                CommandType = CommandType.StoredProcedure
             };

            cmd.Parameters.AddWithValue("@search", search);
            SqlDataReader readRows = cmd.ExecuteReader();

            List<E_TripsView> record = new();
            while (readRows.Read())
             {
                E_TripsView view = new()
                {
                    TripCode = readRows.GetString("TripCode"),
                    DriverFullName = readRows.GetString("Driver"),
                    Bus = readRows.GetString("Bus"),
                    Origin = readRows.GetString("Origin"),
                    Destination = readRows.GetString("Destination"),
                    Price = readRows.GetInt32("Price")
                };

                record.Add(view);
             }

             readRows.Close();
             conn.Close();
             return record;         
         }

        
        public List<E_Drivers> DriversRecord(string search)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("sp_searchDrivers", conn)
             {
                CommandType = CommandType.StoredProcedure
             };

            cmd.Parameters.AddWithValue("@search", search);
            SqlDataReader readRows = cmd.ExecuteReader();

            List<E_Drivers> record = new();
            while (readRows.Read())
            {
                E_Drivers driver = new()
                {
                    DriverID = readRows.GetInt32("DriverID"),
                    DriverCode = readRows.GetString("DriverCode"),
                    Cedula = readRows.GetString("Cedula"),
                    FirstName = readRows.GetString("FirstName"),
                    LastName = readRows.GetString("LastName"),
                    Birthdate = readRows.GetDateTime("Birthdate"),
                    Movil = readRows.GetString("Movil"),
                    Email = readRows.GetString("Email")
                };

                record.Add(driver);
             }

            readRows.Close();
            conn.Close();
            return record;
        }
        
        public List<E_Routes> RoutesRecord(string search)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();             
            }

            SqlCommand cmd = new SqlCommand("sp_searchRoutes", conn)
             {
                CommandType = CommandType.StoredProcedure
             };

            cmd.Parameters.AddWithValue("@search", search);
            SqlDataReader readRows = cmd.ExecuteReader();

            List<E_Routes> record = new();
            while (readRows.Read())
            {
                E_Routes route = new()
                {
                    RouteID = readRows.GetInt32("RouteID"),
                    RouteCode = readRows.GetString("RouteCode"),
                    Origin = readRows.GetString("Origin"),
                    Destination = readRows.GetString("Destination"),
                    Price = readRows.GetInt32("Price")
                };

                record.Add(route);
             }

            readRows.Close();
            conn.Close();
            return record;
        }

        public List<E_Buses> BusesRecord(string search)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("sp_searchBuses", conn)
             {
                CommandType = CommandType.StoredProcedure
             };

            cmd.Parameters.AddWithValue("@search", search);
            SqlDataReader readRows = cmd.ExecuteReader();

            List<E_Buses> record = new();
            while (readRows.Read())
            {
                E_Buses bus = new()
                {
                    BusID = readRows.GetInt32("BusID"),
                    BusCode = readRows.GetString("BusCode"),
                    Brand = readRows.GetString("Brand"),
                    Model = readRows.GetString("Model"),
                    LicensePlate = readRows.GetString("LicensePlate"),
                    Color = readRows.GetString("Color"),
                    ModelYear = readRows.GetInt32("ModelYear")
                };

                record.Add(bus);
             }

            readRows.Close();
            conn.Close();
            return record;
        }

        public void InsertDriver(E_Drivers d)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("sp_insertDriver", conn)
                 {
                    CommandType = CommandType.StoredProcedure
                 };

                cmd.Parameters.AddWithValue("@Cedula", d.Cedula);
                cmd.Parameters.AddWithValue("@FirstName", d.FirstName);
                cmd.Parameters.AddWithValue("@LastName", d.LastName);
                cmd.Parameters.AddWithValue("@Birthdate", d.Birthdate);
                cmd.Parameters.AddWithValue("@Movil", d.Movil);
                cmd.Parameters.AddWithValue("@Email", d.Email);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void InsertBuses(E_Buses b)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("sp_insertBus", conn)
                 {
                    CommandType = CommandType.StoredProcedure
                 };

                cmd.Parameters.AddWithValue("@Brand", b.Brand);
                cmd.Parameters.AddWithValue("@Model", b.Model);
                cmd.Parameters.AddWithValue("@LicensePlate", b.LicensePlate);
                cmd.Parameters.AddWithValue("@Color", b.Color);
                cmd.Parameters.AddWithValue("@ModelYear", b.ModelYear);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void InsertTrip(E_Trips t)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("sp_insertTrip", conn)
                 {
                    CommandType = CommandType.StoredProcedure
                 };

                cmd.Parameters.AddWithValue("@DriverID", t.DriverID);
                cmd.Parameters.AddWithValue("@BusID", t.BusID);
                cmd.Parameters.AddWithValue("@RouteID", t.RouteID);
               
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

         public void InsertRoute(E_Routes r)
          {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("sp_insertRoute", conn)
                 {
                    CommandType = CommandType.StoredProcedure
                 };

                cmd.Parameters.AddWithValue("@Origin", r.Origin);
                cmd.Parameters.AddWithValue("@Destination", r.Destination);
                cmd.Parameters.AddWithValue("@Price", r.Price);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
          }

        public void UpdateDriver(E_Drivers d)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("sp_updateDriver", conn)
                {
                    CommandType = CommandType.StoredProcedure
                 };

                cmd.Parameters.AddWithValue("@DriverCode", d.DriverCode);
                cmd.Parameters.AddWithValue("@FirstName", d.FirstName);
                cmd.Parameters.AddWithValue("@LastName", d.LastName);
                cmd.Parameters.AddWithValue("@Birthdate", d.Birthdate);
                cmd.Parameters.AddWithValue("@Movil", d.Movil);
                cmd.Parameters.AddWithValue("@Email", d.Email);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateRoute(E_Routes r)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("sp_updateRoute", conn)
                 {
                    CommandType = CommandType.StoredProcedure
                 };

                cmd.Parameters.AddWithValue("@RouteCode", r.RouteCode);
                cmd.Parameters.AddWithValue("@Price", r.Price);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteDriver(E_Drivers d)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("sp_deleteDriver", conn)
                 {
                    CommandType = CommandType.StoredProcedure
                 };

                cmd.Parameters.AddWithValue("@DriverCode", d.DriverCode);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteBus(E_Buses b)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("sp_deleteBus", conn)
                 {
                    CommandType = CommandType.StoredProcedure
                 };

                cmd.Parameters.AddWithValue("@BusCode", b.BusCode);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteRoute(E_Routes r)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("sp_deleteRoute", conn)
                 {
                    CommandType = CommandType.StoredProcedure
                 };

                cmd.Parameters.AddWithValue("@RouteCode", r.RouteCode);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteTrip(E_Trips t)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("sp_deleteTrip", conn)
                 {
                    CommandType = CommandType.StoredProcedure
                 };

                cmd.Parameters.AddWithValue("@TripCode", t.TripCode);

                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}