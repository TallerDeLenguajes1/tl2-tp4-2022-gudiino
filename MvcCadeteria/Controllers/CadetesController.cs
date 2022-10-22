using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcCadeteria.Models;

namespace MvcCadeteria.Controllers
{
    public class CadetesController : Controller
    {
        private readonly MvcCadeteriaContext _context;

        public CadetesController(MvcCadeteriaContext context)
        {
            _context = context;
        }

        // GET: Cadetes
        public async Task<IActionResult> Index()
        {
              return _context.Cadete != null ? 
                          View(await _context.Cadete.ToListAsync()) :
                          Problem("Entity set 'MvcCadeteriaContext.Cadete'  is null.");
        }

        // GET: Cadetes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cadete == null)
            {
                return NotFound();
            }

            var cadete = await _context.Cadete
                .FirstOrDefaultAsync(m => m.id == id);
            if (cadete == null)
            {
                return NotFound();
            }

            return View(cadete);
        }

        // GET: Cadetes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cadetes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nombre,calle,numero,telefono")] Cadete cadete)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadete);
        }

        // GET: Cadetes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cadete == null)
            {
                return NotFound();
            }

            var cadete = await _context.Cadete.FindAsync(id);
            if (cadete == null)
            {
                return NotFound();
            }
            return View(cadete);
        }

        // POST: Cadetes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nombre,calle,numero,telefono")] Cadete cadete)
        {
            if (id != cadete.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadete);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadeteExists(cadete.id))
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
            return View(cadete);
        }

        // GET: Cadetes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cadete == null)
            {
                return NotFound();
            }

            var cadete = await _context.Cadete
                .FirstOrDefaultAsync(m => m.id == id);
            if (cadete == null)
            {
                return NotFound();
            }

            return View(cadete);
        }

        // POST: Cadetes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cadete == null)
            {
                return Problem("Entity set 'MvcCadeteriaContext.Cadete'  is null.");
            }
            var cadete = await _context.Cadete.FindAsync(id);
            if (cadete != null)
            {
                _context.Cadete.Remove(cadete);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadeteExists(int id)
        {
          return (_context.Cadete?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
