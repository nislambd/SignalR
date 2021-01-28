using Microsoft.AspNet.SignalR;
using NLog.SignalR;

namespace SignalR_Test.Hubs
{
    public class LoggingHub : Hub<ILoggingHub>
    {
        public void Log(LogEvent logEvent)
        {
            Clients.Others.Log(logEvent);
        }
    }
}

//https://github.com/toddmeinershagen/NLog.SignalR
//install-package NLog.SignalR