using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session32_Bootstrap_Wells_Controller : Controller
    {
        /// <summary>
        /// یک <div> است که باعث می گردد محتوای داخل آن به صورت فرورفته در صفحه نمایش داده شود. برای ایجاد well کافی
        /// است محتوای مورد نظر خود را در داخل یک <div> همراه با کلاس .well قرار دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Well()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید اندازه عنصر well را با استفاده از کلاس های .well-lg و .wel-sm تغییر دهید. این کلاس ها همراه با کلاس .well به کار می روند.
        /// </summary>
        /// <returns></returns>
        public ActionResult Well_Sizing()
        {
            return View();
        }
    }
}