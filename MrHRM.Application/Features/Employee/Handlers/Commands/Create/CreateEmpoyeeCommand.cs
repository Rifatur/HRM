using MediatR;
using System.ComponentModel.DataAnnotations;

namespace MrHRM.Application.Features.Employee.Handlers.Commands.Create
{
    public class CreateEmpoyeeCommand : IRequest<int>
    {
        public int CompanyID { get; set; }


        public string FirstName { get; set; } = null!;


        public string LastName { get; set; } = null!;


        public DateTime DateOfBirth { get; set; }


        public string Email { get; set; } = null!;


        public string Gender { get; set; } = null!;

        public string Nationality { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;


        [StringLength(10)]
        public string? EmpCode { get; set; }

        public string? MaritalStatus { get; set; }

        public int DepartmentId { get; set; }


        public int DesignationId { get; set; }


        public string? Address { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? ZipCode { get; set; }

        public string? EmergencyContactName { get; set; }

        public string? EmergencyContactPhone { get; set; }

        public string? EmergencyContactRelationship { get; set; }
    }
}
