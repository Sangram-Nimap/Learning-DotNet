using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    internal class PracticesSetThird
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1 - Check Consecutive Numbers");
                Console.WriteLine("2 - Check for Duplicates");
                Console.WriteLine("3 - Validate Time");
                Console.WriteLine("4 - Convert to PascalCase");
                Console.WriteLine("5 - Count Vowels");
                Console.WriteLine("Type 'Quit' to Exit");

                var choice = Console.ReadLine();
                if (choice.ToLower() == "quit") break;

                if (choice == "1") CheckConsecutiveNumbers();
                else if (choice == "2") CheckDuplicates();
                else if (choice == "3") ValidateTime();
                else if (choice == "4") ConvertToPascalCase();
                else if (choice == "5") CountVowels();
                else Console.WriteLine("Invalid Option. Try Again.");
            }
        }

        static void CheckConsecutiveNumbers()
        {
            Console.WriteLine("Enter numbers separated by a hyphen:");
            var input = Console.ReadLine();
            var numbers = input.Split('-').Select(int.Parse).ToArray();

            var isAscending = true;
            var isDescending = true;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                    isAscending = false;
                if (numbers[i] != numbers[i - 1] - 1)
                    isDescending = false;
            }

            Console.WriteLine(isAscending || isDescending ? "Consecutive" : "Not Consecutive");
        }

        static void CheckDuplicates()
        {
            Console.WriteLine("Enter numbers separated by a hyphen:");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                return;

            var numbers = input.Split('-');
            var hasDuplicates = numbers.Length != numbers.Distinct().Count();

            Console.WriteLine(hasDuplicates ? "Duplicate" : "No Duplicates");
        }

        static void ValidateTime()
        {
            Console.WriteLine("Enter a time in 24-hour format (e.g. 19:00):");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || !input.Contains(":"))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var parts = input.Split(':');
            var isValidHour = int.TryParse(parts[0], out var hour) && hour >= 0 && hour <= 23;
            var isValidMinute = int.TryParse(parts[1], out var minute) && minute >= 0 && minute <= 59;

            Console.WriteLine(isValidHour && isValidMinute ? "Ok" : "Invalid Time");
        }

        static void ConvertToPascalCase()
        {
            Console.WriteLine("Enter a few words separated by a space:");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            var words = input.ToLower().Split(' ');
            var pascalCase = string.Concat(words.Select(word => char.ToUpper(word[0]) + word.Substring(1)));

            Console.WriteLine($"PascalCase: {pascalCase}");
        }

        static void CountVowels()
        {
            Console.WriteLine("Enter an English word:");
            var input = Console.ReadLine().ToLower();
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            var vowelCount = input.Count(c => vowels.Contains(c));
            Console.WriteLine($"Number of vowels: {vowelCount}");
        }
    }
}