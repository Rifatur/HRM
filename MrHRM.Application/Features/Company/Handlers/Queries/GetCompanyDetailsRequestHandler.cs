using AutoMapper;
using MediatR;
using MrHRM.Application.DTOs.HR;
using MrHRM.Application.Features.Company.Requests;
using MrHRM.Application.Persistence.Contracts;

namespace MrHRM.Application.Features.Company.Handlers.Queries
{
    public class GetCompanyDetailsRequestHandler : IRequestHandler<GetCompanyDetailsRequest, CompanyDTOs>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        public GetCompanyDetailsRequestHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<CompanyDTOs> Handle(GetCompanyDetailsRequest request, CancellationToken cancellationToken)
        {
            var companyDetails = await _companyRepository.GetCompanyWithDetails(request.Id);
            return _mapper.Map<CompanyDTOs>(companyDetails);
        }

    }
}
