namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Linq;

    public static class Program20
    {
        public static void Main20()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (int i in parallelResult)
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
