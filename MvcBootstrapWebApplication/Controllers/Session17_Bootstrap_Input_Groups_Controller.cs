using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session17_Bootstrap_Input_Groups_Controller : Controller
    {
        /// <summary>
        /// با استفاده از Input Groups شما می توانید متون یا دکمه ها را به قبل یا بعد از عناصر <input> اضافه نمایید.
        /// با افزودن محتوا به قبل یا بعد از عنصر <input> ، شما می توانید عناصر معمول و پر کاربرد را به داده های ورودی کاربر اضافه نمایید.
        /// برای مثال می توایند علامت $ یا @ را به داده های ورودی اضافه نمایید.
        /// برای قرار دادن عناصر قبل یا بعد از .form-control کارهای زیر را انجام دهید:
        /// عنصر input مورد نظر را در یک <div> با کلاس .input-group قرار دهید.
        /// عنصری که قرار است اضافه گردد را در داخل یک <span> با کلاس .input-group-addon قرار دهید. سپس
        /// <span> با محتوای داخل آنرا در <div> با کلاس .input-group قرار دهید.
        /// حال می توانید این <span> را قبل یا بعد از عنصر <input> قرار دهید.
        /// استفاده از عناصر <select> برای افزودن به عنصر <input> توصیه نمی گردد. همچنین Input Groups را به صورت مستقیم در
        /// فرم ها استفاده نکنید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Basic_Input_Group()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید اندازه گروه ها را با افزودن کلاس های .input-group-lg ، .input-group-sm ، .input-group-xs به کلاس
        /// .input-group تغییر دهید. محتوا به صورت خودکار تغییر خواهد کرد.
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Input_Group_Sizing()
        {
            return View();
        }

        /// <summary>
        /// شما می توانید به عناصر <input> به جای متن checkbox یا radio buttons اضافه نمایید. برای افزودن این عناصر یک نمونه از
        /// این عناصر را در داخل <span class=”input-group-addon”>…</span> قرار دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Checkboxes_and_Radio_Addons()
        {
            return View();
        }

        /// <summary>
        /// شما همچنین می توانید دکمه ها را قبل یا بعد از Input Groups قرار دهید. کلاس .input-group-addon را به کلاس
        /// .input-group-btn تغییر دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Button_Addons()
        {
            return View();
        }

        /// <summary>
        /// افزودن دکمه همراه با منو آبشاری به یک Input Group می تواند به سادگی صورت گیرد. برای این منظور کافی است یک دکمه
        /// همراه با منو آبشاری ایجاد کرده و آن را در داخل <div> با کلاس .input-group-btn قرار دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Buttons_with_Dropdown()
        {
            return View();
        }

        /// <summary>
        /// برای ایجاد این مولفه کافی است یک Split Button Dropdowns که در فصل قبل نحوه ایجاد آن شرح داده شد را ایجاد نموده و
        /// در داخل <div> با کلاس .input-group-btn قرار دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Segmented_Buttons()
        {
            return View();
        }
    }
}