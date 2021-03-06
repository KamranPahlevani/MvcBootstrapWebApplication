﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapWebApplication.Controllers
{
    public class Session34_Bootstrap_Modal_Plugin_Controller : Controller
    {

        /// <summary>
        /// Modal یک پنجره است که بر روی پنجره اصلی نمایش داده می شود. هدف این پنجره ایجاد شرایط تبادل داده است بدون اینکه نیاز
        /// به بسته شدن پنجره اصلی وجود داشته باشد. این پنجره ها می توانند برای نمایش اطلاعات، دریافت داده از کاربر و ... به کار روند.
        /// اگر شما قصد دارید تنها از این پلاگین استفاده نمایید از فایل modal.js استفاده نمایید و یا فایل های bootstrap.js و
        /// bootstrap.min.js را به کار گیرید.
        /// نحوه استفاده
        /// شما می توانید پنجره modal را از طریق روش های زیر کنترل نمایید:
        /// از طریق Data Attributes : در عنصر کنترل کننده پنجره modal )به عنوان مثال یک دکمه یا لینک( ویژگی data-toggle="modal"
        /// را قرار دهید. علاوه بر این شما باید محتوای پنجره modal را از طریق عبارات data-target="#id" و یا href="#id" مشخص نمایید
        /// جزییات کد:
        /// برای فراخوانی یک پنجره modal یک عنصر کنترل کننده وجود دارد در این مثال از یک button استفاده شده است.
        /// پنجره مورد نظر در داخل عنصر button از طریق عبارت data-target=”myModal” مشخص شده است. این روش
        /// فراخوانی به شما اجازه می دهد که در یک صفحه چندین پنجره modal داشته باشید و هر یک را جداگانه فراخوانی نمایید.
        /// می توانید چندین پنجره modal ایجاد نمایید و هر یک را در زمان های مختلف و در شرایط مشخص فراخوانی نمایید.
        /// در تکه کد بالا از دو کلاس استفاده شده است. اولین کلاس،کلاس .modal که به سادگی محتوای یک <div> رابه عنوان
        /// پنجره modal تعریف می کند و دومین کلاس، کلاس .fade که استفاده از این جلوه نمایشی را در هنگام نمایش پنجره 
        /// موجب می گردد.
        /// ویژگی aria-labeledby=”myModalLabel” به قسمت title پنجره modal اشاره دارد.
        /// ویژگی aria-hidden=”true” باعث می گردد که پنجره تا هنگام فراخوانی نمایش داده نشود.
        /// <div class=”modal-header”> برای کنترل نحوه نمایش عنوان پنجره modal به کار می رود.
        /// class=”close” یک کلاس CSS است که برای کنترل نحوه نمایش دکمه مربوط به بستن پنجره به کار می رود.
        /// data-dismiss=”modal” یک ویژگی HTML5 است که به منظور بستن پنجره به کار برده شده است.
        /// class=”modal-body” جهت کنترل نحوه نمایش محتوای پنجره به کار رفته است.
        /// class=”modal-footer” جهت کنترل نحوه نمایش قسمت footer پنجره به کار رفته است.
        /// data-toggle=”modal” یکی از ویژگی های HTML5 است که برای نمایش پنجره به کار رفته است.
        /// Options:
        /// ویژگی های مشخصی برای این پلاگین وجود دارند که می توانند با استفاده از JavaScript و یا Data Attribute برای سفارشی
        /// کردن پلاگین مورد استفاده قرار گیرند.
        /// data-backdrop : اگر شما تمایل دارید که پنجره modal با کلیک کاربر بر روی صفحه اصلی بسته نشود مقدار این ویژگی را برابر
        /// با false قرار دهید.
        /// data-keyboard : اگر شما تمایل دارید که پنجره اصلی با فشردن کلید esc بسته نشود مقدار این ویژگی را برابر با false قرار دهید
        /// data-show : از این ویژگی برای نمایش پنجره modal استفاده نمایید.
        /// data-remote : توسط این ویژگی و با استفاده از تابع load در jQuery می توانید محتوای مشخصی را در درون پنجره modal
        /// نمایش دهید.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create_Modal()
        {
            return View();
        }

        /// <summary>
        /// modal(option) : می توان توسط این تابع ویژگی های پنجره modal که در بخش قبل توسط Data Attributes کنترل میشدند را فعال غیر فعال نمود
        /// modal(‘toggle’) : با فراخوانی این تابع در هنگام نمایش پنجره modal ، پنجره پنهان می گردد و در هنگامی که پنجره نمایش
        /// داده نمی شود با فراخوانی این تابع پنجره نمایش داده می شود.
        /// modal(‘show’) : باعث نمایش پنجره می گردد
        /// باعث پنهان شدن تابع می گردد. : modal(‘hide’)
        /// </summary>
        /// <returns></returns>
        public ActionResult Modal_Methods()
        {
            return View();
        }

        /// <summary>
        /// show.bs.modal : در زمان فراخوانی تابع show تحریک می گردد.
        /// shown.bs.modal : در زمانی که پنجره به صورت کامل به کاربر نمایش داده شد تحریک می گردد.
        /// hide.bs.modal : در زمان فراخوانی تابع hide تحریک می گردد.
        /// hidden.bs.modal : در زمانی که پنجره به صورت کامل در حالت عدم نمایش قرار گرفت تحریک می گردد.
        /// </summary>
        /// <returns></returns>
        public ActionResult Modal_Events()
        {
            return View();
        }
    }
}