using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session41_Bootstrap_Button_Plugin_Controller : Controller
    {
        /// <summary>
        /// اگر شما قصد دارید تنها از این پلاگین استفاده نمایید از فایل button.js استفاده نمایید و یا فایل های bootstrap.js و
        /// bootstrap.min.js را به کار گیرید.
        /// برای افزودن وضعیت بارگذاری به یک دکمه تنها کافی است عبارت data-loading-text=”loading” را به دکمه مورد نظر اضافه نمایید
        /// </summary>
        /// <returns></returns>
        public ActionResult Loading_State()
        {
            return View();
        }

        /// <summary>
        /// برای استفاده از این ویژگی عبارت data-toggle=”button” را به دکمه مور نظر اضافه نمایید
        /// </summary>
        /// <returns></returns>
        public ActionResult Single_Toggle()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید با افزودن عبارت data-toggle=”buttons” به کلاس btn-group یک گروه دکمه ایجاد نمایید که هر یک از
        /// دکمه ها ویژگی های checkbox را دارند و تنها ظاهر آنها مانند button است.
        /// </summary>
        /// <returns></returns>
        public ActionResult Checkbox()
        {
            return View();
        }

        /// <summary>
        /// به طور مشابه شما می توانید به راحتی با افزودن عبارت data-toggle=”buttons” به کلاس btn-group یک گروه دکمه ایجاد
        /// نمایید که هر یک از دکمه ها ویژگی های یک radio را دارند اما تنها ظاهر آنها شبیه button است
        /// </summary>
        /// <returns></returns>
        public ActionResult Radio()
        {
            return View();
        }

        /// <summary>
        /// button (‘toggle’) : باعث تغییر وضعیت دکمه می گردد.
        /// button (‘loading’) : دکمه را در حالت بارگذاری قرار می دهد. در این حالت متن دکمه با عبارت موجود در data-loading-text جایگزین می گردد.
        /// button (‘reset’) : وضعیت دکمه را به حالت اول باز می گرداند
        /// button (string) : توسط این تابع یک متن را در داخل دکمه نمایش دهید
        /// </summary>
        /// <returns></returns>
        public ActionResult Button_Methods()
        {
            return View();
        }
    }
}