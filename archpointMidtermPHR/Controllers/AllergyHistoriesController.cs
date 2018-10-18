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
    public class AllergyHistoriesController : Controller
    {
        private readonly ArchpointContext _context;

        public AllergyHistoriesController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: AllergyHistories
        public async Task<IActionResult> Index()
        {
            return View(await _context.AllergyHistory.ToListAsync());
        }

        // GET: AllergyHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allergyHistory = await _context.AllergyHistory
                .FirstOrDefaultAsync(m => m.AllergyHistoryId == id);
            if (allergyHistory == null)
            {
                return NotFound();
            }

            return View(allergyHistory);
        }

        // GET: AllergyHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AllergyHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AllergyHistoryId,DrugAllergen,ContactAllergen,InsectStingBites,AirborneInhaledAllergen,TypeOfReaction,Severity,Symptoms,MedTreatmentRequired,Comments")] AllergyHistory allergyHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(allergyHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(allergyHistory);
        }

        // GET: AllergyHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allergyHistory = await _context.AllergyHistory.FindAsync(id);
            if (allergyHistory == null)
            {
                return NotFound();
            }
            return View(allergyHistory);
        }

        // POST: AllergyHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AllergyHistoryId,DrugAllergen,ContactAllergen,InsectStingBites,AirborneInhaledAllergen,TypeOfReaction,Severity,Symptoms,MedTreatmentRequired,Comments")] AllergyHistory allergyHistory)
        {
            if (id != allergyHistory.AllergyHistoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(allergyHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AllergyHistoryExists(allergyHistory.AllergyHistoryId))
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
            return View(allergyHistory);
        }

        // GET: AllergyHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allergyHistory = await _context.AllergyHistory
                .FirstOrDefaultAsync(m => m.AllergyHistoryId == id);
            if (allergyHistory == null)
            {
                return NotFound();
            }

            return View(allergyHistory);
        }

        // POST: AllergyHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var allergyHistory = await _context.AllergyHistory.FindAsync(id);
            _context.AllergyHistory.Remove(allergyHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AllergyHistoryExists(int id)
        {
            return _context.AllergyHistory.Any(e => e.AllergyHistoryId == id);
        }
    }
}
