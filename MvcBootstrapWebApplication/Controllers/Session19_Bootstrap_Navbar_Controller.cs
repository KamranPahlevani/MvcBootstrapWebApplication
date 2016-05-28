using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session19_Bootstrap_Navbar_Controller : Controller
    {

        /// <summary>
        /// به منظور ایجاد navbar پیش فرض:
        /// به تگ <nav> کلاس های .navbar و .navbar-default را اضافه نمایید.
        /// عبارت role=”navigation” را به تگ <nav> اضافه نمایید.
        /// برای ایجاد قسمت نمایش عنوان سایت یک <div> همراه با کلاس .navbar-header ایجاد نمایید. در داخل این عنصر
        /// یک تگ <a> همراه با کلاس .navbar-brand اضافه نمایید. برای نمایش نام سایت می توانید از این تگ استفاده نمایید.
        /// به منظور افزودن لینک های ناوبری کافی است یک فهرست نامرتب <ul> همراه با کلاس .nav و .navbar-nav اضافه نمایید
        /// </summary>
        /// <returns></returns>
        public ActionResult Default_Navbar()
        {
            return View();
        }

        /// <summary>
        /// به منظور افزودن ویژگی responsive به navbar مراحل زیر را دنبال نمایید:
        /// قسمتی را که تمایل دارید در صفحات با اندازه کوچک پنهان گردد در داخل یک <div> همراه با کلاس .collapse و
        /// .navbar-collapse قرار دهید. قسمت id این عنصر را با یک نام منحصر به فرد تنظیم نمایید.
        /// قسمتی که در صفحات کوچک پنهان می گردد به صورت یک دکمه نمایش داده می شود. برای ایجاد این دکمه در داخل
        /// <div> با کلاس navbar-header یک button با کلاس navbar-toggle و ویژگی data-toggle=”collapse”
        /// اضافه نمایید. ویژگی data-target این دکمه را با #id منو مرحله قبل تنظیم نمایید. قبل از
        /// علامت # را اضافه نمایید.
        /// سه عدد <span> با کلاس .icon-bar بین تگ های <button>…</button> قرار دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Responsive_Navbar()
        {
            return View();
        }

        /// <summary>
        /// برای قرار دادن فرم ها در navbar از کلاس .navbar-form در تگ <form> استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Forms_in_navbar()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید دکمه ها را با افزودن کلاس .navbar-btn به عناصر <button> در قسمت navbar قرار دهید. کلاس .navbar-btn
        /// می تواند در تگ های <a> و <input> نیز استفاده گردد. این دکمه ها به صورت مستقل هستند.
        /// </summary>
        /// <returns></returns>
        public ActionResult Buttons_in_navbar()
        {
            return View();
        }

        /// <summary>
        /// برای افزودن متون در navbar متن مورد نظر را در داخل یک عنصر با کلاس .navbar-text قرار دهید. عنصر رایج برای این عمل
        /// معمولا تگ <p> است.
        /// </summary>
        /// <returns></returns>
        public ActionResult Text_in_navbar()
        {
            return View();
        }

        /// <summary>
        /// اگر شما قصد دارید تا از لینک در قسمت navbar استفاده نمایید از کلاس .navbar-link استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Non_nav_Links()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید تمام مولفه ها مانند links ، forms ، buttons یا text را از سمت چپ یا راست و با استفاده از کلاس های
        /// .navbar-left و .navbar-right تراز نمایید. هر دو کلاس یک float در جهت مشخص شده به عنصر مورد نظر اضافه می کند.
        /// </summary>
        /// <returns></returns>
        public ActionResult Component_Alignment()
        {
            return View();
        }

        /// <summary>
        /// می تواند پویا باشد. شما می توانید Navbar navbar را در بالا یا پایین صفحه قرار دهید و یا آنرا به گونه ایی تنظیم نمایید تا در تمام
        /// حالات قابل دسترس باشد.
        /// اگر شما تمایل دارید که navbar در صورت اسکرول در بالای صفحه به صورت ثابت قرار گیرد کلاس .navbar-fixed-top را به
        /// کلاس .navbar اضافه نمایید. مثال زیر استفاده از این کلاس را نمایش می دهد. برای محافظت در برابر حالتی که navabar بر روی
        /// متن قرار میگیرد حداقل 50 پیکسل برای تگ <body> ، padding در نظر بگیرید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Fixed_to_top()
        {
            return View();
        }

        /// <summary>
        /// برای قرار گرفتن navbar در هنگام اسکرول در پایین صفحه از کلاس .navbar-fixed-bottom همراه با کلاس .navbar
        /// استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Fixed_to_bottom()
        {
            return View();
        }

        /// <summary>
        /// برای ایجاد یک navbar که همراه صفحه scroll می گردد، کلاس .navbar-static-top را به کلاس .navbar اضافه نمایید. با
        /// استفاده از این کلاس نیازی به افزودن padding به عنصر <body> وجود ندارد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Static_top()
        {
            return View();
        }

        /// <summary>
        /// برای ایجاد یک navbar با پس زمینه مشکی و متن سفید کلاس .navbar-inverse را به کلاس .navbar اضافه نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Inverted_navbar()
        {
            return View();
        }

    }
}