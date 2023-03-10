using Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ApiControllerBase
{
    private readonly AppDbContext _context;
    public BooksController(AppDbContext context)
    {
        _context= context;
    }

    [HttpGet(Name ="api/[Controller]/Get")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok( await _context.Books.FindAsync(id));
    }

}
