using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using log4net.Core;

namespace DGSRestServices.Common.Utilities
{
    public class Log4NetHelper
    {
        #region Vars

        private ILog log;
        static Log4NetHelper logHelper;
        public  enum levelLog {
            ALL,
            DEBUG,
            INFO,
            WARN,
            ERROR,
            FATAL,
            OFF
        };

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        private Log4NetHelper()
        {
            XmlConfigurator.Configure();
            log = LogManager.GetLogger(this.GetType());
        }

        #endregion

        #region Publics Statics

        /// <summary>
        /// Devuelve la instancia del log
        /// </summary>
        /// <returns></returns>
        public static ILog GetLog()
        {
            if (logHelper == null) { logHelper = new Log4NetHelper(); }
            return logHelper.log;
        }


        public static void addLog (Log4NetHelper.levelLog _levelLog , String message, Exception exc = null) 
        {


            StringBuilder sbError = new StringBuilder();
            if (exc != null)
            {
                sbError.AppendFormat("Error Message {0}" ,exc.Message);
                sbError.AppendFormat("Error Source  {1}", exc.Source);
                sbError.AppendFormat("Error InnerException.Message  {2}", exc.InnerException.Message);

            }
            switch (_levelLog)
            {
                case Log4NetHelper.levelLog.DEBUG:
                    Log4NetHelper.GetLog().DebugFormat("{0} - Exeception :", message, sbError.ToString ());
                    break;
                case Log4NetHelper.levelLog.ERROR:
                    Log4NetHelper.GetLog().ErrorFormat("{0} - Exeception :", message, sbError.ToString());
                    break;
                case Log4NetHelper.levelLog.FATAL:
                    Log4NetHelper.GetLog().FatalFormat("{0} - Exeception :", message, sbError.ToString());
                    break;
                case Log4NetHelper.levelLog.INFO:
                    Log4NetHelper.GetLog().InfoFormat("{0} - Exeception :", message, sbError.ToString());
                    break;
                case Log4NetHelper.levelLog.OFF:
                  //  Log4NetHelper.GetLog().("{0} - Exeception :", message, sbError.ToString());
                    break;
                case Log4NetHelper.levelLog.WARN:
                    Log4NetHelper.GetLog().WarnFormat("{0} - Exeception :", message, sbError.ToString());
                    break;
                case Log4NetHelper.levelLog.ALL:
                   // Log4NetHelper.GetLog().Error("{0} - Exeception :", message, sbError.ToString());
                    break;



            }
           
            Log4NetHelper.GetLog().Info("info");
            Log4NetHelper.GetLog().Debug("debug");

            //switch(levelLog)
            //{
            //    case  "INFO":
            //        _log.GetLog().Debug("debug");
            //        break;
            //}
            /*
               _log.
                string title = string.Format("{0} {1}",
                        loggingEvent.Level.DisplayName,
                        loggingEvent.LoggerName);

                string message = string.Format(
                    "{0}{1}{1}{2}{1}{1}(Yes to continue, No to debug)",
                    "",
                    Environment.NewLine,
                    loggingEvent.LocationInformation.FullInfo);
            */

        }
        #endregion
    }
}
