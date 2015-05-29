using System;

namespace PostClient.UI
{
    public interface IPlugin : IDisposable
    {
        void DoActions();
    }
}