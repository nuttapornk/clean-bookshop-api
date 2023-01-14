using Application.Publisher.Queries.GetPublishers;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ApiControllerBase
    {
        public PublishersController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> Get(GetPublishersQuery req)
        {
            try
            {
                var data = await Mediator.Send(req);                
                return Ok(data);
            }
            catch (Exception ex)
            {                
                return BadRequest(ex.Message);               
            }
                       
        }

    }
}
