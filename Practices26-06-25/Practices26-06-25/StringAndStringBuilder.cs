using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices26_06_25
{
    public class StringAndStringBuilder
    {
        public static void String()
        {
            string name = "sangramsingh ";
            Console.WriteLine("ToUpper: " + name.ToUpper());

            string secondName2 = "  Sangram  ";
            Console.WriteLine("Trim: " + secondName2.Trim());

            string no = "134142342";
            Console.WriteLine("Digits ToUpper (no effect): " + no.ToUpper());
            int num = int.Parse(no);
            Console.WriteLine("Parsed number * 2: " + (num * 2));

            Console.Write("Enter an input: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered: {input}");

            // Additional string operations
            string text = "Welcome to C# Programming";
            Console.WriteLine("Original text: " + text);
            Console.WriteLine("ToLower: " + text.ToLower());
            Console.WriteLine("Length: " + text.Length);
            Console.WriteLine("Substring(0, 7): " + text.Substring(0, 7));
            Console.WriteLine("Contains(\"C#\"): " + text.Contains("C#"));
            Console.WriteLine("Replace(\"C#\", \".NET\"): " + text.Replace("C#", ".NET"));
            Console.WriteLine("IndexOf(\"to\"): " + text.IndexOf("to"));
            Console.WriteLine("Split words:");
            foreach (var word in text.Split(' '))
            {
                Console.WriteLine("- " + word);
            }
        }

        public static void StringBuilder()
        {
            var builder = new StringBuilder();

            builder.Append('-', 10);
            builder.Append(" Hello ");
            builder.Append('-', 10);
            Console.WriteLine("Initial build: " + builder);

            builder.Replace('-', '*');
            Console.WriteLine("After Replace: " + builder);

            builder.Insert(0, ">>> ");
            builder.Append(" <<<");
            Console.WriteLine("After Insert & Append: " + builder);

            builder.Remove(0, 4);
            Console.WriteLine("After Remove: " + builder);

            builder.Clear();
            Console.WriteLine("After Clear (should be empty): '" + builder.ToString() + "'");
        }
    }
}
