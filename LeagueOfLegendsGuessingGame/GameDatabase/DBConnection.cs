using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsGuessingGame
{
    internal class DBConnection
    {
        string server = "localhost";
        string database = "lol_guessing_game";
        string username = "andreidb_lol";
        string password = "12345";
        string connstring = null;
        MySqlConnection conn;
        public MySqlConnection Connect() {
            connstring = "server=" + server + ";uid=" + username + ";password=" + password + ";database=" + database;
            conn= new MySqlConnection(connstring);
            conn.Open();
            return conn;
        }
        public void CloseConnection() {
            conn.Close();
        }
         
        
    }
}
