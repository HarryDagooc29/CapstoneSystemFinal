// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using HarryMidterm.Entities;

// namespace HarryMidterm.Controllers
// {
//     [Route("[controller]")]
//     [Route("[controller]/[action]")]
//     public class RegisterController : Controller
//     {
//         private readonly ILogger<RegisterController> _logger;

//         private readonly harrymidtermdbContext _context;

//         public RegisterController(harrymidtermdbContext context)
//         {
//             _context = context;
//         }

//         [HttpGet]
//         public IActionResult Index()
//         {
//             return View(_context.Categories.ToList());
//         }


//         public IActionResult Create()
//         {
//             return View();
//         }

//         [HttpPost]
//         public IActionResult Create(Login log)
//         {
//             _context.Logins.Add(log);
//             _context.SaveChanges();

//             return RedirectToAction("Index");
//         }

//         [HttpPost]
//         public IActionResult Update(Login logins)
//         {
//             if(ModelState.IsValid)
//             {
//                 _context.Logins.Update(logins);
//                 _context.SaveChanges();

//                 return RedirectToAction("Index");
//             }
//             return View(logins);
//         }

//         public IActionResult Update(int? id)
//         {
//             if(id == null)
//             {
//                 return RedirectToAction("Index");
//             }
            
//             var category = _context.Categories.Where(q => q.Id == id).FirstOrDefault();
//             return View(category);
//         }

//         public IActionResult Delete(int id)
//         {
//             if(id != 0)
//             {
//                 var categoryDelete = _context.Categories.Where(q => q.Id == id).FirstOrDefault();
//                 _context.Categories.Remove(categoryDelete);
//                 _context.SaveChanges();

//                 return RedirectToAction("Index");
//             }

//            return RedirectToAction("Index");
//         }
//     }
// }