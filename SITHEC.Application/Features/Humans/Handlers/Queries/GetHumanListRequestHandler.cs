using AutoMapper;
using MediatR;
using SITHEC.Application.Contracts.Persistence;
using SITHEC.Application.Dtos.Human;
using SITHEC.Application.Features.Humans.Requests.Queries;

namespace SITHEC.Application.Features.Humans.Handlers.Queries
{
    public class GetHumanListRequestHandler : IRequestHandler<GetHumanListRequest, List<HumanListDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetHumanListRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<HumanListDto>> Handle(GetHumanListRequest request, CancellationToken cancellationToken)
        {
            var customers = await _unitOfWork.HumanRepository.GetAll();
            return _mapper.Map<List<HumanListDto>>(customers);
        }
    }
}
