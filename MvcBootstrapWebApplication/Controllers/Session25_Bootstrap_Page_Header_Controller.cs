using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session25_Bootstrap_Page_Header_Controller : Controller
    {
        /// <summary>
        /// Page header یک ویژگی جالب است که برای نمایش عناوین مطالب مورد استفاده قرار می گیرد. برای استفاده از این ویژگی، عنوان
        /// خود را در داخل یک <div> با کلاس .page-header قرار دهید
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Page_Header()
        {
            return View();
        }
    }
}