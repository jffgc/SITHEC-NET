using MediatR;
using SITHEC.Application.Dtos.Human;
using SITHEC.Application.Responses;

namespace SITHEC.Application.Features.Humans.Requests.Commands
{
    public class CreateHumanCommand : IRequest<BaseCommandResponse>
    {
        public CreateHumanDto CreateHumanDto { get; set; }
    }
}
