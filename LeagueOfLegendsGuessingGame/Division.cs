using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsGuessingGame
{
    internal class Division
    {

        string divisionName;
        int lp;
        public Division(string divisionName,int lp) {
            this.divisionName = divisionName;
            this.lp = lp;
        }
        public string GetDivisionName() {
            return divisionName;
        }
        public int GetLp()
        {

            return lp;
        }
    }
}
