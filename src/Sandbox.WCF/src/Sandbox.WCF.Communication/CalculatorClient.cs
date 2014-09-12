using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sandbox.WCF.Common;

namespace Sandbox.WCF.Communication
{
    public class CalculatorClient
    {
        public async Task<IEnumerable<decimal>> Operation(decimal val1, decimal val2)
        {
            try
            {
                using (var comClient = CreateChannel())
                {
                    return await comClient.Channel.Operate(val1, val2);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static WcfServiceClient<ICommunicationChannel> CreateChannel()
        {
            return WcfServiceClientFactory<ICommunicationChannel>.Create();
        }
    }
}