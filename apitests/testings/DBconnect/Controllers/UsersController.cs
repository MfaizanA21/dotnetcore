using DBconnect.Models;
using DBconnect.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace DBconnect.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController: ControllerBase
{
    [HttpPost("register-user")]
    public IActionResult RegisterUser(Users user)
    {
        DALAuth.RegisterUser(user);
        if (user.Role == "student")
        {
            return Ok(new {message = "Student Registered successfully"});
        }
        return Ok(new {message = "User Registered successfully"});
    }

    [HttpPost("register-student")]
    public IActionResult RegisterStudent(Students student)
    {
        DALAuth.RegisterStudent(student);
        return Ok(new {message = "Student Registered successfully"});
    }
    
}
