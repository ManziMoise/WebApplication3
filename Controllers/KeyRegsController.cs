using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class KeyRegsController : Controller
    {
        private readonly DataContext _context;

        public KeyRegsController(DataContext context)
        {
            _context = context;
        }

        // GET: KeyRegs
        public async Task<IActionResult> Index()
        {
            return View(await _context.keyRegs.ToListAsync());
        }

        // GET: KeyRegs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var keyReg = await _context.keyRegs
                .FirstOrDefaultAsync(m => m.id == id);
            if (keyReg == null)
            {
                return NotFound();
            }

            return View(keyReg);
        }

        // GET: KeyRegs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KeyRegs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,kid,locke,type,color,Material,address,status")] KeyReg keyReg)
        {
            if (ModelState.IsValid)
            {
                _context.Add(keyReg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(keyReg);
        }

        // GET: KeyRegs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var keyReg = await _context.keyRegs.FindAsync(id);
            if (keyReg == null)
            {
                return NotFound();
            }
            return View(keyReg);
        }

        // POST: KeyRegs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,kid,locke,type,color,Material,address,status")] KeyReg keyReg)
        {
            if (id != keyReg.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(keyReg);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KeyRegExists(keyReg.id))
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
            return View(keyReg);
        }

        // GET: KeyRegs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var keyReg = await _context.keyRegs
                .FirstOrDefaultAsync(m => m.id == id);
            if (keyReg == null)
            {
                return NotFound();
            }

            return View(keyReg);
        }

        // POST: KeyRegs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var keyReg = await _context.keyRegs.FindAsync(id);
            _context.keyRegs.Remove(keyReg);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KeyRegExists(int id)
        {
            return _context.keyRegs.Any(e => e.id == id);
        }
    }
}
