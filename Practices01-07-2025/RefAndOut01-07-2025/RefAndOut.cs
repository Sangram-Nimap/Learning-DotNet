/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut01_07_2025
{
    public class RefAndOut
    {
        private static void Main(string[] args)
        {
            int value = 10;
            AddFive(ref value);
            Console.WriteLine("After ref: " + value);

            string name;
            int age;
            GetStudentDetails(out name, out age);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Age: " + age);
        }

        public static void AddFive(ref int number)
        {
            number += 5;
        }

        public static void GetStudentDetails(out string name, out int age)
        {
            name = "Sangram";
            age = 24;
        }
    }
}
*/