using System;
using System.Threading.Tasks;
using AsyncAwait.Server;

namespace AsyncAwait.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int value = 5;
            var blackbox = new BlackBox();

            var result = blackbox.GetValue(value);
            Console.WriteLine(result);

            var resultAsync = blackbox.GetValueAsync(value).Result;
            Task.WaitAll();
            Console.WriteLine(resultAsync);

            Console.ReadKey();
        }
    }
}