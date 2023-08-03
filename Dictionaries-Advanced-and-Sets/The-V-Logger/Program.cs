using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    class Vlogger
    {
        public string Name { get; set; }
        public SortedSet<string> Follower { get; set; }
        public int FollowingCount { get; set; }

        public Vlogger(string name, SortedSet<string> follower, int followingCount)
        {
            Name = name;
            Follower = follower;
            FollowingCount = followingCount;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var vloggers = new List<Vlogger>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                var split = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string vlogger = split[0];
                string command = split[1];
                string vloggerToFollow = split[2];

                if (command == "followed" && vloggers.Any(x => x.Name == vloggerToFollow)
                    && vloggers.Any(x => x.Name == vlogger)
                    && vloggerToFollow != vlogger)
                {

                    bool existingFollowerCheck = false;

                    foreach (var followedVlogger in vloggers)
                    {
                        if (followedVlogger.Name == vloggerToFollow)
                        {
                            if (!followedVlogger.Follower.Contains(vlogger))
                            {
                                followedVlogger.Follower.Add(vlogger);
                                break;
                            }
                            else if (followedVlogger.Follower.Contains(vlogger))
                            {
                                existingFollowerCheck = true; ;
                                break;
                            }
                        }
                    }

                    if (!existingFollowerCheck)
                    {
                        foreach (var theFollower in vloggers)
                        {
                            if (theFollower.Name == vlogger)
                            {
                                theFollower.FollowingCount++;
                                break;
                            }
                        }
                    }
                }
                else if (command == "joined")
                {
                    if (!vloggers.Any(x => x.Name.Contains(vlogger)))
                    {
                        vloggers.Add(new Vlogger(vlogger, new SortedSet<string>(), 0));
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            vloggers = vloggers.OrderByDescending(x => x.Follower.Count).ThenBy(x => x.FollowingCount).ToList();

            bool firstVloggerCheck = false;
            int index = 0;

            foreach (var vlogger in vloggers)
            {
                if (!firstVloggerCheck)
                {
                    index++;

                    Console.WriteLine($"{index}. {vlogger.Name} : {vlogger.Follower.Count} followers, {vlogger.FollowingCount} following");

                    foreach (var follower in vlogger.Follower)
                    {
                        Console.WriteLine($"*  {follower}");
                    }

                    firstVloggerCheck = true;
                }
                else
                {
                    index++;
                    Console.WriteLine($"{index}. {vlogger.Name} : {vlogger.Follower.Count} followers, {vlogger.FollowingCount} following");
                }
            }
        }
    }
}