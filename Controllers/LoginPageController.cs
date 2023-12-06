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
using Microsoft.EntityFrameworkCore;


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
        // public IActionResult LoanRecords()
        // {
        //     return View();
        // }
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
        // public IActionResult LoanReports()
        // {
        //     return View("LoanReports");
        // }

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

        public IActionResult ViewBalance()
        {
            return View("ViewBalance");
        }

        public IActionResult Capital()
        {
            return View();
        }
        public IActionResult Receipt()
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
        //Loan Reports Display
        public async Task<IActionResult> LoanReports()
        {
            return View(await _context.Addloanrecords.ToListAsync());
        }

        // GET: Borrower/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanRecord = await _context.Addloanrecords
                .FirstOrDefaultAsync(m => m.AddloanrecordId == id);
            if (loanRecord == null)
            {
                return NotFound();
            }

            return View(loanRecord);
        }


        public async Task<IActionResult> LoanRecords()
        {
            return View(await _context.Addloanrecords.ToListAsync());
        }

        // GET: Borrower/Details/5
        public async Task<IActionResult> LoanRecordDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanRecord = await _context.Addloanrecords
                .FirstOrDefaultAsync(m => m.AddloanrecordId == id);
            if (loanRecord == null)
            {
                return NotFound();
            }

            return View(loanRecord);
        }

        // public async Task<IActionResult> LoanReportsDetails()
        // {
        //     return View(await _context.Addloanrecords.ToListAsync());
        // }

        public async Task<IActionResult> LoanReportsDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanRecord = await _context.Addloanrecords
                .FirstOrDefaultAsync(m => m.AddloanrecordId == id);
            if (loanRecord == null)
            {
                return NotFound();
            }

            return View(loanRecord);
        }

           

    }
}