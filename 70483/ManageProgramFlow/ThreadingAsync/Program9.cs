namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Threading.Tasks;
    public static class Program9
    {
        public static void Main9()
        {
            Task<int> t = Task.Run(() => 
            {
                return 42;
            }).ContinueWith((i)=> 
            {
                return i.Result * 2;
            });
            Console.WriteLine(t.Result);
            Console.ReadLine();
        }

    }
}
