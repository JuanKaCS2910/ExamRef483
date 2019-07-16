namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    public static class Program15
    {
        public static void Main15()
        {
            Parallel.For(0, 10, i => 
            {
                Console.WriteLine("First For {0}", i);
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i => 
            {
                Console.WriteLine("First ForEach {0}", i);
                Thread.Sleep(1000);
            });

            Console.ReadLine();

        }

    }
}
