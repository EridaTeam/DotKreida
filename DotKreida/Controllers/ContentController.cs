using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotKreida.Managers;
using DotKreida.Contracts.Managers;

namespace DotKreida.Controllers {
    public class ContentController : Controller {
        private readonly IContentManager contentManager;

        public ContentController() {
            contentManager = new ContentManager();
        }

        public ActionResult Topics() {
            var topicsViewModel = contentManager.GetTopics();

            return View(topicsViewModel);
        }

        public ActionResult Courses(string topic, int page = 1) {
            var coursesViewModel = contentManager.GetCoursesPerPage(topic, 6, page);
            ViewBag.TopicName = topic;

            return View(coursesViewModel);
        }
    }
}