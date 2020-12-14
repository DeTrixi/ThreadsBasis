using System;
using System.Data.SqlTypes;
using System.Threading;

namespace OpgaveFire
{
    class Program
    {
        static Char ch = '*';

        static void Main(string[] args)
        {
            Thread printerThread = new Thread(Printer);
            printerThread.Start();

            Thread readerThread = new Thread(Reader);
            readerThread.Start();
        }

        static void Printer()
        {
            while (true)
            {
                Console.Write(ch);
                Thread.Sleep(100);
            }
        }

        static void Reader()
        {
            while (true)
            {
                ch = Console.ReadKey().KeyChar;
            }
        }


    }
}
