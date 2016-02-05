using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session27_Bootstrap_Alerts_Controller : Controller
    {

        /// <summary>
        /// شما می توانید یک پیام هشدار را با استفاده از یک
        /// تگ <div> همراه با کلاس .alert ایجاد نمایید. برای تغییر رنگ هشدار می توانید از کلاس های .alert-success ،
        /// ، .alert-warning ، .alert-danger استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Alerts()
        {
            return View();
        }

        /// <summary>
        /// برای ایجاد پیام هایی که حاوی یک دکمه جهت بستن هستند مراحل زیر را انجام دهید:
        /// یک هشدار پایه مانند مثال قبل و با استفاده از یک <div> و کلاس .alert ایجاد نمایید.
        /// کلاس .alert-dismissable را به تگ <div> اضافه نمایید.
        /// یک آیکون جهت بستن هشدار توسط عنصر <button> ایجاد نمایید. توجه نمایید که به دکمه مورد نظر کلاس .close و
        /// ویژگی های data-dismiss=”alert” و aria-hidden=”true” را اضافه نمایید.
        /// از وجود خصیصه data-dismiss=”alert” در عنصر <button> اطمینان حاصل نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Dismissal_Alerts()
        {
            return View();
        }

        /// <summary>
        /// گاهی نیاز است که پیام های هشدار حاوی یک لینک جهت راهنمایی کاربر باشند برای قرار دادن لینک در پیام های هشدار:
        /// یک هشدار پایه مانند مثال قبل و با استفاده از یک <div> و کلاس .alert ایجاد نمایید.
        /// در داخل <div> یک تگ <a> همراه با کلاس .alert-link قرار دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Links_in_Alerts()
        {
            return View();
        }
    }
}