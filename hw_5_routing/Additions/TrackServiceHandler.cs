using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hw_5_routing.Models;

namespace hw_5_routing.Additions
{
    public static class TrackServiceHandler
    {
        public static List<TrackServiceHistory> ChooseByYear( List<TrackServiceHistory> db, int year)
        {
            return db.Select(s => s).Where(w=>w.dRepairDate.Year==year).ToList();
        }
        public static List<TrackServiceHistory> ChooseByYearMonth(List<TrackServiceHistory> db, int year,int month)
        {
            return db.Select(s => s).Where(w => w.dRepairDate.Year == year&&w.dRepairDate.Month==month).ToList();
        }
        public static List<TrackServiceHistory> ChooseByYearMonthDay(List<TrackServiceHistory> db, int year,int month,int day)
        {
            return db.Select(s => s).Where(w => w.dRepairDate.Year == year&&w.dRepairDate.Month==month&&w.dRepairDate.Day==day).ToList();
        }

    }
}