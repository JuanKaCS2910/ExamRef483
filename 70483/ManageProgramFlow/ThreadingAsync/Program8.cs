using System;
namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System.Threading.Tasks;
    public static class Program8
    {

        public static void Main8()
        {
            Task t = Task.Run(() => 
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("*");
                    //Console.WriteLine("{0} {1}", i, "+");
                }
            });
            t.Wait();
            Console.ReadLine();
        }

    }
}
