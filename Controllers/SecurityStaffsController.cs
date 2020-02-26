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
    public class SecurityStaffsController : Controller
    {
        private readonly DataContext _context;

        public SecurityStaffsController(DataContext context)
        {
            _context = context;
        }

        // GET: SecurityStaffs
        public async Task<IActionResult> Index()
        {
            return View(await _context.securityStaffs.ToListAsync());
        }

        // GET: SecurityStaffs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var securityStaff = await _context.securityStaffs
                .FirstOrDefaultAsync(m => m.id == id);
            if (securityStaff == null)
            {
                return NotFound();
            }

            return View(securityStaff);
        }

        // GET: SecurityStaffs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SecurityStaffs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Fname,Lname,gender,tel,email,position,status,picture")] SecurityStaff securityStaff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(securityStaff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(securityStaff);
        }

        // GET: SecurityStaffs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var securityStaff = await _context.securityStaffs.FindAsync(id);
            if (securityStaff == null)
            {
                return NotFound();
            }
            return View(securityStaff);
        }

        // POST: SecurityStaffs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Fname,Lname,gender,tel,email,position,status,picture")] SecurityStaff securityStaff)
        {
            if (id != securityStaff.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(securityStaff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SecurityStaffExists(securityStaff.id))
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
            return View(securityStaff);
        }

        // GET: SecurityStaffs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var securityStaff = await _context.securityStaffs
                .FirstOrDefaultAsync(m => m.id == id);
            if (securityStaff == null)
            {
                return NotFound();
            }

            return View(securityStaff);
        }

        // POST: SecurityStaffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var securityStaff = await _context.securityStaffs.FindAsync(id);
            _context.securityStaffs.Remove(securityStaff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SecurityStaffExists(int id)
        {
            return _context.securityStaffs.Any(e => e.id == id);
        }
    }
}
