using System;
using System.Collections.Generic;

namespace AdventOfCode_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> inputs = input.GetInputs();

            int answer = 0;
            bool answerfound = false;

            foreach (int input in inputs)
            {
                foreach (int input2 in inputs)
                {
                    foreach (int input3 in inputs)
                    {
                        if(input!=input2 && input != input3)
                        {
                            if (input + input2 + input3 == 2020)
                            {
                                answerfound = true;
                                answer = input * input2 * input3;
                                break;
                            }
                        }
                    }
                }
                if (answerfound)
                    break;
            }

            Console.WriteLine("Answer found : " + answer);

        }
    }
}
