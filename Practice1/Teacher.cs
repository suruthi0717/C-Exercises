using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Teacher:Person
    {
        private string subject;
        public void SetSub(string s)
        {
            subject = s;
        }
        public void Explain()
        {
            Console.WriteLine("Explanation Begins for {0}",subject);
        }
    }
}
