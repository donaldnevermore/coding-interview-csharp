namespace CodingInterview
{
    public class NumberOfOnes
    {
        public static int NumberOfOnesBetween(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return NumberOf(n.ToString());
        }

        private static int NumberOf(string n)
        {
            return 0;
        }
    }
}
