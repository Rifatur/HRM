using MrHRM.Domain.Entities;

namespace MrHRM.Application.Persistence.Contracts
{
    public interface ICompanyRepository : IGenericRepository<Company>
    {
        Task<Company> GetCompanyWithDetails(int id);
    }
}
