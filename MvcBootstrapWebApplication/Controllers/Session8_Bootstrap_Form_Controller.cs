using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session8_Bootstrap_Form_Controller : Controller
    {
        public ActionResult Vertical_Form()
        {
            return View();
        }

        public ActionResult Inline_Form()
        {
            return View();
        }

        public ActionResult Horizontal_Form()
        {
            return View();
        }

        public ActionResult Input()
        {
            return View();
        }

        public ActionResult Textarea()
        {
            return View();
        }

        public ActionResult Checkboxes_and_Radios()
        {
            return View();
        }

        public ActionResult Selects()
        {
            return View();
        }

        public ActionResult Static_Control()
        {
            return View();
        }

        /// <summary>
        /// علاوه بر حالت focus ، Bootstrap برای Inputs که در حالت غیرفعال قرار دارند نیز حالت نمایش خاصی مهیا کرده است.
        /// Input Focus
        /// زمانی که یک input ، focus را دریافت می کند، border آن حذف می گردد و یک سایه ) box-shadow ( نمایش داده می شود.
        /// Disabled Inputs
        /// اگر شما نیاز دارید که یک input را غیر فعال نمایید به سادگی خاصیت disabled را به آن اضافه نمایید. این کار نه تنها input را
        /// غیر فعال می کند بلکه نحوه نمایش آنرا نیز تغییر می دهد.
        /// Disabled Fieldsets
        /// با افزودن خاصیت disabled به یک عنصر <fieldset> همه کنترل های مرتبط به آن نیز غیر فعال می گردند.
        /// Validation States
        /// Bootstrap برای حالت های خطا، اخطار و موفقیت حالت های نمایشی خاصی دارد. جهت استفاده از این حالت های نمایش به سادگی
        /// کلاس مناسب را به عنصر والد اضافه نمایید. این کلاس ها شامل has-success ، has-warning و has-error می گردد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Form_Controls_State()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید عرض و ارتفاع عناصر فرم را با استفاده از کلاس هایی مانند .input-lg و .col-lg-* تنظیم نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Form_Controls_Size()
        {
            return View();
        }

        /// <summary>
        /// کنترل های فرم Bootstrap می توانند متنی را به عنوان راهنما داشته باشند که در ادامه input نمایش داده می شود. برای افزودن
        /// چنین متنی از کلاس .help-block بعد از <input> مورد نظر استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Help_Text()
        {
            return View();
        }

    }
}