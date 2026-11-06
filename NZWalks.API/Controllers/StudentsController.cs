using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers;




//http://localhost:5012/api/Students
[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{


    // GET: http://localhost:5012/api/Students
    [HttpGet]
    public IActionResult GetAllStudents()
    {
      string[] students = new string[]
        {
            "John Doe",
            "Jane Smith",
            "Bob Johnson"
        };
        return Ok(students);
    }
}
