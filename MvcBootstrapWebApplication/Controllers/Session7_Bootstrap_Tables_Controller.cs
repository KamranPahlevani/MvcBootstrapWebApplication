using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session7_Bootstrap_Tables_Controller : Controller
    {
        // GET: Session7_Bootstrap_Tables_
        public ActionResult Basic_Table()
        {
            return View();
        }

        /// <summary>
        /// تغییر یک در میان رنگ سطرهای جدول
        /// </summary>
        /// <returns></returns>
        public ActionResult Striped_Tables()
        {
            return View();
        }

        public ActionResult Bordered_Table()
        {
            return View();
        }

        public ActionResult Hover_Table()
        {
            return View();
        }

        /// <summary>
        /// کاهش عرض سطرهای جدول
        /// </summary>
        /// <returns></returns>
        public ActionResult Condensed_Table()
        {
            return View();
        }

        /// <summary>
        /// اضافه کردن کلاس به سطرهای مختلف
        /// </summary>
        /// <returns></returns>
        public ActionResult Contextual_Classes()
        {
            return View();
        }

        /// <summary>
        /// اضافه کردن اسکرول افقی به جدول در ابزارهای کوچکتر از 768 پیکسل
        /// </summary>
        /// <returns></returns>
        public ActionResult Responsive_Tables()
        {
            return View();
        }

    }
}