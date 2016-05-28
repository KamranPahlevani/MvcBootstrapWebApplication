using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session43_Bootstrap_Carousel_Plugin_Controller : Controller
    {
        /// <summary>
        /// Carousel یک روش انعطاف پذیر و responsive جهت افزودن slider به سایت شماست. علاوه بر responsive بودن این
        /// عنصر به اندازه کافی قابل انعطاف است که امکان افزودن تصویر، فریم، فیلم و هر نوع محتوای دیگر وجود دارد.
        /// اگر شما قصد دارید تنها از این پلاگین استفاده نمایید از فایل carousel.js استفاده نمایید و یا فایل های bootstrap.js و
        /// bootstrap.min.js را به کار گیرید.
        /// برای ایجاد این عنصر طبق مراحل زیر اقدام نمایید:
        /// برای ایجاد ساختار کلی یک عنصر <div> همراه با کلاس .carousel و .slide ایجاد نمایید. برای این عنصر id مشخصی
        /// تنظیم نمایید.
        /// برای افزودن قسمت indicators از یک فهرست مرتب همراه با کلاس .carousel-indicators استفاده نمایید. ویژگی
        /// data-target هر یک از عناصر این فهرست را با id عنصر والد تنظیم نمایید. همچنین از ویژگی data-slide-to برای
        /// اشاره به اسلاید موردنظر استفاده نمایید.
        /// برای افزودن عناصر قابل نمایش ابتدا یک عنصر <div> همراه با کلاس .carousel-inner ایجاد نمایید. در داخل این
        /// عنصر به تعداد مورد نظر <div> همراه با کلاس .item اضافه نمایید، از این عناصر برای قرار دادن تصاویر استفاده نمایید.
        /// برای ایجاد قسمت ناوبری از دو عدد تگ <a> همراه با کلاس .carousel-control استفاده نمایید. ویژگی href این تگ
        /// را با #id عنصر والد تنظیم نمایید. برای تگ <a> که در سمت راست قرار دارد کلاس .right را نیز اضافه نمایید همچنین
        /// ویژگی data-slide این عنصر را با next تنظیم نمایید. برای تگ <a> که در سمت چپ قرار دارد کلاس .left را اضافه
        /// نمایید و ویژگی data-slide را با prev تنظیم نمایید.
        /// در قسمت indicators و محتوا، کلاس .active را به نخستین عنصر اختصاص دهید.
        /// نحوه استفاده
        /// از طریق Data Attribute : از ویژگی های Data Attribute برای کنترل اسلایدها استفاده نمایید.
        /// ویژگی data-slide کلمات prev یا next را می پذیرد که توسط آن می توان بین محتوای اسلایدر حرکت کرد
        /// با استفاده از data-slide-to می توانید carousel را به یک slide مشخص منتقل نمایید. شماره اسلایدها از صفر شروع می گردد
        /// ویژگی data-ride=”carousel” برای تنظیم انیمیشن آغازین به کار می رود.
        /// از طریق JavaScript :
        /// Options
        /// data-interval : زمان تاخیر بین اسلایدها را مشخص می کند. number Default: 5000
        /// data-pause : توسط این ویژگی می توان نحوه توقف اسلایدها را مشخص کرد.
        /// data-wrap : توسط این ویژگی می توان تعیین نمود که بعد از آخرین اسلاید چه عملی صورت گیرد. با قرار دادن مقدار true برای
        /// این ویژگی نمایش ادامه می یابد اما با قرار دادن مقدار false برای این ویژگی با رسیدن به آخرین اسلاید، اسلایدر موقف می گردد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Simple_Slider()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید به هر عنصر و با استفاده از کلاس .carousel-caption یک عنوان اضافه نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Optional_Captions()
        {
            return View();
        }

        /// <summary>
        /// carousel(‘options’) : توسط این تابع می توان ویژگی های این پلاگین را مقداردهی کرد.
        /// carousel(‘cycle’) : این تابع باعث نمایش اسلایدها می گردد.
        /// carousel(‘pause’) : این تابع باعث توقف اسلایدر می گردد.
        /// carousel(number) : این تابع باعث نمایش یک اسلاید مشخص می گردد. شماره اسلایدها از صفر شروع می گردد.
        /// carousel(‘prev’) : اسلاید قبل را نمایش می دهد.
        /// carousel(‘next’) : اسلاید بعد را نمایش می دهد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Carousel_Methods()
        {
            return View();
        }

        /// <summary>
        /// slide.bs.carousel : این رویداد در زمان فراخوانی تابع slide تحریک می گردد.
        /// slid.bs.carousel : این رویداد در زمان پایان حرکت هر اسلاید تحریک می گردد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Carousel_Events()
        {
            return View();
        }


    }
}