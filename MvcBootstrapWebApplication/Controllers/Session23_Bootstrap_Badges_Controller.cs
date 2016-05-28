using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session23_Bootstrap_Badges_Controller : Controller
    {

        /// <summary> 
        /// badges شبیه label است اما تفاوت اصلی با عنصر label گوشه های گرد شده آن است.
        /// از این عنصر جهت نمایش موارد جدید و یا موارد خوانده نشده استفاده نمایید. برای استفاده از این عنصر تنها کافی است کد <span
        /// class="badge">…</span> را به لینک ها و بقیه موارد اضافه نمایید.
        /// زمانی که مورد جدید و یا خوانده نشده ایی وجود ندارد، می توانید از نمایش این عنصر توسط :empty جلوگیری نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Badges()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید badges را در داخل pills نیز استفاده نمایید. شما می توانید این کار را با قرار دادن <span class=”badge”>
        /// در داخل لینک ها انجام دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Active_nav_state()
        {
            return View();
        }
    }
}