using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotKreida.Models {
    public class Course {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string VideoChannelUrl { get; set; }
        public DateTime PublishingDate { get; set; }

        public virtual Topic Topic { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Question> Questions { get; set; }

        public Course() {
            Questions = new List<Question>();
        }
    }
}