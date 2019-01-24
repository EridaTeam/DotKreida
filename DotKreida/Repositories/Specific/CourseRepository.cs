using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotKreida.Contracts.Repositories.Specific;
using DotKreida.Models;
using RefactorThis.GraphDiff;
using System.Data.Entity;

namespace DotKreida.Repositories.Specific {
    public class CourseRepository : ICourseRepository {
        private readonly SqlServerContext db;

        public CourseRepository(SqlServerContext db) {
            this.db = db;
        }

        public void Create(Course course) {
            db.Entry(course.Topic).State = EntityState.Unchanged;
            //db.Entry(course.User).State = EntityState.Unchanged;

            db.Courses.Add(course);
        }

        public void Delete(Course course) =>
            db.Courses.Remove(db.Courses.Find(course.Id));

        public IEnumerable<Course> GetAll() =>
            db.Courses.AsNoTracking().ToList();

        public Course GetById(int id) =>
            db.Courses.AsNoTracking().SingleOrDefault(x => x.Id == id);

        public void Update(Course course) =>
            db.UpdateGraph(course, map => map.OwnedCollection(x => x.Questions, with =>
                with.OwnedCollection(y => y.Answers)));
    }
}