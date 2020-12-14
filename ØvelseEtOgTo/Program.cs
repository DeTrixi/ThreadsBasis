using System;
using System.IO;
using System.Threading;

namespace ØvelseEtOgTo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadMethods trMethods = new ();
            Thread tr = new Thread(trMethods.WriteToConsolas){Name = "Thread: one"};
            Thread trTwo = new Thread(trMethods.WriteToConsolas){Name = "Thread: two"};
            tr.Start();
            trTwo.Start();
            tr.Join();
            Console.WriteLine("Hello Teacher!");
            Console.ReadLine();
        }
    }

    public class ThreadMethods
    {
        public void WriteToConsolas()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread curThread = Thread.CurrentThread;
                Console.WriteLine($"C#-trådning er nemt! {curThread.Name}");
                Thread.Sleep(1000);
            }
        }
    }
}