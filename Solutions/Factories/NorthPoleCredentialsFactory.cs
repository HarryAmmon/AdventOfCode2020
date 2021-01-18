using System;
using System.Collections.Generic;
using Solutions.Entities;

namespace Solutions.Factories
{
    public class NorthPoleCredentialsFactory
    {
        public List<NorthPoleCredentials> GenerateCredentials(string[] fileContents)
        {
            List<NorthPoleCredentials> credentials = new List<NorthPoleCredentials>();
            string credential = "";

            for (int i = 0; i < fileContents.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(fileContents[i]))
                {
                    credentials.Add(GenerateCredentials(credential));
                    credential = "";
                }
                else
                {
                    credential += fileContents[i];
                    credential += " ";
                }
            }

            return credentials;
        }

        public NorthPoleCredentials GenerateCredentials(string credential)
        {
            string[] credentialParts = credential.Split(" ");
            string byr = "";
            string iyr = "";
            string eyr = "";
            string hgt = "";
            string hcl = "";
            string ecl = "";
            string pid = "";
            string cid = "";
            foreach (string part in credentialParts)
            {
                string[] attAndValue = part.Split(":");
                switch (attAndValue[0])
                {
                    case "byr":
                        byr = attAndValue[1];
                        break;
                    case "iyr":
                        iyr = attAndValue[1];
                        break;
                    case "eyr":
                        eyr = attAndValue[1];
                        break;
                    case "hgt":
                        hgt = attAndValue[1];
                        break;
                    case "hcl":
                        hcl = attAndValue[1];
                        break;
                    case "ecl":
                        ecl = attAndValue[1];
                        break;
                    case "pid":
                        pid = attAndValue[1];
                        break;
                    case "cid":
                        cid = attAndValue[1];
                        break;
                    default:
                        break;
                }
            }

            return new NorthPoleCredentials(birthYear: byr, issueYear: iyr, expirationYear: eyr, height: hgt, hairColor: hcl, eyeColor: ecl, passportID: pid, countryID: cid);
        }
    }
}