using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session13_Bootstrap_Glyphicon_Controller : Controller
    {
        /// <summary>
        /// Bootstrap در حدود 300 عدد glyph را گردآوری کرده
        /// Glyphicons آیکون هایی هستند که ویژگی های فونت را دارا می باشند. این آیکون ها رایگان نیستند اما سازنده آنها این آیکون ها را
        /// برای Bootstrap به صورت رایگان در دسترس قرار داده است.
        /// </summary>
        /// <returns></returns>
        public ActionResult Bootstrap_Glyphicon()
        {
            return View();
        }
    }
}