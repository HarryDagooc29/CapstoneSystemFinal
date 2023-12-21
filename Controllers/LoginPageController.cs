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
using HarryMidterm.ViewModel;


namespace HarryMidterm.Controllers
{
    // [Route("[controller]")]
    // [Route("[controller]/[action]")]
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

        // public IActionResult ViewBalance()
        // {
        //     return View("ViewBalance");
        // }

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
        public async Task<IActionResult> LoanRecordsDetails(int? id)
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

       

    
//   THIS IS TO DISPLAY DATA 
        public async Task<IActionResult> ViewBalance()
{
    // Assuming you want to retrieve a specific borrower's data, you may adjust the query accordingly
    Schedule borrowerRecord = await _context.Schedules.FirstOrDefaultAsync();

    // Check if a borrower record is found
    if (borrowerRecord != null)
    {
        return View(borrowerRecord);
    }
    else
    {
        // Handle the case where no borrower record is found
        return NotFound();
    }
}

////////////////////////////////





        

          public async Task<IActionResult> PayLoan(int? id)
        {
    if (id == null)
    {   
        // If ID is not provided, return the list of all loan records
        var loanRecordsList = await _context.Addloanrecords.ToListAsync();
        return View("LoanRecords", loanRecordsList);
    }

    // Find the specific loan record by id
    var loanRecord = await _context.Schedules
    .OrderByDescending(m => m.ScheduleId)
    .Where(s=>s.AddloanrecordId==id)
    .FirstOrDefaultAsync();

// Now, lastLoanRecord contains the very last item from the Schedules table based on ScheduleID


    if (loanRecord == null)
    {
        return NotFound();
    }

    // If ID is provided, return the details view for the specific loan record
    return View(loanRecord);
    }



       public async Task<IActionResult> TransactionReports(int? id)
        {
            if (id == null)
            {
                // Display a list of all transactions
                return View("TransactionReports", await _context.Schedules.ToListAsync());
            }

            // Display details of a specific transaction
            var sched = await _context.Schedules
                .FirstOrDefaultAsync(m => m.ScheduleId == id);

            if (sched == null)
            {
                return NotFound();
            }

            return View(sched);
        }


       public async Task<IActionResult> TransctionDetails(int? id)
        {
            if (id == null)
            {
                // Display a list of all transactions
                return View("TransctionDetails", await _context.Schedules.ToListAsync());
            }

            // Display details of a specific transaction
            var sched = await _context.Schedules
                .FirstOrDefaultAsync(m => m.ScheduleId == id);

            if (sched == null)
            {
                return NotFound();
            }

            return View(sched);
        }

        
    public IActionResult MasterList()
        {
            return View("MasterList");
        }
 


       
        

        
      
       

           

    }
}