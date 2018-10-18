using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using archpointMidtermPHR.Models;

namespace archpointMidtermPHR.Controllers
{
    public class ImmunizationsController : Controller
    {
        private readonly ArchpointContext _context;

        public ImmunizationsController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: Immunizations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Immunizations.ToListAsync());
        }

        // GET: Immunizations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var immunizations = await _context.Immunizations
                .FirstOrDefaultAsync(m => m.ImmunizationId == id);
            if (immunizations == null)
            {
                return NotFound();
            }

            return View(immunizations);
        }

        // GET: Immunizations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Immunizations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ImmunizationId,ImmunizationType,DateReceived,AdministeredBy,DateLastTetanus,Comments")] Immunizations immunizations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(immunizations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(immunizations);
        }

        // GET: Immunizations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var immunizations = await _context.Immunizations.FindAsync(id);
            if (immunizations == null)
            {
                return NotFound();
            }
            return View(immunizations);
        }

        // POST: Immunizations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ImmunizationId,ImmunizationType,DateReceived,AdministeredBy,DateLastTetanus,Comments")] Immunizations immunizations)
        {
            if (id != immunizations.ImmunizationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(immunizations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImmunizationsExists(immunizations.ImmunizationId))
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
            return View(immunizations);
        }

        // GET: Immunizations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var immunizations = await _context.Immunizations
                .FirstOrDefaultAsync(m => m.ImmunizationId == id);
            if (immunizations == null)
            {
                return NotFound();
            }

            return View(immunizations);
        }

        // POST: Immunizations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var immunizations = await _context.Immunizations.FindAsync(id);
            _context.Immunizations.Remove(immunizations);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImmunizationsExists(int id)
        {
            return _context.Immunizations.Any(e => e.ImmunizationId == id);
        }
    }
}
