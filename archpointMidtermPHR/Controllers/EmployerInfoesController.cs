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
    public class EmployerInfoesController : Controller
    {
        private readonly ArchpointContext _context;

        public EmployerInfoesController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: EmployerInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployerInfo.ToListAsync());
        }

        // GET: EmployerInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employerInfo = await _context.EmployerInfo
                .FirstOrDefaultAsync(m => m.EmployerId == id);
            if (employerInfo == null)
            {
                return NotFound();
            }

            return View(employerInfo);
        }

        // GET: EmployerInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployerInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployerId,EmployerName,EmployerAddress,EmployerCity,EmployerStateProvince,EmployerZip,EmployerPhone")] EmployerInfo employerInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employerInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employerInfo);
        }

        // GET: EmployerInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employerInfo = await _context.EmployerInfo.FindAsync(id);
            if (employerInfo == null)
            {
                return NotFound();
            }
            return View(employerInfo);
        }

        // POST: EmployerInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployerId,EmployerName,EmployerAddress,EmployerCity,EmployerStateProvince,EmployerZip,EmployerPhone")] EmployerInfo employerInfo)
        {
            if (id != employerInfo.EmployerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employerInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployerInfoExists(employerInfo.EmployerId))
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
            return View(employerInfo);
        }

        // GET: EmployerInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employerInfo = await _context.EmployerInfo
                .FirstOrDefaultAsync(m => m.EmployerId == id);
            if (employerInfo == null)
            {
                return NotFound();
            }

            return View(employerInfo);
        }

        // POST: EmployerInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employerInfo = await _context.EmployerInfo.FindAsync(id);
            _context.EmployerInfo.Remove(employerInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployerInfoExists(int id)
        {
            return _context.EmployerInfo.Any(e => e.EmployerId == id);
        }
    }
}
