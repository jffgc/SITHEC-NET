using AutoMapper;
using MediatR;
using SITHEC.Application.Contracts.Persistence;
using SITHEC.Application.Dtos.Human.Validators;
using SITHEC.Application.Exception;
using SITHEC.Application.Features.Humans.Requests.Commands;

namespace SITHEC.Application.Features.Humans.Handlers.Commands
{
    public class UpdateHumanCommandHandler : IRequestHandler<UpdateHumanCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateHumanCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateHumanCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateHumanDtoValidators();
            var validationResult = await validator.ValidateAsync(request.UpdateHumanDto);

            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);

            var human = await _unitOfWork.HumanRepository.GetById(request.UpdateHumanDto.Id);

            if (human is null)
                throw new NotFoundException(nameof(human), request.UpdateHumanDto.Id);

            _mapper.Map(request.UpdateHumanDto, human);

            await _unitOfWork.HumanRepository.Update(human);
            await _unitOfWork.Save();
            return Unit.Value;
        }
    }
}
