using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadCarInsurance.Models;
using TechAcadCarInsurance.ViewModels;

namespace TechAcadCarInsurance.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quote(string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth, int CarYear, string CarMake, 
                                    string CarModel, string Dui, int SpeedingTickets, string Coverage, int QuoteValue = 50)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress) || string.IsNullOrEmpty(CarMake) 
                || string.IsNullOrEmpty(CarModel) || string.IsNullOrEmpty(Dui) || string.IsNullOrEmpty(Coverage))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (CustomersEntities db = new CustomersEntities())
                {
                    var quote = new Customer();

                    quote.FirstName = FirstName;
                    quote.LastName = LastName;
                    quote.EmailAddress = EmailAddress;
                    quote.DateOfBirth = DateOfBirth;
                    quote.CarYear = CarYear;
                    quote.CarMake = CarMake;
                    quote.CarModel = CarModel;
                    quote.Dui = Dui;
                    quote.SpeedingTickets = SpeedingTickets;
                    quote.Coverage = Coverage;
                    quote.QuoteValue = QuoteValue;


                   
                    if (quote.DateOfBirth < DateTime.Now.AddYears(-25))
                    {
                        quote.QuoteValue += 25;
                    }
                    if (quote.DateOfBirth < DateTime.Now.AddYears(-18))
                    {
                        quote.QuoteValue += 100;
                    }
                    if (quote.DateOfBirth > DateTime.Now.AddYears(-100))
                    {
                        quote.QuoteValue += 25;
                    }
                    if (quote.CarYear < 2000)
                    {
                        quote.QuoteValue += 25;
                    }
                    if (quote.CarYear > 2015)
                    {
                        quote.QuoteValue += 25;
                    }
                    if (quote.CarMake == "Porsche")
                    {
                        quote.QuoteValue += 25;
                    }
                    if (quote.CarMake == "Porsche" && quote.CarModel == "911 Carrera")
                    {
                        quote.QuoteValue += 25;
                    }
                    if (quote.SpeedingTickets++ > 0)
                    {
                        quote.QuoteValue += 10;
                    }
                    if (quote.Dui == "Yes")
                    {
                        quote.QuoteValue = Convert.ToInt32(quote.QuoteValue * 1.25m);
                    }
                    if (quote.Coverage == "Full")
                    {
                        quote.QuoteValue = Convert.ToInt32(quote.QuoteValue * 1.5m);
                    }

                    
                    
                  
                    

                    db.Customers.Add(quote);
                    db.SaveChanges();

                    return View("QuoteSubmitted");
                }
            }
            
           
        }

        
        public ActionResult Admin()
        {
            return View();
        }
        
        
        
    }
}