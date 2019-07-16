namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Linq;
    public static class Program19
    {
        public static void Main19()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();
            
            for (int i = 0; i < parallelResult.Length; i++)
            {
                Console.Write(parallelResult[i] + 
                    System.Environment.NewLine);
            }
            
            Console.ReadLine();
        }
    }
}
