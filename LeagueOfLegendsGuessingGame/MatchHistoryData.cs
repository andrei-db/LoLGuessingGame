using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsGuessingGame
{
    internal class MatchHistoryData
    {

        private string result;
        private string score;
        private int lp;

        public MatchHistoryData(string result, string score, int lp)
        {
            this.result = result;
            this.score = score;
            this.lp = lp;
        }

        public string GetResult() {
               return result;
        }
        public string GetScore() {
            return score;
        }

        public int GetLp() {

            return lp;
        }
    }
}
