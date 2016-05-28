using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session37_Bootstrap_Tab_Plugin_Controller : Controller
    {

        /// <summary>
        /// اگر شما قصد دارید تنها از این پلاگین استفاده نمایید از فایل tab.js استفاده نمایید و یا فایل های bootstrap.js و
        /// bootstrap.min.js را به کار گیرید.
        /// نحوه استفاده
        /// شما می توانید از این پلاگین به دو روش استفاده نمایید:
        /// از طریق Data Attribute : به تگ <a> عبارت data-toggle=”tab” و یا data-toggle=”pill” را اضافه نمایید.
        /// از طریق JavaScript : شما می توانید tabs را با استفاده از روش زیر و با کمک JavaScript فعال نمایید.
        /// Fade Effect
        /// برای افزودن جلوه fade به tabs ، شما باید کلاس .fade را به هر یک از .tab-pane اضافه نمایید. همچنین اولین tab-pane
        /// باید حاوی کلاس .in باشد:
        /// برای ایجاد یک صفحه همراه با tab مراحل زیر را دنبال نمایید:
        /// ابتدا یک منو همراه با کلاس .nav و .nav-tabs ایجاد نمایید. به هر یک از عناصر <a> در این فهرست ویژگی
        /// data-toggle=”tab” را اضافه نمایید.
        /// برای ایجاد محتوا برای tabs یک عنصر <div> همراه با کلاس .tab-content ایجاد نمایید. در داخل این عنصر به تعداد
        /// عناصر <a> در فهرست ایجاد شده <div> همراه با کلاس .tab-pane اضافه نمایید. مقدار id هر یک از این عناصر را با
        /// نام منحصر به فرد مقداردهی نمایید. برای نخستین tab-pane کلاس .in را نیز اضافه نمایید
        /// در داخل فهرست برای هر یک از عناصر <a> ، مقدار ویژگی href این عناصر را با #id عناصر tab-pane تنظیم نمایید
        /// می توایند به کلاس .tab-pane کلاس .fade را نیز اضافه نمایید.
        /// برای نمایش یک عنصر به صورت فعال می توانید کلاس .active را به tab-pane و عنصر li متناظر آن در فهرست اضافه نمایید
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Tab()
        {
            return View();
        }

        /// <summary>
        /// $().tab : این تابع یک tab و محتوای مربوط به آن را فعال میکند. tab باید حاوی یکی از دو ویژگی data-target و یا href باشد
        /// </summary>
        /// <returns></returns>
        public ActionResult Tab_Methods()
        {
            return View();
        }

        /// <summary>
        /// show.bs.tab : این رویداد قبل از نمایش tab جدید تحریک می گردد.
        /// shown.bs.tab : این رویداد در زمانی که tab به صورت کامل نمایش داده شد تحریک می گردد. 
        /// </summary>
        /// <returns></returns>
        public ActionResult Tab_Events()
        {
            return View();
        }
    }
}