using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotKreida.Models;

namespace DotKreida.ViewModels {
    public class HomeIndexViewModel {
        public List<Course> LatestCourses { get; set; }

        public HomeIndexViewModel(List<Course> latestCourses) {
            LatestCourses = latestCourses;
        }
    }
}