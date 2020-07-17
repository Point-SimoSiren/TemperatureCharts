using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TempCharts.Models;
using TempCharts.ViewModels;
using System.Data.Entity.SqlServer;

namespace TempCharts.Controllers
{
    public class MeasurementsController : Controller
    {
        private hoivadbEntities db = new hoivadbEntities();

        // GET: Measurements
        public async Task<ActionResult> Index()
        {
            return View(await db.Measurements.ToListAsync());
        }


        public ActionResult _HumidityGraphics()
        {

           // List<HumidityGraphics> humidataList = new List<HumidityGraphics>();

            var humidityMeasurements = from m in db.Measurements
                                       orderby m.Time
                               select new HumidityGraphics
                               {
                                   //Time = m.Time.ToString("YY/MM/DD"),
                                   Time = SqlFunctions.DateName("yy", m.Time) + "." + SqlFunctions.DateName("M", m.Time) + "." + SqlFunctions.DateName("day", m.Time) + "." + SqlFunctions.DateName("hour", m.Time) + "." + SqlFunctions.DateName("minute", m.Time),
                                   Humidity = m.Humidity
 
                               };

            return Json(humidityMeasurements, JsonRequestBehavior.AllowGet);

        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
