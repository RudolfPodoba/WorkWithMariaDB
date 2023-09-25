using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MariaDBLibrary;

namespace WorkWithMariaDB
{
    public partial class PracaSMariaDb : Form
    {
        public PracaSMariaDb()
        {
            InitializeComponent();
        }

        private string IntNaPomlcku(int? i_Vstup) // Nahradenie prázdneho čísla ponlčkou.
        {
            if (i_Vstup == null)
            {
                return "-";
            }

            return i_Vstup.ToString();
        }

        private string StringNaPomlcku(string s_Vstup) // Nahradenie prázdneho stringu pomlčkou.
        {
            if (s_Vstup is null || s_Vstup == "")
            {
                return "-";
            }

            return s_Vstup;
        }

        private void NastavNaTxb(TextBox txb_Sem, Boolean b_Vymaz) // Nastaví kurzor do požadovaného text boxu a vymaže/nevymaže v ňom údaje.
        {
            if (b_Vymaz)
            {
                txb_Sem.Text = "";
            }
            else
            {
                txb_Sem.SelectAll();
            }
            
            txb_Sem.Focus();
        }

        private bool KontrolaId(TextBox txb_Id, out int i_Id) // Skontroluje či je zadané ID číslo.
        {
            // Definícia premenných.
            i_Id = 0;

            if (String.IsNullOrWhiteSpace(txb_Id.Text)) // Kontrola zadania ID.
            {
                MessageBox.Show("Najskôr zadajte ID!", "POZOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Nastavenie na zadanie ID.
                NastavNaTxb(txb_Id, true);
                
                return false;
            }
            else if (!Int32.TryParse(txb_Id.Text, out i_Id)) // Kontrola správnosti zadania ID.
            {
                MessageBox.Show("Zadané ID musí byť číslo!", "POZOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Nastavenie na zadanie ID.
                NastavNaTxb(txb_Id, true);

                return false;
            }

            return true;
        }

        private bool KontrolaZadanychUdajov(TextBox txb_Meno, TextBox txb_Popis, TextBox txb_Status, out ToDo UpdateInsert ) // Skontroluje, či boli zadané údaje a či je status číslo.
            // Ak je zadaný aspoň jeden údaj a status je prázdny, alebo číslo, tak vráti true, inak false.
        {
            try
            {
                // Definovanie premenných.
                UpdateInsert = new ToDo();
                Boolean b_JeNull = false;
                int i_StatusParse;

                // Načítanie zadaných údajov.
                string s_Status = txb_Status.Text;
                UpdateInsert.s_Meno = txb_Meno.Text;
                UpdateInsert.s_Popis = txb_Popis.Text;

                // Upozornenie na nevyplnenie položiel.
                if (s_Status == "" && UpdateInsert.s_Meno == "" && UpdateInsert.s_Popis == "")
                {
                    MessageBox.Show("Nie sú vyplnené žiadne položky.", "POZOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    // Nastavenie na položku mena pre insert.
                    txb_Meno.Focus();

                    return false;
                }

                // Ak status nie je zadaný, tak sa do DB zapíše null.
                if (s_Status == "")
                {
                    b_JeNull = true;
                }

                // Kontrola správnosti zadania ID.
                if (!(Int32.TryParse(s_Status, out i_StatusParse) || b_JeNull))
                {
                    // Oznam o zle zadanom čísle.
                    MessageBox.Show("Zadané ID musí byť číslo!", "POZOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    // Nastavenie na zadanie statusu.
                    txb_Status.Text = "";
                    txb_Status.Focus();

                    return false;
                }

                // Naplnenie statusu.
                if (b_JeNull)
                {
                    UpdateInsert.i_Status = null;
                }
                else
                {
                    UpdateInsert.i_Status = i_StatusParse;
                }

                return true;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        private void btn_NacitajPodlaId_Click(object sender, EventArgs e) // Načítanie riadku z tabuľky TODO podľa ID.
        {
            int i_Id = 0;

            if (KontrolaId(txb_IdU, out i_Id))
            {
                try
                {   
                    // Načítanie podľa ID.
                    ToDo Riadok = new ToDo().NacitajToDoPodlaId(Convert.ToInt32(i_Id));

                    if (Riadok != null) // Vypísanie načítaných údajov.
                    {                           
                        txb_MenoU.Text = Riadok.s_Meno;
                        txb_PopisU.Text = Riadok.s_Popis;
                        txb_StatusU.Text = Riadok.i_Status.ToString();
                    }
                    else // Info o nenájdení údajov.
                    {
                        MessageBox.Show("Položka so zadaným ID sa v databáze nenachádza.", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Vyprázdni text boxi a nastaví sa na zadanie ID.
                        NastavNaTxb(txb_MenoU, true);
                        NastavNaTxb(txb_PopisU, true);
                        NastavNaTxb(txb_StatusU, true);
                        NastavNaTxb(txb_IdU, false);
                    }
                }
                catch (Exception Ex) // Oznam o chybe.
                {
                    MessageBox.Show(Ex.Message, "CHYBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_NacitajZoznam_Click(object sender, EventArgs e) // Načítanie tabuľky TODO.
        {
            try
            {
                // Definovanie premenných.
                string s_ID, s_Meno, s_Popis, s_Status;

                // Načítanie celej tabuľky TODO.
                IEnumerable<ToDo> Zoznam = new ToDo().NacitajToDoZoznam();

                // Vyprázdnenie priestoru pre zadanie výsledkov.
                lb_Zoznam.Items.Clear();

                // Vypísanie načítaných údajov.
                foreach (ToDo Riadok in Zoznam)
                {
                    s_ID = IntNaPomlcku(Riadok.i_Id);
                    s_Meno = StringNaPomlcku(Riadok.s_Meno);
                    s_Popis = StringNaPomlcku(Riadok.s_Popis);
                    s_Status = IntNaPomlcku(Riadok.i_Status);

                    lb_Zoznam.Items.Add("ID: " + s_ID + "; Meno: " + s_Meno + "; Popis: " + s_Popis + "; Status: " + s_Status);
                }
            }
            catch (Exception Ex) // Oznam o chybe.
            {
                MessageBox.Show(Ex.Message, "CHYBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Vloz_Click(object sender, EventArgs e) // Vloženie dát do tabuľky ToDo.
        {

            try
            {
                // Definovanie premenných.
                ToDo VlozToDo = new ToDo();
                int i_Id;
                
                // Kontrola zadaných údajov, ktorá obsahuje aj hlásenia o ich nesprávnych hodnotách.
                if (KontrolaZadanychUdajov(txb_MenoI, txb_PopisI, txb_StatusI, out VlozToDo))
                {
                    // Zapísanie do DB a načítanie ID, pod ktorým bol záznam uložený.
                    i_Id = new ToDo().Vloz(VlozToDo);

                    // Vypísanie ID, pod ktorým bol záznam uložený.
                    MessageBox.Show("Záznam bol uložený pod ID " + i_Id, "Oznam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Vymaže zadané údaje a nastaví na prvý.
                    NastavNaTxb(txb_StatusI, true);
                    NastavNaTxb(txb_PopisI, true);
                    NastavNaTxb(txb_MenoI, true);
                }
            }            
            catch (Exception Ex) // Oznam o chybe.
            {
                MessageBox.Show(Ex.Message, "CHYBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Aktualizuj_Click(object sender, EventArgs e) // Aktualizuje údaje podľa zadaného ID.
            //Ak sa ID v DB nenájde, tak o tom neinformuje. Správa sa ako Update, nie je kontrola na jeho existenciu.
        {
            try
            {
                // Definovanie premenných.
                ToDo AktualizujToDo = new ToDo();
                int i_Id = 0;

                // Aktualizuje dané ID, tak ho treba skontrolovať.
                if (KontrolaId(txb_IdU, out i_Id))
                {
                    // Kontrola zadaných údajov, ktorá obsahuje aj hlásenia o ich nesprávnych hodnotách.
                    if (KontrolaZadanychUdajov(txb_MenoU, txb_PopisU, txb_StatusU, out AktualizujToDo))
                    {
                        AktualizujToDo.i_Id = i_Id;

                        // Aktualizácia dát na základe ID.
                        new ToDo().Aktualizuj(AktualizujToDo);

                        // Vypísanie ID. pod ktorým bol záznam uložený.
                        MessageBox.Show("Záznam bol úspešne aktualizovaný.", "Oznam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Vymaže zadané údaje a podľa na ID.
                        NastavNaTxb(txb_StatusU, true);
                        NastavNaTxb(txb_PopisU, true);
                        NastavNaTxb(txb_MenoU, true);
                        NastavNaTxb(txb_IdU, false);
                    }
                }
            }
            catch (Exception Ex) // Oznam o chybe.
            {
                MessageBox.Show(Ex.Message, "CHYBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Vymaz_Click(object sender, EventArgs e) // VYmaže údaje podľa zadaného ID.
        {
            // Definovanie premenných.
            ToDo VymazToDo = new ToDo();
            int i_Id = 0;

            if (KontrolaId(txb_IdD, out i_Id))
            {
                try
                {
                    VymazToDo.i_Id = i_Id;

                    // Vymazanie dát na podľa ID.
                    new ToDo().Vymaz(VymazToDo);

                    // Oznam o vymazaní záznamu.
                    MessageBox.Show("Záznam bol úspešne vymazaný.", "Oznam", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Nastaví na ID.
                    NastavNaTxb(txb_IdD, true);
                }
                catch (Exception Ex) // Oznam o chybe.
                {
                    MessageBox.Show(Ex.Message, "CHYBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}