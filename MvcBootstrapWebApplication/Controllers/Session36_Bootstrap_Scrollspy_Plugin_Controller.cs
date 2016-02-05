using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session36_Bootstrap_Scrollspy_Plugin_Controller : Controller
    {
        /// <summary>
        /// پلاگین Scrollspy به شما اجازه می دهد که از طریق بخش های ناوبری به قسمت مشخصی از صفحه منتقل گردید.
        /// اگر شما قصد دارید تنها از این پلاگین استفاده نمایید از فایل scrollspy.js استفاده نمایید و یا فایل های bootstrap.js و
        /// bootstrap.min.js را به کار گیرید.
        /// نحوه استفاده
        /// شما می توانید با استفاده از روش های زیر از این پلاگین استفاده نمایید:
        /// از طریق Data Attribute : ویژگی data-spy=”scroll” را به عنصر مورد نظر خود مثلا تگ <body> اضافه نمایید.
        /// سپس ویژگی data-target را با ID فهرست حاوی لینک ها تنظیم نمایید.
        /// از طریق JavaScript : شما می توانید این پلاگین را با استفاده از JavaScript فراخوانی نمایید، عنصر مورد نظر خود را
        /// برای منتقل شدن به آن انتخاب نمایید و تابع scrollspy() را فراخوانی نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Scrollspy()
        {
            return View();
        }

        /// <summary>
        /// scrollspy (‘refresh’) : زمانی که scrollspy را از طریق JavaScript فراخوانی می کنید نیاز است تابع .refresh را
        /// فراخوانی نمایید تا عناصر صفحه بروزرسانی شوند.
        /// </summary>
        /// <returns></returns>
        public ActionResult Scrollspy_Methods()
        {
            return View();
        }

        /// <summary>
        /// activate.bs.scrollspy : این رویداد زمانی تحریک می گردد که آیتم جدیدی توسط scrollspy فعال می گردد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Scrollspy_Events()
        {
            return View();
        }
    }
}