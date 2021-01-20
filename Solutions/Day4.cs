using System.Collections.Generic;
using AdventOfCodeCore;
using Solutions.Entities;
using Solutions.Factories;
using Solutions.Services;
using System;

namespace Solutions
{
    public class Day4 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            NorthPoleCredentialsFactory factory = new NorthPoleCredentialsFactory();
            List<NorthPoleCredentials> credentials = factory.GenerateCredentials(fileContent);

            NorthPoleCredentialsValidator validator = new NorthPoleCredentialsValidator();
            int validCredentials = 0;
            foreach (NorthPoleCredentials credential in credentials)
            {
                if (validator.CheckRequiredFieldsPresent(credential))
                {
                    validCredentials++;
                }
            }

            return validCredentials;
        }

        public int Part2(string[] fileContent)
        {
            NorthPoleCredentialsFactory factory = new NorthPoleCredentialsFactory();
            List<NorthPoleCredentials> credentials = factory.GenerateCredentials(fileContent);

            NorthPoleCredentialsValidator validator = new NorthPoleCredentialsValidator();
            int validCredentials = 0;

            foreach (NorthPoleCredentials credential in credentials)
            {
                if (validator.Validate(credential))
                {
                    validCredentials++;
                }
            }

            return validCredentials;
        }
    }
}