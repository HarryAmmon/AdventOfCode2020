namespace Day4
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
    }
}