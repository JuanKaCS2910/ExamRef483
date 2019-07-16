
namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Threading;

    /*
     * Creating using a background thread
     */
    public static class Program2
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void Main2()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = false; // Indica si es un subproceso en segundo plano
            t.Start();
            Console.ReadLine();
        }


    }
}
