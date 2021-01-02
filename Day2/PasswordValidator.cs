namespace Day2
{
    public class PasswordValidator
    {
        public bool OccurrencePolicy(Password password)
        {
            int occurence = CountOccurrence(password.Contain, password.Pword);
            if (occurence >= password.LowerBound && occurence <= password.UpperBound)
            {
                return true;
            }
            else return false;
        }

        private int CountOccurrence(char policy, string pword)
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

        public bool PositionPolicy(Password password)
        {
            char[] pwordAsChars = password.Pword.ToCharArray();
            int firstPosition = password.LowerBound - 1;
            int secondPosition = password.UpperBound - 1;
            if (pwordAsChars[firstPosition] == password.Contain ^ pwordAsChars[secondPosition] == password.Contain) // XOR
            {
                return true;
            }
            else return false;
        }
    }
}