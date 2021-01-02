using System;
using System.IO;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] fileContent = File.ReadAllLines("input.txt");
            Console.WriteLine($"PART1: {Part1(fileContent)}");
            Console.WriteLine($"PART2: {Part2(fileContent)}");
        }

        static int Part1(string[] fileContent)
        {
            AreaMap area = new AreaMap(fileContent);
            PathMapper mapper = new PathMapper(area);

            string output = area.ToString();
            Console.WriteLine(output);

            int result = mapper.TreesHit(1, 3);

            return result;
        }

        static int Part2(string[] fileContent)
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
