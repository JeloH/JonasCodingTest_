using System;
using System.Linq;
using System.Web.Http;


namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            try
            {

                    config.MapHttpAttributeRoutes();

                    config.Routes.MapHttpRoute(
                        name: "DefaultApi",
                        routeTemplate: "api/{controller}/{id}",
                        defaults: new { id = RouteParameter.Optional }
                    );


            }
            catch (Exception ex)
            {

                WebApi.App_Start.LoggerTools.LogException(ex, "Error : " + ex);
            }


        }
    }
}
