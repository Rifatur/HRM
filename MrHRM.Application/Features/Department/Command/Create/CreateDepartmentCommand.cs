using MediatR;

namespace MrHRM.Application.Features.Department.Command.Create
{
    public class CreateDepartmentCommand : IRequest<int>
    {

        public string DepartmentName { get; set; } = string.Empty;
        public int CompanyID { get; set; }
    }
}
