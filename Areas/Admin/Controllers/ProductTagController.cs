using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBazar.Data;
using OnlineBazar.Models;

namespace OnlineBazar.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTagController : Controller
    {
        private ApplicationDbContext _db;
        public ProductTagController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var data = _db.SpecialTags.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SpecialTag ProTag)
        {
            if (ModelState.IsValid)
            {
                _db.SpecialTags.Add(ProTag);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ProTag);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ProType = _db.SpecialTags.Find(id);
            if (ProType == null)
            {
                return NotFound();
            }
            return View(ProType);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SpecialTag ProTag)
        {
            if (ModelState.IsValid)
            {
                _db.SpecialTags.Update(ProTag);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ProType = _db.SpecialTags.Find(id);
            if (ProType == null)
            {
                return NotFound();
            }
            return View(ProType);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(SpecialTag ProTag)
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ProType = _db.SpecialTags.Find(id);
            if (ProType == null)
            {
                return NotFound();
            }
            return View(ProType);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(SpecialTag ProTag)
        {
            if (ModelState.IsValid)
            {
                _db.SpecialTags.Remove(ProTag);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}