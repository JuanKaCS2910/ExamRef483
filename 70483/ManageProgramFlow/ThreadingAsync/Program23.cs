namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Linq;

    public static class Program23
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel()
                    .Where(i => IsEven(i));
                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException e)
            {
                Console.WriteLine("There where {0} exceptions",
                    e.InnerExceptions.Count);
            }
            Console.ReadLine();
        }

        public static bool IsEven(int i)
        {
            if (i != 0)
                if (i % 10 == 0) throw new ArgumentException("i");
            return i % 2 == 0;
        }
    }
}
