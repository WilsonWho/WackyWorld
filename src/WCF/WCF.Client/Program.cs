using System;
using WCF.Common;
namespace WCF.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var wcfServiceClient = WcfServiceClientFactory<ICommunicationChannel>.Create(Constants.RemoteEndpointAddress);
            
            var sum = wcfServiceClient.Channel.Add(1, 1);
            Console.WriteLine("Sum is {0}", sum);

            var quotient = wcfServiceClient.Channel.Divide(10, 5);
            Console.WriteLine("Quotient is {0}", quotient);



            Console.ReadLine();
        }
    }
}
