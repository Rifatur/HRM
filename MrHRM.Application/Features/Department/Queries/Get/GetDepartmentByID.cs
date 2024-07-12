using MediatR;
using MrHRM.Application.DTOs.HR;

namespace MrHRM.Application.Features.Department.Queries.Get
{
    public class GetDepartmentByID : IRequest<DepartmentDTOs>
    {
        public int DepartmentId { get; set; }
    }
}
