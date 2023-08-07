using MediatR;
using SITHEC.Application.Dtos.Human;

namespace SITHEC.Application.Features.Humans.Requests.Queries
{
    public class GetHumanDetailRequest : IRequest<HumanDetailDto>
    {
        public Guid Id { get; set; }
    }
}
