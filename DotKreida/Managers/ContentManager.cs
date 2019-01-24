using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotKreida.ViewModels;
using DotKreida.Repositories;
using DotKreida.Contracts.Managers;
using DotKreida.Contracts.Repositories;

namespace DotKreida.Managers {
    public class ContentManager : IContentManager {
        private readonly IUnitOfWork unitOfWork;

        public ContentManager() {
            unitOfWork = new UnitOfWork();
        }

        public ContentTopicsViewModel GetTopics() {
            var topics = unitOfWork.Topics.GetAll().ToList();

            return new ContentTopicsViewModel(topics);
        }

        public ContentCoursesViewModel GetCoursesPerPage(string topicName, int coursesPerPage, int pageNumber) {
            var courses = unitOfWork.Courses.GetAll()
                .Where(x => x.Topic.Name == topicName);
            var pageCourses = courses.Skip(coursesPerPage * (pageNumber - 1))
                .Take(coursesPerPage)
                .ToList();

            var nextTwoPages = new List<int>();
            var maxPages = Math.Ceiling(courses.Count() / 6.0);

            for (int i = 1; i < 3; i++) {
                if (pageNumber + i <= maxPages) {
                    nextTwoPages.Add(pageNumber + i);
                }
            }

            return new ContentCoursesViewModel(pageCourses, nextTwoPages, pageNumber);
        }
    }
}