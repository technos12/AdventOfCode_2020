﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    public static class datas
    {
        public static List<string> GetDatas()
        {
            return new List<string>
            {
                "....#...............#.#..###.##",
".#..#....###..............##...",
"....###......#....#.#...#.##..#",
".......#........#..###...##....",
".....#..#......#..#..##..#...#.",
"....#..........#....#...#......",
"............###...#............",
"##......#.....#......#.....##..",
"........#.........##..#.#...##.",
"....#.#..#.#...#........#..#...",
".#.....#.#......#....#..#..#..#",
"#.##..##......#.....##...#..#..",
"#........#..##...###....##.....",
"......#.#..##...#.#.....#......",
"##.......#..#.........#...#....",
".....##.........#....#.#.###.#.",
"..##...........#.#.#.#.....#.#.",
"....#...............#......#.#.",
"#.#..#....#.....#.....##...#..#",
"#......#..............#.#.##...",
"......###.....#...#........###.",
"####...#.....#...#....#........",
".......#...#....##...#.........",
".####..##............#.........",
"#.#...#...#....#...#.#......#..",
"..#..#.....#.......#...#.#...##",
".#.........#...#......##.#...#.",
".#.#...#...#.....#.#........#.#",
".#.....###....###..##.#..##.#..",
".....##....#......#..#...#...#.",
"#...##....#.......#.....##.##..",
"#...#.....#.#...........#..###.",
"##.#........###...........###.#",
"#...#.#........#.#.....#.......",
"..................#..#.........",
".....#.#..#.#......#..#.....##.",
".#.#.......#..##........#..##.#",
".#.#..#.#...#.......#.#.#..#...",
"...#......#....#....##.#..#....",
"......#.......##....##..#.....#",
"...#.##...##...............#..#",
".###....#.#.....##..#.......#.#",
"#....#..........#...........#.#",
"...#...............#.#..#....#.",
".....#..##..........#..###.....",
".....####.....#.#.......#...#..",
"#.............#...#.......##...",
".#....##.......#.#......#.#.##.",
".#..#.......#..##...#...#......",
"#.......#..#..#..#.....#.......",
"##...#.#.#...........#....#....",
".......#..#.#..............#.#.",
".....#.......#.......#.#.#.....",
"....##.##.....#......#.......#.",
"#...#..#.#....###....##...#.#.#",
"#..#......#........#.#.#.....#.",
"###..##..#......#.....#.......#",
"..##....#.#.#......#..##...#...",
".....#..#....#...#.#...#...#...",
".....#.#..###.#..#...##......#.",
"#.#..#....#..#.....#.#...#.#...",
".#..#....#.......#..#.......#..",
"#.........#..#..#.........##..#",
"..##.##..#..#...##.............",
".....###...#..#...##.#..#......",
"#.##.....##..............#.....",
".......#.##.#.##...#.#.......##",
"...#.#.##...#......#...........",
"##.#........#.....##.....#.....",
".#.....#.............#......#..",
"....#..##..#..#....#..#.#......",
".#.....#....##..##..#...##.....",
".##........#.#.#.#..........#.#",
"...#.#.#..#....#...#..###.##...",
".#....#....#.#.#.#....#..#.....",
"#.#.......#..#..#...........#.#",
".....#.....##..#....##.........",
"....#.##..............#........",
".................#....#.......#",
"...................###...#...#.",
"...#.#..#..##..##....#.....#...",
"#...#..........................",
".......#..#..#.#..#.....#......",
"..##.#..#......#...#.##..##..#.",
".##.........#.#...........#....",
"...#...#..##.#......#..#..#....",
".....#.#....#...#............#.",
".##..#.....##....#...#.........",
"#......##...#...#............#.",
".....#.##...#.#....##..........",
".............#.......#.#.......",
"##....#.#........#....#..##....",
"....#...##.#....##..#.....#.#..",
"...##..#....##......#...#......",
".####.#..#..#.#...#.#.#....#...",
".#........#.##....#.#....#.....",
".........#....##..#..#.........",
"....##...#....##.............#.",
"....#..##.#....#.#..#...##.....",
".....##...#..#....#......#.#...",
"..........#.......#.##..#.##..#",
".......#.........#...#.##......",
"....##.#.......#...............",
"....#.......#..##.......##.#.##",
"#.#..#.#....#.#.........###...#",
".#.##.....##..##...........#.#.",
"...#....##........##...#...#...",
".#.##....#.#...#.#..#..#...#...",
"#....#.##...#.#..#....#.....#..",
"#..#...#........#...........#..",
"...........#.......#......#..#.",
"....##...#......##.....#......#",
".#.##.#.#.............#....##..",
".#...#...##.#.#........#..##.#.",
".#.#........#.#...#..#........#",
".###.#.#...#..#..#.#....#..#...",
"..##..##....#.#............#...",
"#..........#........#..#.#.#...",
".#...#..#..#.#.....#.....#....#",
"#.....#.#.#.....####.......#...",
"...#.#........#.#.###...#.....#",
".....#.....##....#....#..##...#",
"..#....###.##.#..#..#....#...#.",
".....#.....#...........#.#.###.",
".....#......###...#.#...##.....",
"...........###..#...#....#.#..#",
"...#..###.....#....#.#...#.....",
".......#...#..#..##....#.#.#...",
"...#..####.###........#.....#..",
"..#......###..#..#.##..........",
"....#....##..##..##.......###..",
"...#.......#..#.#....##........",
".#.#.....#.#.#..........#..#..#",
".##....##....##...........##.##",
"........#......#.##....##...#.#",
"..#.#.....#..#....#..........#.",
"...........#...............#...",
".....####.....#.....###.#..#...",
"..........####..##.##.#....#...",
"...#.#.#......#....#..#.#......",
".#.#......###.....#....#.......",
"..#..#..#.......#..#...#.....#.",
"...#............#......##...###",
"......#.............#..#..###..",
".#.#......#..##.#..#..#.#...#.#",
".#.....#.......#..#...........#",
"..#.###.#..#...#.##..#.##......",
"....#.#........#..#.#...#.#.##.",
".#..##.#..#.#.#...##..#.#......",
".......#..#..#..#.....#.#.#..#.",
".##.###..##.....#.##..#........",
"...##..............#.#.##....#.",
"##....#...#...........#........",
"..#........#.#.##..#.#...#..#..",
".......#.......##.#..#....#.#..",
".......#....##..#.#.#..#....#..",
"..........#....#..#..#....#....",
"........#.....#.#.....##.......",
"........##.###.........#.#.#...",
"###......####...#.#........#...",
"......#........#......#.....#..",
"##..#.##..##.###..#........##..",
".#..#...#............##.##..#..",
"...........#..#.#..............",
".##.#.#....#...............#..#",
".........##.................#..",
"#............##..##.........##.",
"##........#.........#..##.#...#",
"........#.....#..#.........#.##",
"....#......#.....##.##.........",
".#.#.....#.#..#..##....#....#..",
".###...#..##....##.....#.#..##.",
".#....#.#.......#..#..#...###..",
"..#.#......#.#..#.....###.....#",
"#....#..#...#.....#.......#.##.",
".#.......##.#.#...#......#.....",
"###....#.#......#....#.#...##..",
"...#....####.......##.....#..#.",
".#.................#.......##.#",
"...#.###..........#..##......#.",
".....##.#..............##..#...",
"#.....#..#..........#..#.......",
"..#...#.#.#.......##.#.....#...",
"#........#.#........#.#.....#..",
"#.....#...##....##..##........#",
".#.##..#...#....#........#..#..",
"#..#.....#....#...##......#....",
"...#...#...#.#.#....##....#.#.#",
"......#...............#.....#..",
".......#.#..#..##.#.....#......",
"...........##......#...#.......",
"....##..##.....#.#...#.........",
"......##..###.......#....#.##..",
"......#..#.##....#..###..#.....",
".....#.........#........##.....",
".....####..................#...",
".#.#...##................#.....",
".#..#...#...#.....#.##..#..#...",
".#................#...###....#.",
"...#....#...........#...#....#.",
".......#....##...............#.",
".#.#.##..##.......#....#....###",
"......#.#....#...#..#..........",
"....#.##.#.#...##.#.#......#...",
"##....#...##.....#..#.###.#....",
".......#......#.........#.#...#",
".##.#...........##.........#.#.",
"##..##.....#...#..#.#...#....#.",
"#..##......###........#...#....",
".....#.#.......#...#..##....##.",
".....#.#..#.....#.......#..##..",
"...#..#..............#.#.......",
".#.#...###......###............",
".....#.....#...#.###...........",
".......#..................#...#",
"#....#...#...#....#....#.#....#",
"....#..#............#.#........",
"#....#..........#.#.#..#..#....",
".......#....#......#....#......",
".##.#.#...#...#...##...........",
".........###.#..#..............",
"...#........##....#....#....###",
"....##..#.......#.#...#.#..#.#.",
".....##....#..##.........#.....",
"........##..#........#.........",
"...........#..#.##..##...#.....",
".........#.#..####..#...#.##.##",
"##..#.#.....##.....#.........#.",
"..#...#...#....#.#....#.....#.#",
".###.#....#.#......#....#......",
".##.....#....#.......#.#..#.##.",
"#..#..##.....#....#...##.....#.",
"...#.........####.........##..#",
"..#.....#....###.#.#...#..#....",
".........#....#..#.#.........#.",
".....###.##..#...#.....#..#..#.",
"....#......#..#.#...#.....#....",
".......#...#..#....#.......#.#.",
".#....#............#....####...",
"#..##..##....#.....#...#.....#.",
"...#...##...#.#....#...........",
".......#####.....#..###.#..#...",
".....#.....#.#....#.........#..",
".###.#..#...##.##.#.#..#..#....",
".#..#.##..#......#..........##.",
"##....#....#.........###..#....",
"..#.............#.......#.#....",
"..#.....#..##...#...###..#.##..",
"##...##...#.#....#..#..........",
"...............#.....#.......#.",
"....#.#......##.#......#...#.#.",
".........#.............#.#.....",
"...#.#.........................",
"..#..#....##..#...###.##.......",
"...##.#...##..#.#.##.#...#.##..",
".##....#....#.......#.....##..#",
".#...............#..#...#......",
"...##.....##.###....#.....#...#",
"...#.....#...####....##....#..#",
"..#.#.###..##.....#........#...",
".....##.##..#..#.........##....",
"........##.....#..........#.##.",
"..##.#....####..#...........#..",
"##....#..#..#.#.##.....#...##..",
"...#...#......#..#.#....#......",
"##.....##.......##.##....#.....",
".........#...##...........#....",
".###.#..#....##...#.....#.....#",
"...#..........#.###..##...#.##.",
"...#..#....#.#.#.......###.....",
"....#..#.#.....##...#.#.#.#....",
".......##..#...##..##.#....#...",
".##..........#.#.#.....#.....#.",
"#....#......##...#..##.#..#..#.",
".#...#.....###..#......#.....#.",
".#..#.###.......#.##....###....",
"#....#....#....#....#..#.##....",
"..#..#.....#.....#....###.....#",
"##.###..#...##.......#.#.......",
"#...##......##....#.#...#....#.",
"..##.#.#....#...#.....##.......",
".#....#..#...#...##..##........",
"###......#.##....#.#..##.......",
"...#.....##.#.........#..#.....",
".......#.#....#.....##......#..",
"#..#..............##.#........#",
"....#.#....#..#.#...##.........",
"..........#..........#.........",
".#.....#.....#.##....#.##..#..#",
".......#.......#.#.#.##....#...",
"..#...........#....#.......##..",
"..#.#.#.#...##..#.#.#..#...#.#.",
"..#..#..........#...##....#....",
"....##.#....#.............#....",
".##...##..........#.#..#...#...",
"#..#..#.##..........##.........",
"............#.......#..#.....##",
"....#......#........#..#.##....",
"#.#......#.#...#.....#.........",
"..#.....#..#..........#.....#..",
".#..#.#.#.##...#..#.#.........#",
"#...##....#..##..#...#.#.##....",
"#..##.##.#.##.......#.......#..",
"#.#.......#........#.##....#.#.",
"....#..##....##..##......#..##.",
"#.....#....#.#........####.....",
"......#...#...###..#...........",
".##.#.##...##................##",
"..##.#.....#.#..#......#.#.....",
"......#...#........#.....#.##..",
"#..#.#..#.....#.#..#..##..#.#..",
"...#.........#.#.#.##...#......",
"...#..##....#..#.#....#.###.#..",
"........###................##.#",
"##...........#......##.##.....#",
".#.#.#....#....#....#..........",
"#.....#........................",
"....#.....#...#......#.........",
"....#.#..#..............#......",
"##.........#..#....#.......#...",
".###....#..#.#.####.........#..",
"..#.#....#.....###..#..........",
"..........#................#.##",

            };
        }
    }
}
