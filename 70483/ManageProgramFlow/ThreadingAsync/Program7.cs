namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Threading;
    public static class Program7
    {
        public static void Main7 ()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            Console.ReadLine();
        }

    }
}
