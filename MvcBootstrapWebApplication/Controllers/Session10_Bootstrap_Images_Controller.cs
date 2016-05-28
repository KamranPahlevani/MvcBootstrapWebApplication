using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session10_Bootstrap_Images_Controller : Controller
    {
        /// <summary>
        /// img-rounded : به تصویر خصیصه border-radius:6px را به منظور گرد شدن گوشه های تصویر اختصاص می دهد.
        /// img-circle : تصویر را با افزودن border-radius:500px به صورت گرد شده نمایش می دهد.
        /// img-thumbnail : به تصویر مقداری padding و یک border خاکستری رنگ اضافه می کند.
        /// </summary>
        /// <returns></returns>
        public ActionResult Image_Classes()
        {
            return View();
        }
    }
}