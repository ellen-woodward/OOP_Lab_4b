using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public enum Result { Win, Draw, Loss }

    internal class Team : IComparable<Team>
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

        public List<Player> players { get; set; }

        public Team(string name)
        {
            TeamName = name;
            players = new List<Player>();
        }

        public string DisplayTeamTable()
        {
            return string.Format($"{TeamName}\t{Points}\t{Wins}\t{Draws}\t{Losses}\t{GamesPlayed}");
        }

        public void AddResult(Result result)
        {
            GamesPlayed++;

            switch (result)
            {
                case Result.Win:
                    Wins++;
                    break;
                case Result.Draw:
                    Draws++;
                    break;
                case Result.Loss:
                    Losses++;
                    break;
            }
        }

        public int CompareTo(Team that)
        {
            return this.Points.CompareTo(that.Points);
        }
    }
}
