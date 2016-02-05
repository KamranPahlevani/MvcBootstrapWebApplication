using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session35_Bootstrap_Dropdown_Plugin_Controller : Controller
    {
        /// <summary>
        /// اگر شما قصد دارید تنها از این پلاگین استفاده نمایید از فایل dropdown.js استفاده نمایید و یا فایل های bootstrap.js و
        /// bootstrap.min.js را به کار گیرید.
        /// نحوه استفاده
        /// شما می توانید به دو روش منوها را کنترل نمایید:
        /// از طریق Data Attributes : در عنصر کنترل کننده منو ) به عنوان مثال یک دکمه یا لینک( ویژگی data-toggle=”dropdown” را اضافه نمایید.
        /// برای لینک ها از عبارت data-target نیز استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_DropDown()
        {
            return View();
        }

        public ActionResult DropDown_In_Navbar()
        {
            return View();
        }

        public ActionResult DropDown_In_Tab()
        {
            return View();
        }

        public ActionResult DropDown_Methods()
        {
            return View();
        }


    }
}