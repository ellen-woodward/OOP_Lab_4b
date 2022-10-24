using Q1;

Team SligoRovers = new Team("Sligo Rovers");
Team FinnHarps = new Team("Finn Harps");
Team GalwayUnited = new Team("Galway United");
Team DerryCity = new Team("Derry City");
Team Dundalk = new Team("Dundalk FC");

List<Team> teams = new List<Team>();

teams.Add(SligoRovers);
teams.Add(FinnHarps);
teams.Add(GalwayUnited);
teams.Add(DerryCity);
teams.Add(Dundalk);

void DisplayTeams(List<Team> teams)
{
    Console.WriteLine($"Name\t\tPoints\tWins\tDraws\tLosses\tPlayed\t");

    foreach (Team team in teams)
    {
        Console.WriteLine(team.DisplayTeamTable());
    }
}

SligoRovers.AddResult(Result.Win);
FinnHarps.AddResult(Result.Loss);
FinnHarps.AddResult(Result.Draw);
GalwayUnited.AddResult(Result.Win);
Dundalk.AddResult(Result.Loss);

DisplayTeams(teams);
