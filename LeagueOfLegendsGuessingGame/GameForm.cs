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
        GameController gameController=new GameController();
 
        public GameForm()
        {
         
            InitializeComponent();
            gameController.SetData(Result0, Result1, Result2, Result3, Result4,
                qPictureBox,wPictureBox,ePictureBox,rPictureBox,
                guessingField,
                this);
            gameController.InitializeFirstRound();


        }
   
        private void guessBtn_Click(object sender, EventArgs e)
        {
            gameController.GuessTheChampion();
        }

        private void surrenderBtn_Click(object sender, EventArgs e)
        {
            gameController.Surrender();
         
        }

        private void idkBtn_Click(object sender, EventArgs e)
        {
            gameController.Idk();
        }
    }
}
