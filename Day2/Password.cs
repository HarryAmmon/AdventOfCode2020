namespace Day2
{
    public class Password
    {
        public readonly int LowerBound;
        public readonly int UpperBound;
        public readonly char Contain;
        public readonly string Pword;
        public bool Valid = false;

        public Password(string fileLine)
        {
            string[] boundsAndPolicyAndPword = fileLine.Split(' ');
            Pword = boundsAndPolicyAndPword[2];
            Contain = boundsAndPolicyAndPword[1].ToCharArray()[0];

            string[] lowerAndUpperBound = boundsAndPolicyAndPword[0].Split('-');
            LowerBound = int.Parse(lowerAndUpperBound[0]);
            UpperBound = int.Parse(lowerAndUpperBound[1]);
        }
    }
}