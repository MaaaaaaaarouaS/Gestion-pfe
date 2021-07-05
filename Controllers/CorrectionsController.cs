using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using authdemo.Data;
using authdemo.Models;
using Microsoft.AspNetCore.Authorization;

namespace authdemo.Controllers
{
    public class CorrectionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CorrectionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Enseignant")]
        // GET: Corrections
        public async Task<IActionResult> Index()
        {
            return View(await _context.Corrections.ToListAsync());
        }

        // GET: Corrections/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var correction = await _context.Corrections
                .FirstOrDefaultAsync(m => m.ID == id);
            if (correction == null)
            {
                return NotFound();
            }

            return View(correction);
        }

        // GET: Corrections/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Corrections/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Note,Comments,RapportID")] Correction correction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(correction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(correction);
        }

        // GET: Corrections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var correction = await _context.Corrections.FindAsync(id);
            if (correction == null)
            {
                return NotFound();
            }
            return View(correction);
        }

        // POST: Corrections/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Note,Comments,RapportID")] Correction correction)
        {
            if (id != correction.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(correction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CorrectionExists(correction.ID))
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
            return View(correction);
        }

        // GET: Corrections/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var correction = await _context.Corrections
                .FirstOrDefaultAsync(m => m.ID == id);
            if (correction == null)
            {
                return NotFound();
            }

            return View(correction);
        }

        // POST: Corrections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var correction = await _context.Corrections.FindAsync(id);
            _context.Corrections.Remove(correction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CorrectionExists(int id)
        {
            return _context.Corrections.Any(e => e.ID == id);
        }
    }
}
