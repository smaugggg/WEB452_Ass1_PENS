﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEB452_Ass1_PENS.Data;
using WEB452_Ass1_PENS.Models;

namespace WEB452_Ass1_PENS.Controllers
{
    public class PensController : Controller
    {
        private readonly WEB452_Ass1_PENSContext _context;

        public PensController(WEB452_Ass1_PENSContext context)
        {
            _context = context;
        }

        // GET: Pens
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pen.ToListAsync());
        }

        // GET: Pens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pen = await _context.Pen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pen == null)
            {
                return NotFound();
            }

            return View(pen);
        }

        // GET: Pens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Type,Colour,Size,Erasable")] Pen pen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pen);
        }

        // GET: Pens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pen = await _context.Pen.FindAsync(id);
            if (pen == null)
            {
                return NotFound();
            }
            return View(pen);
        }

        // POST: Pens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Type,Colour,Size,Erasable")] Pen pen)
        {
            if (id != pen.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PenExists(pen.Id))
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
            return View(pen);
        }

        // GET: Pens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pen = await _context.Pen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pen == null)
            {
                return NotFound();
            }

            return View(pen);
        }

        // POST: Pens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pen = await _context.Pen.FindAsync(id);
            _context.Pen.Remove(pen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PenExists(int id)
        {
            return _context.Pen.Any(e => e.Id == id);
        }
    }
}
