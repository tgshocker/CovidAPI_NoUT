using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CovidTest.Methods;
using MVC_CovidTest.Models;
using System.Threading.Tasks;

namespace MVC_CovidTest.Controllers
{
    public class CovidAPIController : Controller
    {
        // GET: CovidAPI
        public async Task<ActionResult> Index()
        {
            //ViewBag.data = getReportsByRegion();
            //ViewBag.provinces = getReportsByProvince();

            JsonRegions dataRegions = await CovidAPI.getRegion();
            JsonReports dataReports = await CovidAPI.getReports();
            List<ReportsModels> dataReportsShown = new List<ReportsModels>();

            dataReportsShown = dataReports.data;
            dataReportsShown = dataReportsShown.OrderByDescending(x => Convert.ToInt32 (x.confirmed)).ToList<ReportsModels>();

            //dataReportsShown = from x in dataReports.data
            //                   orderby x.active descending
            //                   select x;

            ViewBag.regions = dataRegions.data.OrderBy(x=>x.name).ToList<RegionsModels>();
            ViewBag.reports = dataReportsShown.Take(10);
            return View();
        }

        public async Task<ActionResult> IndexByProvince()
        {
            string iso = RouteData.Values["id"].ToString();

            JsonRegions dataRegions = await CovidAPI.getRegion();
            JsonReports dataReports = await CovidAPI.getReportsByProvince(iso);
            List<ReportsModels> dataReportsShown = new List<ReportsModels>();

            dataReportsShown = dataReports.data;
            dataReportsShown = dataReportsShown.OrderByDescending(x => Convert.ToInt32(x.confirmed)).ToList<ReportsModels>();

            //dataReportsShown = from x in dataReports.data
            //                   orderby x.active descending
            //                   select x;

            ViewBag.regions = dataRegions.data.OrderBy(x => x.name).ToList<RegionsModels>();
            ViewBag.reports = dataReportsShown.Take(10);
            ViewBag.iso = iso;
            return View();
        }


    }
}
