using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassTracker.Models;
using ClassTracker.Data;
using System.Diagnostics;
using System.Collections;
using System.Linq.Expressions;

namespace ClassTracker.Controllers
{
    public class StudentController : Controller
    {

        private IRepository _repository;

        public StudentController(IRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Search(string lname)
        {
            Expression<Func<Student, bool>> predicate =
                    pr => pr.LastName.ToUpper().StartsWith(lname.ToUpper().Trim());
            ICollection<Student> model = _repository.Find<Student>(predicate).ToList();


            return View(model);
        }

        public ActionResult Index()
        {
            List<Student> model = new List<Student>();
            Student s1 = new Student {
                FirstName = "Bob",
                LastName = "Smith",
                NetworkID = "123456",
                Email = "BobSmith@something.com",
                Phone = "555-555-1234"
            };
            Student s2 = new Student {
                FirstName = "Jane",
                LastName = "Eyre",
                NetworkID = "123457",
                Email = "JaneEyre@something.com",
                Phone = "555-555-1235"
            };

            model.Add(s1);
            model.Add(s2);

            return View(model);
        }

        public ActionResult Detail(Guid id)
        {
            Student model = _repository.Get<Student>(id);

            return View(model);
        }

        public ActionResult EditStudent()
        {

            return View();
        }

        [HttpPost]
        public ActionResult EditStudent(Student student)
        {
            student = _repository.Add(student);

            Debug.WriteLine("Student added. Name: {0}, ID: {1}", student.FirstName, student.ID);

            return RedirectToAction("Detail", new { id = student.ID });
        }
    }
}
