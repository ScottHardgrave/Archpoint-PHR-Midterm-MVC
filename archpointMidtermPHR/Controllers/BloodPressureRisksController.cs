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
    public class BloodPressureRisksController : Controller
    {
        private readonly ArchpointContext _context;

        public BloodPressureRisksController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: BloodPressureRisks
        public async Task<IActionResult> Index()
        {
            return View(await _context.BloodPressureRisk.ToListAsync());
        }

        // GET: BloodPressureRisks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloodPressureRisk = await _context.BloodPressureRisk
                .FirstOrDefaultAsync(m => m.BloodPressureRiskId == id);
            if (bloodPressureRisk == null)
            {
                return NotFound();
            }

            return View(bloodPressureRisk);
        }

        // GET: BloodPressureRisks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BloodPressureRisks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BloodPressureRiskId,DateDateEntered,SystolicPressure,DiastolicPressure,PulseRate,DateTaken,TimeTaken,SystolicBpgoal,DiastolicBpgoal,Comments")] BloodPressureRisk bloodPressureRisk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bloodPressureRisk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bloodPressureRisk);
        }

        // GET: BloodPressureRisks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloodPressureRisk = await _context.BloodPressureRisk.FindAsync(id);
            if (bloodPressureRisk == null)
            {
                return NotFound();
            }
            return View(bloodPressureRisk);
        }

        // POST: BloodPressureRisks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BloodPressureRiskId,DateDateEntered,SystolicPressure,DiastolicPressure,PulseRate,DateTaken,TimeTaken,SystolicBpgoal,DiastolicBpgoal,Comments")] BloodPressureRisk bloodPressureRisk)
        {
            if (id != bloodPressureRisk.BloodPressureRiskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bloodPressureRisk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BloodPressureRiskExists(bloodPressureRisk.BloodPressureRiskId))
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
            return View(bloodPressureRisk);
        }

        // GET: BloodPressureRisks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloodPressureRisk = await _context.BloodPressureRisk
                .FirstOrDefaultAsync(m => m.BloodPressureRiskId == id);
            if (bloodPressureRisk == null)
            {
                return NotFound();
            }

            return View(bloodPressureRisk);
        }

        // POST: BloodPressureRisks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bloodPressureRisk = await _context.BloodPressureRisk.FindAsync(id);
            _context.BloodPressureRisk.Remove(bloodPressureRisk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BloodPressureRiskExists(int id)
        {
            return _context.BloodPressureRisk.Any(e => e.BloodPressureRiskId == id);
        }
    }
}
