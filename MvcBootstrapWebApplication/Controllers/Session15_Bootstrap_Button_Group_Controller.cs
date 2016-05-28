using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session15_Bootstrap_Button_Group_Controller : Controller
    {
        /// <summary>
        /// برای ایجاد چنین گروه بندی تنها کافی است دکمه های خود را در داخل یک <div> همراه با کلاس .btn-group قرار دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Basic_Button_Groups()
        {
            return View();
        }

        /// <summary>
        /// به منظور قرار دادن چندین bnt-group در داخل یک گروه از یک <div> همراه با کلاس .btn-toolbar استفاده می کنیم.
        /// </summary>
        /// <returns></returns>
        public ActionResult Button_Toolbar()
        {
            return View();
        }

        /// <summary>
        /// برای تغییر اندازه دکمه های موجود در داخل یک گروه از کلاس های btn-group-* که مقدار * می تواند موارد lg ، sm و xs باشد
        /// می توان استفاده کرد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Button_Size()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید گروه بندی را به صورت تودرتو انجام دهید. این کار در زمان ترکیب دکمه ها با منوهای آبشاری کاربرد دارد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Nesting()
        {
            return View();
        }

        /// <summary>
        /// برای نمایش گروه ها به صورت عمودی کافی است کلاس .btn-group را به .btn-group-vertical تغییر دهیم.
        /// </summary>
        /// <returns></returns>
        public ActionResult Vertical_Button_Group()
        {
            return View();
        }
    }
}