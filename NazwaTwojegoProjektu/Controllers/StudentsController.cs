using Microsoft.AspNetCore.Mvc;

namespace apbdWyk8.Controllers;

[ApiController]
[Route("api/controller")]
public class StudentsController : ControllerBase
{
    public StudentsController()
    {
        
    }

    [HttpGet]
    public IActionResult GetStudents()
    {

        return Ok();
    }
}