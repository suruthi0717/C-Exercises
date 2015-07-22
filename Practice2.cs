using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reverse
{
    class Program
    {
        static int size = 0;
        static int[] arr = new int[] { };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array:");
            size = Convert.ToInt32(Console.ReadLine());
            arr = new int[size];
            GetValue();
            Reverse();
            Console.Read();
        }
        public static void GetValue()
        {
            Console.WriteLine("Enter value for an array:");
            for (int i = 0; i < size; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        public static void Reverse()
        {
            for (int i = size - 1; i >= 0; i--)
                Console.WriteLine(arr[i]);
        }
                
    }
}
