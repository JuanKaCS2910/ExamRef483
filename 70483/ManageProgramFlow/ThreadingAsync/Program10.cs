namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Threading.Tasks;
    public static class Program10
    {
        public static void Main10()
        {
            Task t = Task.Run(() => 
            {
                return 42;
            });

            t.ContinueWith((i) => 
            {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) => 
            {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) => 
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
            Console.ReadLine();
        }

    }
}
