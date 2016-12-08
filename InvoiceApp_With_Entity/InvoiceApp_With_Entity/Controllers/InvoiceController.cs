using InoivceApp_With_Entity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceApp_With_Entity.Controllers
{
    public class InvoiceController : Controller
    {
        private const string USER_NAME = "UserName";
        private const string USER_TYPE = "UserType";

        private IPreloadedInvoices _invoice;

        public InvoiceController(IPreloadedInvoices invoice)
        {
            _invoice = invoice;
        } 
        // GET: Invoice
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InvoicePage()
        {
            string uName = (string)(Session[USER_NAME]);
            string uAuth = (string)(Session[USER_TYPE]);
            ViewBag.uName = uName;
            bool autorization = false;
            if (uAuth == "user")
            {
                autorization = true;
                ViewBag.uAuthorization = autorization;
                ViewBag.uType = "User";
                return View("InvoicePage");

            }
            else if (uAuth == "manager")
            {
                autorization = true;
                ViewBag.uAuthorization = autorization;
                ViewBag.uType = "Manager";
                return View("InvoicePage");
            }
            ViewBag.uAthorization = autorization;
            return View("InovoicePage");
        }
    }
}