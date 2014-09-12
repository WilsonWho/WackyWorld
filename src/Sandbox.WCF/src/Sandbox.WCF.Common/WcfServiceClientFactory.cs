using Sandbox.WCF.Configuration;

namespace Sandbox.WCF.Common
{
    public static class WcfServiceClientFactory<TChannel> where TChannel : class 
    {
        public static WcfServiceClient<TChannel> Create()
        {
            return new WcfServiceClient<TChannel>(Constants.RemoteEndpointAddress);
        }
    }
}