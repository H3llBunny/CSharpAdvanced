using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    internal class Contest
    {
        public string ContestName { get; set; }
        public int Points { get; set; }

        public Contest(string contestName, int points)
        {
            ContestName = contestName;
            Points = points;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var contests = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "end of contests")
            {
                var tokens = input.Split(':');
                string contest = tokens[0];
                string password = tokens[1];
                contests.Add(contest, password);
            }

            string command = string.Empty;
            var users = new SortedDictionary<string, List<Contest>>();

            while ((command = Console.ReadLine()) != "end of submissions")
            {
                var tokens = command.Split("=>");
                string contest = tokens[0];
                string password = tokens[1];
                string user = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contests.TryGetValue(contest, out string storedPassword) && storedPassword == password)
                {
                    users.TryAdd(user, new List<Contest>());
                    var userContests = users[user];
                    var existingContest = userContests.FirstOrDefault(c => c.ContestName == contest);

                    if (existingContest != null)
                    {
                        existingContest.Points = Math.Max(existingContest.Points, points);
                    }
                    else
                    {
                        userContests.Add(new Contest(contest, points));
                    }
                }
            }

            string topCandidate = users
                .OrderByDescending(u => u.Value.Sum(c => c.Points))
                .First()
                .Key;

            Console.WriteLine($"Best candidate is {topCandidate} with total {users[topCandidate].Sum(c => c.Points)} points.");

            var sortedUsers = users.ToDictionary(user => user.Key, user => user.Value.OrderByDescending(x => x.Points).ToList());

            Console.WriteLine("Ranking: ");

            foreach (var user in sortedUsers)
            {
                Console.WriteLine(user.Key);

                foreach (var contest in user.Value)
                {
                    Console.WriteLine($"#  {contest.ContestName} -> {contest.Points}");
                }
            }
        }
    }
}