using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PHMLab1_16_10.Models
{
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();   
        public StudentController()
        {
            listStudents = new List<Student>()
            {
                new Student() { Id = 101, Name = "Hải Minh", Branch = Branch.IT,
                    Gender = Gender.Male, IsRegular = true,
                    Address = "A1-2018", Email = "minh@g.com",
                    DateOfBorth = new DateTime(2006, 9, 11)},
                new Student() { Id = 102, Name = "Minh Châu", Branch = Branch.BE,
                    Gender = Gender.Female, IsRegular = true,
                    Address = "A1-2019", Email = "chau@g.com",
                    DateOfBorth = new DateTime(2006, 12, 2)},
                new Student() { Id = 103, Name = "Hoàng Anh", Branch = Branch.CE,
                    Gender = Gender.Male, IsRegular = true,
                    Address = "A1-2020", Email = "anh@g.com",
                    DateOfBorth = new DateTime(2006, 11, 18)},
                new Student() { Id = 104, Name = "Xuân Thịnh", Branch = Branch.EE,
                    Gender = Gender.Female, IsRegular = true,
                    Address = "A1-2021", Email = "thinh@g.com",
                    DateOfBorth = new DateTime(2006, 1, 18)}
            };
        }
        [Route("Admin/Student/List")]
        public IActionResult Index()
        {
            return View(listStudents);
        }
        [Route("Admin/Student/Add")]
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem{Text = "IT", Value = "1"},
                new SelectListItem{Text = "BE", Value = "2"},
                new SelectListItem{Text = "CE", Value = "3"},
                new SelectListItem{Text = "EE", Value = "4"}
            };
            return View();
        }
        [Route("Admin/Student/Add")]
        [HttpPost]
        public IActionResult Create(Student s)
        {
            s.Id = listStudents.Last<Student>().Id + 1;
            listStudents.Add(s);
            return View("Index", listStudents);
        }
    }
}
