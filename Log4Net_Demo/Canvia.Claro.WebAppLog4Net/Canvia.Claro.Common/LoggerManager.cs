using System;
using System.Diagnostics;
using log4net;

namespace Canvia.Claro.Common
{
   public class LoggerManager
   {
       private readonly ILog _logger;

       public LoggerManager(string loggerName)
       {
        _logger =   LogManager.GetLogger(loggerName);
       }

       public void SaveLogger(string message, LoggerLevel logLevel, Exception ex = null)
        {
           switch (logLevel)
            {
                case LoggerLevel.Info: _logger.Info(message); break;
                case LoggerLevel.Debug: _logger.Debug(message); break;
                case LoggerLevel.Fatal: _logger.Fatal(message); break;
                case LoggerLevel.Error: _logger.Error(message, ex); break;
            }

        }
    }
}
