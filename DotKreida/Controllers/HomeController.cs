using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotKreida.Managers;
using DotKreida.Contracts.Managers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace DotKreida.Controllers {
    public class HomeController : Controller {
        private readonly IHomeManager homeManager;

        public HomeController() {
            homeManager = new HomeManager();
        }

        public ActionResult Index() {
            var indexViewModel = homeManager.GetLatestCourses(3);

            return View(indexViewModel);
        }

        public ActionResult About() {
            return View();
        }
    }
}