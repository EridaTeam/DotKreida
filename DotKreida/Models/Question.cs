using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotKreida.Models {
    public class Question {
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }

        public Question() {
            Answers = new List<Answer>();
        }
    }
}