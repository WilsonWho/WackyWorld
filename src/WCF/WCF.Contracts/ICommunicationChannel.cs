using System.ServiceModel;

namespace WCF.Common
{
    [ServiceContract(Name = "CommunicationChannel")]
    public interface ICommunicationChannel
    {
        [OperationContract]
        decimal Add(int val1, int val2);

        [OperationContract]
        decimal Divide(int numerator, int denominator);
    }
}