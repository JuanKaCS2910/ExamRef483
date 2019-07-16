namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Threading;

    public static class Program6
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() => 
        {
            return Thread.CurrentThread.ManagedThreadId;
        });
        public static void Main6()
        {
            new Thread(() => 
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread A: {0}", i);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread B: {0}", i);
                }
            }).Start();

            Console.ReadLine();
        }

    }
}
