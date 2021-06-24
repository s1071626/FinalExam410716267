using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalExam410716267.Controllers
{
    public class ExamController : Controller
    {
        // GET: Exam
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            @ViewBag.name = "邱致豪";
            return View();
        }
    }
}