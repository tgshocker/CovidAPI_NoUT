using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CovidTest.Models
{
    public class RegionsModels
    {
        public string iso { get; set; }
        public string name { get; set; }
    }

    public class JsonRegions
    {
        public List<RegionsModels> data { get; set; }
    }
}