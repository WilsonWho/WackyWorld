using System;

namespace Sandbox.WCF.Server
{
    public interface IWcfService : IDisposable
    {
        void Start();
        void Stop();
    }
}