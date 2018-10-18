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
    public class DrugUseRisksController : Controller
    {
        private readonly ArchpointContext _context;

        public DrugUseRisksController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: DrugUseRisks
        public async Task<IActionResult> Index()
        {
            return View(await _context.DrugUseRisk.ToListAsync());
        }

        // GET: DrugUseRisks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drugUseRisk = await _context.DrugUseRisk
                .FirstOrDefaultAsync(m => m.DrugUseRiskId == id);
            if (drugUseRisk == null)
            {
                return NotFound();
            }

            return View(drugUseRisk);
        }

        // GET: DrugUseRisks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DrugUseRisks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DrugUseRiskId,RecreationalDrugUser,FrequencyUsed,YearsUsed,YearsQuit,DrugsCausedLifeProblems,DrugsCausedProblemsExpl,TreatedForDrugAbuse,YearTreated,TreatmentLength,TypeOfTreatment,Comments")] DrugUseRisk drugUseRisk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drugUseRisk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drugUseRisk);
        }

        // GET: DrugUseRisks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drugUseRisk = await _context.DrugUseRisk.FindAsync(id);
            if (drugUseRisk == null)
            {
                return NotFound();
            }
            return View(drugUseRisk);
        }

        // POST: DrugUseRisks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DrugUseRiskId,RecreationalDrugUser,FrequencyUsed,YearsUsed,YearsQuit,DrugsCausedLifeProblems,DrugsCausedProblemsExpl,TreatedForDrugAbuse,YearTreated,TreatmentLength,TypeOfTreatment,Comments")] DrugUseRisk drugUseRisk)
        {
            if (id != drugUseRisk.DrugUseRiskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drugUseRisk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrugUseRiskExists(drugUseRisk.DrugUseRiskId))
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
            return View(drugUseRisk);
        }

        // GET: DrugUseRisks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drugUseRisk = await _context.DrugUseRisk
                .FirstOrDefaultAsync(m => m.DrugUseRiskId == id);
            if (drugUseRisk == null)
            {
                return NotFound();
            }

            return View(drugUseRisk);
        }

        // POST: DrugUseRisks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var drugUseRisk = await _context.DrugUseRisk.FindAsync(id);
            _context.DrugUseRisk.Remove(drugUseRisk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrugUseRiskExists(int id)
        {
            return _context.DrugUseRisk.Any(e => e.DrugUseRiskId == id);
        }
    }
}
