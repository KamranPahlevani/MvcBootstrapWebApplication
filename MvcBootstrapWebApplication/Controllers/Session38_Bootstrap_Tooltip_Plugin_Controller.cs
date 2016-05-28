using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session38_Bootstrap_Tooltip_Plugin_Controller : Controller
    {

        /// <summary>
        /// Tooltips برای توصیف لینک ها مناسب هستند.
        /// اگر شما قصد دارید تنها از این پلاگین استفاده نمایید از فایل tooltip.js استفاده نمایید و یا فایل های bootstrap.js و
        /// bootstrap.min.js را به کار گیرید.
        /// نحوه استفاده
        /// پلاگین tooltip توصیف را بعد از عنصر مورد نظر نمایش می دهد. برای استفاده از این پلاگین دو روش وجود دارد:
        /// از طریق Data Attribute : برای افزودن یک tooltip عبارت data-toggle=”tooltip” را به تگ <a> اضافه نمایید. عنوان (title)
        /// تگ <a> به عنوان متن tooltip نمایش داده می شود. به صورت پیش فرض tooltip در قسمت بالای لینک نمایش داده می شود
        /// از طریق JavaScript :
        /// برای استفاده از این پلاگین نیاز است که آنرا توسط jQuery فعال نمایید.
        /// Options
        /// data-animation : برای کنترل حالت نمایش انیمیشن این پلاگین می توانید از این ویژگی استفاده نمایید.
        /// data-html : برای قرار دادن تگ های html از این ویژگی استفاده نمایید.در صورت false بودن این ویژگی باید از jQuery برای قرار دادن محتوا استفاده نمایید.
        /// data-placement : برای تعیین مکان نمایش پلاگین از این ویژگی استفاده نمایید. مقادیر این ویژگی عبارات top ، bottom , right و left هستند.
        /// data-selector : اگر برای پلاگین selector مشخصی تعیین شده است کنترل پلاگین به عنصر مورد نظر واگذار می گردد.
        /// data-title : توسط این ویژگی می توان برای پلاگین عنوان پیش فرض تعریف نمود.
        /// data-trigger : توسط این ویژگی نحوه تحریک و نمایش پلاگین را تعیین نمایید. این ویژگی مقادیر click ، hover ، focus و manual را می پذیرد.
        /// data-content : توسط این ویژگی می توان برای پلاگین محتوای پیش فرض تعیین نمود.
        /// data-delay : توسط این ویژگی می توان زمان تاخیر مورد نیاز برای نمایش و پنهان شدن پلاگین را مشخص نمود.
        /// data-container : توسط این ویژگی می توان این پلاگین را به یک عنصر مشخص الحاق نمود.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Tooltip()
        {
            return View();
        }

        /// <summary>
        /// tooltip (options) : توسط این تابع می توان مقادیر ویژگی های پلاگین را تنظیم نمود.
        /// tooltip (‘toggle’) : توسط این تابع در صورت نمایش tooltip عنصر نمایش داده نمی شود در صورت عدم نمایش، عنصر نمایش داده می شود.
        /// tooltip (‘show’) : استفاده از این تابع باعث نمایش پلاگین می گردد.
        /// tooltip (‘hide’) : استفاده از این تابع باعث عدم نمایش پلاگین می گردد.
        /// tooltip (‘destroy’) : استفاده از این تابع باعث عدم نمایش و از بین رفتن پلاگین می گردد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Tooltip_Methods()
        {
            return View();
        }

        /// <summary>
        /// show.bs.tooltip : این رویداد در زمان فراخوانی تابع show تحریک می گردد
        /// shown.bs.tooltip : این رویداد زمانی که پلاگین به کاربر به صورت کامل نمایش داده شد تحریک می گردد.
        /// hide.bs.tooltip : این رویداد در زمان فراخوانی تابع hide تحریک می گردد.
        /// hidden.bs.tooltip : این رویداد در زمانی که پلاگین به صورت کامل پنهان گردید تحریک می گردد
        /// </summary>
        /// <returns></returns>
        public ActionResult Tooltip_Events()
        {
            return View();
        }
    }
}