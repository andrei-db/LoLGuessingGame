using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsGuessingGame
{
    internal class PlayerStats
    {
        string username;
        Division division;
        int wins;
        int losses;
        int gamesPlayed;

        List<MatchHistory> matchHistory=new List<MatchHistory>();
        public PlayerStats(string username,Division division,int gamesPlayed,int wins,int losses) {
            this.division= division;
            this.gamesPlayed=gamesPlayed;
            this.wins=wins;
            this.losses =losses;
            this.username= username;
        }
        public int GetWins() {
            return wins;
        }
        public void SetWins(int wins) {
            this.wins = wins;
        }
        public int GetLosses()
        {
            return losses;
        }
        public int GetGamesPlayed()
        {
            return gamesPlayed;
        }
        public string GetUsername()
        {
            return username;
        }
        public Division GetDivision() {
            return division;
        }
        
    }
}
