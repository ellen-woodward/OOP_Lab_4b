using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Team
    {
        public string TeamName { get; private set; }
        public int Wins { get; private set; }
        public int Draws { get; private set; }
        public int Losses { get; private set; }
        public int GamesPlayed { get; private set; }

        private int points;
        public int Points
        {
            get { return (Wins * 3) + Draws; }
            set { points = value; }
        }

        public Team() { }

        public Team(string name)
        {
            TeamName = name;
        }

        public string DisplayTeamTable()
        {
            return string.Format($"{TeamName}\t{Points}\t{Wins}\t{Draws}\t{Losses}\t{GamesPlayed}");
           //return String.Format($"{TeamName,-15}{Points,-7}{Wins,-7}{Draws,-7}{Losses,-7}{GamesPlayed,-7}");
        }
    }
}
