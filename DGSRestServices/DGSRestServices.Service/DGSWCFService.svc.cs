using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DGSRestServices.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DGSWCFService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DGSWCFService.svc or DGSWCFService.svc.cs at the Solution Explorer and start debugging.
    public partial  class DGSWCFService : IDGSWCFService
    {

        #region Private Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
            // free native resources
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
