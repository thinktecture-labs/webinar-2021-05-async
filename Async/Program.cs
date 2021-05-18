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
            EventBasedAsynchronousPatternDemo.Run();
            TaskBasedAsynchronousPatternDemo.Run();

            var task = TaskStateMachineDemo.Run();
            while (!task.IsCompleted)
            {
                System.Threading.Thread.Sleep(10);
            }

            Console.WriteLine("Finished!");
        }
    }
}
