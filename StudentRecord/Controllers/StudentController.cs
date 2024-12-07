using Microsoft.AspNetCore.Mvc;
using StudentRecord.Data;
using StudentRecord.Models;

namespace StudentRecord.Controllers
{
 

    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Student> objStudentlist=_db.Students.ToList();
            return View(objStudentlist);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(obj);
                _db.SaveChanges();
            }
                return RedirectToAction("Index");
            
        }

        public IActionResult Edit(int ? StudentId)
        {
            if (StudentId==null || StudentId == 0) { 
                    return NotFound();

            }
            Student ?StudentFromDb = _db.Students.Find(StudentId);
            if (StudentFromDb == null)
            {
                return NotFound();

            }
            return View(StudentFromDb);

        }
        [HttpPost]
        public IActionResult Edit(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Update(obj);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int? StudentId)
        {
            if (StudentId == null || StudentId == 0)
            {
                return NotFound();

            }
            Student? StudentFromDb = _db.Students.Find(StudentId);
            if (StudentFromDb == null)
            {
                return NotFound();

            }
            return View(StudentFromDb);

        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePost(int? StudentId)
        {
            Student ?obj = _db.Students.Find(StudentId);
            if (obj == null )
            {
                return NotFound();

            }
            _db.Students.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
