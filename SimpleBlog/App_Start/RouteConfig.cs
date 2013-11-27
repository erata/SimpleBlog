using SimpleBlog.Controllers;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] {typeof(PostsController).Namespace};

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
           
            //Login Page Route 
            routes.MapRoute("Login", "login", new { controller = "Auth", action = "login"}, namespaces);

            //Logout Page Route
            routes.MapRoute("Logout", "logout", new { controller = "Auth", action = "logout" }, namespaces);
            
            //Home Page Route
            routes.MapRoute("Home", "", new { Controller = "Posts", action = "Index" }, namespaces);


        }
    }
}