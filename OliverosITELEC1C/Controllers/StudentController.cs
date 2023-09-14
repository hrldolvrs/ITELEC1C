using Microsoft.AspNetCore.Mvc;
using OliverosITELEC1C.Models;

namespace OliverosITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student st = new Student();
            st.StudentId = 1;
            st.StudentName = "Herald Oliveros";
            st.DateEnrolled = DateTime.Parse("30/8/2023");
            st.Course = Course.BSIT;
            st.Email = "heraldlenvehr.oliveros.cics@ust.edu.ph";

            ViewBag.Student = st;
            return View();
        }
    }
}
