using MVCStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStudy.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var studentList = new List<StudentModel>
            {
                new StudentModel(){StudentId = 1 , StudentName ="Shraddha" , Age =22},
                new StudentModel() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                new StudentModel() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new StudentModel() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new StudentModel() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                new StudentModel() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                new StudentModel() { StudentId = 4, StudentName = "Rob" , Age = 19 }
            };
            return View(studentList);
        }
        [HttpPost]
        public ActionResult Edit(StudentModel std)
        {
            var id = std.StudentId;
            var name = std.StudentName;
            var age = std.Age;
         //   var standardName = std.standard.StandardName;

            return RedirectToAction("index");
        }
      
    }
}