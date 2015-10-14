using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DGSRestServices.Common.Utilities
{
    public class JavaScriptSerializerHelper
    {
        /// <summary>
        /// Obtiene la cadena de JavaScript para el formulario
        /// </summary>
        /// <param name="obj">Objeto a serializar</param>
        /// <returns>Cadena serializada</returns>
        public static string GetString(object obj)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            jss.MaxJsonLength = int.MaxValue;
            return jss.Serialize(obj);
        }

        /// <summary>
        /// Deserializa el objeto json
        /// </summary>
        /// <typeparam name="T">Tipo de objeto</typeparam>
        /// <param name="json">json</param>
        /// <returns>Objeto</returns>
        public static T Deserialize<T>(string json)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            return jss.Deserialize<T>(json);
        }
    }
}

