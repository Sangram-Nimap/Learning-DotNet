/*using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasic
{
    internal class PracticesSetSecond
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1 - Facebook Likes");
                Console.WriteLine("2 - Reverse Name");
                Console.WriteLine("3 - Unique Numbers");
                Console.WriteLine("4 - Show Unique Numbers");
                Console.WriteLine("5 - Smallest 3 Numbers");
                Console.WriteLine("Type 'Quit' to Exit");

                var choice = Console.ReadLine();
                if (choice.ToLower() == "quit") break;

                if (choice == "1") FacebookLikes();
                else if (choice == "2") ReverseName();
                else if (choice == "3") UniqueNumbers();
                else if (choice == "4") ShowUniqueNumbers();
                else if (choice == "5") SmallestThreeNumbers();
                else Console.WriteLine("Invalid Option. Try Again.");
            }
        }

        static void FacebookLikes()
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter a name (Press Enter to finish):");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;
                names.Add(input);
            }

            if (names.Count == 0) Console.WriteLine("No likes.");
            else if (names.Count == 1) Console.WriteLine($"{names[0]} likes your post.");
            else if (names.Count == 2) Console.WriteLine($"{names[0]} and {names[1]} like your post.");
            else Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
        }

        static void ReverseName()
        {
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();
            var reversed = new string(name.Reverse().ToArray());
            Console.WriteLine($"Reversed: {reversed}");
        }

        static void UniqueNumbers()
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a unique number:");
                var num = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(num)) Console.WriteLine("Already entered. Try again.");
                else numbers.Add(num);
            }

            numbers.Sort();
            Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));
        }

        static void ShowUniqueNumbers()
        {
            var numbers = new HashSet<int>();
            while (true)
            {
                Console.WriteLine("Enter a number (type 'Quit' to stop):");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit") break;
                numbers.Add(Convert.ToInt32(input));
            }

            Console.WriteLine("Unique numbers: " + string.Join(", ", numbers));
        }

        static void SmallestThreeNumbers()
        {
            while (true)
            {
                Console.WriteLine("Enter comma-separated numbers:");
                var input = Console.ReadLine();
                var numbers = input.Split(',').Select(n => int.Parse(n.Trim())).ToList();

                if (numbers.Count < 5)
                {
                    Console.WriteLine("List must have at least 5 numbers. Try again.");
                    continue;
                }

                var smallest = numbers.OrderBy(n => n).Take(3);
                Console.WriteLine("Smallest 3: " + string.Join(", ", smallest));
                break;
            }
        }
    }
}*/