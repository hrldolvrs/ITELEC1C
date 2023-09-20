using Microsoft.AspNetCore.Mvc;
using OliverosITELEC1C.Models;

namespace OliverosITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>()
        {
            new Student ()
            {
                StudentId = 1, StudentName = "Herald Oliveros", DateEnrolled = DateTime.Parse("30/8/2023"),
                Course = Course.BSIT, StudentEmail = "heraldlenvehr.oliveros.cics@ust.edu.ph"
            },

            new Student ()
            {
                StudentId = 2, StudentName = "John Paolo Tan", DateEnrolled = DateTime.Parse("11/3/2021"),
                Course = Course.BSIT, StudentEmail = "johnpaolo.tan.cics@ust.edu.ph"
            }
        };
        public IActionResult Index()
        {
            return View(StudentList);
        }

        public IActionResult ShowDetail(int ID)
        {
            //Search for the Instructor whose ID matches the given ID
            Student? stdnt = StudentList.FirstOrDefault(st => st.StudentId == ID);

            if (stdnt != null) //was a student found?
                return View(stdnt);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student newStudent) 
        {
            StudentList.Add(newStudent);
            return View("Index", StudentList);
        }

        [HttpGet]
        public IActionResult EditStudent(int ID)
        {
            Student? stdnt = StudentList.FirstOrDefault(st => st.StudentId == ID);

            if (stdnt != null) 
                return View(stdnt);

            return NotFound();
        }

        [HttpPost]
        public IActionResult EditStudent(Student studentChange)
        {
            Student? stdnt = StudentList.FirstOrDefault(st => st.StudentId == studentChange.StudentId);
            if (stdnt != null)
            {
                stdnt.StudentId = studentChange.StudentId;
                stdnt.StudentName = studentChange.StudentName;
                stdnt.Course = studentChange.Course;
                stdnt.DateEnrolled = studentChange.DateEnrolled;

            }
            return View("Index", StudentList);
        }
    }
}
