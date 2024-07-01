using MediatR;
using MrHRM.Application.DTOs.HR;

namespace MrHRM.Application.Features.Employee.Request
{
    public class GetEmplyeeListRequest : IRequest<List<EmployeeDTOs>>
    {
    }
}
