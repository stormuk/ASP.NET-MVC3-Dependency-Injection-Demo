using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIDemo.Core
{
    public interface IMessagingService
    {
        void Send(string message);
    }
}
