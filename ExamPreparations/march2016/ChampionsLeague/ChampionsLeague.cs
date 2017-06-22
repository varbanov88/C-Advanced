using System;
using System.Collections.Generic;
using System.Linq;

namespace ChampionsLeague
{
    public class ChampionsLeague
    {
        public static void Main()
        {
            string input;

            var teamsOpponents = new Dictionary<string, List<string>>();
            var teamsWins = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "stop")
            {
                var tokens = input.Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries);
                var firstTeam = tokens.First().Trim();
                var secondTeam = tokens[1].Trim();
                var firstMatchScore = tokens[2].Trim();
                var secondMatchScore = tokens[3].Trim();

                if (!teamsOpponents.ContainsKey(firstTeam))
                {
                    teamsOpponents[firstTeam] = new List<string>();
                    teamsWins[firstTeam] = 0;
                }

                if (!teamsOpponents.ContainsKey(secondTeam))
                {
                    teamsOpponents[secondTeam] = new List<string>();
                    teamsWins[secondTeam] = 0;
                }

                teamsOpponents[firstTeam].Add(secondTeam);
                teamsOpponents[secondTeam].Add(firstTeam);

                var winner = FindWinner(firstTeam, secondTeam, firstMatchScore, secondMatchScore);

                teamsWins[winner] += 1;
            }

            foreach (var team in teamsWins.OrderByDescending(w => w.Value).ThenBy(t => t.Key))
            {
                Console.WriteLine(team.Key);
                Console.WriteLine($"- Wins: {team.Value}");
                Console.WriteLine($"- Opponents: {string.Join(", ", teamsOpponents[team.Key].OrderBy(o => o))}");
            }
        }

        private static string FindWinner(string firstTeam, string secondTeam, string firstMatchScore, string secondMatchScore)
        {
            var firstTeamAwayGoals = 0;
            var secondTeamAwayGoals = 0;
            var firstTeamTotalGoals = 0;
            var secondTeamTotalGoals = 0;

            var firstMatch = firstMatchScore.Split(':').Select(int.Parse).ToArray();
            firstTeamTotalGoals += firstMatch[0];
            secondTeamTotalGoals += firstMatch[1];
            secondTeamAwayGoals += firstMatch[1];

            var secondMatch = secondMatchScore.Split(':').Select(int.Parse).Reverse().ToArray();
            firstTeamTotalGoals += secondMatch[0];
            firstTeamAwayGoals += secondMatch[0];
            secondTeamTotalGoals += secondMatch[1];

            if (firstTeamTotalGoals != secondTeamTotalGoals)
            {
                if (firstTeamTotalGoals > secondTeamTotalGoals)
                {
                    return firstTeam;
                }

                else
                {
                    return secondTeam;
                }
            }

            else
            {
                if (firstTeamAwayGoals > secondTeamAwayGoals)
                {
                    return firstTeam;
                }

                else
                {
                    return secondTeam;
                }
            }
        }
    }
}
