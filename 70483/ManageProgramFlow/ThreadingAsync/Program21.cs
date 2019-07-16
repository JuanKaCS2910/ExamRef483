namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Linq;

    public static class Program21
    {
        public static void Main21()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel()
                .AsOrdered()
                .Where(i => i % 2 == 0).AsSequential();

            foreach (int i in parallelResult.Take(5))
                Console.WriteLine(i);

            Console.ReadLine();
            
        }
    }
}
