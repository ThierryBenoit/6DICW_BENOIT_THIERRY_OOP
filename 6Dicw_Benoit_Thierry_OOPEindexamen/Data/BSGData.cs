using Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BSGData
    {
        private String _connString;
        private MySqlConnection _mySqlConnection;

        public BSGData()
        {
            _connString = "server=localhost;user id=root;Password=1234; database = cylondetector";
            _mySqlConnection = new MySqlConnection(_connString);
        }
        public List<Personage> ReadPersonageTable()
        {
            List<Personage> lijst = new List<Personage>();
            String sql = "SELECT * FROM personages ORDER BY id;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);
            _mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                Personage personage = new Personage(
                    (int)(mySqlDataReader["Id"]),
                    mySqlDataReader["Naam"].ToString(),
                    (int)(mySqlDataReader["PlaneetId"]),
                    (int)(mySqlDataReader["SchipId"]),
                    (bool)(mySqlDataReader["IsCylon"]),
                    mySqlDataReader["Rol"].ToString(),
                    (int)(mySqlDataReader["Leeftijd"]));

                lijst.Add(personage);
            }

            _mySqlConnection.Close();
            return lijst;
        }

        public List<Planeet> ReadPlaneetTable()
        {
            List<Planeet> lijst = new List<Planeet>();
            String sql = "SELECT * FROM planeten ORDER BY id;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);
            _mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                Planeet planeet = new Planeet(
                    Convert.ToInt32(mySqlDataReader["Id"]),
                    mySqlDataReader["Naam"].ToString(),
                    mySqlDataReader["Zonnestelsel"].ToString(),
                    (int)Convert.ToInt64(mySqlDataReader["WaterLiters"]),
                    Convert.ToBoolean(mySqlDataReader["Bewoonbaar"])
                    );
                lijst.Add(planeet);
            }
            _mySqlConnection.Close();
            return lijst;
        }

        public List<Schip> ReadVlootTable()
        {
            List<Schip> lijst = new List<Schip>();
            String sql = "Select * From vloot ORDER BY Id";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);
            _mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read() == true)
            {
                Schip schip = new Schip(
                    (int)(mySqlDataReader["Id"]),
                    mySqlDataReader["Naam"].ToString(),
                    mySqlDataReader["Type"].ToString(),
                    (int)(mySqlDataReader["Bouwjaar"]),
                    (int)(mySqlDataReader["AantalBemanning"]),
                    mySqlDataReader["Status"].ToString()
                    );
                lijst.Add(schip);
            }
            _mySqlConnection.Close();
            return lijst;
        }

        public void DeleteCyclon(String naam)
        {
            String sql = "DELETE FROM personages WHERE (naam = @Naam);";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@Naam", naam);
            _mySqlConnection.Open();
            mySqlCommand.ExecuteNonQuery();
            _mySqlConnection.Close();
        }
    }
}
