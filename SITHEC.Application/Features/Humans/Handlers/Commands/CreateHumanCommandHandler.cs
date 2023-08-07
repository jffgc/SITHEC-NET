using AutoMapper;
using MediatR;
using SITHEC.Application.Contracts.Persistence;
using SITHEC.Application.Dtos.Human.Validators;
using SITHEC.Application.Features.Humans.Requests.Commands;
using SITHEC.Application.Responses;
using SITHEC.Domain;

namespace SITHEC.Application.Features.Humans.Handlers.Commands
{
    public class CreateHumanCommandHandler : IRequestHandler<CreateHumanCommand, BaseCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateHumanCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(CreateHumanCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateHumanDtoValidators();
            var validationResult = await validator.ValidateAsync(request.CreateHumanDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creación del humano fallida";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var human = _mapper.Map<Human>(request.CreateHumanDto);
                human = await _unitOfWork.HumanRepository.Add(human);
                await _unitOfWork.Save();

                response.Success = true;
                response.Message = "La creación del humano fue satisfactoria";
                response.Id = human.Id;
            }

            return response;
        }
    }
}
