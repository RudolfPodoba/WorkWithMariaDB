using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaDBLibrary
{
    public class DbPripojenie
    {
        public MySqlConnection Pripojenie { get; set; } = null;
        public MySqlCommand Prikaz { get; set; } = null;

        //pripojenie k DB serveru
        public void OtvorPripojenie()
        {
            try
            {
                if (Pripojenie == null)
                {
                    Pripojenie = new MySqlConnection();
                }
                else
                {
                    ZatvorPripojenie();
                }

                Pripojenie.ConnectionString = "Server=127.0.0.1;User ID=root;Password=Slovakia;Database=todos"; //adresa servera
                Pripojenie.Open();
                Prikaz = Pripojenie.CreateCommand();
                Prikaz.Connection = Pripojenie;                
            }
            catch (Exception Ex)
            {
                throw new Exception("Nepodarilo sa pripojiť na databázu." + System.Environment.NewLine + Ex.Message);
            }
        }

        //zatvorenie pripojenia
        public void ZatvorPripojenie()
        {
            try
            {
                Prikaz.Dispose();
                Prikaz = null;
            }
            catch (Exception Ex)
            {
                var s_Sprava = Ex.Message;
            }

            try
            {
                if (Pripojenie != null)
                {
                    Pripojenie.Close();
                    Pripojenie = null;
                }
            }
            catch (Exception Ex)
            {
                var s_Sprava = Ex.Message;
            }
        }

        // načítanie dát z DB
        public static int VykonajNacitaj(string s_Sql, MySqlParameter[] p_Parametre, Action<System.Data.Common.DbDataReader> Nacitaj) {
            DbPripojenie Pripojenie = new DbPripojenie();
            try
            {
                Pripojenie.OtvorPripojenie();
                Pripojenie.Prikaz.CommandText = s_Sql;
                Pripojenie.Prikaz.Parameters.Clear();
                Pripojenie.Prikaz.Parameters.AddRange(p_Parametre);
                var VykonajAcitaj = Pripojenie.Prikaz.ExecuteReader();
                Nacitaj(VykonajAcitaj);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                Pripojenie.ZatvorPripojenie();
            }
            return 0;
        }

        // vloženie dát, vrátenie ID
        public static int VykonajAvratId(string s_Sql, MySqlParameter[] p_Parametre)
        {
            int i_Vysledok = 0;
            DbPripojenie Pripojenie = new DbPripojenie();

            try
            {
                Pripojenie.OtvorPripojenie();
                Pripojenie.Prikaz.CommandText = s_Sql + " SELECT LAST_INSERT_ID();"; // V SQL príkaze musí byť za insertom SELECT LAST_INSERT_ID();
                Pripojenie.Prikaz.Parameters.Clear();
                Pripojenie.Prikaz.Parameters.AddRange(p_Parametre);
 
                using (MySqlDataReader Citaj = Pripojenie.Prikaz.ExecuteReader())
                {
                    while (Citaj.Read())
                    {
                        i_Vysledok = Convert.ToInt32(Citaj[0]); // Načíta prvý údaj z vráteného selectu, čo je ID, ktoré sa priradilo vloženému riadku.
                    }
                }
            }            
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                Pripojenie.ZatvorPripojenie();
            }
            return i_Vysledok;
        }

        public static int VykonajPoziadavku(string sql, MySqlParameter[] p_Parametre)
        {
            int i_Vysledok = 0;
            DbPripojenie Pripojenie = new DbPripojenie();
            
            try
            {
                Pripojenie.OtvorPripojenie();
                Pripojenie.Prikaz.CommandText = sql;
                Pripojenie.Prikaz.Parameters.Clear();
                Pripojenie.Prikaz.Parameters.AddRange(p_Parametre);
                i_Vysledok = Pripojenie.Prikaz.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Pripojenie.ZatvorPripojenie();
            }
            return i_Vysledok;
        }
    }
}
