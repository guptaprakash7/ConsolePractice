using System;

namespace ConsoleAppPractice
{
    internal class FindOccurrenceOflettersinstring
    {
        static void Main2(string[] args)
        {
            string s = "INDIA";


            while (s.Length > 0)
            {
                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[0] == s[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                s = s.Replace(s[0].ToString(), string.Empty);
            }
        }

    }
}
