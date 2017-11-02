using System.Web.Http;
using WebActivatorEx;
using Aula02;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Aula02
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "Aula02");
                        c.IncludeXmlComments($"{System.AppDomain.CurrentDomain.BaseDirectory}\\bin\\Aula02.xml");
                    })
                .EnableSwaggerUi(c =>
                    {
                    });
        }
    }
}
