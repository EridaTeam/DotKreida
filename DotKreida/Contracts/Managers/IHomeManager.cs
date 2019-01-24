using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotKreida.ViewModels;

namespace DotKreida.Contracts.Managers {
    public interface IHomeManager {
        HomeIndexViewModel GetLatestCourses(int count);
    }
}