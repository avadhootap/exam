using Microsoft.AspNetCore.Mvc;
using myapp.Models;

namespace myapp.Controllers
{


[Route("api/[controller]")]
[ApiController]
public class PlayerController : ControllerBase
{

    private readonly DBPlayerContext _dbContext;

    public PlayerController(DBPlayerContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    [Route("GetPlayers")]
    public IActionResult GetPlayers()
    {
        List<Player> list=_dbContext.Players.ToList();
        return StatusCode (StatusCodes.Status200OK,list);
    }
}
}
