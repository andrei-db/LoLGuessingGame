using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueOfLegendsGuessingGame
{
    internal class GameBL
    {
        LoLChampions loLChampions;
        string[] champPool;
        string path = "D:\\PersonalProjects\\LeagueOfLegendsGuessingGame\\RiotData\\10.10.3224670\\data\\en_US\\championFull.json";
        string abilitiesImagesPath = "D:\\PersonalProjects\\LeagueOfLegendsGuessingGame\\RiotData\\10.10.3224670\\img\\spell\\";
        string lockedImagePath = "D:\\PersonalProjects\\LeagueOfLegendsGuessingGame\\Images\\locked.jpg";
        Label divisionLabel;
        Label seriesLabel;
        private string champGenerated;
        PictureBox[] abilitiesPB=new PictureBox[4];
        TextBox guessingField; Label guessingResponse;
        Random random = new Random();
        int randomChampionIndex,randomAbilityIndex;
        int lpValue = 0;
        int lpPerWin = 100;
        int lpPerLose = 20;
        int currentDivisionIndex = 0;
        int currentSubDivisionIndex = 0;
        string[,] divisions = new string[6, 4] {
        {"IRON IV","IRON III","IRON II","IRON I" },
        {"BRONZE IV","BRONZE III","BRONZE II","BRONZE I" },
        {"SILVER IV","SILVER III","SILVER II","SILVER I" },
        {"GOLD IV","GOLD III","GOLD II","GOLD I" },
        {"PLATINUM IV","PLATINUM III","PLATINUM II","PLATINUM I" },
        {"DIAMOND IV","DIAMOND III","DIAMOND II","DIAMOND I" }
        };
        Color[] divisionsColors = new Color[6] {
            Color.Yellow,
            Color.RosyBrown,
            Color.Gray,
            Color.Yellow,
            Color.Green,
            Color.Cyan
        };
        public void InitializeFirstRound() {
  
            loLChampions = JsonConvert.DeserializeObject<LoLChampions>(File.ReadAllText(path));
            champPool = new string[loLChampions.data.Count];
            int index = 0;
            foreach (var champ in loLChampions.data) {
                champPool[index++] = champ.Key;
            }
            divisionLabel.Text = divisions[currentDivisionIndex,currentSubDivisionIndex] +": "+lpValue+" LP";
            divisionLabel.BackColor= divisionsColors[currentDivisionIndex];

            GenerateRandomChampion();
            GenerateRandomAbility();
        }
       

        public void GenerateRandomChampion() {
            randomChampionIndex = random.Next(0, champPool.Length);
            champGenerated = champPool[randomChampionIndex];
            Debug.WriteLine(champGenerated);
        }
        public void GenerateRandomAbilityIndex()
        {
            randomAbilityIndex = random.Next(0, 4);
        }
        private void LockAllAbilities() {
            for (int i=0;i<4;i++) {
                abilitiesPB[i].Image= System.Drawing.Image.FromFile(lockedImagePath);
            }
        }
        private void UnlockOneAbility() {
            GenerateRandomAbilityIndex();
            abilitiesPB[randomAbilityIndex].Image= System.Drawing.Image.FromFile(abilitiesImagesPath + loLChampions.data[champPool[randomChampionIndex]].spells[randomAbilityIndex].image.full);

        }
        public void GenerateRandomAbility() {

            LockAllAbilities();
            UnlockOneAbility();
           
        }
        public void GuessTheChampion() {
            if (guessingField.Text != "")
            {
                if (guessingField.Text.ToLower() == champGenerated.ToLower())
                {
                    guessingResponse.Text = "Correct";
                    guessingResponse.BackColor = System.Drawing.Color.Lime;
                    GameWon();
                    GenerateRandomChampion();
                    GenerateRandomAbility();
                }
                else
                {
                    guessingResponse.Text = "Wrong";
                    guessingResponse.BackColor = System.Drawing.Color.Red;
                    
                }
            }
        }
        bool startSeries = false;
       
        private void GameWon() 
        {
            lpValue += lpPerWin;
            if (startSeries) {
                seriesGames[seriesGameNumberIndex] = "Win";
                seriesGameNumberIndex++;
                seriesWins++;
                if (seriesWins==1) {
                    startSeries = false;
                    currentDivisionIndex++;
                    currentSubDivisionIndex = 0;
                    lpValue = 0;seriesWins = 0;
                    divisionLabel.BackColor = divisionsColors[currentDivisionIndex];
                        }
            }
            else if (lpValue >= 100)
            {
                lpValue = 100;
                if (currentSubDivisionIndex == 3)
                {
                    startSeries = true;

                }
                else {
                    lpValue = 0;
                    currentSubDivisionIndex++;
                }
            }
          
            UpdateDivision();
        }
     
        string[] seriesGames = new string[5] { "Game 1", "Game 2", "Game 3", "Game 4", "Game 5" };
        int seriesGameNumberIndex = 0;
        int seriesWins = 0;
        private void UpdateDivision()
        {

            if (!startSeries)
            {
                string seriesStr = null;
                for (int i = 0; i < seriesGames.Length; i++)
                {
                    
                    seriesStr += seriesGames[i];
                    if (i < seriesGames.Length - 1) seriesStr += " ";
                    seriesLabel.Text =  seriesStr;
                }

            }
            
            else {
                string seriesStr = null;
                for (int i=0;i<seriesGames.Length;i++) {
                   
                    seriesStr += seriesGames[i] + " ";
                    if (i < seriesGames.Length - 1) seriesStr += " ";
                    seriesLabel.Text = seriesStr ;
                }
                
            }
            divisionLabel.Text = divisions[currentDivisionIndex, currentSubDivisionIndex] + ": " + lpValue + " LP";
        }
       
     
        public void GameLost()
        {
            lpValue -= lpPerLose;
            if (divisions[currentDivisionIndex,currentSubDivisionIndex].Contains("IRON") && lpValue<0) {
                lpValue = 0;
            }
            if (startSeries)
            {
                seriesGames[seriesGameNumberIndex] = "Lost";
                seriesGameNumberIndex++;
            }
            UpdateDivision();
        }
        public void SetPictureBox(PictureBox qPB, PictureBox wPB, PictureBox ePB, PictureBox rPB) {
            abilitiesPB[0]= qPB;
            abilitiesPB[1] = wPB;
            abilitiesPB[2] = ePB;
            abilitiesPB[3] = rPB;
        }
        public void SetGuessingFieldAndGuessingResponse(TextBox guessingField,Label guessingResponse) {
            this.guessingField = guessingField;
            this.guessingResponse = guessingResponse;
        }

        public void SetDivision(Label divisionLabel)
        {
            this.divisionLabel = divisionLabel;
        }
        public void SetSeriesLabel(Label seriesLabel)
        {
            this.seriesLabel = seriesLabel;
        }
    }
}
