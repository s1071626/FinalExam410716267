using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalExam410716267.Controllers
{
    public class CalController : Controller
    {
        // GET: Cal
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(float? week)
        {
            var result = "";
            if (week.HasValue) {
                if (week == 1) {
                    result = "星期一";
                }
                if (week == 2)
                {
                    result = "星期二";
                }
                if (week == 3)
                {
                    result = "星期三";
                }
                if (week == 4)
                {
                    result = "星期四";
                }
                if (week == 5)
                {
                    result = "星期五";
                }
                if (week == 6)
                {
                    result = "星期六";
                }
                if (week == 7)
                {
                    result = "星期日";
                }
            }
            ViewBag.Result = result;
            return View();
        }
    }
}