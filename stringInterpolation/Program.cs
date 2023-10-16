using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter your Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your lastName: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter you age: ");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hi, {firstName} {lastName} you are {Age} years old");

            Console.ReadLine();

        }
    }
}
