using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session42_Bootstrap_Collapse_Plugin_Controller : Controller
    {
        /// <summary>
        /// اگر شما قصد دارید تنها از این پلاگین
        /// استفاده نمایید از فایل collapse.js استفاده نمایید و یا فایل های bootstrap.js و bootstrap.min.js را به کار گیرید. برای
        /// استفاده از این پلاگین نیاز است تا پلاگین transition نیز در نسخه Bootstrap شما وجود داشته باشد.
        /// شما می توانید از این پلاگین برای موارد زیر استفاده نمایید:
        /// برای ایجاد گروه ها با ویژگی collapse و با جلوه accordion :
        /// ابتدا یک <div> همراه با کلاس .panel-group ایجاد نمایید. به این عنصر یک id منحصر به فرد اختصاص دهید.
        /// در داخل عنصر <div> ایجاد شده به تعداد محتوای مورد نظر panel همراه با قسمت heading و body ایجاد نمایید.
        /// در داخل قسمت panel-heading و در داخل قسمت panel-title عنصر کنترل کننده را ایجاد نمایید و به عنصر کنترل
        /// کننده ویژگی data-toggle=”collapse” را اضافه نمایید. برای اضافه شدن حالت نمایش accordion نیز ویژگی
        /// data-parent را با id عنصر <div> همراه با کلاس panel-group تنظیم نمایید.
        /// یک <div> همراه با کلاس .panel-collapse و .collapse ایجاد نمایید. یک id منحصر به فرد برای این عنصر ایجاد
        /// نمایید و مقدار href عنصر کنترل کننده را با آن تنظیم نمایید. panel-body را در داخل این عنصر قرار دهید.
        /// شما می توایند از این پلاگین به دو روش استفاده نمایید:
        /// از طریق Data Attribute : ویژگی های data-toggle=”collapse” و data-target را به عنصر اضافه نمایید تا به
        /// طور خودکار کنترل عناصر به عنصر جاری تعلق گیرد. ویژگی data-target یک CSS Selector را برای تخصیص
        /// collapse می پذیرد. از افزودن کلاس .collapse به عناصر تحت collapse اطمینان حاصل نمایید. اگر شما قصد
        /// دارید که یک عنصر به صورت پیش فرض باز نمایش داده شود کلاس .in را به آن اضافه نمایید.
        /// از طریق JavaScript
        /// Options :
        /// data-parent : توسط این ویژگی می توان عنصر والد برای چندین عنصر را تنظیم نمود تا در صورت نمایش یک عنصر دیگر عناصر پنهان گردند.
        /// data-toggle : وضعیت عناصر را تغییر می دهد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Collapse_With_accordion()
        {
            return View();
        }

        /// <summary>
        /// برای ایجاد گروه ها با ویژگی collapse و فاقد جلوه accordion :
        /// برای ایجاد چنین عناصری
        /// ویژگی data-parent را حذف نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Collapse_Without_accordion()
        {
            return View();
        }

        /// <summary>
        /// collapse(options) : توسط این تابع می توان ویژگی های این پلاگین را تنظیم نمود.
        /// collapse(‘toggle’) : توسط این تابع می توان وضعیت نمایش پلاگین را تغییر داد.
        /// collapse(‘show’) : این تابع پلاگین را نمایش می دهد.
        /// collapse(‘hide’) : این تابع پلاگین را پنهان می کند.
        /// </summary>
        /// <returns></returns>
        public ActionResult Collapse_Methods()
        {
            return View();
        }

        /// <summary>
        /// show.bs.collapse : رویداد در زمان فراخوانی تابع show تحریک می گردد
        /// shown.bs.collapse : این رویداد در زمانی که پلاگین به کاربر نمایش داده می شود تحریک می گردد
        /// hide.bs.collapse : این رویداد در زمان فراخوانی تابع hide تحریک می گردد
        /// hidden.bs.collapse : این رویداد در زمانی که پلاگین به صورت کامل نمایش داده نمی شود تحریک می گردد
        /// </summary>
        /// <returns></returns>
        public ActionResult Collapse_Events()
        {
            return View();
        }

    }
}