using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Db;
using WebApplication1.model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody]student s1)
        {
            _db.Add(s1);
            _db.SaveChanges();
            return Ok(s1);

        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            List<student> students = new List<student>();
            students = _db.Students.ToList();
            return Ok(students);
        }
    }
}
