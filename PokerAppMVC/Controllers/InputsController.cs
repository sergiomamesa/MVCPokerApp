using PokerAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokerAppMVC.Controllers
{
    public class InputsController : Controller
    {

        public ActionResult Index()
        {
            return View(new Input());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Calculate(Input input)
        {
            if (input.SmallBlind <= 0)
                ModelState.AddModelError("SmallBlind", "Not a valid value");

            if (input.BigBlind <= 0)
                ModelState.AddModelError("BigBlind", "Not a valid value");

            if (input.Stack <= 0)
                ModelState.AddModelError("Stack", "Not a valid value");

            if (input.Players <= 0)
                ModelState.AddModelError("Players", "Not a valid value");

            if (input.Opponents <= 0)
                ModelState.AddModelError("Opponents", "Not a valid value");

            if (input.SmallBlind > input.BigBlind)
                ModelState.AddModelError("BigBlind", "BigBlind must be greather than SmallBlind");

            if (input.Ante.HasValue && input.Ante.Value > input.SmallBlind)
                ModelState.AddModelError("Ante", "Ante must be lower than SmallBlind");

            if (ModelState.IsValid == false)
                return View("Index", input);

            return RedirectToAction("Index", "Results", input);
        }


    }
}