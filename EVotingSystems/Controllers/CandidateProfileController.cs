using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EVotingSystems.Controllers
{
    public class CandidateProfileController : Controller
    {
        // GET: CandidateProfile
        [HttpGet]
        public ActionResult CandidateList()
        {
            return View();

        }


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Portfolio() {

            return View();
        }

        [HttpGet]
        public ActionResult Contact() {


            return View();

        }
    }
}