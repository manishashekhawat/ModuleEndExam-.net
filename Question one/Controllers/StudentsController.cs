using Microsoft.AspNetCore.Mvc;
using Question_one.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Question_one.Models;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Question_one.Data_Access;


namespace Question_one.Controllers
{
    public class StudentsController : Controller
        {
            private readonly StudentRepository _repository;

            public StudentsController()
            {
                _repository = new StudentRepository();
            }

            public IActionResult Index()
            {
                var students = _repository.GetAllStudents();
                return View(students);
            }

            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Create(Student student)
            {
                if (ModelState.IsValid)
                {
                    _repository.AddStudent(student);
                    return RedirectToAction("Index");
                }

                return View(student);
            }

            public IActionResult Edit(int id)
            {
                var student = _repository.GetStudentById(id);
                if (student == null)
                {
                    return NotFound();
                }

                return View(student);
            }

            [HttpPost]
            public IActionResult Edit(Student student)
            {
                if (ModelState.IsValid)
                {
                    _repository.UpdateStudent(student);
                    return RedirectToAction("Index");
                }

                return View(student);
            }

            public IActionResult Delete(int id)
            {
                var student = _repository.GetStudentById(id);
                if (student == null)
                {
                    return NotFound();
                }

                return View(student);
            }

            [HttpPost, ActionName("Delete")]
            public IActionResult DeleteConfirmed(int id)
            {
                _repository.DeleteStudent(id);
                return RedirectToAction("Index");
            }
        }
    }