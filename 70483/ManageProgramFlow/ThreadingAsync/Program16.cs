
namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Threading.Tasks;
    public static class Program16
    {
        public static void Main16()
        {
            ParallelLoopResult result = Parallel.For(0, 100, 
                (int i, ParallelLoopState loopState) =>
            {
                Console.WriteLine("First For: {0}", i);
                if (i == 50)
                {
                    Console.WriteLine("Breaking loop");
                    loopState.Break();
                }
                return;
            });
            Console.ReadLine();
        }
    }
}
