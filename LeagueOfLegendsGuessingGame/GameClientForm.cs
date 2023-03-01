using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

           

            historyPanel.Hide();

            gameClientController.SetCurrentForm(this);
            gameClientController.ShowStats(gamesPlayedLabel,winsLabel,lossesLabel,winrateLabel);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            gameClientController.Logout();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            gameClientController.Play();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            historyPanel.Show();
            gameClientController.showMatchHistory(historyGrid);

        }

        private void divisionPB_Click(object sender, EventArgs e)
        {
            
           
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            historyPanel.Hide();
        }
       
    }
}
