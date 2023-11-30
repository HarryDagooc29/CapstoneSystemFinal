using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HarryMidterm.Entities;
using HarryMidterm.ViewModel;


namespace HarryMidterm.Controllers
{
    [Route("[controller]")]
    [Route("[controller]/[action]")]
    public class NewBorrowerController : Controller
    {
        private readonly ILogger<NewBorrowerController> _logger;

        private readonly harrymidtermdbContext _context;

        public NewBorrowerController(harrymidtermdbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.Newborrowers.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create(Newborrower newborrower)
        {
            _context.Newborrowers.Add(newborrower);
            _context.SaveChanges();

            return RedirectToAction("Signin");
        }


         [HttpPost]
        public IActionResult Update(Newborrower newborrower)
        {
            if(ModelState.IsValid)
            {
                _context.Newborrowers.Update(newborrower);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(newborrower);
        }

        public IActionResult Update(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }

            var newborrower = _context.Newborrowers.Where(q => q.NewBorrowerId == id).FirstOrDefault();
            return View(newborrower);
        }

        public IActionResult Delete(int id)
        {
            if (id != 0)
            {
                var borrowerDelete = _context.Newborrowers.Where(q => q.NewBorrowerId == id).FirstOrDefault();
                _context.Newborrowers.Remove(borrowerDelete);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public IActionResult ViewBorrower()
        {
            return View("ViewBorrower");
        }
 public IActionResult BorrowerRecords()
        {
            return View("BorrowerRecords");
        }

      
    }
}