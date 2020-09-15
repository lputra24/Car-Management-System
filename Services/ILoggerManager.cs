using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarManagementSystem.Services
{
    interface ILoggerManager
    {
        void LogInfo(String message);
        void LogWarn(String message);
        void LogDebug(String message);
        void LogError(String message);
    }
}
