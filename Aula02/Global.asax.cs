using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Globalization;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;

namespace Aula02
{
    public class Global : System.Web.HttpApplication
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Start(object sender, EventArgs e)
        {
            //GlobalConfiguration.DefaultServer.Dispose();
            GlobalConfiguration.Configure(
                config =>
                {
                    //config.Routes.MapHttpRoute(
                    //name: "DefaultApi",
                    //routeTemplate: "api/{controller}/{id}",
                    //defaults: new { id = RouteParameter.Optional }
                    //);

                    config.Routes.MapHttpRoute(
                    name: "ActionApi",
                    routeTemplate: "api/{controller}/{action}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                    );

                    //config.Routes.MapHttpRoute("DefaultApiWithId", "Api/{controller}/{id}", new { id = RouteParameter.Optional }, new { id = @"\d+" });
                    //config.Routes.MapHttpRoute("DefaultApiWithAction", "Api/{controller}/{action}/{id}", new { id = RouteParameter.Optional }, new { id = @"\d+" });
                    // config.Routes.MapHttpRoute("DefaultApiGet", "Api/{controller}", new { action = "Get" }, new { httpMethod = new HttpMethodConstraint(HttpMethod.Get) });
                    //config.Routes.MapHttpRoute("DefaultApiPost", "Api/{controller}", new { action = "Post" }, new { httpMethod = new HttpMethodConstraint(HttpMethod.Post) });

                    // - Configura Rotas
                    config.MapHttpAttributeRoutes();

                    // - Remove XML
                    config.Formatters.Remove(config.Formatters.XmlFormatter);

                    // - Configure Json
                    config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                    config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    config.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;
                    config.Formatters.JsonFormatter.SerializerSettings.DateFormatString = "dd/MM/yyyy";
                    config.Formatters.JsonFormatter.SerializerSettings.Culture = CultureInfo.CurrentCulture;
                }
                );
            //.UseWebApi(config);
        }
    }
}