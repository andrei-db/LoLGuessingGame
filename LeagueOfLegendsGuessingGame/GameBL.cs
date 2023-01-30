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

        private string champGenerated;
        PictureBox[] abilitiesPB=new PictureBox[4];
        PictureBox qPB; PictureBox wPB; PictureBox ePB; PictureBox rPB;
        TextBox guessingField; Label guessingResponse;
        Random random = new Random();
        int randomChampionIndex,randomAbilityIndex;
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
       
    }
}
