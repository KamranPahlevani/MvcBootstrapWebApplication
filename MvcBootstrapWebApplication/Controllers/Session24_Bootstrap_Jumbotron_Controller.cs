using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session24_Bootstrap_Jumbotron_Controller : Controller
    {
        /// <summary>
        /// در این فصل نحوه استفاده از Jumbotron تشریح خواهد شد. این مولفه جهت استفاده در صفحه اصلی سایت مناسب است و امکان
        /// درج محتوای بیشتر را فراهم می آورد.
        /// برای استفاده از این مولفه یک <div> همراه با کلاس .jumbotron ایجاد نمایید و محتوای مورد نظر خود را در داخل آن قرار دهید.
        /// استفاده از تگ <h1> در داخل این عنصر باعث افزایش اندازه این تگ می گردد همچنین font-weight این تگ به 222 پیکسل
        /// کاهش می یابد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Jumbotron()
        {
            return View();
        }

        /// <summary>
        /// برای استفاده از یک jumbotron که تمام عرض صفحه را اشغال می کند و فاقد گوشه های گرد شده است کافی است از کلاس
        /// jumbotron در خارج از کلاس .container استفاده نمایید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Jumbotron_FullPage()
        {
            return View();
        }
    }
}