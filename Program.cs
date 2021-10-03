using System;
using System.Collections.Generic;
using System.Linq;

namespace Recount
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> reCount = new Dictionary<string, int>();
            for (int i = 0; i < 100000; i++)
            {
                string voteName = Console.ReadLine().ToUpper();
                if (voteName == "***")
                {
                    break;
                }
                else
                {
                    if (reCount.ContainsKey(voteName))
                    {
                        reCount[voteName] += 1;
                    }
                    else
                    {
                        reCount.Add(voteName, 1);
                    }
                }
            }
            int maxVote = reCount.Values.Max();
            int x = 0;
            foreach (var vote in reCount)
            {
                if (vote.Value == maxVote)
                {
                    x++;
                }
            }
            if (x < 2)
            {
                foreach (var vote in reCount)
                {
                    if (vote.Value == maxVote)
                    {
                        string maxKey = vote.Key;
                        Console.WriteLine(maxKey);
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Runoff!");
            }
        }
    }
}