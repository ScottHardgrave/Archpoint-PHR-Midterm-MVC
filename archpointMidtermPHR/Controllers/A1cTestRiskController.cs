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
    public class A1cTestRiskController : Controller
    {
        private readonly ArchpointContext _context;

        public A1cTestRiskController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: A1cTestRisk
        public async Task<IActionResult> Index()
        {
            return View(await _context.A1cTestRisk.ToListAsync());
        }

        // GET: A1cTestRisk/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var a1cTestRisk = await _context.A1cTestRisk
                .FirstOrDefaultAsync(m => m.A1cTestRiskId == id);
            if (a1cTestRisk == null)
            {
                return NotFound();
            }

            return View(a1cTestRisk);
        }

        // GET: A1cTestRisk/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: A1cTestRisk/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("A1cTestRiskId,DateEntered,DateTested,A1cTestResults,A1cTargetRangeGoal,Comments")] A1cTestRisk a1cTestRisk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(a1cTestRisk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(a1cTestRisk);
        }

        // GET: A1cTestRisk/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var a1cTestRisk = await _context.A1cTestRisk.FindAsync(id);
            if (a1cTestRisk == null)
            {
                return NotFound();
            }
            return View(a1cTestRisk);
        }

        // POST: A1cTestRisk/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("A1cTestRiskId,DateEntered,DateTested,A1cTestResults,A1cTargetRangeGoal,Comments")] A1cTestRisk a1cTestRisk)
        {
            if (id != a1cTestRisk.A1cTestRiskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(a1cTestRisk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!A1cTestRiskExists(a1cTestRisk.A1cTestRiskId))
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
            return View(a1cTestRisk);
        }

        // GET: A1cTestRisk/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var a1cTestRisk = await _context.A1cTestRisk
                .FirstOrDefaultAsync(m => m.A1cTestRiskId == id);
            if (a1cTestRisk == null)
            {
                return NotFound();
            }

            return View(a1cTestRisk);
        }

        // POST: A1cTestRisk/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var a1cTestRisk = await _context.A1cTestRisk.FindAsync(id);
            _context.A1cTestRisk.Remove(a1cTestRisk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool A1cTestRiskExists(int id)
        {
            return _context.A1cTestRisk.Any(e => e.A1cTestRiskId == id);
        }
    }
}
