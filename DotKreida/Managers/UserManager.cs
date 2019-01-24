using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using DotKreida.Models;
using DotKreida.Repositories;

namespace DotKreida.Managers {
    public class UserManager : UserManager<User> {
        public UserManager(IUserStore<User> store)
            : base(store) {
        }

        public static UserManager Create(IdentityFactoryOptions<UserManager> options, IOwinContext context) {
            SqlServerContext db = context.Get<SqlServerContext>();
            UserManager manager = new UserManager(new UserStore<User>(db));
            return manager;
        }
    }
}