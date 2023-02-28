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
        static string server = "localhost";
        static string database = "lol_guessing_game";
        static  string username = "andreidb_lol";
        static string password = "12345";
        static string connstring = null;
        static MySqlConnection conn;
        public static MySqlConnection Connect() {
            connstring = "server=" + server + ";uid=" + username + ";password=" + password + ";database=" + database;
            conn= new MySqlConnection(connstring);
            conn.Open();
            return conn;
        }

         
        
    }
}
