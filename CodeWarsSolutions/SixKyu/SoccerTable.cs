using System.Collections.Generic;
using System.Linq;

namespace CodeWarsSolutions.SixKyu.SoccerTable
{
    public class TableRow
    {
        public string TeamName { get; set; }
        public int Game { get; set; }
        public int Point { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Loss { get; set; }
    }
    public struct MatchStructure
    {
        public string homeTeam { get; set; }
        public string awayTeam { get; set; }
        public int homeScore { get; set; }
        public int awayScore { get; set; }

        public MatchStructure(string HomeTeam, string AwayTeam, int HomeScore, int AwayScore)
        {
            homeTeam = HomeTeam;
            awayTeam = AwayTeam;
            homeScore = HomeScore;
            awayScore = AwayScore;
        }
    }

    public class SoccerTable
    {
        public static List<TableRow> InjectNewResult(string newResult, List<TableRow> table)
        {
            var matchResults = ParseMatchResult(newResult);
            
            var homeTeamTable = table.FirstOrDefault(x => x.TeamName == matchResults.homeTeam);
            var awayTeamTable = table.FirstOrDefault(x => x.TeamName == matchResults.awayTeam);

            if (matchResults.homeScore > matchResults.awayScore)
            {
                ProcessMatchWithNoTie(homeTeamTable, awayTeamTable);
            }

            if (matchResults.homeScore < matchResults.awayScore)
            {
                ProcessMatchWithNoTie(awayTeamTable, homeTeamTable);
            }

            if (matchResults.homeScore == matchResults.awayScore)
            {
                ProcessTie(homeTeamTable);
                ProcessTie(awayTeamTable);
            }

            return table;
        }

        private static MatchStructure ParseMatchResult(string matchResult)
        {
            var newResultStringList = matchResult.Split(' ');
            var homeTeam = newResultStringList[0];
            var awayTeam = newResultStringList[2];

            var result = newResultStringList[1].Split(':');
            var homeScore = int.Parse(result[0]);
            var awayScore = int.Parse(result[1]);

            return new MatchStructure(homeTeam, awayTeam, homeScore, awayScore);
        }
        
        private static void ProcessMatchWithNoTie(TableRow victoriousTeam, TableRow loserTeam)
        {
            victoriousTeam.Game++;
            victoriousTeam.Win++;
            victoriousTeam.Point += 3;

            loserTeam.Game++;
            loserTeam.Loss++;
        }

        private static void ProcessTie(TableRow team)
        {
            team.Game++;
            team.Draw++;
            team.Point++;
        }
    }
}
