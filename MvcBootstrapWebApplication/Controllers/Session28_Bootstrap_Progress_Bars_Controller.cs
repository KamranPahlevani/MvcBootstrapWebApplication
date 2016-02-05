using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session28_Bootstrap_Progress_Bars_Controller : Controller
    {

        /// <summary>
        /// این نوارها از قابلیت های نمایشی CSS3 برای جلوه های تصویری خود استفاده می کنند. این خصوصیات در IE9 و نسخه های قدیمی
        /// Firefox پشتیبانی نمی گردند. Opera12 از قابلیت انیمیشن پشتیبانی نمی کند.
        /// برای ایجاد یک نوار پیشرفت :
        /// یک عنصر <div> همراه با کلاس .progress ایجاد نمایید.
        /// در داخل <div> ایجاد شده یک <div> همراه با کلاس .progress-bar قرار دهید.             
        /// میزان پیشرفت را توسط عبارت style=”width:40%;” معین نمایید. در مقابل عبارت width: مقدار پیشرفت مورد نظر
        /// خود را بر حسب درصد وارد نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Default_Progress_Bar()
        {
            return View();
        }

        /// <summary>
        /// برای تغییر در ظاهر نمایش نوار پیشرفت :
        /// یک <div> همراه با کلاس .progress ایجاد نمایید.
        /// که * می تواند مقادیر info ، success ، warning و danger را اختیار نماید، اضافه نمایید.
        /// میزان پیشرفت را از طریق عبارت style=”width:60%;” مشخص نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Alternate_Progress_Bar()
        {
            return View();
        }

        /// <summary>
        /// برای ایجاد چنین نواری مراحل زیر را دنبال نمایید:
        /// یک <div> همراه با کلاس های .progress و .progress-striped ایجاد نمایید.
        /// سپس در داخل <div> بالا یک <div> با کلاس های .progress-bar و .progress-bar-* اضافه نمایید. مقدار
        /// می تواند success ، info ، warning و danger باشد.
        /// مقدار پیشرفت را نیز با عبارت style=”width:60%;” مشخص نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Striped_Progress_Bar()
        {
            return View();
        }

        /// <summary>
        /// برای ایجاد یک نوار پیشرفت که دارای انیمیشن است:
        /// یک <div> همراه با کلاس های .progress ، .progress-striped و .active ایجاد نمایید.
        /// در داخل <div> بالا یک <div> همراه با کلاس .progress-bar قرار دهید.
        /// میزان پیشرفت را با استفاده از عبارت style=”width:40%;” مشخص نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Animated_Progress_Bar()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید چندین مقدار را در یک نوار نمایش دهید. برای ایجاد این حالت چندین نوار پیشرفت را در داخل یک <div> با کلاس
        /// .progress قرار دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Stacked_Progress_Bar()
        {
            return View();
        }
    }
}