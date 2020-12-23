using System;
using System.Collections.Generic;
using System.Linq;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> passes = Data.GetInputs();
            List<int> seatsID = new List<int>();

            int highestID = 0;

            foreach (string pass in passes)
            {
                string rowData = pass.Substring(0, 7);
                string columnsData = pass.Substring(7);

                int min = 0;
                int max = 127;

                foreach (char item in rowData)
                {
                    if (item == 'F')
                        max = (int)Math.Floor(max - (max - min) / 2.0);
                    else
                        min = (int)Math.Ceiling(min + (max - min) / 2.0);
                }
                int row = max;

                
                min = 0;
                max = 7;

                foreach (char item in columnsData)
                {
                    if (item == 'L')
                        max = (int)Math.Floor(max - (max - min) / 2.0);
                    else
                        min = (int)Math.Ceiling(min + (max - min) / 2.0);
                }
                int column = max;

                int seatID = row * 8 + column;

                seatsID.Add(seatID);

                if (seatID > highestID)
                    highestID = seatID;
            }

            seatsID.Sort();

            //int mySeatID = 0;

            for (int i = 1; i < seatsID.Count; i++)
            {
                if (seatsID[i] - seatsID[i-1] != 1)
                {

                }
            }

            //Console.WriteLine("Highest ID : " + highestID);
        }
    }
}
