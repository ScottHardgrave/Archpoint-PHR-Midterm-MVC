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
    public class DiabetesRisksController : Controller
    {
        private readonly ArchpointContext _context;

        public DiabetesRisksController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: DiabetesRisks
        public async Task<IActionResult> Index()
        {
            return View(await _context.DiabetesRisk.ToListAsync());
        }

        // GET: DiabetesRisks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diabetesRisk = await _context.DiabetesRisk
                .FirstOrDefaultAsync(m => m.DiabetesRiskId == id);
            if (diabetesRisk == null)
            {
                return NotFound();
            }

            return View(diabetesRisk);
        }

        // GET: DiabetesRisks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DiabetesRisks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DiabetesRiskId,DateTaken,LevelBeforeBreakfast,LevelAfterBreakfast,LeverlBeforeLunch,LevelAfterLunch,LevelBeforeDinner,LevelAfterDinner,LevelAtBedtime,Medications,TargertGlucoseBeforeMealLow,TargetGlucoseAfterMealHigh,TargetGlucoseRangeAfterMealLow,TargetGlucoseRangeAfterMealHigh,DateSpan,Comments")] DiabetesRisk diabetesRisk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diabetesRisk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diabetesRisk);
        }

        // GET: DiabetesRisks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diabetesRisk = await _context.DiabetesRisk.FindAsync(id);
            if (diabetesRisk == null)
            {
                return NotFound();
            }
            return View(diabetesRisk);
        }

        // POST: DiabetesRisks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DiabetesRiskId,DateTaken,LevelBeforeBreakfast,LevelAfterBreakfast,LeverlBeforeLunch,LevelAfterLunch,LevelBeforeDinner,LevelAfterDinner,LevelAtBedtime,Medications,TargertGlucoseBeforeMealLow,TargetGlucoseAfterMealHigh,TargetGlucoseRangeAfterMealLow,TargetGlucoseRangeAfterMealHigh,DateSpan,Comments")] DiabetesRisk diabetesRisk)
        {
            if (id != diabetesRisk.DiabetesRiskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diabetesRisk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiabetesRiskExists(diabetesRisk.DiabetesRiskId))
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
            return View(diabetesRisk);
        }

        // GET: DiabetesRisks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diabetesRisk = await _context.DiabetesRisk
                .FirstOrDefaultAsync(m => m.DiabetesRiskId == id);
            if (diabetesRisk == null)
            {
                return NotFound();
            }

            return View(diabetesRisk);
        }

        // POST: DiabetesRisks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diabetesRisk = await _context.DiabetesRisk.FindAsync(id);
            _context.DiabetesRisk.Remove(diabetesRisk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiabetesRiskExists(int id)
        {
            return _context.DiabetesRisk.Any(e => e.DiabetesRiskId == id);
        }
    }
}
