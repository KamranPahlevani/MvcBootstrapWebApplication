using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session16_Bootstrap_Button_dropdowns_Controller : Controller
    {
        /// <summary>
        /// به منظور ایجاد چنین ساختاری ابتدا یک <div> همراه با کلاس .btn-group ایجاد نمایید. در داخل <div> ایجاد شده یک دکمه و یک
        /// فهرست نامرتب اضافه نمایید. به دکمه کلاس .dropdown-toggle و ویژگی data-toggle=”dropdwon” را ضافه نمایید.
        /// کلاس فهرست نامرتب را نیز با .dropdown-menu تنظیم نمایید و عبارت role=”menu” را به آن اضافه نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Button_dropdowns()
        {
            return View();
        }

        /// <summary>
        /// این عناصر به دو قسمت تقسیم می شوند که قسمت سمت راست یک دکمه با عملکرد جداگانه است و قسمت سمت چپ نیز برای کنترل
        /// نمایش منو آبشاری به کار می رود. برای ایجاد چنین مولفه ایی تنها کافی است همانند مثال قبل عمل نمایید و علاوه بر دکمه موجود
        /// یک دکمه دیگر که فاقد کلاس .dropdown-toggle می باشد، اضافه نمایید
        /// </summary>
        /// <returns></returns>
        public ActionResult Split_Button_Dropdowns()
        {
            return View();
        }

        public ActionResult Button_Dropdown_Size()
        {
            return View();
        }

        /// <summary>
        /// منوها می توانند به سمت بالا نیز باز شوند. برای این منظور کلاس .dropup را به کلاس .btn-group اضافه نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Dropup_Variation()
        {
            return View();
        }
    }
}