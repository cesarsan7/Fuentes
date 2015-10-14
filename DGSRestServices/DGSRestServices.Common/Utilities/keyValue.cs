using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Common.Utilities
{
    public class keyValue
    {
        public string key ;
        public object value;
        public bool validateObligatory;

        public keyValue()
        {
            key = "";
            value = "";
            validateObligatory = false;
        }

        public keyValue(string key, object value, bool validateObligatory)
        {
            this.key   = key;
            this.value = value;
            this.validateObligatory = validateObligatory;
        }
        public keyValue(string key, object value)
        {
            this.key = key;
            this.value = value;
            this.validateObligatory = false;
        }
    }
}
