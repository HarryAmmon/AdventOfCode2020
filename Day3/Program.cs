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
            Console.WriteLine(Part1(fileContent));
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
    }
}
