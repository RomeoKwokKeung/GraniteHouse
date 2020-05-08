using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraniteHouse.Data;
using GraniteHouse.Models;
using GraniteHouse.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GraniteHouse.Areas.Admin.Controllers
{
    [Authorize(Roles = (SD.AdminEndUser + "," + SD.SuperAdminEndUser))]
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        //dependecy injection
        private readonly ApplicationDbContext _db;

        public ProductTypesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.ProductTypes.ToList());
        }

        //Get Create action method
        public IActionResult Create()
        {
            return View();
        }

        //Post Create action method
        [HttpPost]
        //check if it is valid, to prevent hacker or something input wrong
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductTypes productTypes)
        {
            //check the validation, e.g. [Required] from Models Folder
            if (ModelState.IsValid)
            {
                _db.Add(productTypes);
                //we use anysc so we have to use await
                await _db.SaveChangesAsync();
                //avoid spelling mistakes
                return RedirectToAction(nameof(Index));
            }
            return View(productTypes);
        }

        //Get Edit action method
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productType = await _db.ProductTypes.FindAsync(id);

            if (productType == null)
            {
                return NotFound();
            }

            return View(productType);
        }

        //Post Edit action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductTypes productTypes)
        {
            //if wrong id
            if (id != productTypes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(productTypes);
                await _db.SaveChangesAsync();
                //avoid spelling mistakes
                return RedirectToAction(nameof(Index));
            }
            return View(productTypes);
        }

        //Get Details action method
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productType = await _db.ProductTypes.FindAsync(id);
            if (productType == null)
            {
                return NotFound();
            }

            return View(productType);
        }

        //Get Delete action method, same as Details and Edit get method
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productType = await _db.ProductTypes.FindAsync(id);
            if (productType == null)
            {
                return NotFound();
            }

            return View(productType);
        }

        //Post Delete action method
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productTypes = await _db.ProductTypes.FindAsync(id);
            _db.ProductTypes.Remove(productTypes);
            await _db.SaveChangesAsync();
            //avoid spelling mistakes
            return RedirectToAction(nameof(Index));
        }
    }
}