using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session14_Bootstrap_Dropdowns_Controller : Controller
    {
        /// <summary>
        /// ابتدا یک <div> همراه با کلاس .dropdown ایجاد نمایید.
        /// در داخل <div> ایجاد شده یک دکمه اضافه نمایید. به دکمه ایجاد شده کلاس dropdown-toggle و ویژگی
        /// toggle=”dropdown” را اضافه نمایید.
        /// سپس یک فهرست مرتب همراه با کلاس .dropdown-menu و ویژگی role=”menu” ایجاد نمایید.
        /// برای ایجاد یک جداکننده در بین عناصر فهرست تنها کافی است که یک عنصر <li> را همراه با کلاس .divider استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Dropdown()
        {
            return View();
        }

        /// <summary>
        /// می توانید منو را با افزودن کلاس .pull-right از سمت راست تراز نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Alignment()
        {
            return View();
        }

        /// <summary>
        /// با استفاده از کلاس .dropdown-header به قسمت های موجود در منو عنوان اضافه نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Headers()
        {
            return View();
        }
    }
}