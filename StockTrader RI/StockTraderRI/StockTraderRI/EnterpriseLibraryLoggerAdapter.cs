using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace StockTraderRI
{
    public class EnterpriseLibraryLoggerAdapter : ILoggerFacade
    {
        public EnterpriseLibraryLoggerAdapter()
        {
            Logger.SetLogWriter(new LogWriter(new LoggingConfiguration()));
        }

        #region ILoggerFacade Members

        public void Log(string message, Category category, Priority priority)
        {
            Logger.Write(message, category.ToString(), (int)priority);
        }

        #endregion
    }
}
