using AdventOfCodeCore;

namespace Solutions
{
    public class Day1 : ISolution<int>
    {
        public int Part1(string[] fileContent)
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

        public int Part2(string[] fileContent)
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