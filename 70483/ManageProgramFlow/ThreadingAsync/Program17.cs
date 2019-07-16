
namespace _70483.ManageProgramFlow.ThreadingAsync
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    public static class Program17
    {

        public static void Main17()
        {
            string result = DownloadContent().Result;
            Console.WriteLine("result: {0}", result);
            Console.ReadLine();
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }

    }
}
