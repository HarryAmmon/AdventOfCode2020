using Solutions.Entities;
using System.Text.RegularExpressions;
using System;
namespace Solutions.Services
{
    public class NorthPoleCredentialsValidator
    {
        public bool CheckRequiredFieldsPresent(NorthPoleCredentials credentials)
        {
            if (string.IsNullOrWhiteSpace(credentials.BirthYear) || string.IsNullOrWhiteSpace(credentials.IssueYear) || string.IsNullOrWhiteSpace(credentials.ExpirationYear) || string.IsNullOrWhiteSpace(credentials.Height) || string.IsNullOrWhiteSpace(credentials.HairColor) || string.IsNullOrWhiteSpace(credentials.EyeColor) || string.IsNullOrWhiteSpace(credentials.PassportID))
            {
                return false;
            }
            else { credentials.valid = true; return true; }
        }

        public bool Validate(NorthPoleCredentials credentials)
        {
            bool result = ValidateBirthYear(credentials.BirthYear)
                && ValidateIssueYear(credentials.IssueYear)
                && ValidateExpirationYear(credentials.ExpirationYear)
                && ValidateHeight(credentials.Height)
                && ValidateHairColor(credentials.HairColor)
                && ValidateEyeColor(credentials.EyeColor)
                && ValidatePassportID(credentials.PassportID);

            return result;
        }

        public bool ValidateBirthYear(string birthYear)
        {
            if (int.TryParse(birthYear, out int result))
            {
                if ((result >= 1920) && (result <= 2002))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public bool ValidateIssueYear(string issueYear)
        {
            if (int.TryParse(issueYear, out int result))
            {
                if ((result >= 2010) && (result <= 2020))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public bool ValidateExpirationYear(string expirationYear)
        {
            if (int.TryParse(expirationYear, out int result))
            {
                if ((result >= 2020) && (result <= 2030))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public bool ValidateHeight(string height)
        {
            if (height.EndsWith("cm"))
            {
                var split = height.Split('c');
                if (int.TryParse(split[0], out int result))
                {
                    return result >= 150 && result <= 193;
                }
                else return false;
            }
            else if (height.EndsWith("in"))
            {
                var split = height.Split('i');
                if (int.TryParse(split[0], out int result))
                {
                    return result >= 59 && result <= 76;
                }
                else return false;
            }
            else return false;
        }

        public bool ValidateHairColor(string hairColor)
        {

            Regex test = new Regex(@"^#(?:[0-9a-fA-F]{3}){1,2}$");
            Match match = test.Match(hairColor);

            return match.Success;
        }

        public bool ValidateEyeColor(string eyeColor)
        {
            string[] validEyeColors = { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

            foreach (string color in validEyeColors)
            {
                if (eyeColor.Equals(color))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidatePassportID(string passportID)
        {
            if (passportID.Length == 9)
            {
                return true;
            }
            else return false;
        }
    }
}