using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_MethodParameters
{
    /// <summary>
    ///     Demo of using Pass By OUT
    ///     GoF DESIGN PATTERN EXAMPLE: Creational Pattern - Factory Method Pattern
    /// </summary>
    internal class Demo
    {
        public static void RunThis()
        {
            string? name;
            int age;

            GetName(out name);
            GetAge(out age);

            Console.WriteLine($"Hi {name}. You seem to be {age} years young!");
        }

        private static void GetName(out string? name)
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        }

        private static void GetAge(out int age)
        {
            Console.Write("Enter your age: ");

            string? ageInput = Console.ReadLine();
            //if(!string.IsNullOrEmpty(ageInput))
            //{
            //    age = int.Parse(ageInput);
            //}
            int.TryParse(ageInput, out age);

            if(age >= 18 && age <= 65)
            {
                Console.WriteLine("You are an adult!!!!");
            }
            else
            {
                Console.WriteLine("Invalid Age!");
            }
        }
    }
}
