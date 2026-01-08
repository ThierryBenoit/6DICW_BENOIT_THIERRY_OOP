using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Business;

namespace DataAccess
{
    public class WandelrouteDA
    {
        private String _connString;
        private MySqlConnection _mySqlConnection;

        public WandelrouteDA()
        {
            // connectiestring voor de MySQL-databank wandelroutes
            _connString = "server=localhost;user id=root;Password=Leerling123;database = wandelroutes";

            // initialiseer de connectie op basis van de connectiestring
            _mySqlConnection = new MySqlConnection(_connString);
        }

        public List<Wandelroute> ReadTable()
        {
            List<Wandelroute> lijst = new List<Wandelroute>();

            // SQL-statement om alle wandelroutes, alfabetisch gerangschikt, op te vragen 
            String sql = "SELECT * FROM tblwandelroutes ORDER BY naam;";

            // SQL-commando aanmaken op basis van ons SQL-statement
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            // de connectie met de databank openen
            _mySqlConnection.Open();

            // met ExecuteReader laat je een leescommando opstarten
            // de ingelezen informatie komt in mySqlDataReader terecht
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            // lusje om alle records in mySqlDataReader te overlopen
            while (mySqlDataReader.Read() == true)
            {
                // nieuwe wandelroute maken met de actieve record in mySqlDataReader
                Wandelroute wandelroute =
                     new Wandelroute((int)(mySqlDataReader["id"]),
                                     mySqlDataReader["naam"].ToString(),
                                     (int)(mySqlDataReader["kilometers"]),
                                     mySqlDataReader["gemeente"].ToString(),
                                     mySqlDataReader["provincie"].ToString());

                // voeg de wandelroute toe aan de lijst
                lijst.Add(wandelroute);
            }

            // de connectie met de databank terug sluiten
            _mySqlConnection.Close();

            // lijst met alle wandelroutes retourneren
            return lijst;
        }

        public void UpdateRecord(Wandelroute wandelroute)
        {
            // SQL-statement om een wandelroute te updaten 
            String sql = "UPDATE tblwandelroutes SET naam = @Naam, kilometers = @Kilometers, gemeente = @Gemeente, provincie = @Provincie WHERE(id = @ID); ";

            // SQL-commando aanmaken op basis van ons SQL-statement
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            // parameters in het SQL-commando hun waarde geven
            mySqlCommand.Parameters.AddWithValue("@Naam", wandelroute.Naam);
            mySqlCommand.Parameters.AddWithValue("@Kilometers", wandelroute.Kilometers);
            mySqlCommand.Parameters.AddWithValue("@Gemeente", wandelroute.Gemeente);
            mySqlCommand.Parameters.AddWithValue("@Provincie", wandelroute.Provincie);
            mySqlCommand.Parameters.AddWithValue("@ID", wandelroute.Id);

            // de connectie met de databank openen
            _mySqlConnection.Open();

            // ExecuteNonQuery om een MySqlCommand te starten dat GEEN gegevens leest
            mySqlCommand.ExecuteNonQuery();

            // de connectie met de databank terug sluiten
            _mySqlConnection.Close();
        }

        public void CreateRecord(Wandelroute wandelroute)
        {
            // SQL-statement om een wandelroute toe te voegen 
            String sql = "INSERT INTO tblwandelroutes(naam, kilometers, gemeente, provincie) VALUES(@Naam, @Kilometers, @Gemeente, @Provincie); ";

            // SQL-commando aanmaken op basis van ons SQL-statement
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            // parameters in het SQL-commando hun waarde geven
            mySqlCommand.Parameters.AddWithValue("@Naam", wandelroute.Naam);
            mySqlCommand.Parameters.AddWithValue("@Kilometers", wandelroute.Kilometers);
            mySqlCommand.Parameters.AddWithValue("@Gemeente", wandelroute.Gemeente);
            mySqlCommand.Parameters.AddWithValue("@Provincie", wandelroute.Provincie);

            // de connectie met de databank openen
            _mySqlConnection.Open();

            // ExecuteNonQuery om een MySqlCommand te starten dat geen gegevens inleest
            mySqlCommand.ExecuteNonQuery();

            // de connectie met de databank terug sluiten
            _mySqlConnection.Close();
        }

        public void DeleteRecord(int id)
        {
            // SQL-statement om een wandelroute te wissen
            String sql = "DELETE FROM tblwandelroutes WHERE (id = @ID);";

            // SQL-commando aanmaken op basis van ons SQL-statement
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            // parameters in het SQL-commando hun waarde geven
            mySqlCommand.Parameters.AddWithValue("@ID", id);

            // de connectie met de databank openen
            _mySqlConnection.Open();

            // ExecuteNonQuery om een MySqlCommand te starten dat geen gegevens inleest
            mySqlCommand.ExecuteNonQuery();

            // de connectie met de databank terug sluiten
            _mySqlConnection.Close();
        }


        // methode om alle wandelroutes op basis van filter (max afstand) uit de tabel op te halen
        public List<Wandelroute> ReadTableFilterMaxAfstand(int afstand)
        {
            List<Wandelroute> lijst = new List<Wandelroute>();

            // 1) AANVULLEN **********************************************************
            // SQL-statement om wandelroutes gefilterd op maximumafstand op te vragen 
            String sql = "";


            // SQL-commando aanmaken op basis van ons SQL-statement
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            // 2) AANVULLEN **********************************
            // parameters in het SQL-commando een waarde geven
            

            // de connectie met de databank openen
            _mySqlConnection.Open();

            // met ExecuteReader laat je een leescommando opstarten
            // ingelezen informatie komt in mySqlDataReader terecht
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            // lusje om alle records in mySqlDataReader te overlopen
            while (mySqlDataReader.Read() == true)
            {
                // nieuwe wandelroute maken met de actieve record in mySqlDataReader
                Wandelroute wandelroute = new Wandelroute((int)(mySqlDataReader["id"]), mySqlDataReader["naam"].ToString(), (int)(mySqlDataReader["kilometers"]), mySqlDataReader["gemeente"].ToString(), mySqlDataReader["provincie"].ToString());

                // voeg de wandelroute toe aan de lijst
                lijst.Add(wandelroute);
            }

            // de connectie met de databank terug sluiten
            _mySqlConnection.Close();

            // lijst met alle wandelroutes teruggeven
            return lijst;
        }

        // methode om alle wandelroutes op basis van filter (bereik afstand) uit de tabel op te halen
        public List<Wandelroute> ReadTableFilterRangeAfstand(int minAfstand, int maxAfstand)
        {
            List<Wandelroute> lijst = new List<Wandelroute>();

            // 1) AANVULLEN *************************************************
            // SQL-statement om wandelroutes gefilterd om range op te vragen 
            String sql = "";


            // SQL-commando aanmaken op basis van ons SQL-statement
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            // 2) AANVULLEN **********************************
            // parameters in het SQL-commando een waarde geven


            // de connectie met de databank openen
            _mySqlConnection.Open();

            // met ExecuteReader laat je een leescommando opstarten
            // ingelezen informatie komt in mySqlDataReader terecht
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            // lusje om alle records in mySqlDataReader te overlopen
            while (mySqlDataReader.Read() == true)
            {
                // nieuwe wandelroute maken met de actieve record in mySqlDataReader
                Wandelroute wandelroute = new Wandelroute((int)(mySqlDataReader["id"]), mySqlDataReader["naam"].ToString(), (int)(mySqlDataReader["kilometers"]), mySqlDataReader["gemeente"].ToString(), mySqlDataReader["provincie"].ToString());

                // voeg de wandelroute toe aan de lijst
                lijst.Add(wandelroute);
            }

            // de connectie met de databank terug sluiten
            _mySqlConnection.Close();

            // lijst met alle wandelroutes teruggeven
            return lijst;
        }

        // methode om alle wandelroutes uit een gegeven gemeente te wissen
        public void DeleteRecordsGemeente(String gemeente)
        {
            // 1) AANVULLEN *****************************************************
            // SQL-statement om wandelroutes uit een bepaalde gemeente te wissen
            String sql = "";


            // SQL-commando aanmaken op basis van ons SQL-statement
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            // 2) AANVULLEN **********************************
            // parameters in het SQL-commando een waarde geven


            // de connectie met de databank openen
            _mySqlConnection.Open();

            // 3) AANVULLEN *********************************************************************
            // mySqlCommand opstarten waarmee je wandelroutes van de gegeven gemeente laat wissen


            // de connectie met de databank terug sluiten
            _mySqlConnection.Close();
        }

        // methode om de naam van de langste wandelroute op te halen
        public String ReadLangsteWandelroute()
        {
            String langste = "";

            // 1) AANVULLEN ****************************************************
            // SQL-statement om de naam van de langste wandelroute op te vragen 
            String sql = "";

            // SQL-commando aanmaken op basis van ons SQL-statement
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            // de connectie met de databank openen
            _mySqlConnection.Open();

            // 2) AANVULLEN *******************************************************************************
            // mySqlCommand opstarten waarmee je de langste wandelroute laat inlezen (in variabele langste)
            //   dit mySqlCommand haalt maar één waarde op uit de databank!
            // opgehaalde waarde converteren (van Object) naar String
            

            // de connectie met de databank terug sluiten
            _mySqlConnection.Close();

            // totaal aantal kms teruggeven
            return langste;
        }
    }
}
