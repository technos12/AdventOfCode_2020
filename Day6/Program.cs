using System;
using System.Collections.Generic;
using System.Linq;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Data.GetData();

            List<string> groups = new List<string>();

            int totalYes = 0;

            string groupData = "";

            foreach (string line in data)
            {
                if (line == "")
                {
                    groups.Add(groupData.TrimEnd());
                    groupData = "";
                }
                else
                {
                    groupData += line + " ";
                }
            }

            if (groupData != "")
            {
                groups.Add(groupData.TrimEnd());
                groupData = "";
            }

            //Traiter les données
            var aToZ = from ch in "abcdefghijklmnopqrstuvwxyz" select ch;

            for (int i = 0; i < groups.Count; i++)
            {
                string group = groups[i];

                group = group.Replace(" ", "");

                int nbYes = 0;

                foreach (char carac in aToZ)
                {
                    if (group.Contains(carac))
                    {
                        nbYes++;
                        group = group.Replace(carac.ToString(), "");
                        if (group == "")
                            break;
                    }
                }

                totalYes += nbYes;
            }

            Console.WriteLine("Nb total yes : " + totalYes);
        }
    }
}
