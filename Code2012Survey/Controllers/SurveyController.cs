using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code2012Survey.Models;

namespace Code2012Survey.Controllers
{
    public class SurveyController : Controller
    {
        // GET: /Survey/
        public ActionResult Index(SurveyReply reply)
        {
            return View(reply ?? new SurveyReply());
        }

        [HttpPost]
        public ActionResult Confirm(SurveyReply reply)
        {
            return View(reply);
        }

        [HttpPost]
        public ActionResult Commit(SurveyReply reply)
        {
            //TODO: Post reply of survey, here.

            return View();
        }
    }
}
