/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    internal class Practices
    {
        static void Main(string[] args)
        {
            // Program 1: Validate a number between 1 and 10
            Console.WriteLine("Enter a number between 1 to 10:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

            // Program 2: Find the maximum of two numbers
            Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The maximum number is: {Math.Max(firstNumber, secondNumber)}");

            // Program 3: Determine if an image is landscape or portrait
            Console.WriteLine("Enter the width of the image:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the image:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(width > height ? "Landscape" : "Portrait");

            // Program 4: Speed camera logic
            Console.WriteLine("Enter the speed limit:");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car:");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;
                Console.WriteLine($"Demerit points: {demeritPoints}");

                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
            }
        }
    }
}*/