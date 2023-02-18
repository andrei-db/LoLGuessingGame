using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueOfLegendsGuessingGame
{
    internal class LoginRegisterController
    {
        DBConnection dBConnection = new DBConnection();
        Login login;
        Register register;
        GameForm gameForm;
        Form currentForm;
        public void Login(string username,string password) {
            login = new Login(username,password);

            string query = "SELECT username,password FROM accounts WHERE username='"+login.GetUsername()+"' AND password='"+login.GetPassword()+"'";
            MySqlCommand cmd= new MySqlCommand(query, dBConnection.Connect());
            MySqlDataReader reader=cmd.ExecuteReader();

            if (reader.Read()) {
                gameForm = new GameForm();
                gameForm.Show();
                currentForm.Hide();
                
              
            }
            dBConnection.CloseConnection();
        }
        public void Register(string username, string password)
        {
            register = new Register(username, password);
            string query = "INSERT INTO accounts(username,password) VALUES ('" + register.GetUsername() + "','" + register.GetPassword() + "')";
            MySqlCommand cmd = new MySqlCommand(query, dBConnection.Connect());
            MySqlDataReader reader = cmd.ExecuteReader();

            dBConnection.CloseConnection();
        }
        public void SetCurrentForm(Form form) {
            currentForm = form;
        }
    }
}
