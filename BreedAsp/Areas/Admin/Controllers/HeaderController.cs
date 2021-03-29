using BreedAsp.Data;
using BreedAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreedAsp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HeaderController : Controller
    {
        private readonly DataContext _context;
        public HeaderController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var header = _context.Headers.ToList();
            return View(header);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            Header header = _context.Headers.FirstOrDefault(x => x.Id == id);
            if (header == null)
            {
                return NotFound();
            }
            return View(header);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Header header)
        {
            if (!ModelState.IsValid)
            {
                return View(header);
            }
            _context.Headers.Update(header);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
