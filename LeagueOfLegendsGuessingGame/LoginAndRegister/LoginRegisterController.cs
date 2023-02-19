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
        public void Login(string username,string password) {
            login = new Login(username,password);

            string query = "SELECT username,password FROM accounts WHERE username='"+login.GetUsername()+"' AND password='"+login.GetPassword()+"'";
            MySqlCommand cmd= new MySqlCommand(query, dBConnection.Connect());
            MySqlDataReader reader=cmd.ExecuteReader();

            if (reader.Read()) {
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
        private void CreateAccount(string username,string password) {
            string registerQuery = "INSERT INTO accounts(username,password)" +
                " VALUES ('" + username + "','" + password + "')";

            MySqlCommand cmdRegister = new MySqlCommand(registerQuery, dBConnection.Connect());

            cmdRegister.ExecuteReader();
        }
        private void InitializeAccount(string username) {
            string division = "IRON IV";
            int gp = 0; int wins = 0; int losses = 0; int lp = 0;
            string initializeDivisionQuery = "INSERT INTO account_rank(username,division,lp,games_played,wins,losses) VALUES (@username,@division,@lp,@games_played,@wins,@losses)";
            MySqlCommand cmdRank = new MySqlCommand(initializeDivisionQuery, dBConnection.Connect());
            cmdRank.Parameters.AddWithValue("@username", username);
            cmdRank.Parameters.AddWithValue("@division", division);
            cmdRank.Parameters.AddWithValue("@lp", lp);
            cmdRank.Parameters.AddWithValue("@games_played", gp);
            cmdRank.Parameters.AddWithValue("@wins", wins);
            cmdRank.Parameters.AddWithValue("@losses", losses);
            cmdRank.ExecuteReader();
        }
        public void SetCurrentForm(LoginRegisterForm form) {
            currentForm = form;
        }
    }
}
