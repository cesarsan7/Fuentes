using System;

namespace DGSRestServices.Common.Utilities
{
    public class MessageInfo
    {
        // Fields
        public bool success;
        public string messageDescription;
        public int messageID;
        public string messageLog;

        // Properties
        public bool Success
        {
            get
            {
                return this.success;
            }
            set
            {
                this.success = value;
            }
        }

        public string MessageDescription
        {
            get
            {
                return this.messageDescription;
            }
            set
            {
                this.messageDescription = value;
            }
        }

        public int MessageID
        {
            get
            {
                return this.messageID;
            }
            set
            {
                this.messageID = value;
            }
        }

        public string MessageLog
        {
            get
            {
                return this.messageLog;
            }
            set
            {
                this.messageLog = value;
            }
        }
    }




}
