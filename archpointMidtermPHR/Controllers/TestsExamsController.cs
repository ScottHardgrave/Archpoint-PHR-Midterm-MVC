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
    public class TestsExamsController : Controller
    {
        private readonly ArchpointContext _context;

        public TestsExamsController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: TestsExams
        public async Task<IActionResult> Index()
        {
            var archpointContext = _context.TestsExams.Include(t => t.MedCareLocation);
            return View(await archpointContext.ToListAsync());
        }

        // GET: TestsExams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testsExams = await _context.TestsExams
                .Include(t => t.MedCareLocation)
                .FirstOrDefaultAsync(m => m.TestExamId == id);
            if (testsExams == null)
            {
                return NotFound();
            }

            return View(testsExams);
        }

        // GET: TestsExams/Create
        public IActionResult Create()
        {
            ViewData["MedCareLocationId"] = new SelectList(_context.MedCareLocation, "LocationId", "LocationCity");
            return View();
        }

        // POST: TestsExams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TestExamId,TestExamType,TestExamResult,DateOfTestExam,ReaonForTestExam,MedCareLocationId")] TestsExams testsExams)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testsExams);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MedCareLocationId"] = new SelectList(_context.MedCareLocation, "LocationId", "LocationCity", testsExams.MedCareLocationId);
            return View(testsExams);
        }

        // GET: TestsExams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testsExams = await _context.TestsExams.FindAsync(id);
            if (testsExams == null)
            {
                return NotFound();
            }
            ViewData["MedCareLocationId"] = new SelectList(_context.MedCareLocation, "LocationId", "LocationCity", testsExams.MedCareLocationId);
            return View(testsExams);
        }

        // POST: TestsExams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TestExamId,TestExamType,TestExamResult,DateOfTestExam,ReaonForTestExam,MedCareLocationId")] TestsExams testsExams)
        {
            if (id != testsExams.TestExamId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testsExams);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestsExamsExists(testsExams.TestExamId))
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
            ViewData["MedCareLocationId"] = new SelectList(_context.MedCareLocation, "LocationId", "LocationCity", testsExams.MedCareLocationId);
            return View(testsExams);
        }

        // GET: TestsExams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testsExams = await _context.TestsExams
                .Include(t => t.MedCareLocation)
                .FirstOrDefaultAsync(m => m.TestExamId == id);
            if (testsExams == null)
            {
                return NotFound();
            }

            return View(testsExams);
        }

        // POST: TestsExams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testsExams = await _context.TestsExams.FindAsync(id);
            _context.TestsExams.Remove(testsExams);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestsExamsExists(int id)
        {
            return _context.TestsExams.Any(e => e.TestExamId == id);
        }
    }
}
