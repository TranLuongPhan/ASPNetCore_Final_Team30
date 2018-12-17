using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NETCKTEAM30.Models;

namespace NETCKTEAM30.Controllers
{
    public class NguoiDungsController : Controller
    {
        private readonly MyDbContext _context;

        public NguoiDungsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: NguoiDungs
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.NguoiDungs.Include(n => n.GioiTinh).Include(n => n.LoaiNgDung);
            return View(await myDbContext.ToListAsync());
        }

        // GET: NguoiDungs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoiDung = await _context.NguoiDungs
                .Include(n => n.GioiTinh)
                .Include(n => n.LoaiNgDung)
                .FirstOrDefaultAsync(m => m.NguoiDungID == id);
            if (nguoiDung == null)
            {
                return NotFound();
            }
            string[] arrListStr = nguoiDung.Hinh.Split(';');
            ViewBag.arr = arrListStr;
            return View(nguoiDung);
        }

        // GET: NguoiDungs/Create
        public IActionResult Create()
        {
            ViewData["GioiTinhID"] = new SelectList(_context.GioiTinhs, "GioiTinhID", "TenGT");
            ViewData["LoaiNgDungID"] = new SelectList(_context.LoaiNgDungs, "LoaiNgDungID", "TenLoai");
            return View();
        }

        // POST: NguoiDungs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NguoiDungID,HoTen,GioiTinhID,NgaySinh,DiaChi,SDT,Email,Hinh,LoaiNgDungID,TenDangNhap,MatKhau")] NguoiDung nguoiDung, IFormFile[] myfile)
        {
            if (ModelState.IsValid)
            {
                string arr = "";

                if (myfile != null)
                {
                    foreach (var item in myfile)
                    {
                        string url = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", item.FileName);
                        using (var f = new FileStream(url, FileMode.Create))
                        {
                            item.CopyTo(f);
                        }
                        arr += item.FileName + ";";
                    }
                    nguoiDung.Hinh = arr;
                }
                _context.Add(nguoiDung);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GioiTinhID"] = new SelectList(_context.GioiTinhs, "GioiTinhID", "GioiTinhID", nguoiDung.GioiTinhID);
            ViewData["LoaiNgDungID"] = new SelectList(_context.LoaiNgDungs, "LoaiNgDungID", "LoaiNgDungID", nguoiDung.LoaiNgDungID);
            return View(nguoiDung);
        }

        // GET: NguoiDungs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoiDung = await _context.NguoiDungs.FindAsync(id);
            if (nguoiDung == null)
            {
                return NotFound();
            }
            ViewData["GioiTinhID"] = new SelectList(_context.GioiTinhs, "GioiTinhID", "TenGT", nguoiDung.GioiTinhID);
            ViewData["LoaiNgDungID"] = new SelectList(_context.LoaiNgDungs, "LoaiNgDungID", "TenLoai", nguoiDung.LoaiNgDungID);
            string[] arrListStr = nguoiDung.Hinh.Split(';');
            ViewBag.arr = arrListStr;
            return View(nguoiDung);
        }

        // POST: NguoiDungs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NguoiDungID,HoTen,GioiTinhID,NgaySinh,DiaChi,SDT,Email,Hinh,LoaiNgDungID,TenDangNhap,MatKhau")] NguoiDung nguoiDung, IFormFile[] myfile)
        {
            if (id != nguoiDung.NguoiDungID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string arr = "";

                    if (myfile != null)
                    {
                        foreach (var item in myfile)
                        {
                            string url = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", item.FileName);
                            using (var f = new FileStream(url, FileMode.Create))
                            {
                                item.CopyTo(f);
                            }
                            arr += item.FileName + ";";
                        }
                        nguoiDung.Hinh = arr;
                    }
                    _context.Update(nguoiDung);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NguoiDungExists(nguoiDung.NguoiDungID))
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
            ViewData["GioiTinhID"] = new SelectList(_context.GioiTinhs, "GioiTinhID", "GioiTinhID", nguoiDung.GioiTinhID);
            ViewData["LoaiNgDungID"] = new SelectList(_context.LoaiNgDungs, "LoaiNgDungID", "LoaiNgDungID", nguoiDung.LoaiNgDungID);
            return View(nguoiDung);
        }

        // GET: NguoiDungs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoiDung = await _context.NguoiDungs
                .Include(n => n.GioiTinh)
                .Include(n => n.LoaiNgDung)
                .FirstOrDefaultAsync(m => m.NguoiDungID == id);
            if (nguoiDung == null)
            {
                return NotFound();
            }

            return View(nguoiDung);
        }

        // POST: NguoiDungs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nguoiDung = await _context.NguoiDungs.FindAsync(id);
            _context.NguoiDungs.Remove(nguoiDung);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NguoiDungExists(int id)
        {
            return _context.NguoiDungs.Any(e => e.NguoiDungID == id);
        }
        public IActionResult dangnhap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult dangnhap(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                NguoiDung kh = _context.NguoiDungs.SingleOrDefault(p => p.TenDangNhap == model.MaKH && p.MatKhau == model.MatKhau);
                if (kh == null)
                {
                    ModelState.AddModelError("Loi", "Không có khách hàng này.");
                    return View();
                }

                HttpContext.Session.Set("MaKH", 1);
                HttpContext.Session.Set<int>("a", 1);
                return RedirectToAction("index", "Home");
            }
            else
            {
                return RedirectToAction("index", "Home");
            }
            
        }
        public IActionResult dangky()
        {
            ViewData["GioiTinhID"] = new SelectList(_context.GioiTinhs, "GioiTinhID", "TenGT");
            ViewData["LoaiNgDungID"] = new SelectList(_context.LoaiNgDungs, "LoaiNgDungID", "TenLoai");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> dangky([Bind("NguoiDungID,HoTen,GioiTinhID,NgaySinh,DiaChi,SDT,Email,Hinh,TenDangNhap,MatKhau")] NguoiDung nguoiDung, IFormFile[] myfile)
        {
            if (ModelState.IsValid)
            {
                string arr = "";

                if (myfile != null)
                {
                    foreach (var item in myfile)
                    {
                        string url = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", item.FileName);
                        using (var f = new FileStream(url, FileMode.Create))
                        {
                            item.CopyTo(f);
                        }
                        arr += item.FileName + ";";
                    }
                    nguoiDung.Hinh = arr;
                    nguoiDung.LoaiNgDungID = 2;
                }
                _context.Add(nguoiDung);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), "Home");
            }
            ViewData["GioiTinhID"] = new SelectList(_context.GioiTinhs, "GioiTinhID", "GioiTinhID", nguoiDung.GioiTinhID);
            ViewData["LoaiNgDungID"] = new SelectList(_context.LoaiNgDungs, "LoaiNgDungID", "LoaiNgDungID", nguoiDung.LoaiNgDungID);
            return View(nguoiDung);
        }
    }
}
