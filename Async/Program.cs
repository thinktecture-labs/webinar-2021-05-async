using System;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ThreadDemo.Run();
            AsynchronousProgrammingModelDemo.Run();

            Console.WriteLine("Finished!");
        }
    }
}
