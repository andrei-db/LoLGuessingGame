using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsGuessingGame
{
    internal class GameClientController
    {
        GameClientForm currentForm;
        public void Play()
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
            currentForm.Hide();
        }
        public void Logout() {
            LoginRegisterForm loginRegisterForm= new LoginRegisterForm();
            loginRegisterForm.Show();
            currentForm.Hide();
        }

         public void SetCurrentForm(GameClientForm gameClientForm)
        {
            currentForm= gameClientForm;
        }
      
    }
}
