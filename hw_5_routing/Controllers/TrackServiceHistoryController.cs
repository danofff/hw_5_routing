using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hw_5_routing.Models;
using hw_5_routing.Additions;

namespace hw_5_routing.Controllers
{
    public class TrackServiceHistoryController : Controller
    {
        // GET: TrackServiceHistory
       
        public ActionResult Index(int? year = null,int? month=null,int? day=null)
        {
            List<TrackServiceHistory> data = new List<TrackServiceHistory>();
            using (MyModel db = new MyModel())
            {              
                if (year != null && month != null && day != null)
                {
                    data = TrackServiceHandler.ChooseByYearMonthDay(db.TrackServiceHistory.ToList(), (int)year, (int)month, (int)day);
                }
                else if (year != null && month != null)
                {
                    data = TrackServiceHandler.ChooseByYearMonth(db.TrackServiceHistory.ToList(), (int)year, (int)month);
                }
                else if (year != null)
                {
                    data = TrackServiceHandler.ChooseByYear(db.TrackServiceHistory.ToList(), (int)year);
                }
                else
                {
                    data = db.TrackServiceHistory.ToList();
                }
            }

            if (data.Count>0)
            {
                return View(data);
            }

            return Redirect("~/TrackServiceHistory/NoData");
        }

        public ActionResult NoData()
        {
            return View();
        }
        
    }
}