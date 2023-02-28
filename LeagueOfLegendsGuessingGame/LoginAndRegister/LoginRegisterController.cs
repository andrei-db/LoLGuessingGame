using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LeagueOfLegendsGuessingGame
{
    internal class LoginRegisterController
    {
        DBConnection dBConnection = new DBConnection();
        Login login;
        Register register;
        GameClientForm gameClient;
        LoginRegisterForm currentForm;
        PlayerStats loginPlayerStats;
        MySqlCommand cmd;
            MySqlDataReader loginCredentialsReader, playerStatsReader, playerDivisionReader;
        public void Login(string username,string password) {
            login = new Login(username,password);

            string loginQuery = "SELECT username,password FROM accounts WHERE username='"+
                login.GetUsername()+"' AND password='"+login.GetPassword()+"'";

            string playerStatsQuery = "SELECT username,games_played,wins,losses FROM account_stats WHERE username='" +
                username+ "'";
            string playerDivisionQuery = "SELECT divisionName,lp FROM account_division WHERE username='" +
                username + "'";
            cmd = new MySqlCommand(loginQuery, dBConnection.Connect());
             loginCredentialsReader=cmd.ExecuteReader();
            cmd = new MySqlCommand(playerStatsQuery, dBConnection.Connect());
             playerStatsReader = cmd.ExecuteReader();
            cmd = new MySqlCommand(playerDivisionQuery, dBConnection.Connect());
             playerDivisionReader = cmd.ExecuteReader();
            if (loginCredentialsReader.Read() && playerStatsReader.Read() && playerDivisionReader.Read()) {

                
                    loginPlayerStats = new PlayerStats(playerStatsReader["username"].ToString(),
                        new Division(playerDivisionReader["divisionName"].ToString(),int.Parse(playerDivisionReader["lp"].ToString())),
                       int.Parse(playerStatsReader["games_played"].ToString()),
                       int.Parse(playerStatsReader["wins"].ToString()), int.Parse(playerStatsReader["losses"].ToString()));
                

                Debug.WriteLine(loginPlayerStats.GetUsername()+ " " + loginPlayerStats.GetDivision().GetDivisionName()+" " + loginPlayerStats.GetGamesPlayed() + " "+loginPlayerStats.GetWins()+ " " + loginPlayerStats.GetLosses());
                
                gameClient = new GameClientForm();
                gameClient.Show();
                currentForm.Hide();

            }
            dBConnection.CloseConnection();
        }
        public void Register(string username, string password)
        {
           
            register = new Register(username, password);
            CreateAccount(register.GetUsername(),register.GetPassword());
            InitializeAccount(register.GetUsername());

            dBConnection.CloseConnection();
        }
        PlayerStats registerPlayerStats;
        private void CreateAccount(string username,string password) {
            string registerQuery = "INSERT INTO accounts(username,password)" +
                " VALUES (@username,@password)";

            MySqlCommand cmdRegister = new MySqlCommand(registerQuery, dBConnection.Connect());

            cmdRegister.Parameters.AddWithValue("@username", username);
            cmdRegister.Parameters.AddWithValue("@password",password);

            registerPlayerStats = new PlayerStats(username,new Division("IRON IV",0), 0, 0, 0);
            cmdRegister.ExecuteReader();
        }
       
        private void InitializeAccount(string username) {
           
            string initializeDivisionQuery = "INSERT INTO account_rank(username,division,lp,games_played,wins,losses) VALUES (@username,@division,@lp,@games_played,@wins,@losses)";
            MySqlCommand cmdRank = new MySqlCommand(initializeDivisionQuery, dBConnection.Connect());
           
            
            cmdRank.Parameters.AddWithValue("@username", username);
            cmdRank.Parameters.AddWithValue("@division", registerPlayerStats.GetDivision().GetDivisionName());
            cmdRank.Parameters.AddWithValue("@lp", registerPlayerStats.GetDivision().GetLp());
            cmdRank.Parameters.AddWithValue("@games_played", registerPlayerStats.GetGamesPlayed());
            cmdRank.Parameters.AddWithValue("@wins", registerPlayerStats.GetWins());
            cmdRank.Parameters.AddWithValue("@losses", registerPlayerStats.GetLosses());
            cmdRank.ExecuteReader();
        }
        public void SetCurrentForm(LoginRegisterForm form) {
            currentForm = form;
        }
    }
}
