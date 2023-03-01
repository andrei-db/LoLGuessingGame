using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LeagueOfLegendsGuessingGame
{
    internal class GameClientController
    {
        GameClientForm currentForm;
        MySqlCommand cmd;
        MySqlDataReader reader;
        DataTable dt;
        DataRow dr = null;
        public void Play()
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
            currentForm.Hide();
        }
        public void Logout() {
            LoginRegisterForm loginRegisterForm= new LoginRegisterForm();
            loginRegisterForm.Show();
            currentForm.Hide();
        }

         public void SetCurrentForm(GameClientForm gameClientForm)
        {
            currentForm= gameClientForm;
        }
        public void ShowStats(System.Windows.Forms.Label gamesPlayed,
            System.Windows.Forms.Label wins, System.Windows.Forms.Label losses, System.Windows.Forms.Label winrate) {

            gamesPlayed.Text += GetGamesPlayed();
            wins.Text += GetWins();
            losses.Text += GetLosses();
            winrate.Text += GetWinrate();
        }
       
        public int GetGamesPlayed() {
            int gamesPlayed = -1;
            string query = "SELECT COUNT(id) FROM history WHERE username='" + StatsData.GetUsername() + "'";

            cmd = new MySqlCommand(query, DBConnection.Connect());

            reader = cmd.ExecuteReader();

            while (reader.Read()) {
                gamesPlayed= Int32.Parse(reader["COUNT(id)"].ToString());
            }

            return gamesPlayed;
        }
        public int GetWins() {
            int wins = -1;
            string query = "SELECT COUNT(id) FROM history WHERE username='" + StatsData.GetUsername() + "' AND result='Victory'";

            cmd = new MySqlCommand(query, DBConnection.Connect());

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                wins = Int32.Parse(reader["COUNT(id)"].ToString());
               
            }

            return wins;
        }
        public int GetLosses() {
            int losses = -1;
            string query = "SELECT COUNT(id) FROM history WHERE username='" + StatsData.GetUsername() + "' AND result='Defeat'";

            cmd = new MySqlCommand(query, DBConnection.Connect());

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                losses = Int32.Parse(reader["COUNT(id)"].ToString());
            }

            return losses;
        }
        public double GetWinrate() {
            double winrate = -1;

            winrate=((double)GetWins()/GetGamesPlayed())*100;

            return winrate; 
        }
        public List<MatchHistoryData>GetMatchHistory() {

            List<MatchHistoryData>listData= new List<MatchHistoryData>();
            string query = "SELECT * FROM history WHERE username='"+ StatsData.GetUsername() + "'";



            cmd = new MySqlCommand(query, DBConnection.Connect());
            
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                MatchHistoryData mhd = new MatchHistoryData(reader["result"].ToString(),
                    reader["score"].ToString(), Int32.Parse(reader["lp"].ToString()));

                listData.Add(mhd);
            }
            return listData;
        }
        List<MatchHistoryData> mhListData;
        public void showMatchHistory(DataGridView gridView)
        {
            mhListData =GetMatchHistory();

            dt = new DataTable();


            dt.Columns.Add(new DataColumn("Result", typeof(string)));
            dt.Columns.Add(new DataColumn("Score", typeof(string)));
            dt.Columns.Add(new DataColumn("LP", typeof(int)));

            foreach (var x in mhListData)
            {
                dr = dt.NewRow();
                dr["Result"] = x.GetResult();
                dr["Score"] = x.GetScore();
                dr["LP"] = x.GetLp();
                dt.Rows.Add(dr);
            }

            gridView.DataSource = dt;
        }



    }
}
