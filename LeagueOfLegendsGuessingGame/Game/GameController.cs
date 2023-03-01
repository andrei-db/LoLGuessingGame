using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LeagueOfLegendsGuessingGame
{
    internal class GameController
    {
        LoLChampions loLChampions;
        string[] champPool;
        string path = "D:\\PersonalProjects\\LeagueOfLegendsGuessingGame\\RiotData\\10.10.3224670\\data\\en_US\\championFull.json";
        string abilitiesImagesPath = "D:\\PersonalProjects\\LeagueOfLegendsGuessingGame\\RiotData\\10.10.3224670\\img\\spell\\";
        string lockedImagePath = "D:\\PersonalProjects\\LeagueOfLegendsGuessingGame\\Images\\locked.jpg";
        string questionMarkImagePath = "D:\\PersonalProjects\\LeagueOfLegendsGuessingGame\\Images\\question_mark.png";
        string correctAnswer = "D:\\PersonalProjects\\LeagueOfLegendsGuessingGame\\Images\\correct.png"; 
        string wrongAnswer = "D:\\PersonalProjects\\LeagueOfLegendsGuessingGame\\Images\\wrong.png";
        private string champGenerated;
        PictureBox[] abilitiesPB=new PictureBox[4];
        PictureBox[] resultsPB = new PictureBox[5];
        TextBox guessingField; Label guessingResponse;
        Random random = new Random();
        int randomChampionIndex,randomAbilityIndex;
        GameForm gameForm;
        string[,] divisions = new string[6, 4] {
        {"IRON IV","IRON III","IRON II","IRON I" },
        {"BRONZE IV","BRONZE III","BRONZE II","BRONZE I" },
        {"SILVER IV","SILVER III","SILVER II","SILVER I" },
        {"GOLD IV","GOLD III","GOLD II","GOLD I" },
        {"PLATINUM IV","PLATINUM III","PLATINUM II","PLATINUM I" },
        {"DIAMOND IV","DIAMOND III","DIAMOND II","DIAMOND I" }
        };

        int currentRound = 0;
        
       
        int gamesPlayed = 0;
        int wins = 0;
        int losses = 0;

        MySqlCommand cmd;
        MySqlDataReader reader;
        public void InitializeFirstRound() {
  
            loLChampions = JsonConvert.DeserializeObject<LoLChampions>(File.ReadAllText(path));
            champPool = new string[loLChampions.data.Count];
            int index = 0;
            foreach (var champ in loLChampions.data) {
                champPool[index++] = champ.Key;
            }
            foreach(PictureBox pb in resultsPB) {
                pb.Image=System.Drawing.Image.FromFile(questionMarkImagePath);
            }
            NewRound();
        }
       

        public void GenerateRandomChampion() {
            randomChampionIndex = random.Next(0, champPool.Length);
            champGenerated = champPool[randomChampionIndex];
            Debug.WriteLine(champGenerated);
        }
     
        private void LockAllAbilities() {
            for (int i=0;i<4;i++) {
                abilitiesPB[i].Image= System.Drawing.Image.FromFile(lockedImagePath);
            }
        }
        private void UnlockOneAbility() {
            randomAbilityIndex = random.Next(0, 4);
            abilitiesPB[randomAbilityIndex].Image= System.Drawing.Image.FromFile(abilitiesImagesPath + loLChampions.data[champPool[randomChampionIndex]].spells[randomAbilityIndex].image.full);

        }
        public void GenerateRandomAbility() {
            
            LockAllAbilities();
            UnlockOneAbility(); 
        }
        int roundsWon = 0;
        public void GuessTheChampion() {
            if (guessingField.Text != "")
            {
                if (guessingField.Text.ToLower() == champGenerated.ToLower())
                {
                    if (currentRound < 5) {
                        roundsWon++;
                        resultsPB[currentRound++].Image = System.Drawing.Image.FromFile(correctAnswer);
                    } 
                    else if (currentRound == 5)
                    {
                        WonOrLost();
                        Debug.WriteLine("response");
                        OpenGameClientFormAndCloseCurrent();
                    }

                    NewRound();
                }
                else
                {
                    
                    
                }
            }
        }

        public void Idk() {
            if(currentRound<5)resultsPB[currentRound++].Image = System.Drawing.Image.FromFile(wrongAnswer);
            else if (currentRound == 5)
            {

                WonOrLost();
               
                OpenGameClientFormAndCloseCurrent();
            }

            NewRound();
        }

        private void WonOrLost() {

            if (roundsWon > 2)
            {
                wins++;
            }
            else {
                losses++;
            }
            gamesPlayed++;

          
        }



        public void SetData(PictureBox result0, PictureBox result1, PictureBox result2, PictureBox result3, PictureBox result4,
            PictureBox qPB, PictureBox wPB, PictureBox ePB, PictureBox rPB,
            TextBox guessingField,
            GameForm gameForm
            ) {
            abilitiesPB[0] = qPB;
            abilitiesPB[1] = wPB;
            abilitiesPB[2] = ePB;
            abilitiesPB[3] = rPB;

            resultsPB[0] = result0;
            resultsPB[1] = result1;
            resultsPB[2] = result2;
            resultsPB[3] = result3;
            resultsPB[4] = result4;

            this.guessingField = guessingField;
            this.gameForm= gameForm;
        }
     


      
        public void Surrender()
        {
            //-25 lp
            AddGameToMatchHistory();
            OpenGameClientFormAndCloseCurrent();
            

        }
        private void AddGameToMatchHistory() {
            string query = "INSERT INTO history(username,result,score,lp) VALUES(@username,@result,@score,@lp)";

            MatchHistoryData mhd = new MatchHistoryData("Defeat","Surrender",-25);

            cmd = new MySqlCommand(query, DBConnection.Connect());
            cmd.Parameters.AddWithValue("@username", StatsData.GetUsername());
            cmd.Parameters.AddWithValue("@result", mhd.GetResult());
            cmd.Parameters.AddWithValue("@score", mhd.GetScore());
            cmd.Parameters.AddWithValue("@lp", mhd.GetLp());

            cmd.ExecuteReader();
        }
        private void OpenGameClientFormAndCloseCurrent() {
            GameClientForm gameClientForm = new GameClientForm();
            gameClientForm.Show();
            gameForm.Hide();
        }
        public void NewRound()
        {
            GenerateRandomChampion();
            GenerateRandomAbility();
        }
    }
}
