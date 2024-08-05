using DemoApiNegocio;
using Newtonsoft.Json.Serialization;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace DemoApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services


            // Web API configuration and services
            var container = new Container();

            Resolvers.RegisterServices(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            var apiControllerResolver = new SimpleInjectorWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = apiControllerResolver;

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            

            // config.MessageHandlers.Add(new TokenValidationHandler());

            config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
