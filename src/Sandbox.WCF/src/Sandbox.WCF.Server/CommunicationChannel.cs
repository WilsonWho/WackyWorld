using System.Collections.Generic;
using System.Threading.Tasks;
using Sandbox.WCF.Communication;

namespace Sandbox.WCF.Server
{
    public class CommunicationChannel : ICommunicationChannel
    {
        public async Task<IEnumerable<decimal>> Operate(decimal val1, decimal val2)
        {
            return await Calculator.Operate(val1, val2);
        }
    }
}