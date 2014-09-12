using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Sandbox.WCF.Configuration;

namespace Sandbox.WCF.Common
{
    public class WcfServiceClient<TChannel> : IDisposable where TChannel : class
    {
        private WcfServiceClientInternal _wcfServiceClientInternal;
        private bool _isDisposing;

        public WcfServiceClient(string endpointAddress)
        {
            if (string.IsNullOrWhiteSpace(endpointAddress))
                throw new ArgumentNullException("endpointAddress");

            var baseUri = new Uri(Constants.LocalHostNamedPipeUrl);
            var endpoint = new EndpointAddress(new Uri(baseUri, endpointAddress));

            _wcfServiceClientInternal =
                new WcfServiceClientInternal(new NetNamedPipeBinding(NetNamedPipeSecurityMode.Transport), endpoint);
        }

        public TChannel Channel
        {
            get { return _wcfServiceClientInternal.CommunicationChannel; }
        }

        private class WcfServiceClientInternal : ClientBase<TChannel>
        {
            public WcfServiceClientInternal(Binding binding, EndpointAddress endpointAddress)
                : base(binding, endpointAddress)
            {

            }

            public TChannel CommunicationChannel
            {
                get { return Channel; }
            }
        }

        ~WcfServiceClient()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool dispoing)
        {
            if (_isDisposing)
                return;

            if (dispoing)
            {
                if (_wcfServiceClientInternal != null)
                {
                    _wcfServiceClientInternal.Close();
                    _wcfServiceClientInternal = null;
                }
            }

            _isDisposing = true;
        }
    }
}