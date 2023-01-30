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
    public partial class Form1 : Form
    {
        GameBL gameBL=new GameBL();
        public Form1()
        {
            InitializeComponent();
            gameBL.StartGame();
        }
    }
}
