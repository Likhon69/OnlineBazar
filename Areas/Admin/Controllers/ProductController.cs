using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineBazar.Data;
using OnlineBazar.Models;

namespace OnlineBazar.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private ApplicationDbContext _db;
        private IHostingEnvironment _hoe;
        public ProductController(ApplicationDbContext db,IHostingEnvironment hoe)
        {
            _db = db;
            _hoe = hoe;
        }
        public IActionResult Index()
        {
            var data = _db.Products.Include(c => c.ProductType).Include(f => f.SpecialTag).ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["ProSelect"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductTypeName");
            ViewData["ProTagSelect"] = new SelectList(_db.SpecialTags.ToList(), "Id", "SpecialTagName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Products products,IFormFile image)
        {
           
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    var name = Path.Combine(_hoe.WebRootPath + "/images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "images/" + image.FileName;
                }
                _db.Products.Add(products);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        //Edit
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
    }
}