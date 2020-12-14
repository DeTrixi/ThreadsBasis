using System;
using System.Threading;

namespace OpgaveTre
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a new object called temp
            TemperatureClass temp = new();
            // Creates a new  thread
            Thread tempThread = new Thread(temp.GenerateRandomTemperature);
            // Starts the tread
            tempThread.Start();
            //  main tread run while this bool is true
            bool isAlive = true;

            // do loop runs isAlive bool is true
            do
            {
                // Checks if thread Is Alive
                if (tempThread.IsAlive)
                {
                    Console.WriteLine("Alarm thread is still alive");
                }
                else
                {
                    Console.WriteLine("Alarm-thread is TERMINATED!");
                    isAlive = false;
                }
                // Sleeps for 10 seconds
                Thread.Sleep(10000);
            } while (isAlive == true);


            // Writes to consolas Hello Teatcher
            Console.WriteLine("Hello Teacher!");
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Class for random method that gives random temperature
    /// </summary>
    public class TemperatureClass
    {
        private readonly Random _ran = new();
        private int _temp = 0;
        private int _errors = 0;

        public void GenerateRandomTemperature()
        {
            do
            {
                _temp = _ran.Next(-20, 121);
                if (_temp < 0 || _temp > 100)
                {
                    Console.WriteLine($"Temperature Alarm: {_temp}");
                    _errors += 1;
                }

                Thread.Sleep(2000);
                Console.WriteLine(_temp);
            } while (_errors < 3);
        }
    }
}