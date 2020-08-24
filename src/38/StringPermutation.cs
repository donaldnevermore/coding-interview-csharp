using System;

namespace CodingInterview
{
    public class StringPermutation
    {
        public static void Permutation(string str)
        {
            if (str == null)
            {
                return;
            }

            Permutation(str, 0);
        }

        private static void Permutation(string str, int index)
        {
            if (index > str.Length - 1)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (var i = index; i < str.Length; i++)
                {
                    var array = str.ToCharArray();
                    var temp = array[i];
                    array[i] = array[index];
                    array[index] = temp;
                    var newStr = new string(array);

                    Permutation(newStr, index + 1);
                }
            }
        }
    }
}
