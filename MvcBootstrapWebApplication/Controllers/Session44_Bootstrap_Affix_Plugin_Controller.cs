using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session44_Bootstrap_Affix_Plugin_Controller : Controller
    {

        /// <summary>
        /// این پلاگین به شما اجازه می دهد که یک عنصر <div> را در هنگام scroll صفحه در یک مکان مشخص نمایش دهید.
        /// اگر شما قصد دارید تنها از این پلاگین استفاده نمایید از فایل affix.js استفاده نمایید و یا فایل های bootstrap.js و
        /// bootstrap.min.js را به کار گیرید.
        /// نحوه استفاده
        /// شما می توانید از این پلاگین به دو روش استفاده نمایید:
        /// از طریق Data Attribute : تنها کافی است ویژگی data-spy=”affix” را به عنصر مورد نظر اضافه نمایید.
        /// از طریق JavaScript : شما می توانید از JavaScript برای کار با این پلاگین استفاده نمایید.
        /// Positioning via CSS
        /// در هر دو موقعیت بالا شما باید مکان قرار گیری محتوا را مشخص نمایید. پلاگین affix بین سه کلاس که هر یک وضعیت خاصی را
        /// نمایش می دهند تغییر حالت می دهد: affix ، affix-top ، affix-bottom . شما می توانید از این کلاس ها برای تعیین موقعیت
        /// پلاگین و افزودن تگ های CSS استفاده نمایید:
        /// برای شروع، پلاگین با افزودن کلاس .affix-top مشخص می نماید که عنصر در بالاترین مکان قرار دارد. در این نقطه نیازی
        /// به استفاده از CSS وجود ندارد.
        /// با scroll صفحه کلاس .affix-top با .affix جایگزین می گردد و خاصیت position پلاگین با مقدار fixed تنظیم می
        /// با رسیدن به انتهای صفحه کلاس .affix با کلاس .affix-bottom جایگزین گردد.
        /// شما می توانید با استفاده از این کلاس ها نحوه نمایش پلاگین را کنترل نمایید.
        /// Options
        /// data-offset : توسط این ویژگی می توان مقدار offset از پایین و بالا را تعیین نمود. اگر برای این ویژگی یک عدد تنظیم گردد هر
        /// دومقدار offset پایین و بالا با این عدد تنظیم می گردند. البته می توان هر یک از این موارد را به صورت جداگانه نیز تنظیم نمود.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Affix_Via_Data_Attribute()
        {
            return View();
        }

        public ActionResult Create_Affix_Via_Data_JavaScript()
        {
            return View();
        }
    }
}