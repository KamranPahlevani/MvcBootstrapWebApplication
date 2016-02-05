using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session9_Bootstarp_Buttons_Controller : Controller
    {
        // GET: Session9_Bootstarp_Buttons_
        public ActionResult Button_Classes()
        {
            return View();
        }

        public ActionResult Button_Sizes()
        {
            return View();
        }

        /// <summary>
        /// این حالت نشان دهنده فشرده شدن دکمه است.
        /// </summary>
        /// <returns></returns>
        public ActionResult Active_State()
        {
            return View();
        }

        /// <summary>
        /// وقتی شما دکمه را در حالت غیر فعال قرار می دهید میزان رنگ آن به میزان 50 % کاهش می یابد و حالت gradient خود را از دست می دهد
        /// </summary>
        /// <returns></returns>
        public ActionResult Deactive_Button()
        {
            return View();
        }

        /// <summary>
        /// شما ممکن است از کلاس های .btn در عناصر <a> ، <button> یا <input> استفاده نمایید. اما توصیه می شود که از این کلاس
        /// ها تنها در عنصر <button> استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Button_Tags()
        {
            return View();
        }
    }
}