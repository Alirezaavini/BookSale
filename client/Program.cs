using System;
using DAL;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.insert();
            Console.WriteLine("inserted book");
            Console.Read();
        }
    }
}
