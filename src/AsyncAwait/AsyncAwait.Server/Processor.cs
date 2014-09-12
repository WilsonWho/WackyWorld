using System.Threading;

namespace AsyncAwait.Server
{
    internal static class Processor
    {
         internal static int DoMath(int value)
         {
             const int timeout = 10000;
             Thread.Sleep(timeout);

             return value * value;
         }
    }
}