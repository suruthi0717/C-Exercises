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
            string sub;
            Person p1 = new Person();
            p1.Message();
            Student s1 = new Student();
            s1.SetAge(21);
            s1.Message();
            s1.ShowAge();
            Teacher t1 = new Teacher();
            t1.SetAge(30);
            t1.Message();
            t1.ShowAge();
            Console.WriteLine("Enter the subject:");
            sub = Console.ReadLine();
            t1.SetSub(sub);
            t1.Explain();
            Console.Read();
        }
    }
}
