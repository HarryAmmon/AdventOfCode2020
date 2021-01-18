using System.IO;
using System.Collections.Generic;
using Solutions.Entities;
using Solutions.Services;
using AdventOfCodeCore;

namespace Solutions
{
    public class Day2 : ISolution<int>
    {
        PasswordValidator validator = new PasswordValidator();
        public int Part1(string[] fileContent)
        {
            List<Password> pwordList = new List<Password>();
            int validPasswords = 0;

            foreach (string line in fileContent)
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

        public int Part2(string[] fileContent)
        {
            List<Password> pwordList = new List<Password>();
            int validPasswords = 0;

            foreach (string line in fileContent)
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