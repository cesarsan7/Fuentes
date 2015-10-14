using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGSRestServices.Controller;
using DGSRestServices.Controller.Class;
using DGSRestServices.Model.Class;
using DGSRestServices.Facade.Class;
using DGSRestServices.Common.Utilities;

namespace TestController
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Log4NetHelper.addLog(Log4NetHelper.levelLog.DEBUG, "");
           // agentGetInfo("LUFKIN", 2);
            // addAgentController();
            TestController.DGSService.DGSWCFServiceClient objDGSService = new DGSService.DGSWCFServiceClient();

            var result = objDGSService.agentGetInfoService("LUFKIN", 2);
            //testAgentController();
            testAgentFacade();

        }


        public static void testAgentFacade()
        {

            AgentFacade objAgentFacade = new AgentFacade();
            //objAgentFacade.getAllAgentFacade();
        }
        public static  void testAgentController ()
        {

            AgentController objAgentController = new AgentController();
           // objAgentController.getAllAgent();
        }

        public static void addAgentController()
        {

            AgentController objAgentController = new AgentController();
            AgentModel objModel = new AgentModel();
            objModel.Address1 = "CARVAJAL SANTA MONICA";
            //objAgentController.createAgent(objModel);

        }
        public static void agentGetInfo(string agent,short idUSer )
        {
            // AgentController objAgentController = new AgentController();
            // objAgentController.agentGetInfo(agent, idUSer);

            AgentFacade objFacade = new AgentFacade();
           // string x =objFacade.agentGetInfoFacade(agent, idUSer);

           
        }
    }
}
