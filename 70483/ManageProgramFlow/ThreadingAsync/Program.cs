namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Threading;
    public static class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}" , i);
                Thread.Sleep(60);
            }
        }
        public static void Main1()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main Thread: Do some work");
                Thread.Sleep(30);
            }

            t.Join();
            Console.ReadLine();
        }
    }
}
