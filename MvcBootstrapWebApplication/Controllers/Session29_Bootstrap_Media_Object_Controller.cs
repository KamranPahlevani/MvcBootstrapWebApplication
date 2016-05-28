using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session29_Bootstrap_Media_Object_Controller : Controller
    {

        /// <summary>
        /// این مولفه ها برای ایجاد انواع گوناگونی از قسمت های صفحه می توانند
        /// مورد استفاده قرار گیرند. این مولفه می تواند حاوی متن و یک تصویر که در سمت چپ یا راست آن قرار می گیرد باشد. هدف این
        /// مولفه کوتاه کردن کدهای مورد نیاز جهت ایجاد چنین ساختارهایی است. دو نوع Media Object وجود دارد:
        /// .media :  این کلاس به شما اجازه می دهد که عناصری مانند تصویر، صدا، فیلم را در سمت چپ یا راست متن خود قرار دهید
        /// .media-list : اگر شما قصد دارید تا فهرستی از Media Object ایجاد نمایید از این کلاس استفاده نمایید.
        /// برای استفاده از کلاس .media مراحل زیر را دنبال نمایید:
        /// ابتدا یک <div> همراه با کلاس .media ایجاد نمایید.
        /// در داخل <div> ایجاد شده در مرحله قبل یک تگ <a> اضافه نمایید. در داخل این تگ تصویر مورد نظر خود را قرار دهید.
        /// کلاس .media-object را نیز به تگ <img> اضافه نمایید. برای قرار گرفتن تصویر در سمت چپ یا راست متن
        ///  می توانید به ترتیب از کلاس های  .pull-left و .pull-right برای تگ <a> استفاده نمایید.
        ///  برای افزودن محتوا از یک <div> همراه با کلاس .media-body استفاده نمایید.
        /// </summary>
        public ActionResult Ceate_Media()
        {
            return View();
        }

        /// <summary>
        /// برای ایجاد media list کافی است یک فهرست نامرتب همراه با کلاس .media-list ایجاد نمایید همچنین به هر یک از عناصر این
        /// فهرست <li> کلاس .meida را اضافه نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Media_List()
        {
            return View();
        }
    }
}