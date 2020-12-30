using System;
using System.IO;
namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileContent = File.ReadAllLines("input.txt");



            Console.WriteLine(Part1(fileContent));
            Console.WriteLine(Part2(fileContent));
        }

        static int Part1(string[] fileContent)
        {
            for (int i = 0; i < fileContent.Length; i++)
            {
                for (int j = 1; j < fileContent.Length; j++)
                {
                    int result = int.Parse(fileContent[i]) + int.Parse(fileContent[j]);
                    if (result == 2020)
                    {
                        return int.Parse(fileContent[i]) * int.Parse(fileContent[j]);
                    }
                }
            }

            return -1;
        }

        static int Part2(string[] fileContent)
        {
            for (int i = 0; i < fileContent.Length; i++)
            {
                for (int j = 1; j < fileContent.Length; j++)
                {
                    for (int k = 2; k < fileContent.Length; k++)
                    {
                        int result = int.Parse(fileContent[i]) + int.Parse(fileContent[j]) + int.Parse(fileContent[k]);
                        if (result == 2020)
                        {
                            return int.Parse(fileContent[i]) * int.Parse(fileContent[j]) * int.Parse(fileContent[k]);
                        }
                    }
                }
            }

            return -1;
        }
    }
}
