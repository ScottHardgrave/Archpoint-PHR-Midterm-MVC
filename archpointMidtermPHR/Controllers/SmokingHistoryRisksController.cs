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
    public class SmokingHistoryRisksController : Controller
    {
        private readonly ArchpointContext _context;

        public SmokingHistoryRisksController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: SmokingHistoryRisks
        public async Task<IActionResult> Index()
        {
            return View(await _context.SmokingHistoryRisk.ToListAsync());
        }

        // GET: SmokingHistoryRisks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smokingHistoryRisk = await _context.SmokingHistoryRisk
                .FirstOrDefaultAsync(m => m.SmokingHistRiskId == id);
            if (smokingHistoryRisk == null)
            {
                return NotFound();
            }

            return View(smokingHistoryRisk);
        }

        // GET: SmokingHistoryRisks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SmokingHistoryRisks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SmokingHistRiskId,Smoker,AgeStarted,AgeQuit,ChewingSmokelessTobacco,QuittingGoal")] SmokingHistoryRisk smokingHistoryRisk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(smokingHistoryRisk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(smokingHistoryRisk);
        }

        // GET: SmokingHistoryRisks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smokingHistoryRisk = await _context.SmokingHistoryRisk.FindAsync(id);
            if (smokingHistoryRisk == null)
            {
                return NotFound();
            }
            return View(smokingHistoryRisk);
        }

        // POST: SmokingHistoryRisks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SmokingHistRiskId,Smoker,AgeStarted,AgeQuit,ChewingSmokelessTobacco,QuittingGoal")] SmokingHistoryRisk smokingHistoryRisk)
        {
            if (id != smokingHistoryRisk.SmokingHistRiskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(smokingHistoryRisk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SmokingHistoryRiskExists(smokingHistoryRisk.SmokingHistRiskId))
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
            return View(smokingHistoryRisk);
        }

        // GET: SmokingHistoryRisks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smokingHistoryRisk = await _context.SmokingHistoryRisk
                .FirstOrDefaultAsync(m => m.SmokingHistRiskId == id);
            if (smokingHistoryRisk == null)
            {
                return NotFound();
            }

            return View(smokingHistoryRisk);
        }

        // POST: SmokingHistoryRisks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var smokingHistoryRisk = await _context.SmokingHistoryRisk.FindAsync(id);
            _context.SmokingHistoryRisk.Remove(smokingHistoryRisk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SmokingHistoryRiskExists(int id)
        {
            return _context.SmokingHistoryRisk.Any(e => e.SmokingHistRiskId == id);
        }
    }
}
