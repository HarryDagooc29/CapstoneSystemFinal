using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HarryMidterm.Entities;
using HarryMidterm.ViewModel;
using HarryMidterm;
using Microsoft.AspNetCore.Mvc.Infrastructure;
namespace sampleMVC.Controllers

{
    [Route("api/[controller]/[action]")]
    public class newAPIController : ControllerBase //Orders.cs not Order.cs
    {

        private readonly harrymidtermdbContext _context;
        public newAPIController(harrymidtermdbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> login(String username, String password){
            var barrower = await _context.Newborrowers.FirstOrDefaultAsync(b=>b.Username==username && b.Password==password);
            if(barrower != null){
                return Ok();
            }
            return new BadRequestObjectResult("Account not found");
        }

          [HttpPost]
        public async Task<IActionResult> accountingStaff(String username, String password){
            var staff = await _context.Accountingstaffs.FirstOrDefaultAsync(b=>b.Username==username && b.Password==password);
            if(staff != null){
                return Ok();
            }
            return new BadRequestObjectResult("Account not found");
        }



        public ActionResult<List<Product>> getAllProducts(){
            
            //return _context.Products.ToList();
            var res = 
            (
                from c in _context.Categories
                join p in _context.Products
                on c.Id.ToString() equals p.Category

                select new categoryProdView
                {
                    Id = p.Id,
                    Category = c.Id,
                    CategoryName = c.Name,
                    Name = p.Name,
                    Units = p.Units,
                    Stock = p.Stock,
                    Price = p.Price,
                    Status = p.Status
                }
            ).ToList();

            return Ok(res);
        }

   
        public ActionResult<List<Category>> getAllCategories(){
            return _context.Categories.ToList();
        }

/*
        public IActionResult saveCategory(string name){
            Category c = new Category(){
                Name = name
            };
            _context.Categories.Add(c);
            _context.SaveChanges();
            return Ok();
        }*/

        public IActionResult addProduct(Product p)
        {
            if(string.IsNullOrEmpty(p.Status) || p.Status == "false")
            {
                p.Status = "Inactive";
            }
            _context.Products.Add(p);
            _context.SaveChanges();
            return Ok();
        }

        public IActionResult updateProduct(Product p, int oldStock)
        {
            int newStock = p.Stock;

            if(string.IsNullOrEmpty(p.Status) || p.Status == "false")
            {
                p.Status = "Inactive";
            }
            else
            {
                p.Status = "Active";
            }
            _context.Products.Update(p);
            _context.SaveChanges();


            //CHANGE MOCK TOTAL, STOCK

            Cart ct = new Cart();
            var res = _context.Carts.Where(q => q.ProdId == p.Id).FirstOrDefault();
            if(res != null)
            {
                if(newStock > oldStock)
                {
                    //add
                    int newMockStock = newStock - oldStock;
                    res.CmockStock += newMockStock;
                }
                else
                {
                    int newMockStock = oldStock - newStock;
                    res.CmockStock -= newMockStock;

                    if(res.CmockStock < 0)
                    {
                        res.Cquantity = newStock;
                    }   
                }

                res.CmockTotal = int.Parse(p.Price) * res.Cquantity;
                _context.Carts.Update(res);
                _context.SaveChanges();
            }

            return Ok();
        }


        public IActionResult deleteProduct(int id)
        {
            var res = _context.Products.Where(q => q.Id == id).FirstOrDefault();
            _context.Products.Remove(res);
            _context.SaveChanges();
            
            return Ok();
        }

        public IActionResult addStockProduct(Product p, int iStock,string date)
        {
            p.Stock += iStock;
            _context.Products.Update(p);
            _context.SaveChanges();


            Stockhistory sh = new Stockhistory();   
            sh.AddedStock = iStock;
            sh.ProdId = p.Id;
            sh.Date = date;

            _context.Stockhistories.Add(sh);
            _context.SaveChanges();


            //ADD MOCK STOCK
            Cart ct = new Cart();
            var res = _context.Carts.Where(q => q.ProdId == p.Id).FirstOrDefault();
            if(res != null)
            {
                res.CmockStock += iStock;
                _context.Carts.Update(res);
                _context.SaveChanges();
            }

            return Ok();
        }

        public ActionResult<List<Stockhistory>> viewStock(int id){
            //return _context.Products.ToList();
            var res = 
            (
                from s in _context.Stockhistories
                join p in _context.Products
                on s.ProdId equals p.Id
                where p.Id == id

                select new stockProdHistory
                {
                    Id = p.Id,
                    Name = p.Name,
                    AStockId = s.AStockId,
                    ProdId = p.Id,
                    AddedStock = s.AddedStock,
                    Date = s.Date
                }
            ).ToList();

            return Ok(res);
        }

     public ActionResult<List<Newborrower>> getfname(){
              return _context.Newborrowers.ToList();
     }


      public ActionResult<List<Newborrower>> getSalary(){
              return _context.Newborrowers.ToList();
     }

        public IActionResult addCart(Cart ct)
        {
            _context.Carts.Add(ct);
            _context.SaveChanges();
            return Ok(ct);
        }

        public IActionResult updateCart(Cart ct)
        {
            _context.Carts.Update(ct);
            _context.SaveChanges();
            return Ok(ct);
        }

        public ActionResult<List<Cart>> popCart(){
            var res = 
            (
                from cp in _context.Carts
                join p in _context.Products on cp.ProdId equals p.Id
                join c in _context.Categories on p.Category equals c.Id.ToString()

                select new cartList
                {
                    Id = p.Id,
                    Category = c.Id,
                    CategoryName = c.Name,
                    Name = p.Name,
                    Units = p.Units,
                    Stock = p.Stock,
                    Price = p.Price,
                    Status = p.Status,
                    Quantity = cp.Cquantity,
                    mTotal = cp.CmockTotal,
                    MockStock = cp.CmockStock,
                    cartID = cp.CartId
                }
            ).ToList();

            return Ok(res);
        }

        public IActionResult deleteCart(int cartID)
        {
            var res = _context.Carts.Where(q => q.CartId == cartID).FirstOrDefault();
            _context.Carts.Remove(res);
            _context.SaveChanges();
            return Ok();
        }

        public IActionResult savetoOrder(Order ord)
        {
            _context.Orders.Add(ord);
            _context.SaveChanges();

            //Get the current order id
            //var res = _context.Orders.LastOrDefault();
            var lastId = _context.Orders.OrderByDescending(x => x.OrderId).FirstOrDefault()?.OrderId;
            return Ok(lastId);
        }

        public IActionResult savetoOrderDetails(Orderdetail ordtls, int mStock)
        {
            _context.Orderdetails.Add(ordtls);
            _context.SaveChanges();


            //UPDATE THE STOCK
            Product p = new Product();
            var res = _context.Products.Where(q => q.Id == ordtls.ProductId).FirstOrDefault();
            res.Stock = mStock;

            _context.Products.Update(res);
            _context.SaveChanges();
            return Ok();
        }

        public IActionResult clearCart()
        {
            _context.Carts.RemoveRange(_context.Carts);
            _context.SaveChanges();
            return Ok();
        }
        public ActionResult<List<Order>> getAllOrders(){
            return  _context.Orders.ToList();
        }


          public ActionResult<List<Addloanrecord>> getloan(){
            return  _context.Addloanrecords.ToList();
        }



        public ActionResult<List<Stockhistory>> getAllOrderDetails(int id){
            var res = 
            (
                from od in _context.Orderdetails
                join p in _context.Products on od.ProductId equals p.Id
                join o in _context.Orders on od.OrderId equals o.OrderId
                where o.OrderId == id

                select new orderInfo
                {
                    productName = p.Name,
                    OrderDetailsId = od.OrderDetailsId,
                    OrderId = o.OrderId,
                    ProductId = p.Id,
                    Quantity = od.Quantity,
                    ProductTotal =   float.Parse(od.ProductTotal,System.Globalization.CultureInfo.InvariantCulture)
                }
            ).ToList();

            return Ok(res);
        }


        public async Task<IActionResult> addloan(Addloanrecord addloan)
        {
            // Add the Addloanrecord to the context and retrieve the entity
            await _context.AddAsync(addloan);
            AddLoanSchedule();
            await _context.SaveChangesAsync();
            // var record = new Schedule();
            // record.AddloanrecordId = newLoanEntity.AddloanrecordId;
            // record.Date = newLoanEntity.Date;
            // record.Payment = 0;
            // record.TotalAmount = newLoanEntity.TotalAmount??0;
            // record.Balance = newLoanEntity.TotalAmount??0;

            // _context.Schedules.Add(record);

            // _context.SaveChanges();
            return Ok();
        }

        void AddLoanSchedule(){
            var latest_loan = _context.Addloanrecords.OrderByDescending(a=>a.AddloanrecordId).FirstOrDefault();

            Schedule record = new Schedule();
            record.AddloanrecordId = latest_loan.AddloanrecordId;
            record.Date = latest_loan.Date;
            record.Payment = 0;
            record.TotalAmount = latest_loan.TotalAmount??0;
            record.Balance = latest_loan.TotalAmount??0;
            _context.Schedules.Add(record);

            // _context.SaveChanges();
        }


        public IActionResult payLoanSchedule(string dates, double paymnt, int addLRId, string paymentType, double totalAmnt, double balance)
        {
            Schedule sched = new Schedule();
            try{
                sched.Date = dates;
                sched.Payment = paymnt;
                sched.AddloanrecordId = addLRId;
                sched.Type = paymentType;
                // sched.TotalAmount = balance;
                sched.Balance = balance;
            }catch(Exception e){
                return new BadRequestObjectResult(e);
            }

            _context.Schedules.Add(sched);
            _context.SaveChanges();
            return Ok("Hello");
        }






    }
}