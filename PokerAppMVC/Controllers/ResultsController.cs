using PokerAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokerAppMVC.Controllers
{
    public class ResultsController : Controller
    {
        public ActionResult Index(Input input)
        {
            var result = input.Calculate();

            return View(result);
        }
    }
}