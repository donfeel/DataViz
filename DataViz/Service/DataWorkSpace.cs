using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace dataviz.Service
{
    public class DataWorkSpace
    {
         static string geo_file_path = HttpContext.Current.Server.MapPath("~/DataSpace/china.geojson");

         public static Object GetGeoChina()
        {
            Object result;
            using (StreamReader sr = new StreamReader(geo_file_path))
            {
                try
                {
                    var content = sr.ReadToEnd();
                    sr.Close();

                    JsonReader reader = new JsonTextReader(new StringReader(content));
                    //JObject jOb = JObject.Parse(content);

                    result = JsonConvert.DeserializeObject(content);

                    return result;
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
            
        }
    }
}