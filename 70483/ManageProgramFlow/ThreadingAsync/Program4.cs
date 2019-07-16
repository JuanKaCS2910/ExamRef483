using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _70483.ManageProgramFlow.ThreadingAsync
{
    public class Program4
    {

        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc : {0}", i);
                Thread.Sleep(0);
            }
            
        }

        public static void Main4()
        {
            bool stopped = false;

            Thread t = new Thread(new ThreadStart(()=>
            {
                while(!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));
            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            stopped = true;
            t.Join();

        }

    }
}
