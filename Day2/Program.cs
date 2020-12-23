using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> values = inputs.GetInputs();

            int nbpassValid = 0;

            foreach (string input in values)
            {
                string[] parts = input.Split(' ');

                string[] minmax = parts[0].Split('-');
                /*int minOcc = int.Parse(minmax[0]);
                int maxOcc = int.Parse(minmax[1]);*/
                int pos1 = int.Parse(minmax[0]);
                int pos2 = int.Parse(minmax[1]);
                
                char letter = parts[1].Substring(0, 1).ToCharArray()[0];

                string pass = parts[2];

                if(pass[pos1-1]==letter && pass[pos2-1] != letter)
                {
                    nbpassValid++;
                }

                if (pass[pos2-1] == letter && pass[pos1-1] != letter)
                {
                    nbpassValid++;
                }


                /*int count = pass.Count(p => p == letter);
                if(count>=minOcc && count <= maxOcc)
                {
                    nbpassValid++;
                }*/
            }

            Console.WriteLine("Nb valid pass: " + nbpassValid);
        }
    }
}
