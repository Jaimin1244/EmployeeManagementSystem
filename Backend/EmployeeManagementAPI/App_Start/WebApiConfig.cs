using System.Web.Http;
using System.Web.Http.Cors;
using Swashbuckle.Application;

namespace EmployeeManagementAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Enable CORS for all origins, methods, and headers
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Enable attribute routing
            config.MapHttpAttributeRoutes();

            // Define default API route
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Register Swagger (Only once!)
            config
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Employee Management API");
                })
                .EnableSwaggerUi();
        }
    }
}
