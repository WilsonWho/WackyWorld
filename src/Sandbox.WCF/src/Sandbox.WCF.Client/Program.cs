using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sandbox.WCF.Communication;

namespace Sandbox.WCF.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Operation(10, 5);

            Console.WriteLine(result.Result);
            Console.ReadLine();
        }

        private async static Task<IEnumerable<decimal>> Operation(decimal val1, decimal val2)
        {
            var comChannel = new CalculatorClient();
            return await comChannel.Operation(val1, val2);
        }
    }
}
