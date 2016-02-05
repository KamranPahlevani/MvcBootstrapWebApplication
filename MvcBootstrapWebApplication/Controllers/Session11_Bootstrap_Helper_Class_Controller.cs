using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session11_Bootstrap_Helper_Class_Controller : Controller
    {
        /// <summary>
        /// برای ایجاد آیکون close در پنجره های modal و یا alert از کلاس .close استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Close_Icon()
        {
            return View();
        }

        /// <summary>
        /// با استفاده از caret می توانید برای مواردی که شامل یک منو آبشاری هستند یک آیکون نمایش دهید. برای استفاده از این آیکون از
        /// یک <span> همراه با کلاس .caret استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Carets()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید خاصیت float یک عنصر را با استفاده از کلاس های .pull-left و .pull-right تغییر دهید.
        /// برای تراز کردن عناصر در قسمت ناوبری از کلاس های .navbar-left و .navbar-right استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Quick_floats()
        {
            return View();
        }

        /// <summary>
        /// برای قرار دادن عناصر در مرکز صفحه از کلاس .center-block استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Center_Content_Blocks()
        {
            return View();
        }

        /// <summary>
        /// برای پاکسازی float هر عنصری از کلاس .clearfix استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Clearfix()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید نحوه نمایش و یا عدم نمایش عناصر را با استفاده از کلاس های .show و .hidden کنترل نمایید. استفاده از کلاس
        /// .show باعث نمایش عنصر مورد نظر و استفاده از کلاس .hidden باعث عدم نمایش عنصر مورد نظر می گردد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Showing_and_Hiding_Content()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید یک عنصر را برای تمام ابزارها به جز screen readers با استفاده از کلاس .sr-only پنهان نمایید. screen
        /// readers ابزارهایی هستند که می توانند عناصر موجود در صفحه را بخوانند. این ابزار ها برای افراد نابینا استفاده می گردند. استفاده از
        /// این کلاس باعث عدم نمایش عناصر می گردد اما این عناصر برای این ابزارها قابل تشخیص هستند. تفاوت استفاده از این کلاس و کلاس
        /// .hidden در این موضوع است که با استفاده از کلاس .hidden ابزارهای screen readers نمی توانند عنصر مورد نظر را
        /// تشخیص دهند.
        /// در این تصویر مشاهده می کنید که label مربوط به هر دو input دارای کلاس .sr-only هستند از اینرو این عناصر تنها در ابزارهای
        /// screen readers قابل مشاهده هستند.
        /// </summary>
        /// <returns></returns>
        public ActionResult Screen_reader_content()
        {
            return View();
        }
    }
}