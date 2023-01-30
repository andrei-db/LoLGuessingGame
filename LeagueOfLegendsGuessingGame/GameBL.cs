using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsGuessingGame
{
    internal class GameBL
    {
        LoLChampions loLChampions;
        string[] champPool;
        string path = "D:\\PersonalProjects\\LeagueOfLegendsGuessingGame\\RiotData\\10.10.3224670\\data\\en_US\\champion.json"; 
        public void StartGame() {
            loLChampions = JsonConvert.DeserializeObject<LoLChampions>(File.ReadAllText(path));
            champPool=new string[loLChampions.data.Count];
            int index = 0;
            foreach (var champ in loLChampions.data) {
                champPool[index++]=champ.Key; 
               
            }

            generateRandomChampion();


        }
        Random random = new Random();
        private void generateRandomChampion() {
            int randomChampionIndex=random.Next(0,champPool.Length);
            Debug.WriteLine(champPool[randomChampionIndex]);
        }
    }
}
