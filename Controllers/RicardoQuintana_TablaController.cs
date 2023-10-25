using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RicardoQuintana_ExamenP1.Data;
using RicardoQuintana_ExamenP1.Models;

namespace RicardoQuintana_ExamenP1.Controllers
{
    public class RicardoQuintana_TablaController : Controller
    {
        private readonly RicardoQuintana_ExamenP1Context _context;

        public RicardoQuintana_TablaController(RicardoQuintana_ExamenP1Context context)
        {
            _context = context;
        }

        // GET: RicardoQuintana_Tabla
        public async Task<IActionResult> Index()
        {
              return _context.RicardoQuintana_Tabla != null ? 
                          View(await _context.RicardoQuintana_Tabla.ToListAsync()) :
                          Problem("Entity set 'RicardoQuintana_ExamenP1Context.RicardoQuintana_Tabla'  is null.");
        }

        // GET: RicardoQuintana_Tabla/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RicardoQuintana_Tabla == null)
            {
                return NotFound();
            }

            var ricardoQuintana_Tabla = await _context.RicardoQuintana_Tabla
                .FirstOrDefaultAsync(m => m.id == id);
            if (ricardoQuintana_Tabla == null)
            {
                return NotFound();
            }

            return View(ricardoQuintana_Tabla);
        }

        // GET: RicardoQuintana_Tabla/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RicardoQuintana_Tabla/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,description")] RicardoQuintana_Tabla ricardoQuintana_Tabla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ricardoQuintana_Tabla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ricardoQuintana_Tabla);
        }

        // GET: RicardoQuintana_Tabla/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RicardoQuintana_Tabla == null)
            {
                return NotFound();
            }

            var ricardoQuintana_Tabla = await _context.RicardoQuintana_Tabla.FindAsync(id);
            if (ricardoQuintana_Tabla == null)
            {
                return NotFound();
            }
            return View(ricardoQuintana_Tabla);
        }

        // POST: RicardoQuintana_Tabla/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,description")] RicardoQuintana_Tabla ricardoQuintana_Tabla)
        {
            if (id != ricardoQuintana_Tabla.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ricardoQuintana_Tabla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RicardoQuintana_TablaExists(ricardoQuintana_Tabla.id))
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
            return View(ricardoQuintana_Tabla);
        }

        // GET: RicardoQuintana_Tabla/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RicardoQuintana_Tabla == null)
            {
                return NotFound();
            }

            var ricardoQuintana_Tabla = await _context.RicardoQuintana_Tabla
                .FirstOrDefaultAsync(m => m.id == id);
            if (ricardoQuintana_Tabla == null)
            {
                return NotFound();
            }

            return View(ricardoQuintana_Tabla);
        }

        // POST: RicardoQuintana_Tabla/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RicardoQuintana_Tabla == null)
            {
                return Problem("Entity set 'RicardoQuintana_ExamenP1Context.RicardoQuintana_Tabla'  is null.");
            }
            var ricardoQuintana_Tabla = await _context.RicardoQuintana_Tabla.FindAsync(id);
            if (ricardoQuintana_Tabla != null)
            {
                _context.RicardoQuintana_Tabla.Remove(ricardoQuintana_Tabla);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RicardoQuintana_TablaExists(int id)
        {
          return (_context.RicardoQuintana_Tabla?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
