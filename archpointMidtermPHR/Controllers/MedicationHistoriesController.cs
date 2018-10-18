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
    public class MedicationHistoriesController : Controller
    {
        private readonly ArchpointContext _context;

        public MedicationHistoriesController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: MedicationHistories
        public async Task<IActionResult> Index()
        {
            var archpointContext = _context.MedicationHistory.Include(m => m.MedProvider);
            return View(await archpointContext.ToListAsync());
        }

        // GET: MedicationHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicationHistory = await _context.MedicationHistory
                .Include(m => m.MedProvider)
                .FirstOrDefaultAsync(m => m.MedicationId == id);
            if (medicationHistory == null)
            {
                return NotFound();
            }

            return View(medicationHistory);
        }

        // GET: MedicationHistories/Create
        public IActionResult Create()
        {
            ViewData["MedProviderId"] = new SelectList(_context.MedicalProvider, "MedProviderId", "ActiveOrInactive");
            return View();
        }

        // POST: MedicationHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MedicationId,MedicationName,MedStrength,MedDosage,MedFrequency,ConditionBeingTreated,DrugStatus,DateStarted,DateStopped,MedProviderId,PharmacyUsed,PharmacyNumber,PrescriptionNumber,Refills,OtcDrugs,VitaminsAndSupplements,CommentsDirections")] MedicationHistory medicationHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicationHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MedProviderId"] = new SelectList(_context.MedicalProvider, "MedProviderId", "ActiveOrInactive", medicationHistory.MedProviderId);
            return View(medicationHistory);
        }

        // GET: MedicationHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicationHistory = await _context.MedicationHistory.FindAsync(id);
            if (medicationHistory == null)
            {
                return NotFound();
            }
            ViewData["MedProviderId"] = new SelectList(_context.MedicalProvider, "MedProviderId", "ActiveOrInactive", medicationHistory.MedProviderId);
            return View(medicationHistory);
        }

        // POST: MedicationHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MedicationId,MedicationName,MedStrength,MedDosage,MedFrequency,ConditionBeingTreated,DrugStatus,DateStarted,DateStopped,MedProviderId,PharmacyUsed,PharmacyNumber,PrescriptionNumber,Refills,OtcDrugs,VitaminsAndSupplements,CommentsDirections")] MedicationHistory medicationHistory)
        {
            if (id != medicationHistory.MedicationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicationHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicationHistoryExists(medicationHistory.MedicationId))
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
            ViewData["MedProviderId"] = new SelectList(_context.MedicalProvider, "MedProviderId", "ActiveOrInactive", medicationHistory.MedProviderId);
            return View(medicationHistory);
        }

        // GET: MedicationHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicationHistory = await _context.MedicationHistory
                .Include(m => m.MedProvider)
                .FirstOrDefaultAsync(m => m.MedicationId == id);
            if (medicationHistory == null)
            {
                return NotFound();
            }

            return View(medicationHistory);
        }

        // POST: MedicationHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medicationHistory = await _context.MedicationHistory.FindAsync(id);
            _context.MedicationHistory.Remove(medicationHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicationHistoryExists(int id)
        {
            return _context.MedicationHistory.Any(e => e.MedicationId == id);
        }
    }
}
