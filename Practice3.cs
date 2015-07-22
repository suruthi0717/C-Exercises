using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int count = 0;
        static int[] arr = new int[100];
        static void Main(string[] args)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a number:");
                string num = Console.ReadLine();
                if (num != "end")
                {
                    arr[i] = Convert.ToInt32(num);
                    count++;
                }
                else
                    break;
            }
            Display();
            Console.Read();

        }
        public static int Sum()
        {
            int tot = 0;
            foreach (int val in arr)
            {
                tot = tot + val;
            }
            return tot;
        }
        public static void Display()
        {
            Console.WriteLine("The numbers are:");
            for (int i = 0; i < count;i++ )
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("The sum of all numbers is:{0}", Sum());
        }
    }
}
