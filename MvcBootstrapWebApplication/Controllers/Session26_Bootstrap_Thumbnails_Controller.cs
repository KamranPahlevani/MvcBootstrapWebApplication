using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session26_Bootstrap_Thumbnails_Controller : Controller
    {
        
        /// <summary>
        /// خیلی از سایت ها نیاز دارندکه تصاویر، فیلم ها و
        /// متن ها در یک grid به صورت مرتب قرار گیرند. Bootstrap برای این منظور یک راهکار ساده توسط thumbnail ایجاد کرده است.
        /// برای استفاده از thumbnail عکس مورد نظر را در داخل یک تگ <a> همراه با کلاس .thumbnail قرار دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Thumbnail()
        {
            return View();
        }

        /// <summary>
        /// با ایجاد thumbnail پایه، این امکان وجود دارد که هر نوع محتوای HTML از قبیل عناوین، پاراگراف و یا دکمه ها را در داخل آن
        /// قرار دهیم. برای افزودن محتوا به thumbnail :
        /// تگ <a> را با یک <div> همراه با کلاس .thumbnail جایگزین نمایید.
        /// در داخل <div> ایجاد شده می توانید هر نوع محتوایی قرار دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Thumbnail_With_Content()
        {
            return View();
        }
    }
}