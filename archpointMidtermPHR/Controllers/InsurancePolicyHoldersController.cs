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
    public class InsurancePolicyHoldersController : Controller
    {
        private readonly ArchpointContext _context;

        public InsurancePolicyHoldersController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: InsurancePolicyHolders
        public async Task<IActionResult> Index()
        {
            return View(await _context.InsurancePolicyHolder.ToListAsync());
        }

        // GET: InsurancePolicyHolders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insurancePolicyHolder = await _context.InsurancePolicyHolder
                .FirstOrDefaultAsync(m => m.PolicyHolderId == id);
            if (insurancePolicyHolder == null)
            {
                return NotFound();
            }

            return View(insurancePolicyHolder);
        }

        // GET: InsurancePolicyHolders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InsurancePolicyHolders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PolicyHolderId,PolicyHolderFirstName,PolicyHolderMidInit,PolicyHolderLastName,RealtionshipToPolicyHolder,DateOfBirth,PolicyHolderSsn")] InsurancePolicyHolder insurancePolicyHolder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(insurancePolicyHolder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insurancePolicyHolder);
        }

        // GET: InsurancePolicyHolders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insurancePolicyHolder = await _context.InsurancePolicyHolder.FindAsync(id);
            if (insurancePolicyHolder == null)
            {
                return NotFound();
            }
            return View(insurancePolicyHolder);
        }

        // POST: InsurancePolicyHolders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PolicyHolderId,PolicyHolderFirstName,PolicyHolderMidInit,PolicyHolderLastName,RealtionshipToPolicyHolder,DateOfBirth,PolicyHolderSsn")] InsurancePolicyHolder insurancePolicyHolder)
        {
            if (id != insurancePolicyHolder.PolicyHolderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insurancePolicyHolder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsurancePolicyHolderExists(insurancePolicyHolder.PolicyHolderId))
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
            return View(insurancePolicyHolder);
        }

        // GET: InsurancePolicyHolders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insurancePolicyHolder = await _context.InsurancePolicyHolder
                .FirstOrDefaultAsync(m => m.PolicyHolderId == id);
            if (insurancePolicyHolder == null)
            {
                return NotFound();
            }

            return View(insurancePolicyHolder);
        }

        // POST: InsurancePolicyHolders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var insurancePolicyHolder = await _context.InsurancePolicyHolder.FindAsync(id);
            _context.InsurancePolicyHolder.Remove(insurancePolicyHolder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsurancePolicyHolderExists(int id)
        {
            return _context.InsurancePolicyHolder.Any(e => e.PolicyHolderId == id);
        }
    }
}
