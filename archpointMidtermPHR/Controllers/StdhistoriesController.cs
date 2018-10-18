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
    public class StdhistoriesController : Controller
    {
        private readonly ArchpointContext _context;

        public StdhistoriesController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: Stdhistories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stdhistory.ToListAsync());
        }

        // GET: Stdhistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stdhistory = await _context.Stdhistory
                .FirstOrDefaultAsync(m => m.StdHistoryId == id);
            if (stdhistory == null)
            {
                return NotFound();
            }

            return View(stdhistory);
        }

        // GET: Stdhistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stdhistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StdHistoryId,StdType,StdDateOfDiagnosis,StdStatus,StdDateResolved,StdMedication,Comments")] Stdhistory stdhistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stdhistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stdhistory);
        }

        // GET: Stdhistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stdhistory = await _context.Stdhistory.FindAsync(id);
            if (stdhistory == null)
            {
                return NotFound();
            }
            return View(stdhistory);
        }

        // POST: Stdhistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StdHistoryId,StdType,StdDateOfDiagnosis,StdStatus,StdDateResolved,StdMedication,Comments")] Stdhistory stdhistory)
        {
            if (id != stdhistory.StdHistoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stdhistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StdhistoryExists(stdhistory.StdHistoryId))
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
            return View(stdhistory);
        }

        // GET: Stdhistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stdhistory = await _context.Stdhistory
                .FirstOrDefaultAsync(m => m.StdHistoryId == id);
            if (stdhistory == null)
            {
                return NotFound();
            }

            return View(stdhistory);
        }

        // POST: Stdhistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stdhistory = await _context.Stdhistory.FindAsync(id);
            _context.Stdhistory.Remove(stdhistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StdhistoryExists(int id)
        {
            return _context.Stdhistory.Any(e => e.StdHistoryId == id);
        }
    }
}
