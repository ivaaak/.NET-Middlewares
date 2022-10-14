using System;

namespace Middleware.Demo
{
    public class Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing!");
        }
    }
}