using System;
using Solutions.Entities;
using Solutions.Services;
using AdventOfCodeCore;

namespace Solutions
{
    public class Day3 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            AreaMap area = new AreaMap(fileContent);
            PathMapper mapper = new PathMapper(area);

            string output = area.ToString();
            Console.WriteLine(output);

            int result = mapper.TreesHit(1, 3);

            return result;
        }

        public int Part2(string[] fileContent)
        {
            AreaMap area = new AreaMap(fileContent);
            PathMapper mapper = new PathMapper(area);

            int result = 0;

            result = mapper.TreesHit(1, 1);
            result *= mapper.TreesHit(1, 3);
            result *= mapper.TreesHit(1, 5);
            result *= mapper.TreesHit(1, 7);
            result *= mapper.TreesHit(2, 1);

            return result;
        }
    }
}