using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LeagueOfLegendsGuessingGame
{
    internal class StatsData
    {
        private static string classUsername;
        private static string classDivision;
        private static int classLp;


        public static void GetData(string user, string division, int lp) {
            classUsername = user;
            classDivision = division;
            classLp= lp;
 
        }

        public static string GetUsername() {
            return classUsername;
        }
        public static string GetDivision()
        {
            return classDivision;
        }
        public static int GetLp()
        {
            return classLp;
        }



    }
}
