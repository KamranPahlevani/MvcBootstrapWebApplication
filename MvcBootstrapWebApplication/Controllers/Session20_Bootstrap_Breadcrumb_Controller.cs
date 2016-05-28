using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session20_Bootstrap_Breadcrumb_Controller : Controller
    {
        /// <summary>
        /// Breadcrumbs یک راه موثر برای نمایش اطلاعات سایت است. برای مثال می توان از این عنصر در قسمت بلاگ سایت برای نمایش
        /// مواردی همچون تاریخ انتشار، گروه بندی ها و برچسپ ها و ... استفاده نمود و یا توسط آن می توان برای نمایش مکان فعلی کاربر استفاده نمود
        /// Breadcrumbs در Bootstrap تنها یک فهرست مرتب است که کلاس .breadcrumb به آن اضافه شده است. جداکننده
        /// عناصر در Breadcrumb به صورت خودکار اضافه می گردد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Breadcrumb()
        {
            return View();
        }
    }
}