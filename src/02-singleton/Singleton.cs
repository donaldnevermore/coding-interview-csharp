namespace CodingInterview {
    public sealed class Singleton {
        public static readonly Singleton Instance = new Singleton();

        private Singleton() {
        }
    }

    public sealed class Singleton5 {
        public static Singleton5 Instance => Nested.Instance;

        private Singleton5() {
        }

        private class Nested {
            internal static readonly Singleton5 Instance = new Singleton5();

            static Nested() {
            }
        }
    }
}
