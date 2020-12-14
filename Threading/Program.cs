using System;
using System.Threading;

namespace Threading
{
    class Program
    {
        /// <summary>
        /// This is the static Main Class the Main Thread
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // creates a instance of the MethodClass
            MethodsClass methods = new MethodsClass();
            // Creates a new thread and defines the method (task) it will run
            Thread thread = new Thread(methods.WorkThreadFunction) {Name = "Thread: 1 "};
            Thread threadTwo = new Thread(methods.WorkThreadFunction) {Name = "Thread: 2 "};
            // starts the thread
            thread.Start(thread.Name);
            threadTwo.Start();
            // awaits to the tread 2 is finished running and continues in the main thread
            thread.Join();

            // Writes Hello Teacher to the console
            Console.WriteLine("Hello Teacher!");
            // waits for user input to terminate
            Console.ReadLine();

        }

    }

    /// <summary>
    /// This class contains methods and nothing else
    /// </summary>
    public class MethodsClass
    {
        public void WorkThreadFunction(object name)
        {
            Thread thr = Thread.CurrentThread;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"simple thread catch by this method: {thr.Name} Passed by Parameter: {name}");
            }
        }
    }
}