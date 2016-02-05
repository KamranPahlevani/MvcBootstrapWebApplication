using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session31_Bootstrap_Panels_Controller : Controller
    {

        /// <summary>
        /// از این مولفه زمانی استفاده می گردد که شما قصد دارید
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Default_Panel()
        {
            return View();
        }

        /// <summary>
        /// دو راه برای افزودن عنوان به پنل وجود دارد:
        /// استفاده از یک <div> همراه با کلاس .panel-heading و قرار دادن متن مورد نظر در داخل آن.
        /// استفاده از تگ های <h1>-<h6> همراه با کلاس .panel-title و قرار دادن متن مورد نظر در داخل آن.
        /// </summary>
        /// <returns></returns>
        public ActionResult Panel_with_Heading()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید به پنل خود footer اضافه نمایید. برای این منظور کافی است متن یا عنصر مورد نظر خود را در داخل یک <div>
        /// همراه با کلاس .panel-footer قرار دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Panel_with_Footer()
        {
            return View();
        }

        /// <summary>
        /// برای تغییر رنگ پنل می توانید کلاس .panel-default را با کلاس .panel-* جایگزین نمایید. مقدار * می تواند یکی از موارد
        /// .primary ، .success ، .info ، .warning ، .danger را اختیار نماید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Panel_Contextual_Alternatives()
        {
            return View();
        }

        /// <summary>
        /// برای افزودن یک جدول فاقد border در داخل یک پنل تگ <table> را همراه با کلاس .table استفاده نمایید. 
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Panel_with_Tables()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید در داخل یک پنل یک List Group اضافه نمایید. برای این منظور کافی است یک پنل ایجاد کرده و List Group
        /// خود را در داخل آن قرار دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Panel_with_List_Group()
        {
            return View();
        }
    }
}