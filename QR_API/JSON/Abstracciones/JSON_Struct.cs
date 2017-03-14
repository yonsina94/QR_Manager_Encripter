using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization;

namespace API_Utils.Abstracciones
{
    abstract class JSON_Struct { 

        public JSON_Struct()
        {
          
        }

        public string ToJson(this object obj)
        {
             return JsonConvert.SerializeObject(obj);
        }

        public T To_Object<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

    }
}
