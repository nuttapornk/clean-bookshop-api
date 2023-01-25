using Application.Publishers.Commands.CreatePublisher;
using Application.Publishers.Queries.GetPublishers;
using Azure.Core;
using Domain.Common;
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
                return Ok(ResponseHelper.Success(data));                
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHelper.Error(ex));
            }                     
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePublisherCommand req)
        {
            try
            {
                var result = await Mediator.Send(req);
                return Ok(ResponseHelper.SuccessCreate());
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHelper.Error(ex));                
            }
        }

    }
}
