namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Linq;

    public static class Program22
    {
        public static void Main22()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel()//.AsOrdered()
                .Where(i => i % 2 == 0);
            parallelResult.ForAll(e => Console.WriteLine(e));

            Console.ReadLine();
        }
    }
}
