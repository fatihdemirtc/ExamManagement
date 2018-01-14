using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExamManagement.Helper;
using ExamManagement.Models;

namespace ExamManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ExamXMLModel a=ExamHelper.AllQuestionsGetter();
            return View();
        }
    }
}