using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Configuration;
using System.Xml;

namespace DGSRestServices.Common.Utilities
{
    public class MessageManagerSettings : ConfigurationSection
    {
        // Fields
        private static volatile MessageManagerSettings _instance = null;
        private string pathDataMessage = string.Empty;
        private static readonly object syncRoot = new object();

        // Methods
        private MessageManagerSettings()
        {
        }

        public static MessageManagerSettings GetInstance()
        {
            if (_instance == null)
            {
                lock (syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = ConfigurationManager.GetSection("DGSConfigurations/DataMessage") as MessageManagerSettings;
                    }
                }
            }
            return _instance;
        }

        // Properties
        [ConfigurationProperty("FullPathDataMessage", DefaultValue = "0", IsKey = false, IsRequired = false)]
        public string FullPathDataMessage
        {
            set
            {
                if (this.pathDataMessage.Equals(string.Empty))
                {
                    this.pathDataMessage = base["FullPathDataMessage"].ToString();
                }
            }
        }

        [ConfigurationProperty("PathDataMessage", DefaultValue = "0", IsKey = false, IsRequired = false)]
        public string PathDataMessage
        {
            get
            {
                if (!base["PathDataMessage"].ToString().Equals("0"))
                {
                    if (this.pathDataMessage.Equals(string.Empty))
                    {
                        this.pathDataMessage = System.IO.Directory.GetCurrentDirectory() + @"\" + base["PathDataMessage"].ToString();
                    }
                }
                else
                {
                    this.FullPathDataMessage = "0";
                }
                return this.pathDataMessage;
            }
        }
    }
}
