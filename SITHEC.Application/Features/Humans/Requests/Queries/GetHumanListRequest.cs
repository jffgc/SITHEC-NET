using MediatR;
using SITHEC.Application.Dtos.Human;

namespace SITHEC.Application.Features.Humans.Requests.Queries
{
    public class GetHumanListRequest : IRequest<List<HumanListDto>>
    {
    }
}
