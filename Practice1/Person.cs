using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Person
    {
        public int age;
        public void SetAge(int n)
        {
            age = n;
        }
        public void Message()
        {
            Console.WriteLine("Hello");
        }
        public void ShowAge()
        {
            Console.WriteLine("My Age is: {0} years old",age);
        }
    }
}
