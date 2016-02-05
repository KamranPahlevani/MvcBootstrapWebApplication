using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session12_Bootstrap_Responsive_Utilities_Controller : Controller
    {
        /// <summary>
        /// Bootstrap کلاس های کمکی مفیدی جهت توسعه سایت های مناسب برای گوشی های همراه ارائه می دهد. این کلاس ها می توانند
        /// نمایش یا عدم نمایش عناصر در صفحه را با توجه به اندازه صفحه کنترل نمایند. استفاده از این کلاس ها نیاز به طراحی سایت های
        /// گوناگون برای ابزارهای مختلف را برطرف می کند.
        /// این کلاس ها تنها برای block و table در دسترس هستند.
        /// استفاده از کلاس های .visible-* باعث نمایش عناصر در اندازه های مشخص شده و استفاده از کلاس .hidden-* باعث عدم نمایش
        /// این عناصر در اندازه های مشخص می گردد.
        /// استفاده از کلاس .visible-print باعث می گردد عنصر موردنظر در هنگام پرینت نمایش داده شود و استفاده از کلاس .hidden-
        /// print عکس این عمل را موجب می گردد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Responsive_Utilities_Classes()
        {
            return View();
        }
    }
}