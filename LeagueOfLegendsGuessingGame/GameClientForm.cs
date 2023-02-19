using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueOfLegendsGuessingGame
{
    public partial class GameClientForm : Form
    {
        GameClientController gameClientController=new GameClientController();
        public GameClientForm()
        {
            InitializeComponent();
            gameClientController.SetCurrentForm(this);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            gameClientController.Logout();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            gameClientController.Play();
        }
    }
}
