namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Threading.Tasks;
    public static class Program12
    {
        public static void Main12()
        {
            Task<Int32[]> parent = Task.Run(() => 
            {
                var results = new Int32[3];
                TaskFactory tf = new TaskFactory(
                    TaskCreationOptions.AttachedToParent, 
                    TaskContinuationOptions.ExecuteSynchronously);
                tf.StartNew(() => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);
                return results;
            });

            var finalTask = parent.ContinueWith(
                parentTask => 
                {
                    foreach (int i in parentTask.Result)
                        Console.WriteLine(i);
                });

            finalTask.Wait();
            Console.ReadLine();
        }
    }
}
