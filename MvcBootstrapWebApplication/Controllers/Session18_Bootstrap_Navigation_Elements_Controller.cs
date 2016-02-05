using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session18_Bootstrap_Navigation_Elements_Controller : Controller
    {

        /// <summary>
        /// برای ایجاد یک قسمت ناوبری که مبنای آنرا Tab تشکیل می دهد به این روش عمل نمایید:
        /// یک لیست نامرتب <ul> همراه با کلاس .nav ایجاد نمایید.
        /// کلاس .nav-tabs را نیز اضافه نمایید.
        /// البته برای تکمیل این مولفه نیاز به استفاده از ماژول tab وجود دارد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Tabular_Navigation_and_Tabs()
        {
            return View();
        }

        /// <summary>
        /// برای تغییر حالت نمایش tabs به صورت pills ، طبق مثال قبل عمل نمایید اما در مرحله آخر از کلاس .nav-pills استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Basic_Pills()
        {
            return View();
        }

        /// <summary>
        /// برای نمایش pills به صورت عمودی از کلاس .nav-stacked در کنار کلاس های .nav و .nav-pills استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Verticle_Pills()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید قسمت ناوبری را به گونه ایی تنظیم نمایید که در صفحات با اندازه بزرگتر از 768 پیکسل تمام عرض صفحه را اشغال
        /// نماید. برای این کار باید از کلاس .nav-justified همراه با کلاس های .nav ، .nav-tabs یا .nav ، .nav-pills استفاده نمایید.
        /// در صفحات با اندازه کوچک تر tabs به صور پشته نمایش داده می شوند.
        /// </summary>
        /// <returns></returns>
        public ActionResult Justifide_Nav()
        {
            return View();
        }

        /// <summary>
        /// اگر به هر یک از کلاس های .nav ،کلاس .disable را اضافه نمایید tab مورد نظر به رنگ خاکستری تغییر رنگ می دهد و حالت
        /// :hover نیز برای آن غیر فعال خواهد گردید.
        /// استفاده از این کلاس تنها ظاهر تگ <a> را تغییر می دهد برای غیر فعال کردن لینک بطور کامل از JavaScript استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Disabled_Links()
        {
            return View();
        }

        /// <summary>
        /// به منظور افزودن منوهای آبشاری به صورت زیر عمل نمایید:
        /// یک فهرست نامرتب <ul> همراه با کلاس .nav ایجاد نمایید.
        /// کلاس .nav-tabs را اضافه نمایید.
        /// به <li> مورد نظر که حاوی فهرست است کلاس .dropdown و به تگ <a> داخل آن کلاس .dropdown-toggle و
        /// ویژگی data-toggle=”dropdown” را ضافه نمایید.
        /// در داخل عنصر فعلی یک فهرست نامرتب <ul> همراه با کلاس .dropdown-menu اضافه نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Tabs_with_Dropdowns()
        {
            return View();
        }

        public ActionResult Pills_with_Dropdowns()
        {
            return View();
        }
    }
}