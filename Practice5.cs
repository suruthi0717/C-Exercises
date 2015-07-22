using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the first number ;");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Division of two numbers is:{0}", (num1 / num2));
                Console.Read();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide By Zero Error Occured");
            }

        }
    }
}
