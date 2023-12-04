using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HarryMidterm.Entities;
using HarryMidterm.Models;

namespace HarryMidterm.Controllers
{
    public class BorrowerController : Controller
    {
        private readonly harrymidtermdbContext _context;

        public BorrowerController(harrymidtermdbContext context)
        {
            _context = context;
        }

        // GET: Borrower
        public async Task<IActionResult> Index()
        {
            return View(await _context.Newborrowers.ToListAsync());
        }

        // GET: Borrower/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newborrower = await _context.Newborrowers
                .FirstOrDefaultAsync(m => m.NewBorrowerId == id);
            if (newborrower == null)
            {
                return NotFound();
            }

            return View(newborrower);
        }

        // GET: Borrower/Create
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult BorrowerRecords()
        {
            return View("BorrowerRecords");
        }



        // POST: Borrower/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NewBorrowerId,LastName,FirstName,MiddleName,BirthDate,BirthPlace,Sex,City,Province,ZipCode,Nationality,MaritalStatus,Occupation,Salary,CoMaker,LoanType,DaysToPay,PartialPayment,Collectible,Username,Password")] Newborrower newborrower)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newborrower);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(newborrower);
        }

        // GET: Borrower/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newborrower = await _context.Newborrowers.FindAsync(id);
            if (newborrower == null)
            {
                return NotFound();
            }
            return View(newborrower);
        }

        // POST: Borrower/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //  public async Task<IActionResult> Edit(int id, [Bind("NewBorrowerId,CoMaker")] Newborrower newborrower)
        public async Task<IActionResult> Edit(int id, [Bind("NewBorrowerId,LastName,FirstName,MiddleName,BirthDate,BirthPlace,Sex,City,Province,ZipCode,Nationality,MaritalStatus,Occupation,Salary,CoMaker,LoanType,DaysToPay,PartialPayment,Collectible,Username,Password")] Newborrower newborrower)
        {
            if (id != newborrower.NewBorrowerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newborrower);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewborrowerExists(newborrower.NewBorrowerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(newborrower);
        }

        // GET: Borrower/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newborrower = await _context.Newborrowers
                .FirstOrDefaultAsync(m => m.NewBorrowerId == id);
            if (newborrower == null)
            {
                return NotFound();
            }

            return View(newborrower);
        }

        // POST: Borrower/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var newborrower = await _context.Newborrowers.FindAsync(id);
            _context.Newborrowers.Remove(newborrower);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewborrowerExists(int id)
        {
            return _context.Newborrowers.Any(e => e.NewBorrowerId == id);
        }

       

    }
}
