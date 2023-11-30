using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HarryMidterm.Entities;
using HarryMidterm;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HarryMidterm.Controllers
{
    [Route("[controller]")]
    [Route("[controller]/[action]")]
    public class LoginPageController : Controller
    {
        private readonly ILogger<LoginPageController> _logger;

        private readonly harrymidtermdbContext _context;

        public LoginPageController(harrymidtermdbContext context)
        {
            _context = context;
        }

        // [HttpGet]
        public IActionResult Index()
        {
            return View();
            // _context.Logins.ToList()
        }

        //[HttpPost]
        public IActionResult Signin()
        {
            return View();
            // _context.Logins.Add(log);
            // _context.SaveChanges();
            // return RedirectToAction("Signin"); //Index ni Before
        }


        public IActionResult Register()
        {
            return View("Register");
        }

        public IActionResult HomePage()
        {
            return View();
        }

        public IActionResult BorrowerInformation()
        {
            return View("BorrowerInformation");
        }
        public IActionResult AllReports()
        {
            return View("AllReports"); /*Like Sales Report, Loan Report and Transaction Report*/
        }

        public IActionResult Merchandise()
        {
            return View("Merchandise");
        }
        public IActionResult LoanRecords()
        {
            return View("LoanRecords");
        }
        public IActionResult Signout()
        {
            return View("Signout");
        }

        public IActionResult ForgotPassword()
        {
            return View("ForgotPassword");
        }

        public IActionResult SalesReports()
        {
            return View("SalesReports");
        }
        public IActionResult LoanReports()
        {
            return View("LoanReports");
        }

        public IActionResult TransactionReports()
        {
            return View("TransactionReports");
        }
        public IActionResult DelinquentReports()
        {
            return View("DelinquentReports");
        }
        public IActionResult BorrowerRecords()
        {
            return View("BorrowerRecords");
        }
        public IActionResult Details()
        {
            return View("Details");
        }

        public IActionResult Capital()
        {
            return View();
        }


        public IActionResult AddLoan()
        {
            //  ViewBag.Newborrowers = _context.Newborrowers.ToList()
            // .Select(x => new SelectListItem { Text = x.LastName , Value = x.NewBorrowerId.ToString() });
        
            
            //  ViewBag.Newborrowerss = _context.Newborrowers.ToList()
            // .Select(x => new SelectListItem { Text = x.FirstName , Value = x.NewBorrowerId.ToString() });
            

            
            return View();
        }


     

        [HttpPost]
        public IActionResult AddLoan(Addloanrecord alr)
        {
            _context.Addloanrecords.Add(alr);
            _context.SaveChanges();

            return RedirectToAction("AddLoan");
        }

        [HttpPost]
        public IActionResult Capital(Capital cap)
        {
            _context.Capitals.Add(cap);
            _context.SaveChanges();

            return RedirectToAction("Capital");
        }


           

    }
}