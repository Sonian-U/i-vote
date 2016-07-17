using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EVotingSystems.Controllers
{
    public class CastVoteController : Controller
    {
        // GET: CastVote
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult VerifyCNIC(EVotingSystems.Models.VoterPerson person)
        {


            return RedirectToAction("MobileVerification", "CastVote");


        }
        [HttpGet]
        public ActionResult MobileVerification() {

            return View();
        }
        [HttpPost]
        public ActionResult VerifyMobile(EVotingSystems.Models.VoterPerson person) {

            return RedirectToAction("FacialVerification", "CastVote");
        }
        [HttpGet]
        public ActionResult FacialVerification() {

            return View();
        }

        [HttpPost]
        public ActionResult Verifyface(EVotingSystems.Models.VoterPerson person)
        {

            return RedirectToAction("Verifymainden", "CastVote");
        }

        [HttpGet]
        public ActionResult Verifymainden() {

            return View();


        }
        [HttpPost]
        public ActionResult Verifymainden(EVotingSystems.Models.VoterPerson person)
        {

            return RedirectToAction("thumbPrint", "CastVote");
        }
        [HttpGet]
        public ActionResult thumbPrint() {


            return View();
        }
        [HttpPost]
        public ActionResult thumbPrint(EVotingSystems.Models.Party party)
        {


            return RedirectToAction("Voteticking","CastVote");
        }
        [HttpGet]
        public ActionResult Voteticking()
        {


            return View();

        }
        [HttpPost]
        public ActionResult SubmitVote() {

            ViewBag.message = "Your Vote has been submitted";
            return RedirectToAction("HomeIndex","Home");
        }


    }
}