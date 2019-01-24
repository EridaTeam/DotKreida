using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotKreida.ViewModels;
using DotKreida.Repositories;
using DotKreida.Contracts.Managers;
using DotKreida.Contracts.Repositories;

namespace DotKreida.Managers {
    public class HomeManager : IHomeManager {
        private readonly IUnitOfWork unitOfWork;

        public HomeManager() {
            unitOfWork = new UnitOfWork();
        }

        public HomeIndexViewModel GetLatestCourses(int count) {
            var courses = unitOfWork.Courses.GetAll()
                .OrderByDescending(x => x.PublishingDate)
                .Take(count)
                .ToList();

            return new HomeIndexViewModel(courses);
        }
    }
}