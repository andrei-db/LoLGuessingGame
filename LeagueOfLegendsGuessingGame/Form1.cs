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
    public partial class Form1 : Form
    {
        GameBL gameBL=new GameBL();
       
        public Form1()
        {
            InitializeComponent();
            gameBL.SetPictureBox(qPictureBox,wPictureBox,ePictureBox,rPictureBox);
            gameBL.SetGuessingFieldAndGuessingResponse(guessingField,guessingResponse);

            gameBL.StartGame();
            GenerateNewRound();


        }
        private void GenerateNewRound() {
            gameBL.GenerateRandomChampion();
            gameBL.GenerateRandomAbility();
        }
        private void guessingBtn_Click(object sender, EventArgs e)
        {
            gameBL.GuessTheChampion(); 
        }

        private void skipBtn_Click(object sender, EventArgs e)
        {
            GenerateNewRound();

        }
    }
}
