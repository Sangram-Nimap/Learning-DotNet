using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalQuestion
{
    internal class Logicalquestion
    {
        static void Main(string[] args)
        {
            // 1. Fibonacci Series
            Console.WriteLine("Fibonacci Series:");
            int a = 0, b = 1, c, i;
            Console.Write(a + " " + b + " ");
            for (i = 2; i < 10; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.WriteLine();

            // 2. Prime Number Check
            Console.WriteLine("\nPrime Number Check:");
            int num = 17;
            bool isPrime = true;
            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.WriteLine(num + " is Prime");
            else
                Console.WriteLine(num + " is Not Prime");

            // 3. Reverse a String
            Console.WriteLine("\nReverse a String:");
            string str = "hello";
            string rev = "";
            for (i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            Console.WriteLine("Original: " + str);
            Console.WriteLine("Reversed: " + rev);

            // 4. Palindrome Number
            Console.WriteLine("\nPalindrome Number Check:");
            int n = 121, temp = n, r, res = 0;
            while (n > 0)
            {
                r = n % 10;
                res = res * 10 + r;
                n = n / 10;
            }
            if (temp == res)
                Console.WriteLine(temp + " is Palindrome");
            else
                Console.WriteLine(temp + " is Not Palindrome");
        }
    }
}
