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
    public class CholesterolRisksController : Controller
    {
        private readonly ArchpointContext _context;

        public CholesterolRisksController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: CholesterolRisks
        public async Task<IActionResult> Index()
        {
            return View(await _context.CholesterolRisk.ToListAsync());
        }

        // GET: CholesterolRisks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cholesterolRisk = await _context.CholesterolRisk
                .FirstOrDefaultAsync(m => m.CholesterolRiskId == id);
            if (cholesterolRisk == null)
            {
                return NotFound();
            }

            return View(cholesterolRisk);
        }

        // GET: CholesterolRisks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CholesterolRisks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CholesterolRiskId,DateCholTaken,TotalCholesterol,LdlCholesterol,HdlCholesterol,Triglycerides,TakenAfterFasting,TotalCholGoal,LdlCholGoal,HdlCholGoal,TriglycerideGoal,Comments")] CholesterolRisk cholesterolRisk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cholesterolRisk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cholesterolRisk);
        }

        // GET: CholesterolRisks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cholesterolRisk = await _context.CholesterolRisk.FindAsync(id);
            if (cholesterolRisk == null)
            {
                return NotFound();
            }
            return View(cholesterolRisk);
        }

        // POST: CholesterolRisks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CholesterolRiskId,DateCholTaken,TotalCholesterol,LdlCholesterol,HdlCholesterol,Triglycerides,TakenAfterFasting,TotalCholGoal,LdlCholGoal,HdlCholGoal,TriglycerideGoal,Comments")] CholesterolRisk cholesterolRisk)
        {
            if (id != cholesterolRisk.CholesterolRiskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cholesterolRisk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CholesterolRiskExists(cholesterolRisk.CholesterolRiskId))
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
            return View(cholesterolRisk);
        }

        // GET: CholesterolRisks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cholesterolRisk = await _context.CholesterolRisk
                .FirstOrDefaultAsync(m => m.CholesterolRiskId == id);
            if (cholesterolRisk == null)
            {
                return NotFound();
            }

            return View(cholesterolRisk);
        }

        // POST: CholesterolRisks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cholesterolRisk = await _context.CholesterolRisk.FindAsync(id);
            _context.CholesterolRisk.Remove(cholesterolRisk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CholesterolRiskExists(int id)
        {
            return _context.CholesterolRisk.Any(e => e.CholesterolRiskId == id);
        }
    }
}
