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
    class Interogation_DB
    {
        static string connstr = "Data Source=localhost;UserId=root;database=portfolio";
        static MySqlConnection conn = new MySqlConnection(connstr);
        public static string caut_User(string u, string p)
        {
            // -- Operatia de gasire --
            // Cautam in baza de date DBvideoteca combinatia user+parola
            // transmisa prin parametrii: (string u, string p)
            MySqlCommand comUser = new MySqlCommand();
            comUser.Connection = conn;
            comUser.CommandText = "SELECT denumire_rol FROM admin join roluri on idrol = idr where nume = @paramUser and parola = @paramParola";
            comUser.Parameters.AddWithValue("@paramUser", u);
            comUser.Parameters.AddWithValue("@paramParola", p);
            string rol = "";
            try
            {
                conn.Open();
                MySqlDataReader readerUser = comUser.ExecuteReader();
                // Daca a fost gasita o inregistrare in baza de date - preluam denumirea rolului
            if (readerUser.Read())
                {
                    rol = readerUser["denumire_rol"].ToString();
                }
                // Golim parametrii folositi de comUser pentru a-i putea
                // reutiliza la un apel urmator al metodei: caut_user()
                comUser.Parameters.Clear();
            }
            catch (Exception)
            {
                // Aruncam exceptia in Form1.cs (modulul apelant)
                throw;
            }
            finally
            {
                // Inchidem conexiunea cu baza de date
                conn.Close();
            }
            return rol;
        }
        public static DataTable select_Technology()
        {
            // -- Operatia de interogare --
            // Cautam si aducem din baza de date Portfolio tabela categorie
            // toate inregistrarile (toate categoriile) ordonate alfabetic
            MySqlCommand comTechnology = new MySqlCommand();
            comTechnology.Connection = conn;
            comTechnology.CommandText = "SELECT * FROM categorie ORDER BY nume_categorie ASC ";
            MySqlDataAdapter technologyAdapt = new MySqlDataAdapter(comTechnology);
            DataTable technologyDT = new DataTable();
            try
            {
                conn.Open();
                technologyAdapt.Fill(technologyDT);
            }
            catch (Exception)
            {
                // Aruncam exceptia in Display.cs (modulul apelant)
                throw;
            }
            finally
            {
                // Inchidem conexiunea cu baza de date
                conn.Close();
            }
            return technologyDT;
        }
    }
}
