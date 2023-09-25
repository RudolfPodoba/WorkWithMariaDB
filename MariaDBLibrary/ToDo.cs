using DbKniznica;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaDBLibrary
{
    public class ToDo: Dal
    {
        public int i_Id { get; set; }
        public String s_Meno { get; set; }
        public String s_Popis { get; set; }
        public int? i_Status { get; set; }

        // pre načítanie riadku z tabuľky ToDo
        protected void NacitajRiadokToDo(System.Data.Common.DbDataReader Nacitaj)
        {
            i_Id = (int)Nacitaj["ID"];
            s_Meno = (String)Nacitaj["MENO"];
            s_Popis = (String)Nacitaj["POPIS"];
            i_Status = Nacitaj["STATUS"] as int?;            
        }

        // pre zápis do tabuľky ToDo
        protected List<MySqlParameter> ZapisDoDb()
        {
            List<MySqlParameter> p_Parametre = new List<MySqlParameter>();
            p_Parametre.Add(new MySqlParameter("ID", i_Id));
            p_Parametre.Add(new MySqlParameter("MENO", s_Meno));
            p_Parametre.Add(new MySqlParameter("POPIS", s_Popis));
            p_Parametre.Add(new MySqlParameter("STATUS", IfNull(i_Status)));

            return p_Parametre;
        }

        // načítanie dát podľa id
        public ToDo NacitajToDoPodlaId(int Id)
        {
            ToDo Vysledok = null;
            var Odpoved = DbPripojenie.VykonajNacitaj("SELECT * FROM TODO WHERE ID=?Id", new MySqlParameter[] {
            new MySqlParameter("Id",Id)
            }, (System.Data.Common.DbDataReader Nacitaj) =>
            {
                if (Nacitaj.Read())
                {
                    Vysledok = new ToDo();
                    Vysledok.NacitajRiadokToDo(Nacitaj);
                }
            });

            return Vysledok;
        }

        // načítaj celú tabuľku
        public IEnumerable<ToDo> NacitajToDoZoznam()
        {
            List<ToDo> list = new List<ToDo>();
            var res = DbPripojenie.VykonajNacitaj("SELECT * FROM TODO ", new MySqlParameter[] { },
                 (System.Data.Common.DbDataReader Nacitaj) => {
                     while (Nacitaj.Read())
                     {
                         ToDo Vysledok = new ToDo();
                         Vysledok.NacitajRiadokToDo(Nacitaj);
                         list.Add(Vysledok);
                     }
                 });
            return list;
        }

        public int Vloz(ToDo Parametre)
        {
            s_Meno = Parametre.s_Meno;
            s_Popis = Parametre.s_Popis;
            i_Status = Parametre.i_Status;

            string s_Sql = "INSERT INTO TODO (MENO, POPIS, STATUS) VALUES (?MENO, ?POPIS, ?STATUS);";
            
            return DbPripojenie.VykonajAvratId(s_Sql, ZapisDoDb().ToArray());
        }

        public void Aktualizuj(ToDo Parametre)
        {
            i_Id = Parametre.i_Id;
            s_Meno = Parametre.s_Meno;
            s_Popis = Parametre.s_Popis;
            i_Status = Parametre.i_Status;

            string s_Sql = "UPDATE TODO SET MENO = ?MENO, POPIS = ?POPIS, STATUS = ?STATUS WHERE ID = ?ID;";            

            DbPripojenie.VykonajPoziadavku(s_Sql, ZapisDoDb().ToArray());
        }

        public void Vymaz(ToDo Parametre)
        {
            i_Id = Parametre.i_Id;
            
            string s_Sql = "DELETE FROM TODO WHERE ID = ?ID;";

            DbPripojenie.VykonajPoziadavku(s_Sql, ZapisDoDb().ToArray());
        }
    }
}
