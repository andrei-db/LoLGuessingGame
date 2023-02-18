using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsGuessingGame
{
    internal class Login
    {
        
        string username;
        string password;
        public Login(string username,string password) {
            this.username = username;
            this.password = password;
        }
        public string GetUsername() {
            return username;
        }
        public string GetPassword()
        {
            return password;
        }



    }
}
