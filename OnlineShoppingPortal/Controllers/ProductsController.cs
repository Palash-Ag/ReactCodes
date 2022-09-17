using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShoppingPortal.Data;
using OnlineShoppingPortal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext storeContext;
        public  ProductsController(StoreContext context)
        {
            storeContext = context;
        }
        
        // GET: ProductsController
        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await storeContext.products.ToListAsync();
        }

        // GET: ProductsController/Details/5
        [HttpGet("{id}")]
        public async Task<Product> GetProduct(int id)
        {
            return await storeContext.products.FindAsync(id);
        }

        // GET: ProductsController/Create
        ////public ActionResult Create()
        ////{
        ////    return View();
        ////}

        ////// POST: ProductsController/Create
        ////[HttpPost]
        ////[ValidateAntiForgeryToken]
        ////public ActionResult Create(IFormCollection collection)
        ////{
        ////    try
        ////    {
        ////        return RedirectToAction(nameof(Index));
        ////    }
        ////    catch
        ////    {
        ////        return View();
        ////    }
        ////}

        ////// GET: ProductsController/Edit/5
        ////public ActionResult Edit(int id)
        ////{
        ////    return View();
        ////}

        ////// POST: ProductsController/Edit/5
        ////[HttpPost]
        ////[ValidateAntiForgeryToken]
        ////public ActionResult Edit(int id, IFormCollection collection)
        ////{
        ////    try
        ////    {
        ////        return RedirectToAction(nameof(Index));
        ////    }
        ////    catch
        ////    {
        ////        return View();
        ////    }
        ////}

        ////// GET: ProductsController/Delete/5
        ////public ActionResult Delete(int id)
        ////{
        ////    return View();
        ////}

        ////// POST: ProductsController/Delete/5
        ////[HttpPost]
        ////[ValidateAntiForgeryToken]
        ////public ActionResult Delete(int id, IFormCollection collection)
        ////{
        ////    try
        ////    {
        ////        return RedirectToAction(nameof(Index));
        ////    }
        ////    catch
        ////    {
        ////        return View();
        ////    }
        ////}
    }
}
