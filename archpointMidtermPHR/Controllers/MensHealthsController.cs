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
    public class MensHealthsController : Controller
    {
        private readonly ArchpointContext _context;

        public MensHealthsController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: MensHealths
        public async Task<IActionResult> Index()
        {
            return View(await _context.MensHealth.ToListAsync());
        }

        // GET: MensHealths/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensHealth = await _context.MensHealth
                .FirstOrDefaultAsync(m => m.MensHealthHistoryId == id);
            if (mensHealth == null)
            {
                return NotFound();
            }

            return View(mensHealth);
        }

        // GET: MensHealths/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MensHealths/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MensHealthHistoryId,DateLastAnnualPhysical,DateNextAnnualPhysical,FamilyHistoryProstateCancer,DateLastProstateExam,LastProstateExamResults,DateNextProstateExam,DateLastPsa,LastPsaresults,PsaLevelTestNumber,DateNextPsatest,DateLastFecalOccultTest,FecalOccultResults,DateNextFecalOccultTest,DateLastSigmoidColonoscopyExam,SigmoidColonoscopyResults,DateNextSigmoidColonoscopy,MensHealthIssues,Comments")] MensHealth mensHealth)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mensHealth);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mensHealth);
        }

        // GET: MensHealths/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensHealth = await _context.MensHealth.FindAsync(id);
            if (mensHealth == null)
            {
                return NotFound();
            }
            return View(mensHealth);
        }

        // POST: MensHealths/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MensHealthHistoryId,DateLastAnnualPhysical,DateNextAnnualPhysical,FamilyHistoryProstateCancer,DateLastProstateExam,LastProstateExamResults,DateNextProstateExam,DateLastPsa,LastPsaresults,PsaLevelTestNumber,DateNextPsatest,DateLastFecalOccultTest,FecalOccultResults,DateNextFecalOccultTest,DateLastSigmoidColonoscopyExam,SigmoidColonoscopyResults,DateNextSigmoidColonoscopy,MensHealthIssues,Comments")] MensHealth mensHealth)
        {
            if (id != mensHealth.MensHealthHistoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mensHealth);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MensHealthExists(mensHealth.MensHealthHistoryId))
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
            return View(mensHealth);
        }

        // GET: MensHealths/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensHealth = await _context.MensHealth
                .FirstOrDefaultAsync(m => m.MensHealthHistoryId == id);
            if (mensHealth == null)
            {
                return NotFound();
            }

            return View(mensHealth);
        }

        // POST: MensHealths/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mensHealth = await _context.MensHealth.FindAsync(id);
            _context.MensHealth.Remove(mensHealth);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MensHealthExists(int id)
        {
            return _context.MensHealth.Any(e => e.MensHealthHistoryId == id);
        }
    }
}
