using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day19
{
    public static class Data
    {
        public static List<string> GetRules()
        {
            List<string> lines = new List<string>();

            using (StreamReader file = new StreamReader("rules.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;
        }

        public static List<string> GetMessages()
        {
            List<string> lines = new List<string>();

            using (StreamReader file = new StreamReader("messages.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;
        }
    }
}
