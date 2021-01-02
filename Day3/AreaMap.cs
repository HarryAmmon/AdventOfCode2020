using System;

namespace Day3
{
    public class AreaMap
    {
        public readonly char[,] Map;
        public AreaMap(string[] fileInput)
        {
            Map = new char[fileInput.Length, fileInput[0].Length];
            for (int i = 0; i < fileInput.Length; i++)
            {
                char[] line = fileInput[i].ToCharArray();
                for (int j = 0; j < line.Length; j++)
                {
                    Map[i, j] = line[j];
                }
            }
        }

        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    output += Map[i, j];
                }
                output += "\n";
            }
            return output;
        }
    }
}