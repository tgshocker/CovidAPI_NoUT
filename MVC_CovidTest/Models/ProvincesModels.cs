using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CovidTest.Models
{
    public class ProvincesModels
    {
        public string iso { get; set; }
        public string name { get; set; }
        public string province { get; set; }
        public string lat { get; set; }
        public string @long { get; set; }
    }

    public class JsonProvinces
    {
        public List<ProvincesModels> data { get; set; }
    }
}