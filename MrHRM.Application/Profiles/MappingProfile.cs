using AutoMapper;
using MrHRM.Application.DTOs.HR;
using MrHRM.Domain.Entities;
using MrHRM.Domain.Entities.HR;

namespace MrHRM.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDTOs>().ReverseMap();
            CreateMap<Employee, EmployeeDTOs>().ReverseMap();
            CreateMap<Department, DepartmentDTOs>().ReverseMap();
            CreateMap<Designation, DesignationDTOs>().ReverseMap();
            CreateMap<Client, ClientDTOs>().ReverseMap();
        }
    }
}
