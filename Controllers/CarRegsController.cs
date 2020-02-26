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
    public class CarRegsController : Controller
    {
        private readonly DataContext _context;

        public CarRegsController(DataContext context)
        {
            _context = context;
        }

        // GET: CarRegs
        public async Task<IActionResult> Index()
        {
            return View(await _context.CarRegs.ToListAsync());
        }

        // GET: CarRegs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carReg = await _context.CarRegs
                .FirstOrDefaultAsync(m => m.id == id);
            if (carReg == null)
            {
                return NotFound();
            }

            return View(carReg);
        }

        // GET: CarRegs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarRegs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,date,Employee,plateNo,timein,timeout,SecurityStaff,status")] CarReg carReg)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carReg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carReg);
        }

        // GET: CarRegs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carReg = await _context.CarRegs.FindAsync(id);
            if (carReg == null)
            {
                return NotFound();
            }
            return View(carReg);
        }

        // POST: CarRegs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,date,Employee,plateNo,timein,timeout,SecurityStaff,status")] CarReg carReg)
        {
            if (id != carReg.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carReg);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarRegExists(carReg.id))
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
            return View(carReg);
        }

        // GET: CarRegs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carReg = await _context.CarRegs
                .FirstOrDefaultAsync(m => m.id == id);
            if (carReg == null)
            {
                return NotFound();
            }

            return View(carReg);
        }

        // POST: CarRegs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carReg = await _context.CarRegs.FindAsync(id);
            _context.CarRegs.Remove(carReg);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarRegExists(int id)
        {
            return _context.CarRegs.Any(e => e.id == id);
        }
    }
}
