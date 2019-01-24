using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotKreida.Models {
    public class Answer {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsValid { get; set; }

        public virtual Question Question { get; set; }
    }
}