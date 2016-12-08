using InoivceApp_With_Entity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceApp_With_Entity.Controllers
{
    public class UserAccountsController : Controller
    {
        private const string USER_NAME = "UserName";
        private const string USER_TYPE = "UserType";
        private IPreloadedUsers _users;

        public UserAccountsController(IPreloadedUsers users)
        {
            _users = users;
        }
        // GET: UserAccounts
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ValidateUser(string userName, string userPassword)
        {
            if(Request.Form["_btnSubmit"] == "User Login")
            {
                foreach(User user in _users.UserList)
                {
                    if(userName == user.UserName)
                    {
                        if (userPassword == user.UserPassword)
                        {
                            Session[USER_TYPE] = "user";
                            Session[USER_NAME] = userName;
                            return RedirectToAction("InvoicePage", "Invoice");
                        }
                    }

                }
            }
            else if(Request.Form["_btnSubmit"] == "Manager Login")
            {
                
                foreach(User user in _users.UserList)
                {
                    if(userName == user.UserName)
                    {
                        if (userPassword == user.UserPassword)
                        {
                            if (user.UserType.ToString() == "Manager")
                            {
                                Session[USER_TYPE] = "manager";
                                Session[USER_NAME] = userName;
                                return RedirectToAction("InvoicePage", "Invoice");
                            }
                        }
                    }

                }
            }
            ViewBag.isCorrect = false;
            return View("Index");
        }
    }
}