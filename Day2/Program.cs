using System;
using System.IO;
using System.Collections.Generic;

namespace Day2
{
    class Program
    {
        static PasswordValidator validator = new PasswordValidator();
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines("input.txt");

            Console.WriteLine(Part1(fileLines));
            Console.WriteLine(Part2(fileLines));
        }


        static int Part1(string[] fileLines)
        {
            List<Password> pwordList = new List<Password>();
            int validPasswords = 0;

            foreach (string line in fileLines)
            {
                Password password = new Password(line);
                password.Valid = validator.OccurrencePolicy(password);
                pwordList.Add(password);
                if (password.Valid)
                {
                    validPasswords++;
                }

            }

            return validPasswords;
        }

        static int Part2(string[] fileLines)
        {
            List<Password> pwordList = new List<Password>();
            int validPasswords = 0;

            foreach (string line in fileLines)
            {
                Password password = new Password(line);
                password.Valid = validator.PositionPolicy(password);
                pwordList.Add(password);
                if (password.Valid)
                {
                    validPasswords++;
                }
            }

            return validPasswords;
        }
    }
}
