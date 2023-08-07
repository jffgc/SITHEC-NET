using AutoMapper;
using MediatR;
using SITHEC.Application.Contracts.Persistence;
using SITHEC.Application.Dtos.Human;
using SITHEC.Application.Features.Humans.Requests.Queries;

namespace SITHEC.Application.Features.Humans.Handlers.Queries
{
    public class GetHumanDetailRequestHandler : IRequestHandler<GetHumanDetailRequest, HumanDetailDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetHumanDetailRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<HumanDetailDto> Handle(GetHumanDetailRequest request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.HumanRepository.GetById(request.Id);

            return _mapper.Map<HumanDetailDto>(customer);
        }
    }
}
