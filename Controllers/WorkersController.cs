﻿using System;
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
    //public class WorkersController : Controller
    //{
    //    private readonly DataContext _context;

    //    public WorkersController(DataContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: Workers
    //    public async Task<IActionResult> Index()
    //    {
    //        return View(await _context.Workerss.ToListAsync());
    //    }

    //    // GET: Workers/Details/5
    //    public async Task<IActionResult> Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var workers = await _context.Workerss
    //            .FirstOrDefaultAsync(m => m.id == id);
    //        if (workers == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(workers);
    //    }

    //    // GET: Workers/Create
    //    public IActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: Workers/Create
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create([Bind("id,Fname,Lname,gender,tel,email,position,status,picturePath,Employee")] Workers workers)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _context.Add(workers);
    //            await _context.SaveChangesAsync();
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(workers);
    //    }

    //    // GET: Workers/Edit/5
    //    public async Task<IActionResult> Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var workers = await _context.Workerss.FindAsync(id);
    //        if (workers == null)
    //        {
    //            return NotFound();
    //        }
    //        return View(workers);
    //    }

    //    // POST: Workers/Edit/5
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(int id, [Bind("id,Fname,Lname,gender,tel,email,position,status,picturePath,Employee")] Workers workers)
    //    {
    //        if (id != workers.id)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                _context.Update(workers);
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!WorkersExists(workers.id))
    //                {
    //                    return NotFound();
    //                }
    //                else
    //                {
    //                    throw;
    //                }
    //            }
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(workers);
    //    }

    //    // GET: Workers/Delete/5
    //    public async Task<IActionResult> Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var workers = await _context.Workerss
    //            .FirstOrDefaultAsync(m => m.id == id);
    //        if (workers == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(workers);
    //    }

    //    // POST: Workers/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(int id)
    //    {
    //        var workers = await _context.Workerss.FindAsync(id);
    //        _context.Workerss.Remove(workers);
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }

    //    private bool WorkersExists(int id)
    //    {
    //        return _context.Workerss.Any(e => e.id == id);
    //    }
    //}
}
