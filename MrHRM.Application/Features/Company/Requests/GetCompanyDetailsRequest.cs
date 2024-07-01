using MediatR;
using MrHRM.Application.DTOs.HR;

namespace MrHRM.Application.Features.Company.Requests
{
    public class GetCompanyDetailsRequest : IRequest<CompanyDTOs>
    {
        public int Id { get; set; }
    }
}
