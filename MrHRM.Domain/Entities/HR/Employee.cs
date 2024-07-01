using MrHRM.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MrHRM.Domain.Entities.HR
{
    public class Employee : AuditableBaseEntity
    {
        [Key]
        public int EmployeeId { get; set; }

        [ForeignKey("Company")]
        public int CompanyID { get; set; }
        public Company Company { get; set; }

        [Required]
        [Length(3, 28)]
        public string FirstName { get; set; } = null!;

        [Required]
        [Length(2, 20)]
        public string LastName { get; set; } = null!;

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = null!;
        [Required]
        [Length(2, 30)]
        public string Nationality { get; set; } = null!;
        [Required]
        [Length(9, 20)]
        public string PhoneNumber { get; set; } = null!;


        [StringLength(10)]
        public string? EmpCode { get; set; }



        [AllowedValues("Single", "Married", "Divorced", "Widowed")]
        public string? MaritalStatus { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Designation")]
        public int DesignationId { get; set; }
        public Designation Designation { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? ZipCode { get; set; }

        public string? EmergencyContactName { get; set; }

        public string? EmergencyContactPhone { get; set; }

        public string? EmergencyContactRelationship { get; set; }
    }
}
