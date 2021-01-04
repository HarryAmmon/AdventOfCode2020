using System;
using System.IO;
using System.Collections.Generic;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileContent = File.ReadAllLines("input.txt");
            //             new string[]{"ecl:gry pid:860033327 eyr:2020 hcl:#fffffd",
            // "byr:1937 iyr:2017 cid: 147 hgt:183cm",
            // "",
            //     "iyr:2013 ecl: amb cid:350 eyr: 2023 pid: 028048884",
            // "hcl:#cfa07d byr:1929",
            // "",
            // "hcl:#ae17e1 iyr:2013",
            // "eyr:2024",
            // "ecl:brn pid:760753108 byr:1931",
            // "hgt:179cm",
            // "",
            //  "hcl:#cfa07d eyr:2025 pid:166559648",
            // "iyr: 2011 ecl: brn hgt:59in"};
            Console.WriteLine($"PART1: {Part1(fileContent)}");
        }

        static int Part1(string[] fileContent)
        {
            NorthPoleCredentialsFactory factory = new NorthPoleCredentialsFactory();
            List<NorthPoleCredentials> credentials = factory.GenerateCredentials(fileContent);

            NorthPoleCredentialsValidator validator = new NorthPoleCredentialsValidator();
            int validCredentials = 0;
            int invalid = 0;
            foreach (NorthPoleCredentials credential in credentials)
            {
                if (validator.validate(credential))
                {
                    validCredentials++;
                }
                else
                {
                    Console.WriteLine(credential.ToString());
                    invalid++;
                }

            }

            Console.WriteLine(credentials[credentials.Count - 1].ToString());
            return validCredentials;
        }
    }
}
