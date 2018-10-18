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
    public class TravelHealthsController : Controller
    {
        private readonly ArchpointContext _context;

        public TravelHealthsController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: TravelHealths
        public async Task<IActionResult> Index()
        {
            return View(await _context.TravelHealth.ToListAsync());
        }

        // GET: TravelHealths/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelHealth = await _context.TravelHealth
                .FirstOrDefaultAsync(m => m.TravelHealthId == id);
            if (travelHealth == null)
            {
                return NotFound();
            }

            return View(travelHealth);
        }

        // GET: TravelHealths/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TravelHealths/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TravelHealthId,CountryVisited,DateVisited,DiseaseIllnessContracted,DateContracted,Comments")] TravelHealth travelHealth)
        {
            if (ModelState.IsValid)
            {
                _context.Add(travelHealth);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(travelHealth);
        }

        // GET: TravelHealths/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelHealth = await _context.TravelHealth.FindAsync(id);
            if (travelHealth == null)
            {
                return NotFound();
            }
            return View(travelHealth);
        }

        // POST: TravelHealths/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TravelHealthId,CountryVisited,DateVisited,DiseaseIllnessContracted,DateContracted,Comments")] TravelHealth travelHealth)
        {
            if (id != travelHealth.TravelHealthId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(travelHealth);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelHealthExists(travelHealth.TravelHealthId))
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
            return View(travelHealth);
        }

        // GET: TravelHealths/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelHealth = await _context.TravelHealth
                .FirstOrDefaultAsync(m => m.TravelHealthId == id);
            if (travelHealth == null)
            {
                return NotFound();
            }

            return View(travelHealth);
        }

        // POST: TravelHealths/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var travelHealth = await _context.TravelHealth.FindAsync(id);
            _context.TravelHealth.Remove(travelHealth);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelHealthExists(int id)
        {
            return _context.TravelHealth.Any(e => e.TravelHealthId == id);
        }
    }
}
