using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDBContext _db;

        public DiaryEntriesController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<DiaryEntry> diaryEntries = _db.DiaryEntry.ToList();
            return View(diaryEntries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntry.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            DiaryEntry? entry = _db.DiaryEntry.Find(id);

            if (entry == null)
            {
                return NotFound();
            }

            return View(entry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntry.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

    }
}