using System;

namespace SportsOracle
{
    static class Oracle
    {
        private static bool TryParseTeams(string teams, out string team1, out string team2, out Random rand)
        {
            var parts = teams.Split('-');

            if (parts.Length != 2)
            {
                team1 = null;
                team2 = null;
                rand = null;

                return false;
            }

            // Remove whitespaces from front and back:
            team1 = parts[0].Trim();
            team2 = parts[1].Trim();

            // A little hack: Ensure that we get the same random numbers for equal team strings.
            rand = new Random((team1 + team2).GetHashCode());

            return (team1.Length > 0) && (team2.Length > 0);
        }

        public static void PredictResult(string teams)
        {
            if (!TryParseTeams(teams, out var team1, out var team2, out var rand))
            {
                Console.WriteLine("Bad team format for result prediction.");
                return;
            }

            var team1Result = rand.Next(0, 11);
            var team2Result = rand.Next(0, 11);

            Console.WriteLine("========== Result Oracle ==========");
            Console.WriteLine("{0} vs. {1}:   {2} : {3}", team1, team2, team1Result, team2Result);

            if (team1Result != team2Result)
            {
                Console.WriteLine("{0} will win!", (team1Result > team2Result) ? team1 : team2);
            }
            else
            {
                Console.WriteLine("It will be a tie!");
            }

            Console.WriteLine("===================================\n");
        }

        public static void PredictExtraTime(string teams)
        {
            if (!TryParseTeams(teams, out var team1, out var team2, out var rand))
            {
                Console.WriteLine("Bad team format for extra time prediction.");
                return;
            }

            Console.WriteLine("========== Extra Time Oracle ==========");

            switch (rand.Next(3))
            {
            case 0: Console.WriteLine("The match terminates after 90 minutes."); break;
            case 1: Console.WriteLine("There are 2x15 minutes of extra time."); break;
            default: Console.WriteLine("There are 2x15 minutes of extra time and penalty shoot-outs."); break;
            }

            Console.WriteLine("=======================================\n");
        }

        public static void PredictRedCards(string teams)
        {
            if (!TryParseTeams(teams, out var team1, out var team2, out var rand))
            {
                Console.WriteLine("Bad team format for red cards prediction.");
                return;
            }

            var team1Cards = rand.Next(0, 3);
            var team2Cards = rand.Next(0, 3);

            Console.WriteLine("========== Cards Oracle ==========");
            Console.WriteLine("{0} red cards for {1}, {2} red cards for {3}", team1Cards, team1, team2Cards, team2);
            Console.WriteLine("==================================\n");
        }
    }
}
