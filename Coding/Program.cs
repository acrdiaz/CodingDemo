using Coding.Base;
using Coding.Code;
using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi");

            BaseRun p = new AddTwoNumbers();
            p.Run();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
