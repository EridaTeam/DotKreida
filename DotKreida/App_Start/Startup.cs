using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;
using DotKreida.Managers;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;
using DotKreida.Repositories;

[assembly: OwinStartup(typeof(DotKreida.App_Start.Startup))]

namespace DotKreida.App_Start {
    public class Startup {
        public void Configuration(IAppBuilder app) {
            app.CreatePerOwinContext(SqlServerContext.Create);
            app.CreatePerOwinContext<UserManager>(UserManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }
    }
}