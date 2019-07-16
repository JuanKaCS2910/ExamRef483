using System;
namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System.Threading;
    public static class Program5
    {
        [ThreadStatic]
        public static int _field;

        public static void Main5()
        {
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                    //Thread.Sleep(1);
                }
            }).Start();

            new Thread(() => 
            {
                for (int i = 0; i < 20; i++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                    
                }
            }).Start();

            Console.ReadKey();

        }

    }
}
