using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotKreida.Models;

namespace DotKreida.ViewModels {
    public class ContentCoursesViewModel {
        public List<Course> CurrentPageCourses { get; set; }
        public List<int> NextTwoPages { get; set; }
        public int CurrentPage { get; set; }

        public ContentCoursesViewModel(List<Course> currentPageCourses, List<int> nextTwoPages, int currentPage) {
            CurrentPageCourses = currentPageCourses;
            NextTwoPages = nextTwoPages;
            CurrentPage = currentPage;
        }
    }
}