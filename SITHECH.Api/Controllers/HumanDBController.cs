using MediatR;
using Microsoft.AspNetCore.Mvc;
using SITHEC.Application.Dtos.Human;
using SITHEC.Application.Features.Humans.Requests.Commands;
using SITHEC.Application.Features.Humans.Requests.Queries;
using SITHEC.Application.Responses;

namespace SITHECH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanDBController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HumanDBController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<HumanListDto>>> Get()
        {
            var humans = await _mediator.Send(new GetHumanListRequest());
            return Ok(humans);
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateHumanDto createHumanDto)
        {
            var command = new CreateHumanCommand { CreateHumanDto = createHumanDto };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HumanDetailDto>> Get(Guid id)
        {
            var leaveAllocation = await _mediator.Send(new GetHumanDetailRequest { Id = id });
            return Ok(leaveAllocation);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put([FromBody] UpdateHumanDto humanDto)
        {
            var command = new UpdateHumanCommand { UpdateHumanDto = humanDto };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
