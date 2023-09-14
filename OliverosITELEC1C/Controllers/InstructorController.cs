using Microsoft.AspNetCore.Mvc;
using OliverosITELEC1C.Models;

namespace OliverosITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>()
        {
            new Instructor()
            {
                Id = 202301, InstructorFirstName = "John", InstructorLastName = "Lennon",
                InstructorIsTenured = "Permanent", Rank = Rank.Instructor,
                HiringDate = DateTime.Parse("24/6/2004")
            },

            new Instructor()
            {
                Id = 202302, InstructorFirstName = "Paul", InstructorLastName = "McCartney",
                InstructorIsTenured = "Permanent", Rank = Rank.AssociateProfessor,
                HiringDate = DateTime.Parse("30/1/2009")
            },

            new Instructor()
            {
                Id = 202303, InstructorFirstName = "George", InstructorLastName = "Harrison",
                InstructorIsTenured = "Temporary", Rank = Rank.AssistantProfessor,
                HiringDate = DateTime.Parse("16/3/2011")
            },

            new Instructor()
            {
                Id = 202304, InstructorFirstName = "Ringo", InstructorLastName = "Starr",
                InstructorIsTenured = "Temporary", Rank = Rank.Professor,
                HiringDate = DateTime.Parse("5/11/2015")
            }
        };
        public IActionResult Index()
        {
            return View(InstructorList);
        }
        public IActionResult ShowDetail(int ID)
        {
            //Search for the Instructor whose ID matches the given ID
            Instructor? inst = InstructorList.FirstOrDefault(il => il.Id == ID);

            if (inst != null) //was an instructor found?
                return View(inst);

            return NotFound();
        }
    }
}
