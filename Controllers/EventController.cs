using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wine.Api.Models;

namespace Wine.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase
{
    private readonly ILogger<EventController> _logger;
    private ApplicationContext _context;

    public EventController(ILogger<EventController> logger, ApplicationContext context)
    {
        _logger = logger;
        _context = context;
    }
    
    [HttpGet(Name = "GetEvents")]
    public List<Event> Get()
    {
        return _context.Events.ToList();
    }  
    
    [HttpGet(Name = "GetEvent")]
    public Event Get(string code)
    {
        return _context.Events.FirstOrDefault(e => e.Code == code);
    }
}