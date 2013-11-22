using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    // Lock controller from users who are not Logged in as "admin"
    [Authorize(Roles = "admin")]
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            return Content("ADMIN POSTS");
        }

    }
}
