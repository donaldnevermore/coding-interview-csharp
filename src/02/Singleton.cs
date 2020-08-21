namespace CodingInterview
{
    public sealed class Singleton
    {
        public static readonly Singleton Instance = new Singleton();

        private Singleton()
        {
        }
    }

    public sealed class Singleton5
    {
        public static readonly Singleton5 Instance = Nested.instance;

        private Singleton5()
        {
        }

        private class Nested
        {
            internal static readonly Singleton5 instance = new Singleton5();

            static Nested()
            {
            }
        }
    }
}
