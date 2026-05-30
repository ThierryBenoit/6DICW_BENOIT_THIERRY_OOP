using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BL;

namespace DL
{
    public class Database
    {
        private String _connString;
        private MySqlConnection _mySqlConnection;

        public Database()
        {
            _connString = "server=localhost;user=root;database=rider_db;password=1234;";
            _mySqlConnection = new MySqlConnection(_connString);
        }

        public List<Wielrenner> ReadTable()
        {
            List<Wielrenner> lijst = new List<Wielrenner>();
            String sql = "SELECT * FROM rider_all_time_rankings ORDER BY rider_id;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);
            _mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                Wielrenner wielrenner = new Wielrenner(
                    (int )mySqlDataReader["rider_id"],
                    mySqlDataReader["name"].ToString(),
                    mySqlDataReader["nationality"].ToString(),
                    (DateTime)mySqlDataReader["birthdate"],
                    mySqlDataReader["gender"].ToString(),
                    (int)mySqlDataReader["total_wins"],
                    (decimal)mySqlDataReader["total_points"],
                    (int)mySqlDataReader["ranking"]
                    );
                lijst.Add(wielrenner);
            }
            mySqlDataReader.Close();
            _mySqlConnection.Close();
            return lijst;
        }
        public void DeleteRenner(int riderID)
        {
            string sql = "DELETE FROM rider_all_time_rankings WHERE rider_id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, _mySqlConnection);
            cmd.Parameters.AddWithValue("@id", riderID);
                _mySqlConnection.Open();
    cmd.ExecuteNonQuery();
    _mySqlConnection.Close();
        }
    }
}

