using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadCarInsurance.Models;
using TechAcadCarInsurance.ViewModels;

namespace TechAcadCarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (CustomersEntities db = new CustomersEntities())
            {
                var signups = db.Customers;
                var quoteVMs = new List<QuoteVM>();
                foreach (var signup in signups)
                {
                    var signupVm = new QuoteVM();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVm.QuoteValue = signup.QuoteValue;
                    quoteVMs.Add(signupVm);



                }

                

                return View(quoteVMs);
            }
        }
    }
}