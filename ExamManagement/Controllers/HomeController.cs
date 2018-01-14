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
            //This code will bring the datas from wired.com
            ExamXMLModel a=ExamHelper.AllQuestionsGetter();
            return View();
            
        }
    }
}