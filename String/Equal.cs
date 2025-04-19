using System;
namespace CsharpString
{
    class Test
    {
        public T takeinput<T>()
        {
            string input = Console.ReadLine();
            return (T)Convert.ChangeType(input,typeof(T));
        }

        public static void AllSubstrings(string s)
        {
            int n = s.Length;

            for (int i = 0; i < n; i++)           // Starting index
            {
                for (int j = i + 1; j <= n; j++)  // Ending index (exclusive)
                {
                    Console.WriteLine(s.Substring(i, j - i));
                }
            }
        }
        public static void Main()
        {


            AllSubstrings("abcdefgh");
            string text = "    Ice cream   ";

            // trims leading and trailing whitespaces 
            Console.WriteLine(text.Trim());

            string str1 = "Ice cream";
            string str2 = "Ice cream";

            // comparing str1 with str2
            Console.WriteLine($"str1 equals to str2 : {String.Equals(str1, str2)}");

            Console.ReadLine();
        }
    }
}

// Output: True