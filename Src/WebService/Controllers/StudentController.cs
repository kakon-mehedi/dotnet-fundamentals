using Microsoft.AspNetCore.Mvc;


namespace DotNetFundamentals.WebServices.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class StudentController: Controller
{
    [HttpPost]
    public void AddStudent()
    {
        
    }
}