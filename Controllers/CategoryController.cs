using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HarryMidterm.Entities;
using HarryMidterm;

namespace HarryMidterm.Controllers
{
    [Route("[controller]")]
    [Route("[controller]/[action]")]
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;

        private readonly harrymidtermdbContext _context;

        public CategoryController(harrymidtermdbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category ctg)
        {
            _context.Categories.Add(ctg);
            _context.SaveChanges();

            return RedirectToAction("Signin");
        }

        [HttpPost]
        public IActionResult Update(Category category)
        {
            if(ModelState.IsValid)
            {
                _context.Categories.Update(category);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Update(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }
            
            var category = _context.Categories.Where(q => q.Id == id).FirstOrDefault();
            return View(category);
        }

        public IActionResult Delete(int id)
        {
            if(id != 0)
            {
                var categoryDelete = _context.Categories.Where(q => q.Id == id).FirstOrDefault();
                _context.Categories.Remove(categoryDelete);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

           return RedirectToAction("Index");
        }
    }
}