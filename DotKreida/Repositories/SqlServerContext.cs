using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using DotKreida.Models;
using System.Data.Entity;

namespace DotKreida.Repositories {
    public class SqlServerContext : IdentityDbContext<User> {
        public SqlServerContext()
            : base("DotKreidaDb") { }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public static SqlServerContext Create() =>
            new SqlServerContext();
    }
}