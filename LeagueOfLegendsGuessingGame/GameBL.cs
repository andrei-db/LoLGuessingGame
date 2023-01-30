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
        string imagePath = "D:\\PersonalProjects\\LeagueOfLegendsGuessingGame\\RiotData\\10.10.3224670\\img\\spell\\";
        private string champGenerated;
        PictureBox qPB; PictureBox wPB; PictureBox ePB; PictureBox rPB;
        TextBox guessingField; Label guessingResponse;
        Random random = new Random();
        int randomChampionIndex;
        public void StartGame() {
            loLChampions = JsonConvert.DeserializeObject<LoLChampions>(File.ReadAllText(path));
            champPool = new string[loLChampions.data.Count];
            int index = 0;
            foreach (var champ in loLChampions.data) {
                champPool[index++] = champ.Key;
            }
        }

        public void GenerateRandomChampion() {
            randomChampionIndex = random.Next(0, champPool.Length);
            champGenerated = champPool[randomChampionIndex];
        }
        
        public void GenerateChampionAbilities() {
            qPB.Image = System.Drawing.Image.FromFile(imagePath + loLChampions.data[champPool[randomChampionIndex]].spells[0].image.full);
            wPB.Image = System.Drawing.Image.FromFile(imagePath + loLChampions.data[champPool[randomChampionIndex]].spells[1].image.full);
            ePB.Image = System.Drawing.Image.FromFile(imagePath + loLChampions.data[champPool[randomChampionIndex]].spells[2].image.full);
            rPB.Image = System.Drawing.Image.FromFile(imagePath + loLChampions.data[champPool[randomChampionIndex]].spells[3].image.full);
        }
        public void GuessTheChampion() {
            if (guessingField.Text != "")
            {
                if (guessingField.Text.ToLower() == champGenerated.ToLower())
                {
                    guessingResponse.Text = "Correct";
                    guessingResponse.BackColor = System.Drawing.Color.Lime;
                    GenerateRandomChampion();
                    GenerateChampionAbilities();
                }
                else
                {
                    guessingResponse.Text = "Wrong";
                    guessingResponse.BackColor = System.Drawing.Color.Red;
                }
            }
        }
        public void SetPictureBox(PictureBox qPB, PictureBox wPB, PictureBox ePB, PictureBox rPB) {
            this.qPB= qPB;
            this.wPB = wPB;
            this.ePB =ePB;
            this.rPB = rPB;
        }
        public void SetGuessingFieldAndGuessingResponse(TextBox guessingField,Label guessingResponse) {
            this.guessingField = guessingField;
            this.guessingResponse = guessingResponse;
        }
       
    }
}
