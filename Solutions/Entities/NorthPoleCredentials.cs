namespace Solutions.Entities
{
    public class NorthPoleCredentials
    {
        public readonly string BirthYear;
        public readonly string IssueYear;
        public readonly string ExpirationYear;
        public readonly string Height;
        public readonly string HairColor;
        public readonly string EyeColor;
        public readonly string PassportID;
        public readonly string CountryID;

        public bool valid = false;

        public NorthPoleCredentials(string birthYear = "", string issueYear = "", string expirationYear = "", string height = "", string hairColor = "", string eyeColor = "", string passportID = "", string countryID = "")
        {
            BirthYear = birthYear;
            IssueYear = issueYear;
            ExpirationYear = expirationYear;
            Height = height;
            HairColor = hairColor;
            EyeColor = eyeColor;
            PassportID = passportID;
            CountryID = countryID;

        }

        public override string ToString()
        {
            return $"byr:{BirthYear} iry:{IssueYear} eyr:{ExpirationYear} hgt:{Height} hcl:{HairColor} ecl:{EyeColor} pid:{PassportID} cid:{CountryID}";
        }
    }
}