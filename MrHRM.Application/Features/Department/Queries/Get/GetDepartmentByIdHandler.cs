using AutoMapper;
using MediatR;
using MrHRM.Application.DTOs.HR;
using MrHRM.Application.Persistence.Contracts;

namespace MrHRM.Application.Features.Department.Queries.Get
{
    public class GetDepartmentByIdHandler : IRequestHandler<GetDepartmentByID, DepartmentDTOs>
    {
        private readonly IGenericRepository<DepartmentDTOs> _repository;
        private readonly IMapper _mapper;
        public GetDepartmentByIdHandler(IGenericRepository<DepartmentDTOs> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<DepartmentDTOs> Handle(GetDepartmentByID request, CancellationToken cancellationToken)
        {
            var department = await _repository.GetByIdAsync(request.DepartmentId);
            if (department == null)
            {
                // Handle not found            
            }
            return _mapper.Map<DepartmentDTOs>(department);
        }
    }
}