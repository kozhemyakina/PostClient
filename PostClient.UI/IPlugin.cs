using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostClient.UI
{
    public interface IPlugin : IDisposable
    {
        void DoActions();
    }
}
