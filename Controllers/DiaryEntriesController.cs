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
            _db.DiaryEntry.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}