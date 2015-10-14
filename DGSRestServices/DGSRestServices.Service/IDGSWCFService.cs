using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DGSRestServices.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDGSWCFService" in both code and config file together.
    [ServiceContract]
    public partial interface IDGSWCFService : IDisposable
    {
       // [OperationContract]
       // void DoWork();
    }
}
