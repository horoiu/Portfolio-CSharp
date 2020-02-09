using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Pentru legatura cu baza de date
using System.Data; // Pentru DataTable
using System.Collections; // Pentru ArrayList

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

        public static void deleteTechnologyInDB(ArrayList technologyList)
        {
            MySqlCommand cmdDeleteTechnology = new MySqlCommand("DELETE FROM categorie WHERE (id_categ=@technologyID)", conn);
            conn.Open();

            // Instantiez si incep o tranzactie
            MySqlTransaction tx = conn.BeginTransaction();
            try
            {
                // Atasez comanda cmdDeleteTechnology tranzactiei tx
                cmdDeleteTechnology.Transaction = tx;

                foreach (int technologyID in technologyList)
                {
                    // Adaug id-ul tehnologiei la query string
                    cmdDeleteTechnology.Parameters.AddWithValue("@technologyID", technologyID);
                    cmdDeleteTechnology.ExecuteNonQuery();
                    cmdDeleteTechnology.Parameters.Clear();
                }

                // Modificarile devin permanente
                tx.Commit();
            }
            catch (Exception)
            {
                // Daca a aparut o eroare in timpul executiei vreuneia dintre operatiile asupra bazei de date
                // se vor anula si operatiile care au fost facute inaintea erorii
                tx.Rollback();
                throw;
            }
            finally
            {
                // Inchidem conexiunea cu baza de date
                conn.Close();
            }
        }

    }
}
