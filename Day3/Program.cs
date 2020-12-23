using System;
using System.Collections.Generic;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = 0;

            List<string> terrain = datas.GetDatas();

            int width = terrain[0].Length;
            int height = terrain.Count;

            int currentHeight = 0;
            int currentCol = 0;
            int nbTrees = 0;

            int stepX = 1;
            int stepY = 1;

            while (currentHeight < height)
            {
                currentCol += stepX;
                currentHeight += stepY;

                if (currentCol >= width)
                    currentCol -= width;

                if (currentHeight >= height)
                    break;

                if (terrain[currentHeight][currentCol] == '#')
                {
                    nbTrees++;
                }
            }

            result = nbTrees;

            stepX = 3;
            stepY = 1;

            currentHeight = 0;
            currentCol = 0;
            nbTrees = 0;

            while (currentHeight < height)
            {
                currentCol += stepX;
                currentHeight += stepY;

                if (currentCol >= width)
                    currentCol -= width;

                if (currentHeight >= height)
                    break;

                if (terrain[currentHeight][currentCol] == '#')
                {
                    nbTrees++;
                }
            }

            result *= nbTrees;

            stepX = 5;
            stepY = 1;

            currentHeight = 0;
            currentCol = 0;
            nbTrees = 0;

            while (currentHeight < height)
            {
                currentCol += stepX;
                currentHeight += stepY;

                if (currentCol >= width)
                    currentCol -= width;

                if (currentHeight >= height)
                    break;

                if (terrain[currentHeight][currentCol] == '#')
                {
                    nbTrees++;
                }
            }

            result *= nbTrees;

            stepX = 7;
            stepY = 1;

            currentHeight = 0;
            currentCol = 0;
            nbTrees = 0;

            while (currentHeight < height)
            {
                currentCol += stepX;
                currentHeight += stepY;

                if (currentCol >= width)
                    currentCol -= width;

                if (currentHeight >= height)
                    break;

                if (terrain[currentHeight][currentCol] == '#')
                {
                    nbTrees++;
                }
            }

            result *= nbTrees;

            stepX = 1;
            stepY = 2;

            currentHeight = 0;
            currentCol = 0;
            nbTrees = 0;

            while (currentHeight < height)
            {
                currentCol += stepX;
                currentHeight += stepY;

                if (currentCol >= width)
                    currentCol -= width;

                if (currentHeight >= height)
                    break;

                if (terrain[currentHeight][currentCol] == '#')
                {
                    nbTrees++;
                }
            }

            result *= nbTrees;

            Console.WriteLine("result : " + result);

        }
    }
}
