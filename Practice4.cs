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
            Console.WriteLine("Enter the number:");
           num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 != 0)
                {
                     Console.WriteLine("Enter the number:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The product of {0} and {1} is:{2}",num1,num2,(num1*num2));
                   
                }
                else
                   Console.WriteLine("The number is :{0}",num1);
                Console.Read();
            }
    }
}
