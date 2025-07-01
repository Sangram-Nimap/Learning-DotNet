using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut01_07_2025
{
    internal class LogicalQuestion
    {
        private static void Main(string[] args)
        {
            // Second largest
            int[] arr = { 12, 35, 1, 10, 34, 1, 35 };
            int first = int.MinValue;
            int second = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }

            Console.WriteLine("Second Largest: " + second);

            // Reverse integer
            int num = 12345;
            int reversed = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num = num / 10;
            }

            Console.WriteLine("Reversed: " + reversed);

            // Swap without variable
            int a = 10;
            int b = 12;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a = " + a + ", b = " + b);

            // Anagram
            string str1 = "listen";
            string str2 = "silent";
            bool isAnagram = true;

            if (str1.Length != str2.Length)
            {
                isAnagram = false;
            }
            else
            {
                int[] count = new int[26];

                for (int i = 0; i < str1.Length; i++)
                {
                    count[str1[i] - 'a']++;
                    count[str2[i] - 'a']--;
                }

                for (int i = 0; i < 26; i++)
                {
                    if (count[i] != 0)
                    {
                        isAnagram = false;
                        break;
                    }
                }
            }

            if (isAnagram)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}
