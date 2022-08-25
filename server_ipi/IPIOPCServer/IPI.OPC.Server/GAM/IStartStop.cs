using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPI.OpcUaServer.GAM
{
    internal interface IStartStop
    {
        void Start(ISystemContext context, IList<object> inputArguments);
        void Stop(ISystemContext context);
    }
}
