using Autofac;
using KisManager;
using KisManager.Config;
using KisManager.Dal.Kis;
using Microsoft.Owin.Cors;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Autofac.Integration.WebApi;
using System.Web.Http.Dependencies;
using System.Reflection;
using KisManager.Sql;
using KisService.Core;

namespace KisService
{
    class Startup
    {


        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional, action = "get" }
            );
            appBuilder.UseCors(CorsOptions.AllowAll);
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            // Register dependencies, then...
            OnRegisterObjects(builder);
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            appBuilder.UseAutofacMiddleware(container);
            appBuilder.UseWebApi(config);
            container.Resolve<DbConfig>().Init();

        }

        private void OnRegisterObjects(ContainerBuilder builder)
        {
            builder.Register(o => new KisContext(Program.Kis.GetConnectionString())).SingleInstance();
            builder.RegisterType<SqlProvider>().As<ISqlProvider>();
            builder.RegisterType<DbConfig>().SingleInstance();
        }
    }


}
