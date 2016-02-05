using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session30_Bootstrap_List_Group_Controller : Controller
    {

        /// <summary>
        /// هدف این مولفه نمایش محتوای پیچیده در قالب یک فهرست است
        /// برای ایجاد یک List Group پایه:
        /// یک <ul> همراه با کلاس .list-group ایجاد نمایید.
        /// به هر تگ <li> کلاس .list-group-item را اضافه نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Default_List_Group()
        {
            return View();
        }

        /// <summary>
        /// می توان به هر مورد از عناصر List Group یک Badge اضافه نمود. این عنصر به صورت خودکار در سمت راست هر عنصر قرار می گیرد
        /// برای این منظور کافی است عبارت <span class=”badge”>text</span> را بین عناصر <li> قرار دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Add_Badges_To_List_Group()
        {
            return View();
        }

        /// <summary>
        /// برای نمایش محتوا به صورت لینک در List Group کارهای زیر را انجام دهید:
        /// یک <div> همراه با کلاس .list-group ایجاد نمایید.
        /// در داخل <div> ایجاد شده تگ های <a> مورد نظر خود را همراه با کلاس .list-group-item قرار دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Linking_List_Group_Items()
        {
            return View();
        }

        /// <summary>
        /// ما می توانیم هر نوع محتوای HTML در داخل عناصر List Group قرار دهیم. هر عنصر List Group
        /// می تواند متنی را برای عنوان خود نمایش دهد برای مشخص کردن این متن از کلاس .list-group-item-heading استفاده نمایید.
        /// برای نمایش محتوا نیز کلاس .list-group-item-text را به تگ <p> اضافه نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Add_Content_To_List_Group()
        {
            return View();
        }
    }
}