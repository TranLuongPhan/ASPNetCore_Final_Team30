﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NETCKTEAM30.Models;

namespace NETCKTEAM30.Controllers
{
    public class VanChuyensController : Controller
    {
        private readonly MyDbContext _context;

        public VanChuyensController(MyDbContext context)
        {
            _context = context;
        }

        // GET: VanChuyens
        public async Task<IActionResult> Index()
        {
            return View(await _context.VanChuyens.ToListAsync());
        }

        // GET: VanChuyens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vanChuyen = await _context.VanChuyens
                .FirstOrDefaultAsync(m => m.VanChuyenID == id);
            if (vanChuyen == null)
            {
                return NotFound();
            }

            return View(vanChuyen);
        }

        // GET: VanChuyens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VanChuyens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VanChuyenID,Ten")] VanChuyen vanChuyen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vanChuyen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vanChuyen);
        }

        // GET: VanChuyens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vanChuyen = await _context.VanChuyens.FindAsync(id);
            if (vanChuyen == null)
            {
                return NotFound();
            }
            return View(vanChuyen);
        }

        // POST: VanChuyens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VanChuyenID,Ten")] VanChuyen vanChuyen)
        {
            if (id != vanChuyen.VanChuyenID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vanChuyen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VanChuyenExists(vanChuyen.VanChuyenID))
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
            return View(vanChuyen);
        }

        // GET: VanChuyens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vanChuyen = await _context.VanChuyens
                .FirstOrDefaultAsync(m => m.VanChuyenID == id);
            if (vanChuyen == null)
            {
                return NotFound();
            }

            return View(vanChuyen);
        }

        // POST: VanChuyens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vanChuyen = await _context.VanChuyens.FindAsync(id);
            _context.VanChuyens.Remove(vanChuyen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VanChuyenExists(int id)
        {
            return _context.VanChuyens.Any(e => e.VanChuyenID == id);
        }
    }
}
