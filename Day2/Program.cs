using System;
using System.IO;
using System.Collections.Generic;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines("input.txt");

            Console.WriteLine("Hello World!");

            Console.WriteLine(Part1(fileLines));
        }


        static int Part1(string[] fileLines)
        {
            List<Password> pwordList = new List<Password>();
            PasswordValidator validator = new PasswordValidator();
            int validPasswords = 0;

            foreach (string line in fileLines)
            {
                Password password = new Password(line);
                password.Valid = validator.ValidatePassword(password);
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
