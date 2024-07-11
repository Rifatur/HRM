using AutoMapper;
using MediatR;
using MrHRM.Application.DTOs.HR;
using MrHRM.Application.Persistence.Contracts;

namespace MrHRM.Application.Features.Department.Command.Create
{
    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, int>
    {
        private readonly IGenericRepository<DepartmentDTOs> _repository;
        private readonly IMapper _mapper;
        public CreateDepartmentCommandHandler(IGenericRepository<DepartmentDTOs> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = _mapper.Map<DepartmentDTOs>(request);
            await _repository.InsertAsync(department);
            return department.DepartmentId;
        }
    }
}
