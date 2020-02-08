using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Pentru legatura cu baza de date
using System.Data; // Pentru DataTable

namespace Portfolio
{
    class Update_DB
    {
        static string connstr = "Data Source=localhost;UserId=root;database=portfolio";
        static MySqlConnection conn = new MySqlConnection(connstr);

        public static void modifyTechnologyInDB(string technologyName, int technologyId)
        {
            MySqlCommand cmdUpdateTechnology = new MySqlCommand();
            cmdUpdateTechnology.Connection = conn;
            cmdUpdateTechnology.CommandText = "UPDATE categorie SET nume_categorie = (@technologyName) WHERE (id_categ = (@technologyId))";
            try
            {
                conn.Open(); // Deschidem conexiunea cu Baza de Date
                cmdUpdateTechnology.Parameters.AddWithValue("@technologyName", technologyName);
                cmdUpdateTechnology.Parameters.AddWithValue("@technologyId", technologyId);
                cmdUpdateTechnology.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close(); // Inchidem conexiunea cu Baza de Date
            }
        }

        public static void addTechnologyInDB(string technologyName)
        {
            MySqlCommand cmdAddTechnology = new MySqlCommand();
            cmdAddTechnology.Connection = conn;
            cmdAddTechnology.CommandText = "INSERT INTO categorie(nume_categorie) VALUES(@technologyName)";
            try
            {
                conn.Open(); // Deschidem conexiunea cu Baza de Date
                cmdAddTechnology.Parameters.AddWithValue("@technologyName", technologyName);
                cmdAddTechnology.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close(); // Inchidem conexiunea cu Baza de Date
            }
        }
    }
}
