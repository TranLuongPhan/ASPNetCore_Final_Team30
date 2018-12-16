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
    public class HangHoasController : Controller
    {
        private readonly MyDbContext _context;

        public HangHoasController(MyDbContext context)
        {
            _context = context;
        }

        // GET: HangHoas
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.HangHoas.Include(h => h.Loai).Include(h => h.NhaCungCap);

            return View(await myDbContext.ToListAsync());
        }

        // GET: HangHoas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoas
                .Include(h => h.Loai)
                .Include(h => h.NhaCungCap)
                .FirstOrDefaultAsync(m => m.HanghoaID == id);
            if (hangHoa == null)
            {
                return NotFound();
            }
            string[] arrListStr = hangHoa.Hinh.Split(';');
            ViewBag.arr = arrListStr;
            return View(hangHoa);
        }

        // GET: HangHoas/Create
        public IActionResult Create()
        {
            ViewData["MaLoaiID"] = new SelectList(_context.Loais, "LoaiID", "TenLoai");
            ViewData["NhaCungCapID"] = new SelectList(_context.NhaCungCaps, "NhaCungCapID", "TenNhaCc");
            return View();
        }

        // POST: HangHoas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HanghoaID,TenHh,MaLoaiID,DonGia,Hinh,NhaCungCapID,NgayNhap,MoTa,GiamGia")] HangHoa hangHoa, IFormFile[] myfile)
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
                    hangHoa.Hinh = arr;
                }
                _context.Add(hangHoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaLoaiID"] = new SelectList(_context.Loais, "LoaiID", "LoaiID", hangHoa.MaLoaiID);
            ViewData["NhaCungCapID"] = new SelectList(_context.NhaCungCaps, "NhaCungCapID", "NhaCungCapID", hangHoa.NhaCungCapID);
            return View(hangHoa);
        }

        // GET: HangHoas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoas.FindAsync(id);
            if (hangHoa == null)
            {
                return NotFound();
            }
            ViewData["MaLoaiID"] = new SelectList(_context.Loais, "LoaiID", "TenLoai", hangHoa.MaLoaiID);
            ViewData["NhaCungCapID"] = new SelectList(_context.NhaCungCaps, "NhaCungCapID", "TenNhaCc", hangHoa.NhaCungCapID);
            string[] arrListStr = hangHoa.Hinh.Split(';');
            ViewBag.arr = arrListStr;
            return View(hangHoa);
        }

        // POST: HangHoas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HanghoaID,TenHh,MaLoaiID,DonGia,Hinh,NhaCungCapID,NgayNhap,MoTa,GiamGia")] HangHoa hangHoa, IFormFile[] myfile)
        {
            if (id != hangHoa.HanghoaID)
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
                        hangHoa.Hinh = arr;
                    }
                    _context.Update(hangHoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HangHoaExists(hangHoa.HanghoaID))
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
            ViewData["MaLoaiID"] = new SelectList(_context.Loais, "LoaiID", "LoaiID", hangHoa.MaLoaiID);
            ViewData["NhaCungCapID"] = new SelectList(_context.NhaCungCaps, "NhaCungCapID", "NhaCungCapID", hangHoa.NhaCungCapID);
            return View(hangHoa);
        }

        // GET: HangHoas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoas
                .Include(h => h.Loai)
                .Include(h => h.NhaCungCap)
                .FirstOrDefaultAsync(m => m.HanghoaID == id);
            if (hangHoa == null)
            {
                return NotFound();
            }

            return View(hangHoa);
        }

        // POST: HangHoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hangHoa = await _context.HangHoas.FindAsync(id);
            _context.HangHoas.Remove(hangHoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HangHoaExists(int id)
        {
            return _context.HangHoas.Any(e => e.HanghoaID == id);
        }
        public IActionResult HangHoaTheoLoai(int? LoaiID, int? NhaCungCapID)
        {
            
            List<HangHoa> DsHh = new List<HangHoa>();
            if(LoaiID.HasValue)
            {
                DsHh = _context.HangHoas.Where(h => h.HanghoaID == LoaiID).ToList();
            }
            if(NhaCungCapID.HasValue)
            {
                DsHh = _context.HangHoas.Where(h => h.NhaCungCapID == NhaCungCapID).ToList();
            }
            return View(DsHh.Select(h=> new HangHoaViewModel
            {
                MaHH = h.HanghoaID,
                TenHH = h.TenHh,
                Hinh = h.Hinh,
                DonGia = h.DonGia,
                GiamGia = h.GiamGia
            }));
            
        }
        public IActionResult selectAo()
        {
            List<HangHoa> DsHh = new List<HangHoa>();
            DsHh = _context.HangHoas.Where(h => h.MaLoaiID == 1).ToList();
            return View(DsHh.Select(h => new HangHoaViewModel
            {
                MaHH = h.HanghoaID,
                TenHH = h.TenHh,
                Hinh = h.Hinh,
                DonGia = h.DonGia,
                GiamGia = h.GiamGia
            }));
        }
        public IActionResult selectQuan()
        {
            List<HangHoa> DsHh = new List<HangHoa>();
            DsHh = _context.HangHoas.Where(h => h.MaLoaiID == 2).ToList();
            return View(DsHh.Select(h => new HangHoaViewModel
            {
                MaHH = h.HanghoaID,
                TenHH = h.TenHh,
                Hinh = h.Hinh,
                DonGia = h.DonGia,
                GiamGia = h.GiamGia
            }));
        }
        public IActionResult selectGiay()
        {
            List<HangHoa> DsHh = new List<HangHoa>();
            DsHh = _context.HangHoas.Where(h => h.MaLoaiID == 4).ToList();
            return View(DsHh.Select(h => new HangHoaViewModel
            {
                MaHH = h.HanghoaID,
                TenHH = h.TenHh,
                Hinh = h.Hinh,
                DonGia = h.DonGia,
                GiamGia = h.GiamGia
            }));
        }
        public IActionResult Search(string keyword = "")
        {
            if (keyword != null)
            {
                keyword = keyword.ToLower();
                var data = _context.HangHoas.Where(p => p.TenHh.ToLower().Contains(keyword))
                    .Select(p => new HangHoaViewModel
                    {
                        MaHH = p.HanghoaID,
                        TenHH = p.TenHh,
                        Hinh = p.Hinh,
                        DonGia = p.DonGia,
                        GiamGia = p.GiamGia
                    }).ToList();
                
                return PartialView(data);
            }
            else
            {
                return PartialView();
            }
        }

    }
}
