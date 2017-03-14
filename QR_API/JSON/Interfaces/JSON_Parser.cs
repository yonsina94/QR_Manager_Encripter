using System;
using System.Collections.Generic;
using System.Text;

namespace API_Utils.Interfaces
{
    interface JSON_Parser<T>
    {
        string toJsonObject();
        T To_Object(string json_data);
    }
}
