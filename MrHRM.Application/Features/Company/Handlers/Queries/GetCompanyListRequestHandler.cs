using AutoMapper;
using MediatR;
using MrHRM.Application.DTOs.HR;
using MrHRM.Application.Features.Company.Requests;
using MrHRM.Application.Persistence.Contracts;

namespace MrHRM.Application.Features.Company.Handlers.Queries
{
    public class GetCompanyListRequestHandler : IRequestHandler<GetCompanyListRequest, List<CompanyDTOs>>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public GetCompanyListRequestHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<List<CompanyDTOs>> Handle(GetCompanyListRequest request, CancellationToken cancellationToken)
        {
            var companyList = await _companyRepository.GetAllAsync();
            return _mapper.Map<List<CompanyDTOs>>(companyList);
        }
    }
}
