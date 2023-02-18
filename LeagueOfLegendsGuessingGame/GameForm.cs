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
    public partial class GameForm : Form
    {
        GameBL gameBL=new GameBL();
 
        public GameForm()
        {
         
            InitializeComponent();
            gameBL.SetPictureBox(qPictureBox,wPictureBox,ePictureBox,rPictureBox);
            gameBL.SetGuessingFieldAndGuessingResponse(guessingField,guessingResponse);
            gameBL.SetDivision(divisionLabel);
            gameBL.SetSeriesLabel(SeriesLabel);
            gameBL.InitializeFirstRound();


        }
        private void SkipToNextRound() {
            gameBL.GenerateRandomChampion();
            gameBL.GenerateRandomAbility();
            gameBL.GameLost();
        }
        private void guessingBtn_Click(object sender, EventArgs e)
        {
            gameBL.GuessTheChampion(); 
        }

        private void skipBtn_Click(object sender, EventArgs e)
        {
            // SkipToNextRound();
         
        }
    }
}
