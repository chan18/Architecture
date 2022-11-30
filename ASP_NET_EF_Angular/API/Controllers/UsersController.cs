using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/{controller}")]
public class UsersController : ControllerBase
{
    private readonly DataContext context;

    public UsersController(DataContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<AppUser>> GetUsers()
    {
        var users = context.Users.ToList();

        return users;
    }

    [HttpGet("{id}")]
    public ActionResult<AppUser?> GetUser(int id) 
    {
        return context.Users.Find(id);
    }
}
