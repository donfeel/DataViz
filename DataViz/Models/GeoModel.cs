using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dataviz.Models
{
    public class GeoModel
    {
        public string Type { get; set; }
        public List<Features> Features { get; set; }
    }

    public class Properties
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Geometry
    {
        public string Type { get; set; }
        public List<string> Coordinates { get; set; }
    }

    public class Features
    {
        public string Type { get; set; }
        public Properties Properties { get; set; }
        public Geometry Geometry { get; set; }
    }


}