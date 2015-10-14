using DGSRestServices.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Service
{
    
    /// <summary>
    /// method what allows get  agent info
    /// </summary>
    /// <param name="agent"></param>
    /// <param name="idUser"></param>
    /// <returns></returns>
    public partial interface IDGSWCFService : IDisposable
    {


        #region Agent methods 

        #region Methods GET
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "agentInfo/{agent}/{idUser}")]
        string agentGetInfoService(string agent, string idUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="name"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "agentFindList/{agent}/{name}/{idUser}")]
        string agentFindListService(string agent, string name, string idUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <param name="decimasl"></param>
        /// <param name="trunc"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "agentFindList/{agent}/{decimasl}/{trunc}")]
        string agentGetAgentsListService(string idAgent, string decimasl, string trunc);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "agentGetDistributor/{idAgent}")]
        string agentGetDistributorService(string idAgent);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "agentGetInfoDistributor/{idAgent}")]
        string agentGetInfoDistributorService(string idAgent);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pridUser"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "agentGetList/{pridUser}")]
        string agentGetListService(string pridUser);

        #endregion Methods GET

        #region Methods POST

        #endregion Methods POST

        #region Methods PUT

        #endregion Methods PUT

        #region Methods DELETE

        #endregion Methods DELETE

        #endregion Agent methods 

    }



}
