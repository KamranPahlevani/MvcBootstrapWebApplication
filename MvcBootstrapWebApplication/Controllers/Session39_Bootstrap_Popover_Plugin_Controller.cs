using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session39_Bootstrap_Popover_Plugin_Controller : Controller
    {

        /// <summary>
        /// ظاهری مانند tooltip دارد. برای نمایش popover کاربر باید ماوس را بر روی عنصر مورد نظر قرار دهد. محتوای
        /// می تواند با استفاده از Data API در درون آن قرار گیرد. استفاده از این پلاگین نیاز به استفاده از tooltip دارد
        /// اگر شما قصد دارید تنها از این پلاگین استفاده نمایید از فایل popover.js استفاده نمایید و یا فایل های bootstrap.js و
        /// bootstrap.min.js را به کار گیرید.
        /// نحوه استفاده
        /// شما به دو روش می توانید از این پلاگین استفاده نمایید:
        /// از طریق Data Attributes : برای افزودن popover به تگ <a> یا <button> عبارت data-toggle=”popover” را به
        /// آن اضافه نمایید. عنوان ) title ( در این عناصر متن popover را شکل می دهند. popover به صورت پیش فرض در قسمت بالای
        /// عنصر مورد نظر نمایش داده می شود.
        /// از طریق JavaScript
        /// برای استفاده از این پلاگین شما باید با استفاده از jQuery آنرا فعال نمایید.
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
        public ActionResult Create_Popover()
        {
            return View();
        }

        /// <summary>
        /// popover (options) : توسط این تابع می توان مقادیر ویژگی های پلاگین را تنظیم نمود.
        /// popover (‘toggle’) : توسط این تابع در صورت نمایش popover عنصر نمایش داده نمی شود در صورت عدم نمایش، عنصر نمایش داده می شود.
        /// popover (‘show’) : استفاده از این تابع باعث نمایش پلاگین می گردد.
        /// popover (‘hide’) : استفاده از این تابع باعث عدم نمایش پلاگین می گردد.
        /// popover (‘destroy’) : استفاده از این تابع باعث عدم نمایش و از بین رفتن پلاگین می گردد.        
        /// </summary>
        /// <returns></returns>
        public ActionResult Popover_Methods()
        {
            return View();
        }

        /// <summary>
        /// show.bs.popover : این رویداد در زمان فراخوانی تابع show تحریک می گردد
        /// shown.bs.popover : این رویداد زمانی که پلاگین به کاربر به صورت کامل نمایش داده شد تحریک می گردد.
        /// hide.bs.popover : این رویداد در زمان فراخوانی تابع hide تحریک می گردد.
        /// hidden.bs.popover : این رویداد در زمانی که پلاگین به صورت کامل پنهان گردید تحریک می گردد
        /// </summary>
        /// <returns></returns>
        public ActionResult Popover_Events()
        {
            return View();
        }
    }
}