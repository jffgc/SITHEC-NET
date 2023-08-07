using MediatR;
using SITHEC.Application.Dtos.Human;

namespace SITHEC.Application.Features.Humans.Requests.Commands
{
    public class UpdateHumanCommand : IRequest<Unit>
    {
        public UpdateHumanDto UpdateHumanDto { get; set; }
    }
}
