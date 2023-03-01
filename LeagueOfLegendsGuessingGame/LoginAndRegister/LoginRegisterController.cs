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
        
        LoginRegisterForm currentForm;
    
        MySqlCommand cmd;
        MySqlDataReader reader;
        public void Login(string username,string password) {
         
            string loginQuery = "SELECT username,password FROM accounts WHERE username='"+
                username+"' AND password='"+password+"'";
         
            cmd = new MySqlCommand(loginQuery, DBConnection.Connect());
            reader = cmd.ExecuteReader();

            if (reader.Read()) {
                GetStatsFromDB(username);
                GameClientForm gameClient = new GameClientForm();
                gameClient.Show();
                currentForm.Hide();
            }

            
 
        }
        public void GetStatsFromDB(string username) {
            string statsQuery = "SELECT username,division,lp FROM ranked WHERE username='" +
                username +"'";
            cmd = new MySqlCommand(statsQuery,DBConnection.Connect());
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
               
                StatsData.GetData(reader["username"].ToString(), reader["division"].ToString(), 
                    Int32.Parse( reader["lp"].ToString()));

          
            }
            
        }
        public void Register(string username, string password)
        {
            string registerQuery = "INSERT INTO accounts(username,password)" +
               " VALUES (@username,@password)";

            cmd = new MySqlCommand(registerQuery, DBConnection.Connect());

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.ExecuteReader();

            initializeStats(username);

        }

        private void initializeStats(string username)
        {
            string statsQuery = "INSERT INTO stats(username,division,lp)" +
               " VALUES (@username,@division,@lp)";

            cmd = new MySqlCommand(statsQuery, DBConnection.Connect());

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@division", "IRON IV");
            cmd.Parameters.AddWithValue("@lp", 0);

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
