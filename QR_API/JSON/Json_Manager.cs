using System;
using System.Collections.Generic;
using System.Text;
using API_Utils.JSON;
using Newtonsoft.Json;

namespace API_Utils.JSON
{
    class Json_Manager
    {
        private object obj { get; set; }
        private string json_str { get; set; }

        public Json_Manager(object OBJ)
        {
            obj = OBJ;
            json_str = null;
        }

        public Json_Manager(string Json_Str)
        {
            json_str = Json_Str;
            obj = null;
        }
        
        public object Proceder()
        {
            if (obj != null)
            {
                return JsonConvert.SerializeObject(obj);
            }
            else if(json_str != null)
            {
                return JsonConvert.DeserializeObject(json_str);
            }
        }
    }
}
