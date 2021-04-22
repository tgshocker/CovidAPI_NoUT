using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CovidTest.Models
{
    public class ReportsModels
    {
        public string date { get; set; }
        public string confirmed { get; set; }
        public string deaths { get; set; }
        public string recovered { get; set; }
        public string confirmed_diff { get; set; }
        public string deaths_diff { get; set; }
        public string recovered_diff { get; set; }
        public string last_update { get; set; }
        public string active { get; set; }
        public string active_diff { get; set; }
        public string fatality_rate { get; set; }
        public JsonRegion region { get; set; }

    }

    public class JsonReports
    {
        public List<ReportsModels> data { get; set; }
    }

    public class JsonRegion
    {
        public string iso { get; set; }
        public string name { get; set; }
        public string province { get; set; }
        public string lat { get; set; }
        public string @long { get; set; }
        public List<JsonCities> cities { get; set; }
    }

    public class JsonCities
    {
        public string name { get; set; }
        public string date { get; set; }
        public string flips { get; set; }
        public string lat { get; set; }
        public string @long { get; set; }
        public string confirmed { get; set; }
        public string deaths { get; set; }
        public string confirmed_diff { get; set; }
        public string deaths_diff { get; set; }
        public string last_update { get; set; }

    }
}
