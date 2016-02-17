using dataviz.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dataviz.Controllers
{
    public class DataController : Controller
    {
        //
        // GET: /Data/

        public ActionResult Index()
        {
            return View();
        }


        public JsonNetResult Geo()
        {
            var result = new JsonNetResult
            {
                Data = Service.DataWorkSpace.GetGeoChina(),//JsonConvert.DeserializeObject(testData),
            };

            return result;
        }
    }
}
