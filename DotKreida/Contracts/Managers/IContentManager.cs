using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotKreida.ViewModels;

namespace DotKreida.Contracts.Managers {
    public interface IContentManager {
        ContentTopicsViewModel GetTopics();
        ContentCoursesViewModel GetCoursesPerPage(string topicName, int coursesPerPage, int pageNumber);
    }
}