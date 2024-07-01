using AutoMapper;
using MediatR;
using MrHRM.Application.DTOs.HR;
using MrHRM.Application.Features.Employee.Request;
using MrHRM.Application.Persistence.Contracts;

namespace MrHRM.Application.Features.Employee.Handlers.Queries
{
    public class GetEmployeeListRequestHandler : IRequestHandler<GetEmplyeeListRequest, List<EmployeeDTOs>>
    {
        private readonly IEmpolyeeRepository _empolyeeRepository;
        private readonly IMapper _mapper;

        public GetEmployeeListRequestHandler(IEmpolyeeRepository empolyeeRepository, IMapper mapper)
        {
            _empolyeeRepository = empolyeeRepository;
            _mapper = mapper;
        }
        public async Task<List<EmployeeDTOs>> Handle(GetEmplyeeListRequest request, CancellationToken cancellationToken)
        {
            var employeeList = await _empolyeeRepository.GetAllAsync();
            return _mapper.Map<List<EmployeeDTOs>>(employeeList);
        }
    }
}
