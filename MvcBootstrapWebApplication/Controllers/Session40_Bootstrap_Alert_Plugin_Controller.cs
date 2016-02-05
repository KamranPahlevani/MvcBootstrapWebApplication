using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session40_Bootstrap_Alert_Plugin_Controller : Controller
    {

        /// <summary>
        /// برای نمایش پیام ها به کاربر می توانید از این پلاگین استفاده نمایید.
        /// اگر شما قصد دارید تنها از این پلاگین استفاده نمایید از فایل alert.js استفاده نمایید و یا فایل های bootstrap.js و
        /// bootstrap.min.js را به کار گیرید.
        /// نحوه استفاده
        /// شما می توانید از این پلاگین به دو روش استفاده نمایید:
        /// از طریق Data Attribute : تنها کافی است به دکمه مربوط به بستن پنجره هشدار عبارت data-dismiss=”alert” را اضافه نمایید
        /// از طریق JavaScript
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Alert()
        {
            return View();
        }

        /// <summary>
        /// برای فعال کردن انیمیشن در زمان بسته شدن هشدار از وجود کلاس های .fade و .in اطمینان حاصل کنید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Alert_Methods()
        {
            return View();
        }

        /// <summary>
        /// close.bs.alert : این رویداد در زمانی فراخوانی تابع close تحریک می گردد.
        /// closed.bs.alert : این رویداد بعد از بسته شدن هشدار تحریک می گردد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Alert_Events()
        {
            return View();
        }
    }
}