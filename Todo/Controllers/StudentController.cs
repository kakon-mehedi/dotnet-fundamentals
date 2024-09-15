using Microsoft.AspNetCore.Mvc;


namespace Todo.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class StudentController: Controller
{
    [HttpPost]
    public void AddStudent()
    {
        
    }
}