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
        [HttpPost]
        public IActionResult Index(decimal? Lowamount,decimal? Largeamount)
        {
            var data = _db.Products.Include(c => c.ProductType).Include(c => c.SpecialTag)
                .Where(c => c.Price >= Lowamount && c.Price <= Largeamount).ToList();
            if (Lowamount == null || Largeamount==null)
            {
                data = _db.Products.Include(c => c.ProductType).Include(c => c.SpecialTag)
                .ToList();
                
            }
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
                var SrchProduct = _db.Products.FirstOrDefault(c => c.ProductName == products.ProductName);
                if (SrchProduct != null)
                {
                    ViewBag.message = "This product is alreaady Exists";
                    ViewData["ProSelect"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductTypeName");
                    ViewData["ProTagSelect"] = new SelectList(_db.SpecialTags.ToList(), "Id", "SpecialTagName");
                    return View(products);
                }
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
            return View(products);
        }
        //Edit
        [HttpGet]
        public IActionResult Edit(int? id)
        {

            ViewData["ProSelect"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductTypeName");
            ViewData["ProTagSelect"] = new SelectList(_db.SpecialTags.ToList(), "Id", "SpecialTagName");
            if (id == null)
            {
                return NotFound();
            }
            var products = _db.Products.Include(c => c.ProductType).Include(c => c.SpecialTag).FirstOrDefault(c => c.Id == id);
            if (products == null)
            {
                return NotFound();
            }
            return View(products);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Products products,IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    var name = Path.Combine(_hoe.WebRootPath + "/images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "images/" + image.FileName;
                }
                _db.Products.Update(products);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        //Delete
        [HttpGet]
        public IActionResult Delete(int? id)
        {

            ViewData["ProSelect"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductTypeName");
            ViewData["ProTagSelect"] = new SelectList(_db.SpecialTags.ToList(), "Id", "SpecialTagName");
            if (id == null)
            {
                return NotFound();
            }
            var products = _db.Products.Include(c => c.ProductType).Include(c => c.SpecialTag).FirstOrDefault(c => c.Id == id);
            if (products == null)
            {
                return NotFound();
            }
            return View(products);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Products products, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    var name = Path.Combine(_hoe.WebRootPath + "/images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "images/" + image.FileName;
                }
                _db.Products.Remove(products);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        //Details
        [HttpGet]
        public IActionResult Details(int? id)
        {

            ViewData["ProSelect"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductTypeName");
            ViewData["ProTagSelect"] = new SelectList(_db.SpecialTags.ToList(), "Id", "SpecialTagName");
            if (id == null)
            {
                return NotFound();
            }
            var products = _db.Products.Include(c => c.ProductType).Include(c => c.SpecialTag).FirstOrDefault(c => c.Id == id);
            if (products == null)
            {
                return NotFound();
            }
            return View(products);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(Products products, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    var name = Path.Combine(_hoe.WebRootPath + "/images", Path.GetFileName(image.FileName));
                     image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "images/" + image.FileName;
                }
                
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}