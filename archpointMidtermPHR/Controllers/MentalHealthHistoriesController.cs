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
    public class MentalHealthHistoriesController : Controller
    {
        private readonly ArchpointContext _context;

        public MentalHealthHistoriesController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: MentalHealthHistories
        public async Task<IActionResult> Index()
        {
            var archpointContext = _context.MentalHealthHistory.Include(m => m.MedProvider);
            return View(await archpointContext.ToListAsync());
        }

        // GET: MentalHealthHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mentalHealthHistory = await _context.MentalHealthHistory
                .Include(m => m.MedProvider)
                .FirstOrDefaultAsync(m => m.MentalHealthHistoryId == id);
            if (mentalHealthHistory == null)
            {
                return NotFound();
            }

            return View(mentalHealthHistory);
        }

        // GET: MentalHealthHistories/Create
        public IActionResult Create()
        {
            ViewData["MedProviderId"] = new SelectList(_context.MedicalProvider, "MedProviderId", "ActiveOrInactive");
            return View();
        }

        // POST: MentalHealthHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MentalHealthHistoryId,CurrentTreatmentForMentalDisorder,MedCareLocation,TypeOfTreatment,TreatedInThePast,MentalCondDisorder,CurrentMedication,MedProviderId,Comments")] MentalHealthHistory mentalHealthHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mentalHealthHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MedProviderId"] = new SelectList(_context.MedicalProvider, "MedProviderId", "ActiveOrInactive", mentalHealthHistory.MedProviderId);
            return View(mentalHealthHistory);
        }

        // GET: MentalHealthHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mentalHealthHistory = await _context.MentalHealthHistory.FindAsync(id);
            if (mentalHealthHistory == null)
            {
                return NotFound();
            }
            ViewData["MedProviderId"] = new SelectList(_context.MedicalProvider, "MedProviderId", "ActiveOrInactive", mentalHealthHistory.MedProviderId);
            return View(mentalHealthHistory);
        }

        // POST: MentalHealthHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MentalHealthHistoryId,CurrentTreatmentForMentalDisorder,MedCareLocation,TypeOfTreatment,TreatedInThePast,MentalCondDisorder,CurrentMedication,MedProviderId,Comments")] MentalHealthHistory mentalHealthHistory)
        {
            if (id != mentalHealthHistory.MentalHealthHistoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mentalHealthHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MentalHealthHistoryExists(mentalHealthHistory.MentalHealthHistoryId))
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
            ViewData["MedProviderId"] = new SelectList(_context.MedicalProvider, "MedProviderId", "ActiveOrInactive", mentalHealthHistory.MedProviderId);
            return View(mentalHealthHistory);
        }

        // GET: MentalHealthHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mentalHealthHistory = await _context.MentalHealthHistory
                .Include(m => m.MedProvider)
                .FirstOrDefaultAsync(m => m.MentalHealthHistoryId == id);
            if (mentalHealthHistory == null)
            {
                return NotFound();
            }

            return View(mentalHealthHistory);
        }

        // POST: MentalHealthHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mentalHealthHistory = await _context.MentalHealthHistory.FindAsync(id);
            _context.MentalHealthHistory.Remove(mentalHealthHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MentalHealthHistoryExists(int id)
        {
            return _context.MentalHealthHistory.Any(e => e.MentalHealthHistoryId == id);
        }
    }
}
