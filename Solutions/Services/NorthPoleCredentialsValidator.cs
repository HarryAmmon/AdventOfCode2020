using Solutions.Entities;

namespace Solutions.Services
{
    public class NorthPoleCredentialsValidator
    {
        public bool validate(NorthPoleCredentials credentials)
        {
            if (string.IsNullOrWhiteSpace(credentials.BirthYear) || string.IsNullOrWhiteSpace(credentials.IssueYear) || string.IsNullOrWhiteSpace(credentials.ExpirationYear) || string.IsNullOrWhiteSpace(credentials.Height) || string.IsNullOrWhiteSpace(credentials.HairColor) || string.IsNullOrWhiteSpace(credentials.EyeColor) || string.IsNullOrWhiteSpace(credentials.PassportID))
            {
                return false;
            }
            else { credentials.valid = true; return true; }
        }

        private bool ValidateBirthYear(NorthPoleCredentials credentials)
        {
            int result;
            if (int.TryParse(credentials.BirthYear, out result))
            {
                if ((result >= 1920) && (result <= 2002))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        private bool ValidateIssueYear(NorthPoleCredentials credentials)
        {
            int result;
            if (int.TryParse(credentials.IssueYear, out result))
            {
                if ((result >= 2010) && (result <= 2020))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        private bool ValidateExpirationYear(NorthPoleCredentials credentials)
        {
            int result;
            if (int.TryParse(credentials.ExpirationYear, out result))
            {
                if ((result >= 2020) && (result <= 2030))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }


        private bool ValidateHairColor(NorthPoleCredentials credentials)
        {
            char[] hairColor = credentials.HairColor.ToCharArray();
            if (hairColor[0].Equals('#'))
            {
                //TODO: THIS IS NOT CORRECT MORE RULES TO FOLLOW
                return true;
            }
            else return false;
        }
        private bool ValidatePassportID(NorthPoleCredentials credentials)
        {
            if (credentials.PassportID.Length == 9)
            {
                return true;
            }
            else return false;
        }
    }
}