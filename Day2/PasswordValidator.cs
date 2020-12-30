namespace Day2
{
    public class PasswordValidator
    {
        public bool ValidatePassword(Password password)
        {
            int occurence = PolicyOccurence(password.Contain, password.Pword);
            if (occurence >= password.LowerBound && occurence <= password.UpperBound)
            {
                return true;
            }
            else return false;
        }

        private int PolicyOccurence(char policy, string pword)
        {
            char[] pwordAsChars = pword.ToCharArray();
            int count = 0;
            foreach (char letter in pwordAsChars)
            {
                if (letter == policy)
                {
                    count++;
                }
            }
            return count;
        }
    }
}