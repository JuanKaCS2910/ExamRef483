namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Threading;
    public static class Program3
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc_ {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Main3()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();
            Console.ReadLine();
        }

    }
}
