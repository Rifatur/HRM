using MediatR;
using MrHRM.Application.DTOs.HR;

namespace MrHRM.Application.Features.Company.Requests
{
    public class GetCompanyListRequest : IRequest<List<CompanyDTOs>>
    {

    }
}
