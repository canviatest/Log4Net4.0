using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;

namespace Canvia.Common
{
	public  class LoggerManager
	{
		private  readonly ILog Logger;

		public LoggerManager()
		{
		}
		public LoggerManager(string nameLogger)
		{
		Logger= LogManager.GetLogger(nameLogger);
		}
		public   string SaveLogger(string message, LoggerLevel logLevel , Exception ex)
		{
			

			switch (logLevel)
			{
				case LoggerLevel.Info: Logger.Info(message);break;
				case LoggerLevel.Debug: Logger.Debug(message);break;
				case LoggerLevel.Fatal: Logger.Fatal(message);break;
				case LoggerLevel.Error: Logger.Error(message,ex);break;
			}
            
			return string.Empty;
		}

	

	
		
	}

}
