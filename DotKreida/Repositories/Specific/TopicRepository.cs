using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotKreida.Contracts.Repositories.Specific;
using DotKreida.Models;
using RefactorThis.GraphDiff;

namespace DotKreida.Repositories.Specific {
    public class TopicRepository : ITopicRepository {
        private readonly SqlServerContext db;

        public TopicRepository(SqlServerContext db) {
            this.db = db;
        }

        public void Create(Topic topic) =>
            db.Topics.Add(topic);

        public IEnumerable<Topic> GetAll() =>
            db.Topics.AsNoTracking().ToList();

        public Topic GetById(int id) =>
            db.Topics.AsNoTracking().SingleOrDefault(x => x.Id == id);

        public void Update(Topic topic) =>
            db.UpdateGraph(topic, map => map.OwnedCollection(x => x.Courses));
    }
}