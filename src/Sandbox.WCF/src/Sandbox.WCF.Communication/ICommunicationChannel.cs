using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Sandbox.WCF.Communication
{
    [ServiceContract(Name = "CommunicationChannel")]
    public interface ICommunicationChannel
    {
        [OperationContract]
        [FaultContract(typeof(CalculatorFault))]
        Task<IEnumerable<decimal>> Operate(decimal val1, decimal val2);
    }
}