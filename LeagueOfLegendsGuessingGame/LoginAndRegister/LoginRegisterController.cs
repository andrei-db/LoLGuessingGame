using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
        GameClientForm gameClient;
        LoginRegisterForm currentForm;
    
        MySqlCommand cmd;
        MySqlDataReader loginReader;
        public void Login(string username,string password) {
         
            string loginQuery = "SELECT username,password FROM accounts WHERE username='"+
                username+"' AND password='"+password+"'";
         
            cmd = new MySqlCommand(loginQuery, DBConnection.Connect());
            loginReader = cmd.ExecuteReader();

            if (loginReader.Read()) {
                  gameClient = new GameClientForm();
                gameClient.Show();
                currentForm.Hide();
            }
 
        }
        public void Register(string username, string password)
        {
            string registerQuery = "INSERT INTO accounts(username,password)" +
               " VALUES (@username,@password)";

            MySqlCommand cmdRegister = new MySqlCommand(registerQuery, DBConnection.Connect());

            cmdRegister.Parameters.AddWithValue("@username", username);
            cmdRegister.Parameters.AddWithValue("@password", password);

            cmdRegister.ExecuteReader();

            initializeStats(username);

        }

        private void initializeStats(string username)
        {
            string statsQuery = "INSERT INTO stats(username,division,lp,games_played,wins,losses)" +
               " VALUES (@username,@division,@lp,@games_played,@wins,@losses)";

            MySqlCommand cmd = new MySqlCommand(statsQuery, DBConnection.Connect());

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@division", "IRON IV");
            cmd.Parameters.AddWithValue("@lp", 0);
            cmd.Parameters.AddWithValue("@games_played", 0);
            cmd.Parameters.AddWithValue("@wins", 0);
            cmd.Parameters.AddWithValue("@losses", 0);

            cmd.ExecuteReader();

        }

        private void CreateAccount(string username,string password) {
           
        }
       
        private void InitializeAccount(string username) {
           
      
        }
        public void SetCurrentForm(LoginRegisterForm form) {
            currentForm = form;
        }
    }
}
