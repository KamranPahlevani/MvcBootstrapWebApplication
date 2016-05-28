using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session22_Bootstrap_Labels_Controller : Controller
    {

        public ActionResult Create_Labels()
        {
            return View();
        }

        /// <summary>
        /// شما همچنین می توانید از کلاس های label-default ، label-primary ، label-success ، label-info ، lable-warning, lable-danger
        /// جهت تغییر ظاهر label استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Label_Types()
        {
            return View();
        }
    }
}