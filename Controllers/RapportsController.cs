using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using authdemo.Data;
using authdemo.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace authdemo.Controllers
{
    public class RapportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RapportsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Student, Enseignant")]
        // GET: Rapports
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rapports.ToListAsync());
        }

        // GET: Rapports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapport = await _context.Rapports
                .FirstOrDefaultAsync(m => m.ID == id);
            if (rapport == null)
            {
                return NotFound();
            }

            return View(rapport);
        }

        // GET: Rapports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rapports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Description,DateDepot")] Rapport rapport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rapport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rapport);
        }

        // GET: Rapports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapport = await _context.Rapports.FindAsync(id);
            if (rapport == null)
            {
                return NotFound();
            }
            return View(rapport);
        }

     

        // POST: Rapports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Description,DateDepot")] Rapport rapport)
        {
            if (id != rapport.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rapport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RapportExists(rapport.ID))
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
            return View(rapport);
        }

        // GET: Rapports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapport = await _context.Rapports
                .FirstOrDefaultAsync(m => m.ID == id);
            if (rapport == null)
            {
                return NotFound();
            }

            return View(rapport);
        }

        // POST: Rapports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rapport = await _context.Rapports.FindAsync(id);
            _context.Rapports.Remove(rapport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RapportExists(int id)
        {
            return _context.Rapports.Any(e => e.ID == id);
        }
    }
}
