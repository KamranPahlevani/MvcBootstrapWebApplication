using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session21_Bootstrap_Pagination_Controller : Controller
    {

        /// <summary>
        /// در بعضی مواقع در صفحات نیاز است که شما اطلاعات زیادی را نمایش دهید به عنوان مثال نمایش نتایج جستجو، در چنین مواردی یک
        /// راهکار مناسب استفاده از صفحه بندی برای نمایش نتایج است.
        /// ویژگی صفحه بندی یک فهرست نامرتب است که برای ایجاد بخش پیمایش صفحه بندی بکار می رود.
        /// برای ایجاد این عنصر کافی است یک فهرست نامرتب ایجاد نموده و کلاس .pagination را به آن اضافه نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Default_Pagination()
        {
            return View();
        }

        /// <summary>
        /// برای نمایش عناصر فهرست به صورت فعال و غیر فعال می توانید به ترتیب از کلاس های .active و .disable استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Pagination_States()
        {
            return View();
        }

        /// <summary>
        /// برای تغییر اندازه بخش پیمایش می توانید از کلاس .pagination-* استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Pagination_Size()
        {
            return View();
        }

        /// <summary>
        /// اگر شما نیاز به ایجاد دکمه های قبل و بعد دارید می توانید از کلاس .pager استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Default_Pager()
        {
            return View();
        }

        public ActionResult Pager_Aligned_Links()
        {
            return View();
        }

        public ActionResult Pager_States()
        {
            return View();
        }
    }
}