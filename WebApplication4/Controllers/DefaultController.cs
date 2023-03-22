using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult newList()
        {
            return View();
        }
        public ActionResult toDoList()
        {
            return View();
        }
        public ActionResult userList()
        {
            return View();
        }
    }
}