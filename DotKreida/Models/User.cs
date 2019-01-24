using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DotKreida.Models {
    public class User : IdentityUser {
        public string ImageUrl { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public User() {
            Courses = new List<Course>();
        }
    }
}