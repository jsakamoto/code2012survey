using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
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
            // Post reply of survey to back-end API.

            var repOfQ1 = "[" + string.Join(",",
                new[]{
                    reply.Choice1OfQ1,
                    reply.Choice2OfQ1,
                    reply.Choice3OfQ1,
                    reply.Choice4OfQ1,
                    reply.Choice5OfQ1,
                    reply.Choice6OfQ1
                }.Select(a => a.ToString().ToLower())
            ) + "]";

            var postData = new Dictionary<string, object> { 
                {"survey[why]", repOfQ1},
                {"survey[how_year]", reply.CodingForYears},
                {"survey[locale]", reply.Address},
                {"survey[free_comment]", reply.Comment},
                {"survey[app_name]", ConfigurationManager.AppSettings["AppName"]},
            };

            var postDataStr = string.Join("&", postData
                .Select(a => a.Key + "=" + HttpUtility.UrlEncode(a.Value.ToString(), Encoding.UTF8))
                );

            var webClient = new WebClient { Encoding = Encoding.UTF8 };
            var postToUrl =
                ConfigurationManager.AppSettings["UrlOfAPI"] +
                ConfigurationManager.AppSettings["PostTo"];

            webClient.Headers["Content-type"] = "application/x-www-form-urlencoded";
            webClient.UploadString(postToUrl, "POST", postDataStr);

            return View();
        }

        [HttpGet]
        public ActionResult Commit()
        {
            return View();
        }
    }
}
